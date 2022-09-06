using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Infrastructure.Managers
{
    public interface IRecurringJobManager
    {
        Task SetOverdueStatus();
    }
}
