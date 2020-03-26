using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
namespace R.ARC.Core.Proxy
{
    public abstract class BaseHttpClient: IDisposable
    {
        protected BaseHttpClient(IHttpClientFactory httpClientFactory, ProviderConfiguration configuration)
        {
            _httpClient = httpClientFactory.CreateClient();
            _httpClient.Timeout = TimeSpan.FromSeconds(configuration.RequestTimeoutInMs);
            _httpClient.BaseAddress = new Uri(configuration.BaseAddress);
            _baseAddress = configuration.BaseAddress;

            if (configuration.Headers != null && configuration.Headers.Any())
            {
                configuration.Headers.ToList().ForEach(x => _httpClient.DefaultRequestHeaders.Add(x.Key, x.Value));
            }
        }

        public async Task<TResponse> PostAsync<TRequest, TResponse>(string requestUri, TRequest request, CancellationToken cancellationToken)
        {
            using (var requestMessage = new HttpRequestMessage())
            {
                requestMessage.RequestUri = new Uri(_baseAddress + requestUri);
                requestMessage.Content = new StringContent(JsonSerializer.Serialize(request), System.Text.Encoding.UTF8, "application/json");
                requestMessage.Method = HttpMethod.Post;
                return await SendAsync<TResponse>(requestMessage, cancellationToken);
            }
        }

        public async Task<TResponse> GetAsync<TResponse>(string requestUri, object request, CancellationToken cancellationToken)
        {
            using (var requestMessage = new HttpRequestMessage())
            {
                requestMessage.Method = HttpMethod.Get;
                requestMessage.RequestUri = request != null ? new Uri(_baseAddress + request.ToQueryString(requestUri)) : new Uri(_baseAddress + requestUri);
                return await SendAsync<TResponse>(requestMessage, cancellationToken);
            }
        }

        public async Task GetAsync(string requestUri, CancellationToken cancellationToken)
        {
            var response = await _httpClient.GetAsync(requestUri, cancellationToken);
            using (var resp = await response.Content.ReadAsStreamAsync())
            {
                if (resp == null || !resp.CanRead || resp.Length == 0)
                {
                    throw new HttpRequestException(FormatExceptionMessage(new HttpRequestMessage(HttpMethod.Get, new Uri(requestUri)), "Response body is empty!", response.StatusCode));
                }
            }
        }

        private async Task<T> SendAsync<T>(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var response = await _httpClient.SendAsync(request, cancellationToken);
            if (!response.IsSuccessStatusCode) {
                throw new HttpRequestException(FormatExceptionMessage(request, "Request failed!", response.StatusCode));
            }

            using (var resp = await response.Content.ReadAsStreamAsync())
            {
                if (resp == null || !resp.CanRead || resp.Length == 0)
                {
                    throw new HttpRequestException(FormatExceptionMessage(request, "Response body is empty!", response.StatusCode));
                }

                T result = default(T);
                try
                {
                    result = await JsonSerializer.DeserializeAsync<T>(resp);
                }
                catch
                {
                    throw new HttpRequestException(FormatExceptionMessage(request, "Invalid response!", response.StatusCode));
                }
                return result;
            }
        }

        private string FormatExceptionMessage(HttpRequestMessage request, string errorMessage, HttpStatusCode statusCode)
        {
            return JsonSerializer.Serialize(new
            {
                Error = errorMessage,
                Method = request.Method,
                RequestUri = request.RequestUri,
                Status = statusCode,
                Headers = JsonSerializer.Serialize(request.Headers),
                Body = request.Content.ReadAsStringAsync()
            });
        }

        public void Dispose()
        {
            _httpClient.Dispose();
        }

        private readonly HttpClient _httpClient;
        private readonly string _baseAddress;
    }
}
