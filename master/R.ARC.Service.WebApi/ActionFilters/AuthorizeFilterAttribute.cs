using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Caching.Memory;
using R.ARC.Common.Helper.Enums;
using  R.ARC.Common.Helper.Models.Exceptions;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace R.ARC.Web.Api.ActionFilters
{
    // Been Kicked OUT
    public class AuthorizeFilterAttribute : IAsyncActionFilter
    {
        #region NTLM + Shitty Secure Would been changed with active Single Sign On - SSO / Active Directory
        public string RoleName { get; set; }

        private IMemoryCache MemoryCache { get; }

        public AuthorizeFilterAttribute(IMemoryCache memoryCache)
        {
            MemoryCache = memoryCache;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            //// logic before action goes here

            //WindowsIdentity user = context.HttpContext.User.Identity as WindowsIdentity;

            //if (!(RArcUsers().Any(x => x == user.Name)))
            //{
            //    throw new UserAuhenticationException(user.Name);
            //}

            await next(); // the actual action

            //// logic after the action goes here
        }

        public IEnumerable<string> RArcUsers()
        {
            MemoryCache.TryGetValue(CacheKeys.AppUsers, out IEnumerable<string> result);

            return result;
        } 
        #endregion
    }
}
