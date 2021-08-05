using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using R.ARC.Core.Entity;

namespace R.ARC.Core.DataAccess.Configurations
{
    public sealed class AddressMappingEntityConfiguration : IEntityTypeConfiguration<AddressMappingEntity>
    {
        public void Configure(EntityTypeBuilder<AddressMappingEntity> builder)
        {
            builder.ToTable("AddressMappings", "public");

            builder.HasKey(x => x.CountryCode);
            builder.Property(x => x.Depth).IsRequired();
        }
    }
}
