using EmployeeManagement.Dtos;
using EmployeeManagement.Entities;
using EmployeeManagement.Infrastructure.Repositories;
using EmployeeManagement.Utilities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.DataLayers.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly DataContext _dataContext;

        public CompanyRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<IEnumerable<SelectListItemDto>> GetCompanyAsync()
        {
            return await _dataContext.Company
                .AsNoTracking()
                .Where(x => x.CompanyId != null)
                .OrderBy(x => x.CompanyName)
                .Select(x => new SelectListItemDto
                {
                    KeyInt = x.CompanyId,
                    Value = x.CompanyName
                }).ToListAsync();
        }
    }
}
