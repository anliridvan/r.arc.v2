namespace R.ARC.Util.Session
{
    public class SessionManager : ISessionManager
    {
        public string UserName { get; set; }

        public string IpAddress { get; set; }

        public string MacAddress { get; set; }

        public string HostName { get; set; }

        public string RequestUrl { get; set; }

        public string RequestBody { get; set; }
    }
}
