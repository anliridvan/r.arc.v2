using Microsoft.EntityFrameworkCore.Storage;
using System.Threading.Tasks;

namespace R.ARC.Core.DataLayer.UnitOfWork
{
    public interface IDatabaseUnitOfWork
    {
        int SaveChanges();

        Task<int> SaveChangesAsync();

        IDbContextTransaction BeginTransaction();

        Task<IDbContextTransaction> BeginTransactionAsync();
    }
}
