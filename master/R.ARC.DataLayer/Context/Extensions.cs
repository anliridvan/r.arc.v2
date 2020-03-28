using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using R.ARC.Core.Entity;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace R.ARC.Core.DataLayer.Context
{
    public static class EFFilterExtensions
    {
        public static void DetectChangesLazyLoading(this DbContext context, bool enabled)
        {
            context.ChangeTracker.AutoDetectChangesEnabled = enabled;
            context.ChangeTracker.LazyLoadingEnabled = enabled;
            context.ChangeTracker.QueryTrackingBehavior = enabled ? QueryTrackingBehavior.TrackAll : QueryTrackingBehavior.NoTracking;
        }

        public static IQueryable<T> Include<T>(this IQueryable<T> queryable, Expression<Func<T, object>>[] includes) where T : class
        {
            includes?.ToList().ForEach(include => queryable = queryable.Include(include));

            return queryable;
        }

        public static void ApplyConfigurationsFromAssembly(this ModelBuilder modelBuilder)
        {
            bool expression(Type type) => type.IsGenericType && type.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>);

            var types = Assembly.GetCallingAssembly().GetTypes().Where(type => type.GetInterfaces().Any(expression)).ToList();

            foreach (var type in types)
            {
                dynamic configuration = Activator.CreateInstance(type);
                modelBuilder.ApplyConfiguration(configuration);
            }
        }

        // ----------> SetSoftDeleteFilter

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

        // ----------> BaseEntityBind

        public static void BaseEntityBind(this ModelBuilder modelBuilder, Type entityType)
        {
            BaseEntityBindMethod.MakeGenericMethod(entityType)
                .Invoke(null, new object[] { modelBuilder });
        }

        static readonly MethodInfo BaseEntityBindMethod = typeof(EFFilterExtensions)
                   .GetMethods(BindingFlags.Public | BindingFlags.Static)
                   .Single(t => t.IsGenericMethod && t.Name == "BaseEntityBind");

        public static void BaseEntityBind<TEntity>(this ModelBuilder modelBuilder)
            where TEntity : BaseEntity
        {
            modelBuilder.HasPostgresExtension("uuid-ossp") // CREATE EXTENSION if not exists "uuid-ossp";
                   .Entity<TEntity>()
                   .Property(e => e.Id)
                   .HasDefaultValueSql("uuid_generate_v4()");
        }

        // ----------> BaseExtendedEntityBind

        public static void BaseExtendedEntityBind(this ModelBuilder modelBuilder, Type entityType)
        {
            BaseExtendedEntityBindMethod.MakeGenericMethod(entityType)
                .Invoke(null, new object[] { modelBuilder });
        }

        static readonly MethodInfo BaseExtendedEntityBindMethod = typeof(EFFilterExtensions)
                   .GetMethods(BindingFlags.Public | BindingFlags.Static)
                   .Single(t => t.IsGenericMethod && t.Name == "BaseExtendedEntityBind");

        public static void BaseExtendedEntityBind<T, TEntity>(this ModelBuilder modelBuilder)
            where  T : class, new() where TEntity : BaseExtendedEntity<T>
        {
            modelBuilder.Entity<TEntity>()
                   .Property(b => b.ExtendedData)
                   .HasConversion(
                              v => JsonConvert.SerializeObject(v),
                              v => JsonConvert.DeserializeObject<T>(v));
        }
    }
}
