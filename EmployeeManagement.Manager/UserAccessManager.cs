using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeManagement.Dtos.RolePermission;
using EmployeeManagement.Dtos.UserAccess;
using EmployeeManagement.Entities;
using EmployeeManagement.Factories;
using EmployeeManagement.Infrastructure.Managers;
using EmployeeManagement.Infrastructure.Repositories;
using EmployeeManagement.Models.RolePermission;
using EmployeeManagement.Models.UserAccess;
using EmployeeManagement.Utilities;
using EmployeeManagement.Infrastructures.DataLayer;

namespace EmployeeManagement.Managers
{
    public class UserAccessManager : IUserAccessMAnager
    {
        private readonly IUserAccessRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        private readonly string _userId;

        public UserAccessManager(IHttpContextAccessor contextAccessor,
          IUserAccessRepository repository,
          IUnitOfWork unitOfWork)
        {
            _userId = contextAccessor.HttpContext.User.GetUserId();

            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task AddUserScreenAccessAsync(ScreenAccessModel model, string header)
        {
            await _repository.DeleteAsyncUserScreenAccess(model.UserRoleId);
            await _unitOfWork.SaveChangesAsync();
            List<UserScreenAccess> item = new List<UserScreenAccess>();
           
            UserScreenAccessFactory.CreateUserScreenAccess(model, item, header);
            await _repository.AddUserScreenAccessAsync(item);
            await _unitOfWork.SaveChangesAsync();
        }

       
        public async Task<List<ScreenAccessDto>> GetUserScreenAccessById(int id, int header)
        {
            List<ScreenAccessDto> data = new List<ScreenAccessDto>();
          data = await _repository.GetAsyncUserScreenAccess(id, header);
            if(data.Count == 0)
            {
               
                ScreenAccessDto obj = new ScreenAccessDto();
                foreach (var item in data)
                {
                    

                    obj.ScreenId = item.Id;
                    obj.UserRoleId = id;
                    obj.CanAccess = false;
                    obj.ScreenName = item.ScreenName;
                    obj.ScreenUrl = item.ScreenUrl;
                    data.Add(obj);
                }
            }

            return data;
        }

        public async Task<List<RolePermissionDto>> GetUserPermissionAccessById(int id, int header)
        {
            List<RolePermissionDto> data = new List<RolePermissionDto>();
            data = await _repository.GetAsyncUserPermissionAccess(id, header);
          

            return data;
        }
        public async Task<List<ScreendetailDto>> GetAllScreenDetail(int header)
        {
            return await _repository.GetAllScreenDetail(header);
        }
    }
}
