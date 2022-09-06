using EmployeeManagement.Dtos.Field;
using EmployeeManagement.Models.Field;
using EmployeeManagement.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Infrastructure.Managers
{
   public interface IFieldManager
    {
        Task AddAsync(FieldsAddModel model);
        Task EditAsync(FieldEditModel model);
        Task<FieldDto> GetDetailAsync(int id);
        Task<List<FieldDetailDto>> GetFieldDetailAsync(int lang_id,int screen_id);
        Task<List<FieldDetailDto>> GetFieldDetailByLanguageAsync(int lang_id);
        Task<List<FieldDto>> GetAllAsync();
       Task<JqDataTableResponse<FieldDto>> GetPagedResultAsync(JqDataTableRequest model);
        Task DeleteAsync(int id);
    }
}
