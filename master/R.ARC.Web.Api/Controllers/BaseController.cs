using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using R.ARC.Common.Helper.Models;
using R.ARC.Common.Helper.Models.Exceptions;
using R.ARC.Util.Logging;
using R.ARC.Web.Api.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace R.ARC.Web.Api.Controllers
{
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(void))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ValidationError))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ApiError))]
    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class BaseController<T> : Controller
    {
        protected IMemoryCache MemoryCache;

        protected IAppLogger<T> Logger;

        protected IServiceInvoker ServiceInvoker { get; }

        public BaseController(IServiceProvider serviceProvider)
        {
            MemoryCache = serviceProvider.GetService<IMemoryCache>();
            Logger = serviceProvider.GetService<IAppLogger<T>>();
            ServiceInvoker = serviceProvider.GetService<IServiceInvoker>();
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
                if (!ModelState.IsValid)
                {
                    var errorList = ModelState.ToDictionary(
                        kvp => kvp.Key,
                        kvp => kvp.Value.Errors.Select(e =>
                            string.IsNullOrEmpty(e.ErrorMessage)
                                ? e.Exception?.GetBaseException().Message
                                : e.ErrorMessage).ToArray()
                    );

                    throw new ApiException<IDictionary<string, string[]>>("Invalid request", errorList);
                }

            base.OnActionExecuting(context);
        }

    }
}