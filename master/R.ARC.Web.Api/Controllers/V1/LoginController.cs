using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using R.ARC.Common.Contract;
using R.ARC.Common.Helper.Models;
using R.ARC.Common.Helper.Models.Exceptions;
using R.ARC.Core.Business.Application;
using R.ARC.Web.Api.Settings.JWT;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;

namespace R.ARC.Web.Api.Controllers.V1
{
    [ApiVersion("1.0")]
    public class LoginController : BaseController<LoginController>
    {
        private readonly JwtIssuerOptions _jwtOptions;
        private IUserApplication _UserApp { get; }

        public LoginController(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            _jwtOptions = serviceProvider.GetService<IOptions<JwtIssuerOptions>>().Value;
            _UserApp = serviceProvider.GetService<IUserApplication>();
        }

        /// <summary>
        ///     Login to the system
        /// </summary>
        /// <param name="parameters">Login parameters</param>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(LoginResultModel))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ApiError))]
        public async Task<IActionResult> Login([FromBody] LoginModel parameters)
        {
            return await ServiceInvoker.AsyncOk(async () =>
            {
                var user = await _UserApp.AuthenticateAsync(parameters.UserName, parameters.Password);

                if (user != null)
                {
                    var result = new LoginResultModel();

                    var tokenRequest = await BuildTokenRequest(user);

                    result.CurrentUser = user;
                    result.AuthToken = tokenRequest.Token;

                    return result;
                }

                throw new ApiException<string>("Invalid Credentials");
            });
        }

        /// <summary>
        ///     Register a new user
        /// </summary>
        /// <param name="parameters">New user information</param>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UserModel))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ApiError))]
        public async Task<IActionResult> Register([FromBody] UserModel parameters)
        {
            return await ServiceInvoker.AsyncOk(async () => await _UserApp.CreateAsync(parameters, parameters.Password));
        }

        private async Task<TokenModel> BuildTokenRequest(UserModel user)
        {
            var identity = GenerateClaimsIdentity(user);

            return await GenerateTokenRequest(user, identity);
        }

        private ClaimsIdentity GenerateClaimsIdentity(UserModel user)
        {
            var claims = new List<Claim>
            {
                //new Claim("Role", user.UserRole),
                new Claim("Id", user.Id.ToString())
            };

            return new ClaimsIdentity(new GenericIdentity(user.Username, "Token"), claims);
        }

        /// <returns>Date converted to seconds since Unix epoch (Jan 1, 1970, midnight UTC).</returns>
        private static long ToUnixEpochDate(DateTime date)
        {
            return (long)Math.Round((date.ToUniversalTime() -
                                      new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.Zero))
                .TotalSeconds);
        }

        private async Task<TokenModel> GenerateTokenRequest(UserModel user, ClaimsIdentity identity)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Sid, user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                new Claim(JwtRegisteredClaimNames.Jti, await _jwtOptions.JtiGenerator()),
                new Claim(JwtRegisteredClaimNames.Iat,
                    ToUnixEpochDate(_jwtOptions.IssuedAt).ToString(),
                    ClaimValueTypes.Integer64)
            };

            foreach (var claim in identity.Claims)
                claims.Add(claim);

            // Create the JWT security token and encode it.
            var jwt = new JwtSecurityToken(
                _jwtOptions.Issuer,
                _jwtOptions.Audience,
                claims,
                _jwtOptions.NotBefore,
                _jwtOptions.Expiration,
                _jwtOptions.SigningCredentials);

            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);
            var token = new TokenModel
            {
                ExpiresAt = DateTimeOffset.UtcNow.AddSeconds((int)_jwtOptions.ValidFor.TotalSeconds),
                Token = encodedJwt,
                Email = user.Email
            };

            return token;
        }
    }
}