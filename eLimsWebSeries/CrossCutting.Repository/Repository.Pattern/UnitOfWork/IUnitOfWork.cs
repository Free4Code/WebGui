namespace Repository.Pattern.UnitOfWork
{
    using System;
    using System.Data;

    using global::Repository.Pattern.Infrastructure;
    using global::Repository.Pattern.Repositories;

    public interface IUnitOfWork : IDisposable
    {
        int SaveChanges();

        void Dispose(bool disposing);

        IRepository<TEntity> Repository<TEntity>() 
            where TEntity : class, IObjectState;

        void BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.Unspecified);

        bool Commit();

        void Rollback();

        dynamic GetCustomRepository<T>();

        dynamic GetCustomRepository(Type type);
    }
}