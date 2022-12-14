using System.Threading.Tasks;

namespace EmployeeManagement.Infrastructure.DataLayer
{
    public interface IUnitOfWork
    {
        void BeginTransaction();

        Task BeginTransactionAsync();

        int SaveChanges();

        Task<int> SaveChangesAsync();

        void Commit();

        void Rollback();

        Task<int> ExecuteSqlCommandAsync(string sqlCommand, params object[] parameters);
    }
}
