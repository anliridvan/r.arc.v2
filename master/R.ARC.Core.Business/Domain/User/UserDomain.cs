using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using R.ARC.Core.DataAccess.Repositories;
using R.ARC.Core.DataAccess.UnitOfWork;
using R.ARC.Core.Entity;
using R.ARC.Common.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using R.ARC.Common.Helper.Models.Exceptions;

namespace R.ARC.Core.Business
{
    public class UserDomain : DomainBase<UserDomain>, IUserDomain
    {
        private readonly IUserRepository _UserRep;
        private readonly IDatabaseUnitOfWork _uow;

        public UserDomain(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            _UserRep = serviceProvider.GetService<IUserRepository>();
            _uow = serviceProvider.GetService<IDatabaseUnitOfWork>();
        }

     
        public async Task<UserModel> AuthenticateAsync(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                return null;

            var user = await _UserRep.FirstOrDefaultAsync(x => x.Username == username);

            // check if username exists
            if (user == null)
                return null;

            // check if password is correct
            if (!VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
                return null;

            // authentication successful
            return Mapper.Map<UserEntity,UserModel>(user);
        }

        public async Task<IEnumerable<UserModel>> GetAllAsync()
        {
            return await _UserRep.ListAsync<UserModel>();
        }

        public async Task<UserModel> GetByIdAsync(int id)
        {
            return await _UserRep.FirstOrDefaultAsync<UserModel>(x => x.Id == id); 
        }

        public async Task<UserModel> CreateAsync(UserModel user, string password)
        {
            var userEntity = Mapper.Map<UserModel, UserEntity>(user);
            // validation
            if (string.IsNullOrWhiteSpace(password))
                throw new ApiException<string>("Password is required");

            if (await _UserRep.AnyAsync(x => x.Username == userEntity.Username))
                throw new ApiException<string>("Username \"" + userEntity.Username + "\" is already taken");

            byte[] passwordHash, passwordSalt;
            CreatePasswordHash(password, out passwordHash, out passwordSalt);

            userEntity.PasswordHash = passwordHash;
            userEntity.PasswordSalt = passwordSalt;

            await _UserRep.AddAsync(userEntity);
            await _uow.SaveChangesAsync();
            user.Id = userEntity.Id;

            return user;
        }

        public async Task<int> UpdateAsync(UserModel userParam, string password = null)
        {
            var user = await  _UserRep.FirstOrDefaultAsync(x=> x.Id == userParam.Id);

            if (user == null)
                throw new ApiException<string>("User not found");

            // update username if it has changed
            if (!string.IsNullOrWhiteSpace(userParam.Username) && userParam.Username != user.Username)
            {
                // throw error if the new username is already taken
                if (await _UserRep.AnyAsync(x => x.Username == userParam.Username))
                    throw new ApiException<string>("Username " + userParam.Username + " is already taken");

                user.Username = userParam.Username;
            }

            // update user properties if provided
            if (!string.IsNullOrWhiteSpace(userParam.FirstName))
                user.FirstName = userParam.FirstName;

            if (!string.IsNullOrWhiteSpace(userParam.LastName))
                user.LastName = userParam.LastName;

            // update password if provided
            if (!string.IsNullOrWhiteSpace(password))
            {
                byte[] passwordHash, passwordSalt;
                CreatePasswordHash(password, out passwordHash, out passwordSalt);

                user.PasswordHash = passwordHash;
                user.PasswordSalt = passwordSalt;
            }

            await _UserRep.UpdateAsync(user);
            await _uow.SaveChangesAsync();

            return user.Id;
        }

        public async Task<int> DeleteAsync(int id)
        {
            var user = await _UserRep.FirstOrDefaultAsync(m => m.Id == id);
            if (user != null)
            {
                await _UserRep.DeleteAsync(m => m.Id == id);
                await _uow.SaveChangesAsync();
                return id;
            }
            return 0;
        }

        // private helper methods

        private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            if (password == null) throw new ArgumentNullException("password");
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Value cannot be empty or whitespace only string.", "password");

            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        private static bool VerifyPasswordHash(string password, byte[] storedHash, byte[] storedSalt)
        {
            if (password == null) throw new ArgumentNullException("password");
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Value cannot be empty or whitespace only string.", "password");
            if (storedHash.Length != 64) throw new ArgumentException("Invalid length of password hash (64 bytes expected).", "passwordHash");
            if (storedSalt.Length != 128) throw new ArgumentException("Invalid length of password salt (128 bytes expected).", "passwordHash");

            using (var hmac = new System.Security.Cryptography.HMACSHA512(storedSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != storedHash[i]) return false;
                }
            }

            return true;
        }

    }
}
