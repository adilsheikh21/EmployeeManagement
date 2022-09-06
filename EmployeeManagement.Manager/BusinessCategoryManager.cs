using EmployeeManagement.Dtos.Business;
using EmployeeManagement.Factories;
using EmployeeManagement.Infrastructure.Managers;
using EmployeeManagement.Infrastructure.Repositories;
using EmployeeManagement.Infrastructures.DataLayer;
using EmployeeManagement.Models.Business;
using EmployeeManagement.Utilities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Managers
{
    public  class BusinessCategoryManager : IBusinessCategoryManager
    {
        private readonly IBusinessCategoryRepository _repository;
        private readonly string _userId;    
        private readonly IUnitOfWork _unitOfWork;

        public BusinessCategoryManager(IUnitOfWork unitOfWork,IHttpContextAccessor contextAccessor, IBusinessCategoryRepository repository)
        {
            _repository = repository;
            _userId = contextAccessor.HttpContext.User.GetUserId();
            _unitOfWork = unitOfWork;
        }
        public async Task AddAsync(BusinessCategoryAddModel model)
        {
            await _repository.AddAsync(BusinessCategoryFactory.Create(model,_userId));
            await _unitOfWork.SaveChangesAsync();
        }
        public async Task<List<BusinessCategoryDetailDto>> GetAllAsync()
        {
           return  await _repository.GetAll();
        }
        public async Task<BusinessCategoryDetailDto> GetByIdAsync(int id)
        {
            return await _repository.GetById(id);
        }
        public async Task Delete(int id)
        {
            await _repository.DeleteAsync(id);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
