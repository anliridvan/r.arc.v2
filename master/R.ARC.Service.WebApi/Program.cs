using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.HttpSys;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace R.ARC.Web.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            var h = new WebHostBuilder();
            var configEnv = h.GetSetting("environment") == "Development" ? ".Development" : "" ;
            var config = new ConfigurationBuilder()
                    .AddJsonFile($"appsettings{configEnv}.json", optional: true, reloadOnChange: true)
                    .AddEnvironmentVariables()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .Build();

            var HostUrls = config.GetSection("AppParameters").GetSection("HostUrls").Get<string[]>();

            return WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseUrls(HostUrls)
                ;
        }
    }
}
