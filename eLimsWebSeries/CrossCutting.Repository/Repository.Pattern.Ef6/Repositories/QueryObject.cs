namespace Repository.Pattern.Ef6
{
    using System;
    using System.Linq.Expressions;

    using LinqKit;

    using Repository.Pattern.Repositories;

    public abstract class QueryObject<TEntity> : IQueryObject<TEntity>
    {
        private Expression<Func<TEntity, bool>> query;

        public virtual Expression<Func<TEntity, bool>> Query()
        {
            return this.query;
        }

        public Expression<Func<TEntity, bool>> And(Expression<Func<TEntity, bool>> query)
        {
            return this.query = this.query == null ? query : this.query.And(query.Expand());
        }

        public Expression<Func<TEntity, bool>> Or(Expression<Func<TEntity, bool>> query)
        {
            return this.query = this.query == null ? query : this.query.Or(query.Expand());
        }

        public Expression<Func<TEntity, bool>> And(IQueryObject<TEntity> queryObject)
        {
            return this.And(queryObject.Query());
        }

        public Expression<Func<TEntity, bool>> Or(IQueryObject<TEntity> queryObject)
        {
            return this.Or(queryObject.Query());
        }
    }
}
