using System.Threading.Tasks;

namespace EmployeeManagement.Infrastructure.Managers
{
    public interface ISeedManager
    {
        Task InitializeAsync();
    }
}
