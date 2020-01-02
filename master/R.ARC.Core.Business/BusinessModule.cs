using Autofac;
using R.ARC.Util.Logging;

namespace R.ARC.Core.Business
{

    public class BusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(ThisAssembly).AsImplementedInterfaces();

            builder.RegisterGeneric(typeof(LoggerAdaptor<>)).As(typeof(IAppLogger<>)).InstancePerDependency();


            //builder.Register(context =>
            //{
            //    var configuration = context.Resolve<IConfiguration>();

            //    var issuerOptions = configuration.GetSection("jwtIssuerOptions").Get<JwtIssuerOptions>();

            //    var keyString = issuerOptions.Audience;
            //    var keyBytes = Encoding.Unicode.GetBytes(keyString);

            //    var key = new JwtSigningKey(keyBytes);

            //    issuerOptions.SigningCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);

            //    return new OptionsWrapper<JwtIssuerOptions>(issuerOptions);
            //}).As<IOptions<JwtIssuerOptions>>().InstancePerLifetimeScope();


        }
    }
}
