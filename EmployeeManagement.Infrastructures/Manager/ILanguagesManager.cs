using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Dtos.Languages;
using EmployeeManagement.Models.Languages;
using EmployeeManagement.Utilities;

namespace EmployeeManagement.Infrastructure.Managers
{
  public  interface ILanguagesManager
    {
        Task AddAsync(LanguagesAddModel model);
        Task EditAsync(LanguagesEditModel model);

        Task UpdateAsync(LanguagesUpdateModel model);

        Task<LanguagesDto> GetDetailAsync(int id);

        Task<List<LanguagesDto>> GetAllAsync();

        Task<JqDataTableResponse<LanguagesDto>> GetPagedResultAsync(JqDataTableRequest model);
        Task DeleteAsync(int id);

    }
}
