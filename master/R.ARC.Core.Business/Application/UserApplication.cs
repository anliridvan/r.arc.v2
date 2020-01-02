using R.ARC.Common.Contract;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace R.ARC.Core.Business.Application
{
    public class UserApplication : ApplicationBase<AccountApplication>, IUserApplication
    {
        private IUserDomain _userDom;

        public UserApplication(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            _userDom = serviceProvider.GetService<IUserDomain>();
        }



        public Task<UserModel> AuthenticateAsync(string username, string password)
        {
            return _userDom.AuthenticateAsync(username, password);
        }

        public Task<IEnumerable<UserModel>> GetAllAsync()
        {
            return _userDom.GetAllAsync();
        }

        public Task<UserModel> GetByIdAsync(int id)
        {
            return _userDom.GetByIdAsync(id);
        }

        public Task<UserModel> CreateAsync(UserModel user, string password)
        {
            return _userDom.CreateAsync(user, password);
        }

        public Task UpdateAsync(UserModel user, string password)
        {
            return _userDom.UpdateAsync(user, password);
        }

        public Task DeleteAsync(int id)
        {
            return _userDom.DeleteAsync(id);
        }
    }
}
