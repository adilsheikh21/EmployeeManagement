using EmployeeManagement.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Infrastructure.Repositories
{
    public interface ICompanyRepository
    {
        Task<IEnumerable<SelectListItemDto>> GetCompanyAsync();

    }
}
