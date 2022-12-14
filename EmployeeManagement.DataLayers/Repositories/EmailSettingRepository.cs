using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Dtos.EmailSetting;
using EmployeeManagement.Entities;
using EmployeeManagement.Infrastructure.Repositories;
using System.Linq;
using System.Linq.Dynamic.Core;
using EmployeeManagement.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeManagement.DataLayers.Repositories
{
   public  class EmailSettingRepository: IEmailSettingRepository
    {
        private readonly DataContext _dataContext;

        public EmailSettingRepository(DataContext dataContext,IServiceProvider serviceProvider)
        {
            _dataContext = serviceProvider.CreateScope().ServiceProvider.GetRequiredService<DataContext>();
            //  _dataContext = dataContext;
        }

        public async Task AddAsync1(EmailSetting entity)
        {
            await _dataContext.EmailSetting.AddAsync(entity);
            await _dataContext.SaveChangesAsync();
        }

        public async Task<EmailSetting> GetAsync1(int id)
        {
            return await _dataContext.EmailSetting.Where(x=>x.CompanyId==id).FirstOrDefaultAsync();
        }

        public async Task<EmailSetting> GetAsync(int id,int header)
        {
            return await _dataContext.EmailSetting.FindAsync(id);
        }
        public void Edit(EmailSetting entity)
        {
            _dataContext.EmailSetting.Update(entity);
            _dataContext.SaveChanges();
        }


        public async Task<EmailSettingDto> GetDetailAsync(int id,int header)
        {
            return await (from s in _dataContext.EmailSetting
                          where  s.CompanyId == header
                          select new EmailSettingDto
                          {
                              Id = s.Id,
                              Email = s.Email,
                              Password = s.password,
                              Portnumber = s.Portnumber,
                              DeletedBy = s.DeletedBy,
                              Description = s.Description,
                              SmtpNo = s.SmtpNo,
                              CompanyId = s.CompanyId,
                          

                          })
                          .AsNoTracking()
                          .SingleOrDefaultAsync();
        }

        public async Task<List<EmailSettingDto>> GetAllAsync(int header)
        {
            return await (from s in _dataContext.EmailSetting
                          where  s.CompanyId == header

                          select new EmailSettingDto
                          {
                              Id = s.Id,
                              Email = s.Email,
                              Password = s.password,
                              Portnumber = s.Portnumber,
                              DeletedBy = s.DeletedBy,
                              Description = s.Description,
                              SmtpNo = s.SmtpNo,
                              CompanyId = s.CompanyId,
                             

                          })
                          .AsNoTracking()
                          .ToListAsync();
        }

        public async Task DeleteAsync(int id,int header)
        {
            var data = await _dataContext.EmailSetting.FindAsync(id);
            _dataContext.EmailSetting.Update(data);
            _dataContext.EmailSetting.Remove(data);
            await _dataContext.SaveChangesAsync();
        }
    }
}
