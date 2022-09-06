using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Dtos.RolePermission;
using EmployeeManagement.Entities;
using EmployeeManagement.Factories;
using EmployeeManagement.Infrastructure.Managers;
using EmployeeManagement.Infrastructure.Repositories;
using EmployeeManagement.Models.RolePermission;
using EmployeeManagement.Utilities;
using EmployeeManagement.Infrastructures.DataLayer;

namespace EmployeeManagement.Managers
{
    public class RolePermiManager:IRolePermiManager
    {
        private readonly IRolePermiRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        private readonly string _userId;

        public RolePermiManager(IHttpContextAccessor contextAccessor,IServiceProvider serviceProvider,
          IRolePermiRepository repository,
          IUnitOfWork unitOfWork)
        {
            _userId = contextAccessor.HttpContext.User.GetUserId();

            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task AddAsync(AddRolePermission model, string header)
        {
            await _repository.AddAsync(RolePermiFactory.Create(model, _userId, header));
            await _unitOfWork.SaveChangesAsync();
        }

       

        public async Task DeleteAsync(int id, int header)
        {
            await _repository.DeleteAsync(id, header);
            await _unitOfWork.SaveChangesAsync();
        }
        public async Task DeleteAsync2(int id)
        {
            await _repository.DeleteAsync1(id);
            await _unitOfWork.SaveChangesAsync();
        }

        public  RolePermissionDto isExist(AddRolePermission id)
        {
            try
            {
                return  _repository.isExist(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
