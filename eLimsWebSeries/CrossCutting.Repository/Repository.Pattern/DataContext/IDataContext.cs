namespace Repository.Pattern.DataContext
{
    using System;

    using global::Repository.Pattern.Infrastructure;

    public interface IDataContext : IDisposable
    {
        int SaveChanges();

        void SyncObjectState<TEntity>(TEntity entity) where TEntity : class, IObjectState;

        void SyncObjectsStatePostCommit();
    }
}