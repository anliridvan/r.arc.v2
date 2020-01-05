using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using R.ARC.Common.Setting;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R.ARC.Web.Api.Settings.JWT
{
    public static class JwtExtensions
    {
        public static void ConfigureJwt(this IServiceCollection services, AppSettings _appSettings)
        {
            var jwtAppSettingOptions = _appSettings.JwtIssuerOptions.IsValid() ?
                new JwtIssuerOptions
                {
                    Audience = _appSettings.JwtIssuerOptions.Audience,
                    Issuer = _appSettings.JwtIssuerOptions.Issuer
                }
                : new JwtIssuerOptions();

            var issuerSigningKey = ConfigureSecurityKey(jwtAppSettingOptions);

            services.AddSingleton(issuerSigningKey);

            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidIssuer = jwtAppSettingOptions.Issuer,

                ValidateAudience = true,
                ValidAudience = jwtAppSettingOptions.Audience,

                ValidateIssuerSigningKey = true,
                IssuerSigningKey = issuerSigningKey,

                RequireExpirationTime = true,
                ValidateLifetime = true,

                ClockSkew = TimeSpan.Zero
            };

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(options =>
                {
                    options.RequireHttpsMetadata = false;
                    options.SaveToken = true;
                    options.TokenValidationParameters = tokenValidationParameters;
                    //options.Events = new JwtBearerEvents
                    //{
                    //    OnMessageReceived = context =>
                    //    {
                    //        var task = Task.Run(() =>
                    //        {
                    //            if (context.Request.Query.TryGetValue("securityToken", out var securityToken))
                    //                context.Token = securityToken.FirstOrDefault();
                    //        });

                    //        return task;
                    //    }
                    //};
                });
        }

        private static JwtSigningKey ConfigureSecurityKey(JwtIssuerOptions issuerOptions)
        {
            var keyString = issuerOptions.Audience;
            var keyBytes = Encoding.Unicode.GetBytes(keyString);
            var signingKey = new JwtSigningKey(keyBytes);
            return signingKey;
        }
    }
}
