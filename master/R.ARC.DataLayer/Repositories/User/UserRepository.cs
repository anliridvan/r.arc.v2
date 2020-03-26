using R.ARC.Core.DataLayer.Context;
using R.ARC.Core.Entity;
using System;

namespace R.ARC.Core.DataLayer.Repositories
{
    public sealed class UserRepository : BaseRepository<UserEntity>, IUserRepository
    {
        public UserRepository(PostgreSContext context, IServiceProvider serviceProvider) : base(context, serviceProvider) {
            context.
        }

    }
}
