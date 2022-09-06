using Microsoft.AspNetCore.Http;
using EmployeeManagement.Dtos.FormBuilderType;
using EmployeeManagement.Factories;
using EmployeeManagement.Infrastructure.Managers;
using EmployeeManagement.Infrastructure.Repositories;
using EmployeeManagement.Models.FormBuilder;
using EmployeeManagement.Utilities;
using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeManagement.Infrastructures.DataLayer;

namespace EmployeeManagement.Managers
{
    public class FormBuilderTypeManager : IFormBuilderTypeManager
    {
        private readonly IFormBuilderTypeRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly string _userId;

        public FormBuilderTypeManager(IFormBuilderTypeRepository repository,IUnitOfWork unitOfWork,
            IHttpContextAccessor contextAccessor)
        {
            _userId = contextAccessor.HttpContext.User.GetUserId();
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task AddAsync(FormBuilderTypeAddModel model)
        {
            await _repository.AddAsync(FormBuilderTypeFactory.Create(model,_userId));
            await _unitOfWork.SaveChangesAsync();
        }
        public async Task<List<FormBuilderTypeDetailDto>> GetAll()
        {
            return await _repository.GetAll();
        }
    }
}
