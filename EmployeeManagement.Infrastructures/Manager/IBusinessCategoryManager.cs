using EmployeeManagement.Dtos.Business;
using EmployeeManagement.Models.Business;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace EmployeeManagement.Infrastructure.Managers
{
    public interface IBusinessCategoryManager
    {
        Task AddAsync(BusinessCategoryAddModel model);
        Task<List<BusinessCategoryDetailDto>> GetAllAsync();
        Task<BusinessCategoryDetailDto> GetByIdAsync(int id);
        Task Delete(int id);
    }
}
