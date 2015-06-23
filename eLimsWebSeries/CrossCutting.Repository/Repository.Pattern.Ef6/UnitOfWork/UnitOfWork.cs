namespace Repository.Pattern.Ef6
{
    using System;
    using System.Data;
    using System.Data.Common;
    using System.Data.Entity.Core.Objects;
    using System.Data.Entity.Infrastructure;
    using System.Threading;
    using System.Threading.Tasks;

    using Repository.Pattern.DataContext;
    using Repository.Pattern.Ef6.Factories;
    using Repository.Pattern.Infrastructure;
    using Repository.Pattern.Repositories;
    using Repository.Pattern.UnitOfWork;

    public class UnitOfWork : IUnitOfWorkAsync
    {
        #region Private Fields

        private IDataContextAsync dataContext;

        private bool disposed;

        private ObjectContext objectContext;

        private DbTransaction transaction;

        #endregion Private Fields

        #region Constuctor/Dispose

        public UnitOfWork(IDataContextAsync dataContext, IRepositoryProvider repositoryProvider)
        {
            this.RepositoryProvider = repositoryProvider;
            this.RepositoryProvider.DataContext = this.dataContext = dataContext;
            this.RepositoryProvider.UnitOfWork = this;
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (this.disposed)
            {
                return;
            }

            if (disposing)
            {
                // free other managed objects that implement
                // IDisposable only
                try
                {
                    if (this.objectContext != null && this.objectContext.Connection.State == ConnectionState.Open)
                    {
                        this.objectContext.Connection.Close();
                    }
                }
                catch (ObjectDisposedException)
                {
                    // do nothing, the objectContext has already been disposed
                }

                if (this.dataContext != null)
                {
                    this.dataContext.Dispose();
                    this.dataContext = null;
                }
            }

            // release any unmanaged objects
            // set the object references to null
            this.disposed = true;
        }

        #endregion Constuctor/Dispose

        protected IRepositoryProvider RepositoryProvider { get; set; }

        public int SaveChanges()
        {
            return this.dataContext.SaveChanges();
        }


        public IRepository<TEntity> Repository<TEntity>()
            where TEntity : class, IObjectState
        {
            return this.RepositoryAsync<TEntity>();
        }

        public Task<int> SaveChangesAsync()
        {
            return this.dataContext.SaveChangesAsync();
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return this.dataContext.SaveChangesAsync(cancellationToken);
        }

        public IRepositoryAsync<TEntity> RepositoryAsync<TEntity>()
            where TEntity : class, IObjectState
        {
            return this.RepositoryProvider.GetRepositoryForEntityType<TEntity>();
        }

        public dynamic GetCustomRepository(Type type)
        {
            return this.RepositoryProvider.GetCustomRepository(type);
        }

        public dynamic GetCustomRepository<T>()
        {
            return this.RepositoryProvider.GetCustomRepository<T>();
        }

        #region Unit of Work Transactions

        //IF 04/09/2014 Add IsolationLevel
        public void BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.Unspecified)
        {
            this.objectContext = ((IObjectContextAdapter)this.dataContext).ObjectContext;
            if (this.objectContext.Connection.State != ConnectionState.Open)
            {
                this.objectContext.Connection.Open();
            }

            this.transaction = this.objectContext.Connection.BeginTransaction(isolationLevel);
        }

        public bool Commit()
        {
            this.transaction.Commit();
            return true;
        }

        public void Rollback()
        {
            this.transaction.Rollback();
            this.dataContext.SyncObjectsStatePostCommit();
        }

        #endregion

        // Uncomment, if rather have IRepositoryAsync<TEntity> IoC vs. Reflection Activation
        //public IRepositoryAsync<TEntity> RepositoryAsync<TEntity>() where TEntity : EntityBase
        //{
        //    return ServiceLocator.Current.GetInstance<IRepositoryAsync<TEntity>>();
        //}
    }
}
