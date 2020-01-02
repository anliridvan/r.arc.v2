using Autofac;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using R.ARC.Common.Setting;
using R.ARC.Core.DataAccess.Context;
using R.ARC.Util.Logging;
using R.ARC.Util.Session;

namespace R.ARC.Core.DataAccess
{
    public class DataAccessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(ThisAssembly).AsImplementedInterfaces();

            builder.RegisterGeneric(typeof(LoggerAdaptor<>)).As(typeof(IAppLogger<>)).InstancePerDependency();
            
            builder.Register(context =>
            {

                var configuration = context.Resolve<IConfiguration>();
                string connectionString = configuration.GetConnectionString("RArcAppDb");
                var _appSettings = configuration.GetSection("AppSettings").Get<AppSettings>();
                var opt = new DbContextOptionsBuilder<DatabaseContext>();

                DatabaseContext dbContext ;
                if (_appSettings.Database.UseInMemoryDatabase)
                {
                    dbContext = new DatabaseContext(opt.UseInMemoryDatabase("StoreDbMemory").Options);
                    //dbContext.Database.EnsureCreated();
                    //dbContext.Database.Migrate();
                }
                else
                {
                    dbContext = new DatabaseContext(opt.UseSqlServer(connectionString).Options);
                   
                    #region DbContext Check Migration
                    dbContext.Database.EnsureCreated();
                    dbContext.Database.Migrate();
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
