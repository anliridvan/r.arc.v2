using Microsoft.EntityFrameworkCore;
using R.ARC.Common.Helper.Crypto;
using R.ARC.Common.Helper.Enums;
using R.ARC.Common.Helper.Models;
using R.ARC.Core.Entity;
using System;
using System.Collections.Generic;

namespace R.ARC.Core.DataLayer.Context
{
    public sealed class ContextSeed
    {
        public void Seed(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<AddressMappingEntity>().HasData(new AddressMappingEntity
            {
                CountryCode = "TR",
                Depth = 3,
                CitySequence = 2,
                CountySequence = 3
            },
                new AddressMappingEntity
                {
                    CountryCode = "DE",
                    Depth = 5,
                    RegionSequence = 2,
                    CitySequence = 4,
                    CountySequence = 5
                },
                new AddressMappingEntity
                {
                    CountryCode = "US",
                    Depth = 4,
                    RegionSequence = 2,
                    CitySequence = 4
                },
                new AddressMappingEntity
                {
                    CountryCode = "GB",
                    Depth = 5,
                    RegionSequence = 2,
                    CitySequence = 4,
                    CountySequence = 5
                },
                new AddressMappingEntity
                {
                    CountryCode = "FR",
                    Depth = 7,
                    RegionSequence = 2,
                    CitySequence = 5,
                    CountySequence = 6
                },
                new AddressMappingEntity
                {
                    CountryCode = "VA",
                    Depth = 1
                });

            string password = "admin";
            byte[] passwordHash, passwordSalt;
            HashHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);

            modelBuilder.Entity<UserEntity>().HasData(new UserEntity
            {
                Id = Guid.NewGuid(),
                Username = "admin",
                FirstName = "Ridvan",
                LastName = "Anli",
                Email = "anliridvan@hotmail.com",
                CreatedBy = System.Guid.Empty,
                CreationTime = DateTime.UtcNow,
                ExtendedData = new UserExt
                {
                    AddressList = new List<AddressEntity>
                {
                    new AddressEntity
                    {
                        Address = "Cevirmeci / Ortakoy - Istanbul",
                        AddressType = AddressType.Mail,
                        City = "Istanbul",
                        Region = "Marmara",
                        County= "Besiktas",
                        Country= "TR",
                        CreatedBy = Guid.Empty,
                        CreationTime = DateTime.UtcNow,
                        ZipCode = 34930,
                    }
                }
                },
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt
            });

        }
    }
}
