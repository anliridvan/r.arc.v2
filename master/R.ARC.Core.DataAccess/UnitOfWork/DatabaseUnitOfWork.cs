using Microsoft.EntityFrameworkCore.Storage;
using R.ARC.Core.DataAccess.Context;
using System.Threading.Tasks;

namespace R.ARC.Core.DataAccess.UnitOfWork
{
    public sealed class DatabaseUnitOfWork : IDatabaseUnitOfWork
    {

        private DatabaseContext Context { get; }

        public DatabaseUnitOfWork(DatabaseContext context)
        {
            Context = context;
        }

        public int SaveChanges()
        {
            return Context.SaveChanges();
        }

        public Task<int> SaveChangesAsync()
        {
            return Context.SaveChangesAsync();
        }

        public IDbContextTransaction BeginTransaction()
        {
            return Context.Database.BeginTransaction();
        }

        public async Task<IDbContextTransaction> BeginTransactionAsync()
        {
            return await Context.Database.BeginTransactionAsync();
        }
    }
}
