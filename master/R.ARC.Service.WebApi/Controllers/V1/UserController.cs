using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace CoreAPI1.API.Controllers.V1
{
    [ApiVersion("1.0")]
    [Route("api/users")]//required for default versioning
    [Route("api/v{version:apiVersion}/users")]
    [ApiController]
    public class UserController : Controller
    {

        #region GET
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(string))]
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public async Task<string> Get()
        {

                return null;
        }
        #endregion

    }
}
