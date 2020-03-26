using Autofac;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using R.ARC.Common.Setting;
using R.ARC.Core.DataLayer.Context;

namespace R.ARC.Core.DataLayer
{
    public class DataLayerModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(ThisAssembly).AsImplementedInterfaces();

            builder.Register(context =>
            {

                var configuration = context.Resolve<IConfiguration>();
                string connectionString = configuration.GetConnectionString("RArcAppDb");
                var _appSettings = configuration.GetSection("AppSettings").Get<AppSettings>();
                var opt = new DbContextOptionsBuilder<PostgreSContext>();

                PostgreSContext dbContext;
                if (_appSettings.Database.UseInMemoryDatabase)
                {
                    dbContext = new PostgreSContext(opt.UseInMemoryDatabase("StoreDbMemory").Options);
                    //dbContext.Database.EnsureCreated();
                    //dbContext.Database.Migrate();
                }
                else
                {
                    dbContext = new PostgreSContext(opt.UseNpgsql(connectionString).Options);

                    #region DbContext Check Migration
                    //dbContext.Database.EnsureCreated();
                    //dbContext.Database.Migrate();
                    #endregion
                }

                return dbContext;
            }).AsSelf().SingleInstance();

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
