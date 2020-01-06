using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.PlatformAbstractions;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using R.ARC.Common.Setting;
using R.ARC.Web.Api.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace R.ARC.Web.Api.Settings.Swagger
{
    public static class SwaggerExtensions
    {
        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();


            services.AddSwaggerGen(options =>
            {
                options.OperationFilter<SwaggerDefaultValues>();
                options.IncludeXmlComments(XmlCommentsFilePath);

                #region Swagger auth token input config
                options.AddSecurityDefinition("Bearer", //Name the security scheme
                     new OpenApiSecurityScheme
                     {
                         Description = "JWT Authorization header using the Bearer scheme.",
                         Type = SecuritySchemeType.Http, //We set the scheme type to http since we're using bearer authentication
                                     Scheme = "bearer" //The name of the HTTP Authorization scheme to be used in the Authorization header. In this case "bearer".
                                 });

                options.AddSecurityRequirement(new OpenApiSecurityRequirement{
                                {
                                    new OpenApiSecurityScheme{
                                        Reference = new OpenApiReference{
                                            Id = "Bearer", //The name of the previously defined security scheme.
                                            Type = ReferenceType.SecurityScheme
                                        }
                                    },new List<string>()
                                }
                            });
                #endregion

            });

            services.AddSwaggerGen();
        }

        public static void ConfigureSwagger(this IApplicationBuilder app, IApiVersionDescriptionProvider provider)
        {
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                foreach (var description in provider.ApiVersionDescriptions)
                {
                    options.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json", description.GroupName.ToUpperInvariant());
                    //options.RoutePrefix = string.Empty;
                }
            });


        }

        private static string XmlCommentsFilePath
        {
            get
            {
                var basePath = PlatformServices.Default.Application.ApplicationBasePath;
                var fileName = typeof(Startup).GetTypeInfo().Assembly.GetName().Name + ".xml";
                return Path.Combine(basePath, fileName);
            }
        }
    }
}
