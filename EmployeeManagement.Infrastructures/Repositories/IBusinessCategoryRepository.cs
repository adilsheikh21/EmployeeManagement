using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Dtos.Business;
using EmployeeManagement.Entities;

namespace EmployeeManagement.Infrastructure.Repositories
{
   public  interface IBusinessCategoryRepository
    {
        Task AddAsync(BusinessCategory entity );
        Task<List<BusinessCategoryDetailDto>> GetAll();
        Task<BusinessCategoryDetailDto> GetById(int id);
        Task DeleteAsync(int id);
    }
}
