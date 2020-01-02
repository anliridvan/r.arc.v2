using Newtonsoft.Json;

namespace R.ARC.Common.Helper.Models
{
    public class ApiError
    {
        /// <summary>
        ///     Error description
        /// </summary>
        public string Error { get; set; }

        /// <summary>
        ///     Optional stack trace (only available in dev)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string StackTrace { get; set; }
    }
}