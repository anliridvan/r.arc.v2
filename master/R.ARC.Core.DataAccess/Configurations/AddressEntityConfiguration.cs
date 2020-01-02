using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using R.ARC.Core.Entity;

namespace R.ARC.Core.DataAccess.Configurations
{
    public sealed class AddressEntityConfiguration : IEntityTypeConfiguration<AddressEntity>
    {
        public void Configure(EntityTypeBuilder<AddressEntity> builder)
        {
            builder.ToTable("tAddress", "dbo");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();
            //builder.Property(x => x.Title).IsRequired().HasMaxLength(100);
            builder.Property(x => x.AddressType).IsRequired();
            builder.Property(x => x.Country).IsRequired();
            builder.Property(x => x.Address).IsRequired().HasMaxLength(500);
        }
    }
}
