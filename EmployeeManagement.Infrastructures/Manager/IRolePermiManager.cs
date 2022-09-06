using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Dtos.RolePermission;
using EmployeeManagement.Models.RolePermission;

namespace EmployeeManagement.Infrastructure.Managers
{
   public interface IRolePermiManager
    {
       
            Task AddAsync(AddRolePermission model, string header);
            Task DeleteAsync(int id, int header);
            Task DeleteAsync2(int id);
            RolePermissionDto isExist(AddRolePermission id);
        
    }
}
