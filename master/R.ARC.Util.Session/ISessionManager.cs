namespace R.ARC.Util.Session
{
    public interface ISessionManager
    {
        string UserName { get; set; }
        string IpAddress { get; set; }
        string MacAddress { get; set; }
        string HostName { get; set; }
        string RequestUrl { get; set; }
        string RequestBody { get; set; }
    }
}
