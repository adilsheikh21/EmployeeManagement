using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Dtos.Permission;
using EmployeeManagement.Models.Permission;

namespace EmployeeManagement.Infrastructure.Managers
{
    public interface IPermissionManager
    {
        Task AddAsync(PermissionAddModel model,string header);
        Task EditAsync(PermissionEditModel model, string header);

        Task<PermissionDto> GetDetailAsync(int id, int header);
        Task<PermissionDto> GetDetailByScreenAsync(int id, int header);

        Task<List<PermissionDto>> GetAllAsync(int header);

        Task DeleteAsync(int id, int header);
    }
}
