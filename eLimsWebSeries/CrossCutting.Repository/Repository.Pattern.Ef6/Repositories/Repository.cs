namespace Repository.Pattern.Ef6
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading;
    using System.Threading.Tasks;

    using LinqKit;

    using Repository.Pattern.DataContext;
    using Repository.Pattern.Infrastructure;
    using Repository.Pattern.Repositories;
    using Repository.Pattern.UnitOfWork;

    public class Repository<TEntity> : IRepositoryAsync<TEntity>
        where TEntity : class, IObjectState
    {
        #region Private Fields

        private readonly IDataContextAsync context;

        private readonly DbSet<TEntity> dbSet;

        private readonly IUnitOfWorkAsync unitOfWork;

        #endregion Private Fields

        public Repository(IDataContextAsync context, IUnitOfWorkAsync unitOfWork)
        {
            this.context = context;
            this.unitOfWork = unitOfWork;

            var dbContext = (DbContext)context;
            this.dbSet = dbContext.Set<TEntity>();
        }

        public virtual TEntity Find(params object[] keyValues)
        {
            return this.dbSet.Find(keyValues);
        }

        public virtual TEntity Get(Guid id)
        {
            return this.dbSet.FirstOrDefault(e => e.Id == id);
        }

        public virtual IQueryable<TEntity> SelectQuery(string query, params object[] parameters)
        {
            return this.dbSet.SqlQuery(query, parameters).AsQueryable();
        }

        public virtual void Insert(TEntity entity)
        {
            entity.ObjectState = ObjectState.Added;
            this.dbSet.Attach(entity);
            this.context.SyncObjectState(entity);
        }

        public virtual void InsertRange(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                this.Insert(entity);
            }
        }

        public virtual void Update(TEntity entity)
        {
            entity.ObjectState = ObjectState.Modified;
            this.dbSet.Attach(entity);
            this.context.SyncObjectState(entity);
        }

        public virtual void Delete(object id)
        {
            var entity = this.dbSet.Find(id);
            this.Delete(entity);
        }

        public virtual void Delete(TEntity entity)
        {
            entity.ObjectState = ObjectState.Deleted;
            this.dbSet.Attach(entity);
            this.context.SyncObjectState(entity);
        }

        public IQueryFluent<TEntity> Query()
        {
            return new QueryFluent<TEntity>(this);
        }

        public virtual IQueryFluent<TEntity> Query(IQueryObject<TEntity> queryObject)
        {
            return new QueryFluent<TEntity>(this, queryObject);
        }

        public virtual IQueryFluent<TEntity> Query(Expression<Func<TEntity, bool>> query)
        {
            return new QueryFluent<TEntity>(this, query);
        }

        public IQueryable<TEntity> Queryable()
        {
            return this.dbSet;
        }

        public IRepository<T> GetRepository<T>()
            where T : class, IObjectState
        {
            return this.unitOfWork.Repository<T>();
        }

        public virtual async Task<TEntity> FindAsync(params object[] keyValues)
        {
            return await this.dbSet.FindAsync(keyValues);
        }

        public virtual async Task<TEntity> FindAsync(CancellationToken cancellationToken, params object[] keyValues)
        {
            return await this.dbSet.FindAsync(cancellationToken, keyValues);
        }

        public virtual async Task<TEntity> GetAsync(Guid id)
        {
            return await this.dbSet.FirstOrDefaultAsync(e => e.Id == id);
        }

        public virtual async Task<bool> DeleteAsync(params object[] keyValues)
        {
            return await this.DeleteAsync(CancellationToken.None, keyValues);
        }

        public virtual async Task<bool> DeleteAsync(CancellationToken cancellationToken, params object[] keyValues)
        {
            var entity = await this.FindAsync(cancellationToken, keyValues);

            if (entity == null)
            {
                return false;
            }

            entity.ObjectState = ObjectState.Deleted;
            this.dbSet.Attach(entity);

            return true;
        }

        internal IQueryable<TEntity> Select(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            IEnumerable<Expression<Func<TEntity, object>>> includes = null,
            int? page = null,
            int? pageSize = null)
        {
            IQueryable<TEntity> query = this.dbSet;

            if (includes != null)
            {
                query = includes.Aggregate(query, (current, include) => current.Include(include));
            }

            if (orderBy != null)
            {
                query = orderBy(query);
            }

            if (filter != null)
            {
                query = query.AsExpandable().Where(filter);
            }

            if (page != null && pageSize != null)
            {
                query = query.Skip((page.Value - 1) * pageSize.Value).Take(pageSize.Value);
            }

            return query;
        }

        internal async Task<IEnumerable<TEntity>> SelectAsync(
            Expression<Func<TEntity, bool>> query = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            IEnumerable<Expression<Func<TEntity, object>>> includes = null,
            int? page = null,
            int? pageSize = null)
        {
            // See: Best Practices in Asynchronous Programming http://msdn.microsoft.com/en-us/magazine/jj991977.aspx
            return await Task.Run(() => this.Select(query, orderBy, includes, page, pageSize).AsEnumerable()).ConfigureAwait(false);
        }
    }
}
