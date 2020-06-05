using R.ARC.Common.Helper.Paging;
using R.ARC.Common.Contract;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace R.ARC.Core.Business
{
    public interface IUserDomain
    {
        Task<UserModel> AuthenticateAsync(string username, string password);
        Task<IEnumerable<UserModel>> GetAllAsync();
        Task<UserModel> GetByIdAsync(Guid id);
        Task<UserModel> CreateAsync(UserModel user, string password);
        Task<Guid> UpdateAsync(UserModel user, string password = null);
        Task<Guid> DeleteAsync(Guid id);
    }
}
