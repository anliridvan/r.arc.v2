using Microsoft.EntityFrameworkCore;
using R.ARC.Core.Entity;

namespace R.ARC.Core.DataAccess.Context
{
    public sealed class DatabaseContextSeed
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

            modelBuilder.Entity<UserEntity>().HasData(new UserEntity
            {
                FirstName = "Ridvan",
                LastName = "Anli",
                Username = "admin",
                CreatedBy = System.Guid.Empty,
                CreationTime = System.DateTime.UtcNow
            });


        }
    }
}
