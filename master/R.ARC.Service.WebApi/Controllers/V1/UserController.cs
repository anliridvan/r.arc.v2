using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using R.ARC.Common.Contract;
using R.ARC.Common.Helper.Models;
using R.ARC.Web.Api.Controllers;
using R.ARC.Web.Api.Services;
using System;
using System.Threading.Tasks;

namespace CoreAPI1.API.Controllers.V1
{
    [ApiVersion("1.0")]
    public class UserController : BaseController<UserController>
    {

        public UserController(IServiceProvider serviceProvider) : base(serviceProvider)
        {

        }

        /// <summary>
        ///     Secure method used to test security
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UserBasicModel))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ApiError))]
        public async Task<IActionResult> Get()
        {
            return await ServiceInvoker.AsyncOk(() => Task.FromResult(HttpContext.User.GetUserInformation()));
        }


    }
}
