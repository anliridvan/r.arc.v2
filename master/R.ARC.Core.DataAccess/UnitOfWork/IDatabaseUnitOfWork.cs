using Microsoft.EntityFrameworkCore.Storage;
using System.Threading.Tasks;

namespace R.ARC.Core.DataAccess.UnitOfWork
{
    public interface IDatabaseUnitOfWork
    {
        int SaveChanges();

        Task<int> SaveChangesAsync();

        IDbContextTransaction BeginTransaction();

        Task<IDbContextTransaction> BeginTransactionAsync();
    }
}
