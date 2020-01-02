﻿using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.PlatformAbstractions;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using R.ARC.Common.Setting;
using R.ARC.Core.Business;
using R.ARC.Core.DataAccess;
using R.ARC.Util.Logging;
using R.ARC.Util.Logging.DbLog;
using R.ARC.Util.Mapping.Adapter;
using R.ARC.Web.Api.Autofac.Settings;
using R.ARC.Web.Api.Settings;
using R.ARC.Web.Api.Settings.Autofac;
using R.ARC.Web.Api.Settings.JWT;
using R.ARC.Web.Api.Swagger;
using SAM.Service.WebApi.Helpers;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Text;

namespace R.ARC.Web.Api
{
    public class Startup
    {


        public IConfiguration Configuration { get; }

        private AppSettings _appSettings;

        private readonly ILogger _logger;

        private readonly IWebHostEnvironment _hostingEnvironment;

        private IContainer _applicationContainer;


        public Startup(IConfiguration configuration, ILogger<Startup> logger, IWebHostEnvironment hostingEnvironment)
        {
            Configuration = configuration;
            //AppSettings
            _appSettings = Configuration.GetSection("AppSettings").Get<AppSettings>();
            _logger = logger;

            _hostingEnvironment = hostingEnvironment;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            _logger.LogTrace("Startup::ConfigureServices");

            try
            {
                services.AddCors();

                services.AddMemoryCache();

                services.Configure<IISServerOptions>(options =>
                {
                    options.AllowSynchronousIO = true;
                });

                services.AddControllers().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
                services.AddControllers()
                 .AddNewtonsoftJson(options =>
                 {
                     options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
                     options.SerializerSettings.ContractResolver = new DefaultContractResolver();
                     // serialize dates into ISO format with UTC timezone
                     options.SerializerSettings.DateFormatHandling = DateFormatHandling.IsoDateFormat;
                     options.SerializerSettings.DateTimeZoneHandling = DateTimeZoneHandling.Utc;
                 });

                services.Configure<GzipCompressionProviderOptions>(options => options.Level = CompressionLevel.Fastest);
                services.AddResponseCompression(options => { options.Providers.Add<GzipCompressionProvider>(); });


                if (_appSettings.IsValid())
                {
                    #region Jwt

                    services.ConfigureJwt(_appSettings, ConfigureSecurityKey);
                    #endregion

                    #region ArchitectNow MongoDB & Fuluentvalidation
                    //if (_hostingEnvironment.IsDevelopment())
                    //{
                    //    services.AddHealthChecks()
                    //        .AddMongoDb(_configuration["mongo:connectionString"], _configuration["mongo:databaseName"],
                    //            "MongoDb")
                    //        .AddCheck("Custom", () => { return HealthCheckResult.Healthy(); });

                    //    services.AddHealthChecksUI();
                    //}

                    //services.ConfigureApi(new FluentValidationOptions { Enabled = true });

                    #endregion

                    #region ForwardedHeaders
                    services.Configure<ForwardedHeadersOptions>(options =>
                    {
                        options.ForwardedHeaders = ForwardedHeaders.All;
                    });

                    #endregion

                    #region Authorization

                    services.AddAuthorization(options =>
                    {
                        options.AddPolicy("Default", builder => builder.RequireAuthenticatedUser().Build());
                    });
                    #endregion

                    #region Versioning
                    services.AddApiVersioning(
                    o =>
                    {
                        //o.Conventions.Controller<UserController>().HasApiVersion(1, 0);
                        o.ReportApiVersions = true;
                        o.AssumeDefaultVersionWhenUnspecified = true;
                        o.DefaultApiVersion = new ApiVersion(1, 0);
                        o.ApiVersionReader = new UrlSegmentApiVersionReader();
                    }
                    );

                    // note: the specified format code will format the version as "'v'major[.minor][-status]"
                    services.AddVersionedApiExplorer(
                    options =>
                    {
                        options.GroupNameFormat = "'v'VVV";

                        // note: this option is only necessary when versioning by url segment. the SubstitutionFormat
                        // can also be used to control the format of the API version in route templates
                        options.SubstituteApiVersionInUrl = true;
                    });
                    #endregion

                    #region Swagger
                    if (_appSettings.Swagger.Enabled)
                    {
                        services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();

                        services.AddSwaggerGen(options =>
                        {
                            options.OperationFilter<SwaggerDefaultValues>();
                            options.IncludeXmlComments(XmlCommentsFilePath);
                        });
                        services.AddSwaggerGen();
                    }
                    #endregion

                    #region Telemetry

                    if (!_hostingEnvironment.IsDevelopment())
                    {
                        if (_appSettings.ApplicationInsights != null && !string.IsNullOrEmpty(_appSettings.ApplicationInsights.InstrumentationKey))
                        {
                            services.AddApplicationInsightsTelemetry(_appSettings.ApplicationInsights.InstrumentationKey);
                        }
                    }
                    #endregion
                }

                
                _applicationContainer = services.CreateAutofacContainer((builder, serviceCollection) =>
                {
                    // builder.RegisterLogger(); for serilog

                    //serviceCollection.AddAutoMapper(expression =>
                    //{
                    //    expression.ConstructServicesUsing(type => _applicationContainer.Resolve(type));
                    //}); // for automapper

                    var customizedAgileMapper = new CustomMapper();
                    builder.RegisterInstance<ICustomMapper>(customizedAgileMapper);
                    builder.Register(c => customizedAgileMapper).As<ICustomMapper>().SingleInstance();
                }, new ApiModule(), new BusinessModule(), new DataAccessModule());



                // Create the IServiceProvider based on the container.
                var provider = new AutofacServiceProvider(_applicationContainer);

                _logger.LogInformation($"{nameof(ConfigureServices)} complete...");


                return provider;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }

            return null;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,
            ILoggerFactory loggerFactory,
            IApiVersionDescriptionProvider provider)
        {
            _logger.LogInformation($"{nameof(Configure)} starting...");
            _logger.LogTrace("Startup::Configure");
            _logger.LogDebug($"Startup::Configure::Environment:{env.EnvironmentName}");

            try
            {

                app.UseFileServer();

                #region UploadsPath
                var uploadsPath = _appSettings.UploadsPath ?? Path.Combine(Directory.GetCurrentDirectory(), "uploads");
                if (!Directory.Exists(uploadsPath)) Directory.CreateDirectory(uploadsPath);
                #endregion

                app.UseStaticFiles();

                #region UseForwardedHeaders
                app.UseForwardedHeaders(new ForwardedHeadersOptions
                {
                    ForwardedHeaders = ForwardedHeaders.All,
                    RequireHeaderSymmetry = false
                });
                #endregion

                #region DBLog Configuration
                //Microsoft.Extension.Logging DB Configuration -  DLogger.Extensions.Logging - https://github.com/SasaCetkovic/DLogger.Extensions.Logging
                SqlServerLogWriter logWriter = new SqlServerLogWriter(Configuration.GetConnectionString("LoggingDb"));
                loggerFactory.AddDLogger(Configuration.GetSection("Logging"), logWriter);
                #endregion

                int sirketId = Configuration.GetSection("AppParameters").GetValue<int>("CompanyId");

                #region UseDeveloperExceptionPage
                if (env.IsDevelopment())
                {
                    app.UseDeveloperExceptionPage();
                }
                #endregion

                app.UseHttpsRedirection();

                app.UseCors(b => b.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

                app.UseAuthentication();

                app.UseResponseCompression();

                app.UseMiddleware(typeof(SetSessionMiddleware));

                IMemoryCache cache = app.ApplicationServices.GetService<IMemoryCache>();

            
                app.UseRouting();
                app.UseAuthorization();
                app.UseEndpoints(endpoints =>
                {
                    endpoints.MapControllers();
                });



                app.UseRequestLocalization();

                #region ArchitectNow UseHealthChecksUI
                //if (_hostingEnvironment.IsDevelopment())
                //{
                //    app.UseHealthChecksUI();

                //    app.UseHealthChecks("/health", new HealthCheckOptions
                //    {
                //        Predicate = _ => true,
                //        ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
                //    });
                //}
                #endregion
                
                #region Swagger

                if (_appSettings.IsValid())
                {
                    if (_appSettings.Swagger.Enabled)
                    {
                        app.UseSwagger();
                        app.UseSwaggerUI(options =>
                        {
                            foreach (var description in provider.ApiVersionDescriptions)
                            {
                                options.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json", description.GroupName.ToUpperInvariant());
                                options.RoutePrefix = string.Empty;
                            }
                        });
                    }
                }
                #endregion

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
        }

        string XmlCommentsFilePath
        {
            get
            {
                var basePath = PlatformServices.Default.Application.ApplicationBasePath;
                var fileName = typeof(Startup).GetTypeInfo().Assembly.GetName().Name + ".xml";
                return Path.Combine(basePath, fileName);
            }
        }

        private JwtSigningKey ConfigureSecurityKey(JwtIssuerOptions issuerOptions)
        {
            var keyString = issuerOptions.Audience;
            var keyBytes = Encoding.Unicode.GetBytes(keyString);
            var signingKey = new JwtSigningKey(keyBytes);
            return signingKey;
        }
    }
}
