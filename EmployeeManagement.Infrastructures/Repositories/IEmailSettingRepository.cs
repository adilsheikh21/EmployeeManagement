using EmployeeManagement.Dtos.EmailSetting;
using EmployeeManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace EmployeeManagement.Infrastructure.Repositories
{
    public interface IEmailSettingRepository
    {
        Task AddAsync1(EmailSetting entity);

        Task<EmailSetting> GetAsync(int id,int header);
        Task<EmailSetting> GetAsync1(int id);
        void Edit(EmailSetting entity);

        Task<EmailSettingDto> GetDetailAsync(int id,int header);
        Task<List<EmailSettingDto>> GetAllAsync(int header);

        Task DeleteAsync(int id,int header);

    }
}
