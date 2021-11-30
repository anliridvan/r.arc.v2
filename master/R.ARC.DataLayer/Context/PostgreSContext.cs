using Microsoft.EntityFrameworkCore;
using R.ARC.Core.Entity;

namespace R.ARC.Core.DataLayer.Context
{
    public partial class PostgreSContext : DbContext
    {
        public PostgreSContext()
        {
        }

        public PostgreSContext(DbContextOptions<PostgreSContext> options)
            : base(options)
        {

        }

        #region DbSets

        //public virtual DbSet<UserEntity> Users { get; set; }
        //public virtual DbSet<UserEntity> Tasks { get; set; }
        //public virtual DbSet<AddressEntity> Addresses { get; set; }
        //public virtual DbSet<AddressMappingEntity> AddressMappings { get; set; }
       #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                 optionsBuilder.UseNpgsql("Host=localhost:5342;Database=r_arc;Username=postgres;Password=postgres");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Sequances
            modelBuilder.HasSequence<long>("seq_task_no")
              .StartsAt(1111111111)
              .IncrementsBy(3);

            #endregion
            modelBuilder.ApplyConfigurationsFromAssembly();

            new ContextSeed().Seed(modelBuilder);

            //modelBuilder.Entity<SoftDeleteEntity>().HasQueryFilter(u => !u.IsDeleted);
            foreach (var type in modelBuilder.Model.GetEntityTypes())
            {
                if (typeof(SoftDeleteEntity).IsAssignableFrom(type.ClrType))
                    modelBuilder.SetSoftDeleteFilter(type.ClrType);
                if (typeof(BaseEntity).IsAssignableFrom(type.ClrType))
                    modelBuilder.BaseEntityBind(type.ClrType);
                if (typeof(BaseExtendedEntity<>).IsAssignableFrom(type.ClrType))
                    modelBuilder.BaseExtendedEntityBind(type.ClrType);
            }


            #region Entity Relations Configurations

            modelBuilder.Entity<TaskEntity>()
                .HasOne(t => t.MasterUser)
                .WithOne()
                .HasForeignKey(typeof(TaskEntity), nameof(TaskEntity.UserId))
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);
            #endregion




            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
