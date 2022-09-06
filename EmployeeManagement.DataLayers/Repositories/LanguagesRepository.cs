using EmployeeManagement.Dtos.UserLogin;
using EmployeeManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Linq.Dynamic.Core;
using EmployeeManagement.Utilities;
using Microsoft.EntityFrameworkCore;
using EmployeeManagement.Infrastructure.Repositories;
using EmployeeManagement.Dtos;
using EmployeeManagement.Dtos.Screen;
using EmployeeManagement.Dtos.Languages;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeManagement.DataLayers.Repositories
{
  public  class LanguagesRepository : ILanguagesRepository
    {
        private readonly DataContext _dataContext;

        public LanguagesRepository(DataContext dataContext,IServiceProvider serviceProvider)
        {
            _dataContext = serviceProvider.CreateScope().ServiceProvider.GetRequiredService<DataContext>();
           // _dataContext = dataContext;
        }
        public async Task AddAsync(Languages entity)
        {
            await _dataContext.Languages.AddAsync(entity);
            await _dataContext.SaveChangesAsync();
        }

        public void Edit(Languages entity)
        {
            _dataContext.Languages.Update(entity);
            _dataContext.SaveChanges();
        }

        public void Edit(User entity)
        {
            _dataContext.User.Update(entity);
            _dataContext.SaveChanges();
        }
        public async Task<Languages> GetAsync(int id)
        {
            return await _dataContext.Languages.FindAsync(id);
        }

        public async Task<User> GetLanguageAsync(int id)
        {
            return await _dataContext.User.FindAsync(id);
        }
        public async Task<LanguagesDto> GetDetailAsync(int id)
        {
            return await(from s in _dataContext.Languages
                          where s.LanguageId == id
                          select new LanguagesDto
                          {
                             LanguageName=s.LanguageName,
                             LanguageOrientation=s.LanguageOrientation,
                              Status = s.Status

                          })
                          .AsNoTracking()
                          .SingleOrDefaultAsync();
        }
        public async Task<List<LanguagesDto>> GetAllAsync()
        {
            return await (from s in _dataContext.Languages
                          
                          select new LanguagesDto
                          {
                              LanguageId = s.LanguageId,
                              LanguageName = s.LanguageName,
                              LanguageOrientation = s.LanguageOrientation,
                              Status = s.Status

                          })
                          .AsNoTracking()
                          .ToListAsync();
        }

        public async Task<JqDataTableResponse<LanguagesDto>> GetPagedResultAsync(JqDataTableRequest model)
        {
            if (model.Length == 0)
            {
                model.Length = Constants.DefaultPageSize;
            }

            var filterKey = model.Search.Value;

            var linqStmt = (from s in _dataContext.Languages
                            where s.Status != Constants.RecordStatus.Deleted && (filterKey == null || EF.Functions.Like(s.LanguageName, "%" + filterKey + "%"))
                            select new LanguagesDto
                            {
                                LanguageName = s.LanguageName,
                                LanguageOrientation = s.LanguageOrientation,
                                Status = s.Status
                            })
                            .AsNoTracking();

            var sortExpresstion = model.GetSortExpression();

            var pagedResult = new JqDataTableResponse<LanguagesDto>
            {
                RecordsTotal = await _dataContext.UsersRoles.CountAsync(x => x.Status != Constants.RecordStatus.Deleted),
                RecordsFiltered = await linqStmt.CountAsync(),
                Data = await linqStmt.OrderBy(sortExpresstion).Skip(model.Start).Take(model.Length).ToListAsync()
            };
            return pagedResult;
        }

        public async Task DeleteAsync(int id)
        {
            var data = await _dataContext.Languages.FindAsync(id);
            data.Status = Constants.RecordStatus.Deleted;
            _dataContext.Languages.Update(data);
            await _dataContext.SaveChangesAsync();
        }
    }
}
