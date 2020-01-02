using R.ARC.Util.Logging;
using R.ARC.Util.Session;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace R.ARC.Core.Business.Application
{
    public class ApplicationBase<T>
    {
        protected ISessionManager SessionManager { get; }

        protected IAppLogger<T> Logger { get; }

        public ApplicationBase(IServiceProvider serviceProvider)
        {
            Logger = serviceProvider.GetService<IAppLogger<T>>();
            SessionManager = serviceProvider.GetService<ISessionManager>();
        }
    }
}
