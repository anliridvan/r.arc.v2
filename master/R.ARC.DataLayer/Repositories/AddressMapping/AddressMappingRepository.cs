using R.ARC.Core.DataLayer.Context;
using R.ARC.Core.Entity;
using R.ARC.Util.Session;
using System;

namespace R.ARC.Core.DataLayer.Repositories
{
    public sealed class AddressMappingRepository : BaseRepository<AddressMappingEntity>, IAddressMappingRepository
    {
        public AddressMappingRepository(PostgreSContext context, IServiceProvider serviceProvider) : base(context, serviceProvider) { }

    }
}
