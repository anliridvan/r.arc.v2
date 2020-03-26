using System.Collections.Generic;

namespace R.ARC.Core.Proxy
{
    public class ProviderConfiguration
    {
        public string Key { get; set; }
        public string BaseAddress { get; set; }
        public List<KeyValue> Headers { get; set; }
        public int RequestTimeoutInMs { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class KeyValue
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
