using Newtonsoft.Json;
using System.Text;

namespace R.ARC.Core.Proxy
{
    public static class UrlExtensions
    {
        public static string ToQueryString(this object @object, string baseUrl)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append(baseUrl.TrimEnd('?')).Append("?");
            foreach (var property in @object.GetType().GetProperties())
            {
                var propertyValue = property.GetValue(@object);
                if (propertyValue == null || string.IsNullOrEmpty($"{propertyValue}")) continue;
                foreach (var attribute in property.GetCustomAttributes(false))
                {
                    bool isJsonProperty = attribute is JsonPropertyAttribute;
                    if (isJsonProperty)
                    {
                        stringBuilder.Append(((JsonPropertyAttribute)attribute).PropertyName);
                    }
                    else
                    {
                        stringBuilder.Append(property.Name);

                    }
                    stringBuilder.Append("=");
                    stringBuilder.Append(propertyValue);

                }
                stringBuilder.Append("&");
            }
            return stringBuilder.ToString().TrimEnd('&');
        }
    }
}
