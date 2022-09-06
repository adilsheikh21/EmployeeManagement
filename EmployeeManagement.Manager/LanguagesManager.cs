using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Dtos.Languages;
using EmployeeManagement.Factories;
using EmployeeManagement.Infrastructure.Managers;
using EmployeeManagement.Infrastructure.Repositories;
using EmployeeManagement.Models.Languages;
using EmployeeManagement.Utilities;
using EmployeeManagement.Infrastructures.DataLayer;

namespace EmployeeManagement.Managers
{
  public  class LanguagesManager : ILanguagesManager
    {
        private readonly ILanguagesRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        private readonly string _userId;

        public LanguagesManager(IHttpContextAccessor contextAccessor,
          ILanguagesRepository repository,
          IUnitOfWork unitOfWork)
        {
            _userId = contextAccessor.HttpContext.User.GetUserId();

            _repository = repository;
            _unitOfWork = unitOfWork;
        }
        public async Task AddAsync(LanguagesAddModel model)
        {
            await _repository.AddAsync(FieldFactory.Create(model, _userId));
            await _unitOfWork.SaveChangesAsync();
        }
        public async Task EditAsync(LanguagesEditModel model)
        {
            var item = await _repository.GetAsync(model.LanguageId);
            FieldFactory.Create(model, item, _userId);
            _repository.Edit(item);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task UpdateAsync(LanguagesUpdateModel model)
        {
            var item = await _repository.GetLanguageAsync(model.UserId);
            FieldFactory.Update(model, item, _userId);
            _repository.Edit(item);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<LanguagesDto> GetDetailAsync(int id)
        {
            return await _repository.GetDetailAsync(id);
        }
        public async Task<List<LanguagesDto>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<JqDataTableResponse<LanguagesDto>> GetPagedResultAsync(JqDataTableRequest model)
        {
            return await _repository.GetPagedResultAsync(model);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
