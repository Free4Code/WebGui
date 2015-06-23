namespace Repository.Pattern.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;

    using global::Repository.Pattern.Infrastructure;

    public interface IRepository<TEntity>
        where TEntity : IObjectState
    {
        TEntity Find(params object[] keyValues);

        TEntity Get(Guid id);

        IQueryable<TEntity> SelectQuery(string query, params object[] parameters);

        void Insert(TEntity entity);

        void InsertRange(IEnumerable<TEntity> entities);

        void Update(TEntity entity);

        void Delete(object id);

        void Delete(TEntity entity);

        IQueryFluent<TEntity> Query(IQueryObject<TEntity> queryObject);

        IQueryFluent<TEntity> Query(Expression<Func<TEntity, bool>> query);

        IQueryFluent<TEntity> Query();

        IQueryable<TEntity> Queryable();

        IRepository<T> GetRepository<T>() where T : class, IObjectState;
    }
}