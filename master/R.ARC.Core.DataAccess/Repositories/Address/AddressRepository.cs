using R.ARC.Core.DataAccess.Context;
using R.ARC.Core.Entity;
using R.ARC.Util.Session;
using System;

namespace R.ARC.Core.DataAccess.Repositories
{
    public sealed class AddressRepository : BaseRepository<AddressEntity>, IAddressRepository
    {
        public AddressRepository(DatabaseContext context, IServiceProvider serviceProvider) : base(context, serviceProvider) { }

    }
}
