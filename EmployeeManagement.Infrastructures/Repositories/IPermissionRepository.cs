using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Dtos.Permission;
using EmployeeManagement.Entities;

namespace EmployeeManagement.Infrastructure.Repositories
{
    public interface IPermissionRepository
    {
        Task AddAsync(Permission entity);
        void Edit(Permission entity);
        Task<Permission> GetAsync(int id, int header);


        
        Task<PermissionDto> GetDetailAsync(int id, int header);
        Task<PermissionDto> GetScreenDetailAsync(int id, int header);
        Task<List<PermissionDto>> GetAllAsync(int header);

        Task DeleteAsync(int id, int header);

    }
}
