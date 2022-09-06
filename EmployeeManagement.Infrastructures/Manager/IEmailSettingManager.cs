using EmployeeManagement.Dtos.EmailSetting;
using EmployeeManagement.Models.EmailSetting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace EmployeeManagement.Infrastructure.Managers
{
     public interface IEmailSettingManager
    {
        Task AddAsync(EmailSettingAddModel model, string header);

        Task EditAsync(EmailSettingEditModel model,string header);
        Task<EmailSettingDto> GetDetailAsync(int id,int header);

        Task<List<EmailSettingDto>> GetAllAsync(int header);

        Task DeleteAsync(int id,int header);
    }
}
