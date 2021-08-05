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
            builder.ToTable("Tasks", "public");

            builder.Property(x => x.Title).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Description).HasMaxLength(255);
            builder.Property(x => x.AdditionalInfo).HasMaxLength(255);
            // builder.Property(x => x.AccountId).IsRequired();
            builder.Property(x => x.TaskType).IsRequired();
            builder.Property(x => x.TaskStatus).IsRequired();
            builder.Property(x => x.TaskPriority).IsRequired();

            // builder.Property(x => x.TaskNo).HasDefaultValueSql("NEXT VALUE FOR seq_task_no"); // SqlServer
            builder.Property(x => x.TaskNo).HasDefaultValueSql("nextval('seq_task_no')"); //  -- currval() or lastval() // Then Touched Init Migration 

            builder.Property(b => b.ExtendedData)
                  .HasConversion(
                              v => JsonConvert.SerializeObject(v),
                              v => JsonConvert.DeserializeObject<TaskExt>(v));
        }
    }
}
