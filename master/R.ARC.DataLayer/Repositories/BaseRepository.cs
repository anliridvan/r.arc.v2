using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using R.ARC.Common.Helper.Paging;
using R.ARC.Core.Entity;
using R.ARC.Util.Mapping;
using R.ARC.Util.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace R.ARC.Core.DataLayer.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private DbContext Context { get; }
        private ISessionManager SessionManager { get; }

        public BaseRepository(DbContext context, IServiceProvider serviceProvider)
        {
            Context = context;
            SessionManager = serviceProvider.GetService<ISessionManager>();
            Context.DetectChangesLazyLoading(false);
        }

        protected Guid UserId => SessionManager.UserId;

        private readonly string IsDeletedProp = nameof(SoftDeleteEntity.IsDeleted);

        //public IQueryable<T> Queryable => Set.Where(m =>  m is SoftDeleteEntity 
        //          && typeof(T).GetProperty(IsDeletedProp) != null 
        //          && (bool)typeof(T).GetProperty(IsDeletedProp).GetValue(m) ? false : true); 


        public IQueryable<T> Queryable => Set.AsQueryable();
        public IQueryable<T> AllQueryable => Set.AsQueryable();

        private DbSet<T> Set => Context.Set<T>();

        public IQueryable<T> RawQuery(string sql, params object[] parameters)
        {
            return Set.FromSqlRaw(sql, parameters);
        }

        /// <summary>
        /// DatabaseContext'e TResult tipinde DbQuery tanimlanmalidir.
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public IQueryable<TResult> RawQuery<TResult>(string sql, params object[] parameters) where TResult : class
        {
            // return Context.Set<TResult>().FromSql(sql, parameters); .net core 2.2
            return Context.Set<TResult>().FromSqlRaw(sql, parameters); // .net core 3.0
        }

        #region CRUD
        public void Add(T item)
        {
            if (item is BaseEntity)
            {
                typeof(T).GetProperty(nameof(BaseEntity.CreatedBy)).SetValue(item, UserId);
                typeof(T).GetProperty(nameof(BaseEntity.CreationTime)).SetValue(item, DateTime.UtcNow);
            }

            Set.Add(item);
        }

        public Task AddAsync(T item)
        {
            if (item is BaseEntity)
            {
                typeof(T).GetProperty(nameof(BaseEntity.CreatedBy)).SetValue(item, UserId);
                typeof(T).GetProperty(nameof(BaseEntity.CreationTime)).SetValue(item, DateTime.UtcNow);
            }

            // return Set.AddAsync(item); .net core 2.2
            return Set.AddAsync(item).AsTask(); // .net core 3
        }

        public void AddRange(IEnumerable<T> items)
        {
            Set.AddRange(items);
        }

        public Task AddRangeAsync(IEnumerable<T> items)
        {
            return Set.AddRangeAsync(items);
        }

        public void Update(T item)
        {
            Context.DetectChangesLazyLoading(true);

            if (item is BaseEntity)
            {
                typeof(T).GetProperty(nameof(BaseEntity.UpdatedBy)).SetValue(item, UserId);
                typeof(T).GetProperty(nameof(BaseEntity.UpdateTime)).SetValue(item, DateTime.UtcNow);
            }

            Set.Attach(item);
            var entry = Context.Entry(item);
            entry.State = EntityState.Modified;

            Context.DetectChangesLazyLoading(false);
        }

        public Task UpdateAsync(T item)
        {
            Update(item);

            return Task.CompletedTask;
        }

        public void Delete(Expression<Func<T, bool>> where, bool ignoreSoftDelete = false)
        {
            Context.DetectChangesLazyLoading(true);

            IQueryable<T> items = Set.Where(where);

            if (items == null)
                return;

            if (typeof(SoftDeleteEntity).IsAssignableFrom(typeof(T)) && !ignoreSoftDelete)
            {
                foreach (var item in items)
                {
                    typeof(T).GetProperty(IsDeletedProp).SetValue(item, true);
                    Update(item);
                }
            }
            else
            {
                Set.RemoveRange(items);
            }

            Context.DetectChangesLazyLoading(false);
        }

        public Task DeleteAsync(Expression<Func<T, bool>> where, bool ignoreSoftDelete = false)
        {
            Delete(where, ignoreSoftDelete);

            return Task.CompletedTask;
        }
        #endregion

        #region SelectOnlyActive
        public bool Any()
        {
            return Queryable.Any();
        }

        public Task<bool> AnyAsync()
        {
            return Queryable.AnyAsync();
        }

        public bool Any(Expression<Func<T, bool>> where)
        {
            return Queryable.Any(where);
        }

        public Task<bool> AnyAsync(Expression<Func<T, bool>> where)
        {
            return Queryable.AnyAsync(where);
        }

        public long Count()
        {
            return Queryable.LongCount();
        }

        public Task<long> CountAsync()
        {
            return Queryable.LongCountAsync();
        }

        public long Count(Expression<Func<T, bool>> where)
        {
            return Queryable.LongCount(where);
        }

        public Task<long> CountAsync(Expression<Func<T, bool>> where)
        {
            return Queryable.LongCountAsync(where);
        }

        public T FirstOrDefault(Expression<Func<T, bool>> where)
        {
            return Queryable.Where(where).FirstOrDefault();
        }

        public Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> where)
        {
            return Queryable.Where(where).FirstOrDefaultAsync();
        }

        public TResult FirstOrDefault<TResult>(Expression<Func<T, bool>> where)
        {
            return Queryable.Where(where).Project<T, TResult>().FirstOrDefault();
        }

        public Task<TResult> FirstOrDefaultAsync<TResult>(Expression<Func<T, bool>> where)
        {
            return Queryable.Where(where).Project<T, TResult>().FirstOrDefaultAsync();
        }

        public T FirstOrDefault(params Expression<Func<T, object>>[] include)
        {
            return Queryable.Include(include).FirstOrDefault();
        }

        public Task<T> FirstOrDefaultAsync(params Expression<Func<T, object>>[] include)
        {
            return Queryable.Include(include).FirstOrDefaultAsync();
        }

        public T FirstOrDefault(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] include)
        {
            return Queryable.Where(where).Include(include).FirstOrDefault();
        }

        public Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] include)
        {
            return Queryable.Where(where).Include(include).FirstOrDefaultAsync();
        }

        public IEnumerable<T> List()
        {
            return Queryable.ToList();
        }

        public async Task<IEnumerable<T>> ListAsync()
        {
            return await Queryable.ToListAsync().ConfigureAwait(false);
        }

        public IEnumerable<TResult> List<TResult>()
        {
            return Queryable.Project<T, TResult>().ToList();
        }

        public async Task<IEnumerable<TResult>> ListAsync<TResult>()
        {
            return await Queryable.Project<T, TResult>().ToListAsync().ConfigureAwait(false);
        }

        public IEnumerable<T> List(Expression<Func<T, bool>> where)
        {
            return Queryable.Where(where).ToList();
        }

        public async Task<IEnumerable<T>> ListAsync(Expression<Func<T, bool>> where)
        {
            return await Queryable.Where(where).ToListAsync().ConfigureAwait(false);
        }

        public IEnumerable<TResult> List<TResult>(Expression<Func<T, bool>> where)
        {
            return Queryable.Where(where).Project<T, TResult>().ToList();
        }

        public async Task<IEnumerable<TResult>> ListAsync<TResult>(Expression<Func<T, bool>> where)
        {
            return await Queryable.Where(where).Project<T, TResult>().ToListAsync().ConfigureAwait(false);
        }

        public IEnumerable<T> List(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] include)
        {
            return Queryable.Where(where).Include(include).ToList();
        }

        public async Task<IEnumerable<T>> ListAsync(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] include)
        {
            return await Queryable.Where(where).Include(include).ToListAsync().ConfigureAwait(false);
        }

        public IEnumerable<TResult> List<TResult>(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] include)
        {
            return Queryable.Where(where).Include(include).Project<T, TResult>().ToList();
        }

        public async Task<IEnumerable<TResult>> ListAsync<TResult>(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] include)
        {
            return await Queryable.Where(where).Include(include).Project<T, TResult>().ToListAsync().ConfigureAwait(false);
        }

        public PagedList<T> List(PagedListParameters parameters, Expression<Func<T, bool>> where)
        {
            return new PagedList<T>(Queryable.Where(where), parameters);
        }

        public Task<PagedList<T>> ListAsync(PagedListParameters parameters, Expression<Func<T, bool>> where)
        {
            return Task.FromResult(List(parameters, where));
        }

        public PagedList<TResult> List<TResult>(PagedListParameters parameters, Expression<Func<T, bool>> where)
        {
            return new PagedList<TResult>(Queryable.Where(where).Project<T, TResult>(), parameters, typeof(T));
        }

        public Task<PagedList<TResult>> ListAsync<TResult>(PagedListParameters parameters, Expression<Func<T, bool>> where)
        {
            return Task.FromResult(List<TResult>(parameters, where));
        }
        #endregion

        #region SelectWithDeleted
        public bool AnyWithDeleted()
        {
            return AllQueryable.Any();
        }

        public Task<bool> AnyWithDeletedAsync()
        {
            return AllQueryable.AnyAsync();
        }

        public bool AnyWithDeleted(Expression<Func<T, bool>> where)
        {
            return AllQueryable.Any(where);
        }

        public Task<bool> AnyWithDeletedAsync(Expression<Func<T, bool>> where)
        {
            return AllQueryable.AnyAsync(where);
        }

        public long CountWithDeleted()
        {
            return AllQueryable.LongCount();
        }

        public Task<long> CountWithDeletedAsync()
        {
            return AllQueryable.LongCountAsync();
        }

        public long CountWithDeleted(Expression<Func<T, bool>> where)
        {
            return AllQueryable.LongCount(where);
        }

        public Task<long> CountWithDeletedAsync(Expression<Func<T, bool>> where)
        {
            return AllQueryable.LongCountAsync(where);
        }

        public T FirstOrDefaultWithDeleted(Expression<Func<T, bool>> where)
        {
            return AllQueryable.Where(where).FirstOrDefault();
        }

        public Task<T> FirstOrDefaultWithDeletedAsync(Expression<Func<T, bool>> where)
        {
            return AllQueryable.Where(where).FirstOrDefaultAsync();
        }

        public TResult FirstOrDefaultWithDeleted<TResult>(Expression<Func<T, bool>> where)
        {
            return AllQueryable.Where(where).Project<T, TResult>().FirstOrDefault();
        }

        public Task<TResult> FirstOrDefaultWithDeletedAsync<TResult>(Expression<Func<T, bool>> where)
        {
            return AllQueryable.Where(where).Project<T, TResult>().FirstOrDefaultAsync();
        }

        public T FirstOrDefaultWithDeleted(params Expression<Func<T, object>>[] include)
        {
            return AllQueryable.Include(include).FirstOrDefault();
        }

        public Task<T> FirstOrDefaultWithDeletedAsync(params Expression<Func<T, object>>[] include)
        {
            return AllQueryable.Include(include).FirstOrDefaultAsync();
        }

        public T FirstOrDefaultWithDeleted(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] include)
        {
            return AllQueryable.Where(where).Include(include).FirstOrDefault();
        }

        public Task<T> FirstOrDefaultWithDeletedAsync(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] include)
        {
            return AllQueryable.Where(where).Include(include).FirstOrDefaultAsync();
        }

        public IEnumerable<T> ListWithDeleted()
        {
            return AllQueryable.ToList();
        }

        public async Task<IEnumerable<T>> ListWithDeletedAsync()
        {
            return await AllQueryable.ToListAsync().ConfigureAwait(false);
        }

        public IEnumerable<TResult> ListWithDeleted<TResult>()
        {
            return AllQueryable.Project<T, TResult>().ToList();
        }

        public async Task<IEnumerable<TResult>> ListWithDeletedAsync<TResult>()
        {
            return await AllQueryable.Project<T, TResult>().ToListAsync().ConfigureAwait(false);
        }

        public IEnumerable<T> ListWithDeleted(Expression<Func<T, bool>> where)
        {
            return AllQueryable.Where(where).ToList();
        }

        public async Task<IEnumerable<T>> ListWithDeletedAsync(Expression<Func<T, bool>> where)
        {
            return await AllQueryable.Where(where).ToListAsync().ConfigureAwait(false);
        }

        public IEnumerable<TResult> ListWithDeleted<TResult>(Expression<Func<T, bool>> where)
        {
            return AllQueryable.Where(where).Project<T, TResult>().ToList();
        }

        public async Task<IEnumerable<TResult>> ListWithDeletedAsync<TResult>(Expression<Func<T, bool>> where)
        {
            return await AllQueryable.Where(where).Project<T, TResult>().ToListAsync().ConfigureAwait(false);
        }

        public PagedList<T> ListWithDeleted(PagedListParameters parameters, Expression<Func<T, bool>> where)
        {
            return new PagedList<T>(AllQueryable.Where(where), parameters);
        }

        public Task<PagedList<T>> ListWithDeletedAsync(PagedListParameters parameters, Expression<Func<T, bool>> where)
        {
            return Task.FromResult(List(parameters, where));
        }

        public PagedList<TResult> ListWithDeleted<TResult>(PagedListParameters parameters, Expression<Func<T, bool>> where)
        {
            return new PagedList<TResult>(AllQueryable.Where(where).Project<T, TResult>(), parameters, typeof(T));
        }

        public Task<PagedList<TResult>> ListWithDeletedAsync<TResult>(PagedListParameters parameters, Expression<Func<T, bool>> where)
        {
            return Task.FromResult(List<TResult>(parameters, where));
        }
        #endregion
    }
}
