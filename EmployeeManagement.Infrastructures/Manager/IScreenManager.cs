using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Dtos;
using EmployeeManagement.Dtos.Screen;
using EmployeeManagement.Models.Screen;
using EmployeeManagement.Utilities;

namespace EmployeeManagement.Infrastructure.Managers
{
   public interface I1ScreenManager
    {
        Task AddAsync(ScreenAddModel model, string header);
        Task EditAsync(ScreenEditModel model, string header);
        Task<ScreenDto> GetDetailAsync(int id, int header);
        Task<List<ScreenDto>> GetAllAsync(int header);

        Task<JqDataTableResponse<ScreenDto>> GetPagedResultAsync(JqDataTableRequest model, int header);
        Task DeleteAsync(int id, int header);




    }
}
