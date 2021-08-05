using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Newtonsoft.Json;
using R.ARC.Core.DataAccess.Repositories;
using R.ARC.Core.Entity;
using System;
using System.Linq;
using System.Reflection;

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
                if (type.ClrType.BaseType.IsGenericType && typeof(BaseExtendedEntity<>).IsAssignableFrom(type.ClrType.BaseType.GetGenericTypeDefinition()))
                {
                    foreach (PropertyInfo propertyInfo in type.ClrType.GetProperties())
                    {
                        if (propertyInfo.Name == "ExtendedData")
                        {
                            modelBuilder.SetExtendedFilter(type.ClrType, propertyInfo.PropertyType);
                            break;
                        }
                    }

                }
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
        #region Soft Delete
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
        #endregion

        #region Extended Entity (Json Serilize)
        public static void SetExtendedFilter(this ModelBuilder modelBuilder, Type entityType, Type extEntityType)
        {
            SetExtendedFilterMethod.MakeGenericMethod(extEntityType, entityType)
                .Invoke(null, new object[] { modelBuilder });
        }

        static readonly MethodInfo SetExtendedFilterMethod = typeof(EFFilterExtensions)
                   .GetMethods(BindingFlags.Public | BindingFlags.Static)
                   .Single(t => t.IsGenericMethod && t.Name == "SetExtendedFilter");

        public static void SetExtendedFilter<TExtEntity, TEntity>(this ModelBuilder modelBuilder)
            where TExtEntity : class, new() where TEntity : BaseExtendedEntity<TExtEntity>
        {
            ValueComparer<TExtEntity> comparer = new ValueComparer<TExtEntity>
                   (
                       (l, r) => JsonConvert.SerializeObject(l) == JsonConvert.SerializeObject(r),
                       v => v == null ? 0 : JsonConvert.SerializeObject(v).GetHashCode(),
                       v => JsonConvert.DeserializeObject<TExtEntity>(JsonConvert.SerializeObject(v))
                   );

            ValueConverter<TExtEntity, string> converter = new ValueConverter<TExtEntity, string>
                      (
                          v => JsonConvert.SerializeObject(v),
                          v => JsonConvert.DeserializeObject<TExtEntity>(v) ?? new TExtEntity()
                      );

            modelBuilder.Entity<TEntity>().Property(b => b.ExtendedData).HasConversion(converter);
            modelBuilder.Entity<TEntity>().Property(b => b.ExtendedData).Metadata.SetValueConverter(converter);
            modelBuilder.Entity<TEntity>().Property(b => b.ExtendedData).Metadata.SetValueComparer(comparer);
            //modelBuilder.Entity<TEntity>().Property(b => b.ExtendedData).HasColumnType("jsonb");
        }
        #endregion

        #region Base Entity
        public static void SetBaseEntityFilter(this ModelBuilder modelBuilder, Type entityType)
        {
            SetBaseEntityFilterMethod.MakeGenericMethod(entityType)
                .Invoke(null, new object[] { modelBuilder });
        }

        static readonly MethodInfo SetBaseEntityFilterMethod = typeof(EFFilterExtensions)
                   .GetMethods(BindingFlags.Public | BindingFlags.Static)
                   .Single(t => t.IsGenericMethod && t.Name == "SetBaseEntityFilter");

        public static void SetBaseEntityFilter<TEntity>(this ModelBuilder modelBuilder)
            where TEntity : BaseEntity
        {
            // modelBuilder.Entity<TEntity>().Property(x => x.Id).HasDefaultValueSql("NEWSEQUENTIALID()"); // unknown yet :/
        }
        #endregion
    }
}

