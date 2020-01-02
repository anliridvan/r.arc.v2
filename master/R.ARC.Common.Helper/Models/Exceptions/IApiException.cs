using System.Net;

namespace R.ARC.Common.Helper.Models.Exceptions
{
    public interface IApiException<TContent>
    {
        HttpStatusCode StatusCode { get; set; }
        TContent Content { get; set; }
    }
}