using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Dtos.Permission;
using EmployeeManagement.Entities;
using EmployeeManagement.Infrastructure.Repositories;
using System.Linq;
using System.Linq.Dynamic.Core;
using Microsoft.EntityFrameworkCore;
using EmployeeManagement.Utilities;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeManagement.DataLayers.Repositories
{
    public  class PermiRepository:IPermiRepository
    {
        private readonly DataContext _dataContext;

        public PermiRepository(DataContext dataContext, IServiceProvider serviceProvider)
        {
            //_dataContext = dataContext;
            _dataContext = serviceProvider.CreateScope().ServiceProvider.GetRequiredService<DataContext>();

        }

        public async Task AddAsync(Permi entity)
        {
            await _dataContext.Permi.AddAsync(entity);
            await  _dataContext.SaveChangesAsync();
        }
        public void Edit(Permi entity)
        {
            _dataContext.Permi.Update(entity);
            _dataContext.SaveChanges();
        }

        public async Task<Permi> GetAsync(int id, int header)
        {
            return await _dataContext.Permi.FindAsync(id);
        }

        public async Task<PermissionDto> GetDetailAsync(int id, int header)
        {
            return await (from s in _dataContext.Permi
                          where s.Id == id && s.CompanyId == header && s.Status == Constants.RecordStatus.Active
                          select new PermissionDto
                          {
                              Id = s.Id,
                              Permissions = s.Permisions,
                              PermissionDescription = s.Permision_Description,
                              CompanyId = header,
                              Status = s.Status,
                              ScreenId = s.ScrenId

                          })
                          .AsNoTracking()
                          .SingleOrDefaultAsync();
        }

        public async Task<PermissionDto> GetScreenDetailAsync(int id, int header)
        {
            return await (from s in _dataContext.Permi
                          where s.ScrenId == id && s.CompanyId == header && s.Status == Constants.RecordStatus.Active
                          select new PermissionDto
                          {
                              Id = s.Id,
                              Permissions = s.Permisions,
                              PermissionDescription = s.Permision_Description,
                              CompanyId = header,
                              Status = s.Status,
                              ScreenId = s.ScrenId

                          })
                          .AsNoTracking()
                          .FirstOrDefaultAsync();
        }



        public async Task<List<PermissionDto>> GetAllAsync(int header)
        {
            return await (from s in _dataContext.Permi
                          where s.CompanyId == header && s.Status == Constants.RecordStatus.Active
                          select new PermissionDto
                          {
                              Id = s.Id,
                              Permissions = s.Permisions,
                              PermissionDescription = s.Permision_Description,
                              CompanyId = header,
                              Status = s.Status,
                              ScreenId = s.ScrenId

                          })
                          .AsNoTracking()
                          .ToListAsync();
        }

        public async Task DeleteAsync(int id, int header)
        {
            var data = await _dataContext.Permi.FindAsync(id);
            data.Status = Constants.RecordStatus.Deleted;
            _dataContext.Permi.Update(data);
            await _dataContext.SaveChangesAsync();
        }
    }
}
