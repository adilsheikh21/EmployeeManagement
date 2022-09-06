using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Dtos;
using EmployeeManagement.Dtos.Screen;
using EmployeeManagement.Entities;
using EmployeeManagement.Utilities;

namespace EmployeeManagement.Infrastructure.Repositories
{
  public  interface IScreenRepository
    {
        Task AddAsync(ScreenDetail entity);

        void Edit(ScreenDetail entity);
        Task<ScreenDetail> GetAsync(int id, int header);
        Task<ScreenDto> GetDetailAsync(int id, int header);

        Task<List<ScreenDto>> GetAllAsync(int header);

        Task<JqDataTableResponse<ScreenDto>> GetPagedResultAsync(JqDataTableRequest model, int header);

        Task DeleteAsync(int id, int header);


    }
}
