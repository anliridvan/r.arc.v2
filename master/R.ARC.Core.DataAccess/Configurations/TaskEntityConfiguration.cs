using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using R.ARC.Core.Entity;

namespace R.ARC.Core.DataAccess.Configurations
{
    public sealed class TaskEntityConfiguration : IEntityTypeConfiguration<TaskEntity>
    {
        public void Configure(EntityTypeBuilder<TaskEntity> builder)
        {
            builder.ToTable("tTask", "public");

            builder.Property(x => x.Title).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Description).HasMaxLength(255);
            builder.Property(x => x.AdditionalInfo).HasMaxLength(255);
            // builder.Property(x => x.AccountId).IsRequired();
            builder.Property(x => x.TaskType).IsRequired();
            builder.Property(x => x.TaskStatus).IsRequired();
            builder.Property(x => x.TaskPriority).IsRequired();
        }
    }
}
