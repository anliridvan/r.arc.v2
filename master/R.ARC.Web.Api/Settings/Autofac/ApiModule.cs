using Autofac;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using R.ARC.Web.Api.Settings.JWT;
using R.ARC.Util.Logging;
using R.ARC.Web.Api.Services;
using R.ARC.Web.Api.Filters;
using R.ARC.Util.Session;
using R.ARC.Common.Setting;

namespace R.ARC.Web.Api.Autofac.Settings
{
    public class ApiModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(ThisAssembly).AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterType<SessionManager>().As<ISessionManager>().InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(LoggerAdaptor<>)).As(typeof(IAppLogger<>)).InstancePerDependency();
            builder.RegisterType<ServiceInvoker>().As<IServiceInvoker>().InstancePerLifetimeScope();
            builder.RegisterType<ExceptionResultBuilder>().As<IExceptionResultBuilder>().InstancePerLifetimeScope();
            builder.RegisterType<HttpContextAccessor>().As<IHttpContextAccessor>().SingleInstance();
            builder.RegisterType<GlobalExceptionFilter>().AsSelf().InstancePerLifetimeScope();
           
            builder.Register(context =>
            {
                var configuration = context.Resolve<IConfiguration>();
                var appSettings = configuration.GetSection("AppSettings").Get<AppSettings>();
                return new OptionsWrapper<AppSettings>(appSettings);
            }).As<IOptions<AppSettings>>().SingleInstance();

            builder.Register(context =>
            {

                var configuration = context.Resolve<IConfiguration>();
                var issuerOptions = configuration.GetSection("AppSettings").GetSection("JwtIssuerOptions").Get<JwtIssuerOptions>();

                var key = context.Resolve<JwtSigningKey>();
                if (key == null)
                    context.Resolve<ILogger<ApiModule>>().LogWarning("JwtSigningKey is not defined");
                else
                    issuerOptions.SigningCredentials =
                        new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);

                return new OptionsWrapper<JwtIssuerOptions>(issuerOptions);
            }).As<IOptions<JwtIssuerOptions>>().InstancePerLifetimeScope();



            builder.RegisterType<MemoryCache>().As<IMemoryCache>().SingleInstance();
        }
    }
}
