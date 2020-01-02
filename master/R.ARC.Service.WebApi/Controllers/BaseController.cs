using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using R.ARC.Common.Helper.Enums;
using R.ARC.Common.Contract;
using R.ARC.Util.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using Microsoft.AspNetCore.Authorization;
using R.ARC.Web.Api.Services;

namespace R.ARC.Web.Api.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class BaseController<T> : ControllerBase
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
        
    }
}