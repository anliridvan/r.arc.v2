using Microsoft.AspNetCore.Http;
using R.ARC.Util.Session;
using System.IO;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using R.ARC.Web.Api.Services;
using System;

namespace SAM.Service.WebApi.Helpers
{
    public class SetSessionMiddleware
    {
        private readonly RequestDelegate next;

        public SetSessionMiddleware(RequestDelegate next)
        {

            this.next = next;
        }

        public  async Task Invoke(HttpContext context, ISessionManager sessionManager)
        {
            sessionManager.UserName = context.User.GetUserInformation().UserName;
            sessionManager.IpAddress = context.Connection.RemoteIpAddress.ToString();
            sessionManager.RequestUrl = context.Request.Host + context.Request.Path;
            sessionManager.RequestBody = await GetRequestBody(context);

            Guid.TryParse(GetClaimValue(context, ClaimTypes.Sid), out Guid userId);
            if (userId != Guid.Empty)
            {
                sessionManager.UserId = userId;
                //var cacheSession = await cache.GetObjDecrypt<SessionManager>(CacheConstants.SESSION + userId.ToString(), options.Value.API.EncryptionKey);
                //if (cacheSession != null)
                //{
                //    sessionManager.RoleId = cacheSession.RoleId;
                //    sessionManager.UserId = userId;
                //    sessionManager.RoleName = cacheSession.RoleName;
                //}
            }

            await next(context);
        }

        private async Task<string> GetRequestBody(HttpContext context)
        {
            // https://stackoverflow.com/questions/40494913/how-to-read-request-body-in-a-asp-net-core-webapi-controller
            var bodyStr = "";
            var req = context.Request;

            // Allows using several time the stream in ASP.Net Core
            //req.EnableRewind(); // core 2.0
            req.EnableBuffering(); // core 3.0


            // Arguments: Stream, Encoding, detect encoding, buffer size 
            // AND, the most important: keep stream opened
            using (StreamReader reader
                      = new StreamReader(req.Body, Encoding.UTF8, true, 1024, true))
            {
                bodyStr = await reader.ReadToEndAsync();
            }

            // Rewind, so the core is not lost when it looks the body for the request
            req.Body.Position = 0;

            return bodyStr;

        }

        private string GetClaimValue(HttpContext context, string type)
        {
            var token = context.Request.Headers["Authorization"].ToString().Replace("Bearer ", string.Empty);
            Claim claim = null;

            if (string.IsNullOrEmpty(token))
            {
                return "";
            }
            try
            {
                var decodedToken = new JwtSecurityTokenHandler().ReadJwtToken(token);
                claim = decodedToken.Claims.First(x => x.Type == type);
            }
            catch (Exception)
            {
                // Log Parse Error
            }

            if (claim == null)
            {
                return "";
            }

            if (string.IsNullOrEmpty(claim.Value))
                return string.Empty;

            return claim.Value;
        }
    }
}
