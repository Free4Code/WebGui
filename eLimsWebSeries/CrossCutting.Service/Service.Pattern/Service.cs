namespace Service.Pattern
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading;
    using System.Threading.Tasks;

    using Repository.Pattern.Infrastructure;
    using Repository.Pattern.Repositories;

    public abstract class Service<TEntity> : IService<TEntity> where TEntity : IObjectState
    {
        #region Private Fields

        private readonly IRepositoryAsync<TEntity> repository;

        #endregion Private Fields

        #region Constructor

        protected Service(IRepositoryAsync<TEntity> repository)
        {
            this.repository = repository;
        }

        #endregion Constructor

        public virtual TEntity Find(params object[] keyValues)
        {
            return this.repository.Find(keyValues);
        }

        public virtual TEntity Get(Guid id)
        {
            return this.repository.Get(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return this.repository.Queryable().AsEnumerable();
        }

        public virtual IQueryable<TEntity> SelectQuery(string query, params object[] parameters)
        {
            return this.repository.SelectQuery(query, parameters).AsQueryable();
        }

        public virtual void Insert(TEntity entity)
        {
            this.repository.Insert(entity);
        }

        public virtual void InsertRange(IEnumerable<TEntity> entities)
        {
            this.repository.InsertRange(entities);
        }

        public virtual void Update(TEntity entity)
        {
            this.repository.Update(entity);
        }

        public virtual void Delete(object id)
        {
            this.repository.Delete(id);
        }

        public virtual void Delete(TEntity entity)
        {
            this.repository.Delete(entity);
        }

        public IQueryFluent<TEntity> Query()
        {
            return this.repository.Query();
        }

        public virtual IQueryFluent<TEntity> Query(IQueryObject<TEntity> queryObject)
        {
            return this.repository.Query(queryObject);
        }

        public virtual IQueryFluent<TEntity> Query(Expression<Func<TEntity, bool>> query)
        {
            return this.repository.Query(query);
        }

        public virtual async Task<TEntity> FindAsync(params object[] keyValues)
        {
            return await this.repository.FindAsync(keyValues);
        }

        public virtual async Task<TEntity> FindAsync(CancellationToken cancellationToken, params object[] keyValues)
        {
            return await this.repository.FindAsync(cancellationToken, keyValues);
        }

        public virtual async Task<TEntity> GetAsync(Guid id)
        {
            return await this.repository.GetAsync(id);
        }

        public virtual async Task<bool> DeleteAsync(params object[] keyValues)
        {
            return await this.DeleteAsync(CancellationToken.None, keyValues);
        }

        public virtual async Task<bool> DeleteAsync(CancellationToken cancellationToken, params object[] keyValues)
        {
            return await this.repository.DeleteAsync(cancellationToken, keyValues);
        }
    }
}