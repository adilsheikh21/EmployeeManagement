using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Dtos.Business;
using EmployeeManagement.Entities;

namespace EmployeeManagement.Infrastructure.Repositories
{
    public interface IBusinessSubCategoryRepository
    {
        Task AddAsync(BusinessSubCategory entity);
        Task<List<BusinessSubCategoryDetailDto>> GetAll();
        Task<BusinessSubCategoryDetailDto> GetById(int id);
        Task DeleteAsync(int id);
    }
}
