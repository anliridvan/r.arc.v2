using R.ARC.Util.Logging;
using System;
using Microsoft.Extensions.DependencyInjection;
using R.ARC.Util.Session;
using R.ARC.Util.Mapping.Adapter;
using R.ARC.Core.DataAccess.UnitOfWork;

namespace R.ARC.Core.Business
{
    public class DomainBase<T>
    {
        protected IDatabaseUnitOfWork DatabaseUnitOfWork;
        protected ISessionManager SessionManager;
        protected IAppLogger<T> Logger;
        protected ICustomMapper Mapper;

        public DomainBase(IServiceProvider serviceProvider)
        {
            Logger = serviceProvider.GetService<IAppLogger<T>>();
            SessionManager = serviceProvider.GetService<ISessionManager>();
            Mapper = serviceProvider.GetService<ICustomMapper>();
            DatabaseUnitOfWork = serviceProvider.GetService<IDatabaseUnitOfWork>();
        }

    }
}
