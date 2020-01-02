using Microsoft.EntityFrameworkCore;
using R.ARC.Core.DataAccess.Repositories;
using R.ARC.Core.Entity;
using R.ARC.Common.Contract;
using System.Reflection;
using System.Linq;
using System;

namespace R.ARC.Core.DataAccess.Context
{
    public sealed class DatabaseContext : DbContext
    {

        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }


        //public DbQuery<FussyModel> FussyModels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly();

            //modelBuilder.Entity<SoftDeleteEntity>().HasQueryFilter(u => !u.IsDeleted);
            foreach (var type in modelBuilder.Model.GetEntityTypes())
            {
                if (typeof(SoftDeleteEntity).IsAssignableFrom(type.ClrType))
                    modelBuilder.SetSoftDeleteFilter(type.ClrType);
            }

            new DatabaseContextSeed().Seed(modelBuilder);

            #region Entity Relations Configurations

            // modelBuilder.Entity<TaskEntity>()
            //     .HasOne(t => t.User)
            //     .WithOne()
            //     .HasForeignKey(typeof(TaskEntity), nameof(TaskEntity.UserId))
            //     .IsRequired(false)
            //     .OnDelete(DeleteBehavior.Restrict);

            #endregion
        }
    }

    public static class EFFilterExtensions
    {
        public static void SetSoftDeleteFilter(this ModelBuilder modelBuilder, Type entityType)
        {
            SetSoftDeleteFilterMethod.MakeGenericMethod(entityType)
                .Invoke(null, new object[] { modelBuilder });
        }

        static readonly MethodInfo SetSoftDeleteFilterMethod = typeof(EFFilterExtensions)
                   .GetMethods(BindingFlags.Public | BindingFlags.Static)
                   .Single(t => t.IsGenericMethod && t.Name == "SetSoftDeleteFilter");

        public static void SetSoftDeleteFilter<TEntity>(this ModelBuilder modelBuilder)
            where TEntity : SoftDeleteEntity
        {
            modelBuilder.Entity<TEntity>().HasQueryFilter(x => !x.IsDeleted);
        }
    }
}
