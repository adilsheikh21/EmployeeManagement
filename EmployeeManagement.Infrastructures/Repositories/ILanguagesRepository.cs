using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Dtos.Languages;
using EmployeeManagement.Entities;
using EmployeeManagement.Utilities;

namespace EmployeeManagement.Infrastructure.Repositories
{
   public interface ILanguagesRepository
    {
        Task AddAsync(Languages entity);

        void Edit(Languages entity);

        void Edit(User entity); //for update user language

        Task<Languages> GetAsync(int id);
        Task<User> GetLanguageAsync(int user_id);

        Task<LanguagesDto> GetDetailAsync(int id);

        Task<List<LanguagesDto>> GetAllAsync();

        Task<JqDataTableResponse<LanguagesDto>> GetPagedResultAsync(JqDataTableRequest model);

        Task DeleteAsync(int id);

    }
}
