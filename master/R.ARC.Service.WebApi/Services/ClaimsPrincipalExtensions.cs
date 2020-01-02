using System;
using System.Linq;
using System.Security.Claims;
using R.ARC.Common.Contract;

namespace R.ARC.Web.Api.Services
{
    public static class ClaimsPrincipalExtensions
    {
        public static UserBasicModel GetUserInformation(this ClaimsPrincipal principal)
        {
            if (principal == null) return null;

            var identityName = principal.Identity?.Name;

            var idValue = principal.Claims.FirstOrDefault(claim =>
                string.Equals(nameof(UserBasicModel.Id), claim.Type, StringComparison.OrdinalIgnoreCase))?.Value;

            var userInformation = new UserBasicModel
            {
                Email = identityName
            };

            if (int.TryParse(idValue, out var id)) userInformation.Id = id;

            return userInformation;
        }
    }
}