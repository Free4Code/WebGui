namespace Repository.Pattern.Ef6
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    using Repository.Pattern.Infrastructure;
    using Repository.Pattern.Repositories;

    public sealed class QueryFluent<TEntity> : IQueryFluent<TEntity>
        where TEntity : class, IObjectState
{
    #region Private Fields

    private readonly Expression<Func<TEntity, bool>> expression;

    private readonly List<Expression<Func<TEntity, object>>> includes;

    private readonly Repository<TEntity> repository;

    private Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy;

    #endregion Private Fields

    #region Constructors

    public QueryFluent(Repository<TEntity> repository)
    {
        this.repository = repository;
        this.includes = new List<Expression<Func<TEntity, object>>>();
    }

    public QueryFluent(Repository<TEntity> repository, IQueryObject<TEntity> queryObject)
        : this(repository)
    {
        this.expression = queryObject.Query();
    }

    public QueryFluent(Repository<TEntity> repository, Expression<Func<TEntity, bool>> expression)
        : this(repository)
    {
        this.expression = expression;
    }

    #endregion Constructors

    public IQueryFluent<TEntity> OrderBy(Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy)
    {
        this.orderBy = orderBy;
        return this;
    }

    public IQueryFluent<TEntity> Include(Expression<Func<TEntity, object>> expression)
    {
        this.includes.Add(expression);
        return this;
    }

    public IEnumerable<TEntity> SelectPage(int page, int pageSize, out int totalCount)
    {
        totalCount = this.repository.Select(this.expression).Count();
        return this.repository.Select(this.expression, this.orderBy, this.includes, page, pageSize);
    }

    public IEnumerable<TEntity> Select()
    {
        return this.repository.Select(this.expression, this.orderBy, this.includes);
    }

    public IEnumerable<TResult> Select<TResult>(Expression<Func<TEntity, TResult>> selector)
    {
        return this.repository.Select(this.expression, this.orderBy, this.includes).Select(selector);
    }

    public async Task<IEnumerable<TEntity>> SelectAsync()
    {
        return await this.repository.SelectAsync(this.expression, this.orderBy, this.includes);
    }

    public IQueryable<TEntity> SqlQuery(string query, params object[] parameters)
    {
        return this.repository.SelectQuery(query, parameters).AsQueryable();
    }
}
}
