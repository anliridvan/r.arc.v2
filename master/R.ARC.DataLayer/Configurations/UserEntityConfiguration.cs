﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using R.ARC.Core.Entity;

namespace R.ARC.Core.DataAccess.Configurations
{
    public sealed class UserEntityConfiguration : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.ToTable("tUser", "dbo");

            builder.Property(x => x.Username).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.PasswordHash).IsRequired();
            builder.Property(x => x.PasswordSalt).IsRequired();

            builder.Property(b => b.ExtendedData)
                  .HasConversion(
                              v => JsonConvert.SerializeObject(v),
                              v => JsonConvert.DeserializeObject<UserExt>(v));
        }
    }
}
