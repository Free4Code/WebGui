namespace Repository.Pattern.UnitOfWork
{
    using System.Threading;
    using System.Threading.Tasks;

    using global::Repository.Pattern.Infrastructure;

    using Repository.Pattern.Repositories;

    public interface IUnitOfWorkAsync : IUnitOfWork
    {
        Task<int> SaveChangesAsync();

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

        IRepositoryAsync<TEntity> RepositoryAsync<TEntity>()
            where TEntity : class, IObjectState;
    }
}