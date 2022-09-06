using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Dtos.RolePermission;
using EmployeeManagement.Entities;
using EmployeeManagement.Models.RolePermission;

namespace EmployeeManagement.Infrastructure.Repositories
{
    public interface IRolePermiRepository
    {
       
        Task AddAsync(RolePermi entity);
        Task DeleteAsync(int id, int header);
        Task DeleteAsync1(int id);

        RolePermissionDto isExist(AddRolePermission id);
    }
}
