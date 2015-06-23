namespace Repository.Pattern.DataContext
{
    using System.Threading;
    using System.Threading.Tasks;

    public interface IDataContextAsync : IDataContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

        Task<int> SaveChangesAsync();
    }
}