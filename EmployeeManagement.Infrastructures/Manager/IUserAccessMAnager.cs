using EmployeeManagement.Dtos.UserAccess;
using EmployeeManagement.Models.UserAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Dtos.RolePermission;

namespace EmployeeManagement.Infrastructure.Managers
{
    public interface IUserAccessMAnager
    {
        Task AddUserScreenAccessAsync(ScreenAccessModel model, string header);
        Task<List<ScreenAccessDto>> GetUserScreenAccessById(int id, int header);
        Task<List<RolePermissionDto>> GetUserPermissionAccessById(int id, int header);
        Task<List<ScreendetailDto>> GetAllScreenDetail(int header);
    }
}
