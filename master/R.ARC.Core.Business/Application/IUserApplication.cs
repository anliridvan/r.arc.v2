﻿using R.ARC.Common.Contract;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace R.ARC.Core.Business.Application
{
    public interface IUserApplication
    {
        Task<UserModel> AuthenticateAsync(string username, string password);
        Task<IEnumerable<UserModel>> GetAllAsync();
        Task<UserModel> GetByIdAsync(Guid id);
        Task<UserModel> CreateAsync(UserModel user, string password);
        Task UpdateAsync(UserModel user, string password = null);
        Task DeleteAsync(Guid id);
    }
}
