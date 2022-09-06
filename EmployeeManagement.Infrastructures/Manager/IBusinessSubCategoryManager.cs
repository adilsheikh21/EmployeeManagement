using EmployeeManagement.Dtos.Business;
using EmployeeManagement.Models.Business;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Infrastructure.Managers
{
    public interface IBusinessSubCategoryManager
    {
        Task AddAsync(BusinessSubCategoryAddModel model);
        Task<List<BusinessSubCategoryDetailDto>> GetAllAsync();
        Task<BusinessSubCategoryDetailDto> GetByIdAsync(int id);
        Task Delete(int id);
    }
}
