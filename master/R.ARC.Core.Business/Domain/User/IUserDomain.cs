using R.ARC.Common.Helper.Paging;
using R.ARC.Common.Contract;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace R.ARC.Core.Business
{
    public interface IUserDomain
    {
        Task<UserModel> AuthenticateAsync(string username, string password);
        Task<IEnumerable<UserModel>> GetAllAsync();
        Task<UserModel> GetByIdAsync(int id);
        Task<UserModel> CreateAsync(UserModel user, string password);
        Task<int> UpdateAsync(UserModel user, string password = null);
        Task<int> DeleteAsync(int id);
    }
}
