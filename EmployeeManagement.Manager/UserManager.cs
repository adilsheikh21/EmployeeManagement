using EmployeeManagement.Dtos.UserLogin;
using EmployeeManagement.Factories;
using EmployeeManagement.Infrastructure.Managers;
using EmployeeManagement.Infrastructure.Repositories;
using EmployeeManagement.Models.UserLogin;
using EmployeeManagement.Models.User;
using EmployeeManagement.Models.Languages;
using EmployeeManagement.Utilities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Dtos.User;
using EmployeeManagement.Entities;
using EmployeeManagement.Infrastructures.DataLayer;

namespace EmployeeManagement.Managers
{
    public class UserManager : IUserManager
    {
        private readonly IUserRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        private readonly string _userId;

        public UserManager(IHttpContextAccessor contextAccessor,
          IUserRepository repository,
          IUnitOfWork unitOfWork)
        {
            _userId = contextAccessor.HttpContext.User.GetUserId();

            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task<UserDetailDto> CheckEmail(string Email)
        {
            return await _repository.GetByUserEmailAsync(Email);
        }

        public async Task AddAsync(AddUserModel model, string header)
        {
            await _repository.AddAsync(UserFactory.Create(model, _userId, header));
            await _unitOfWork.SaveChangesAsync();
            
        }
        public  async Task  AddAsync1(AddUserModel model,string header)
        {
            try
            {
              await  _repository.AddAsync1(UserFactory.Create(model, _userId,header));
            await _unitOfWork.SaveChangesAsync();

            }
           catch(Exception ex)
            {
                throw ex;
            }

        }

        public async Task AddUser(AddUserModel model)
        {
            await _repository.AddUser(UserFactory.Create(model,_userId));
        }
        public int GetLastNextDoorUserId(string Email)
        {
            return  _repository.GetLastNextDoorUserId(Email);
        }

        public async Task LoginAddAsync(UserDetailDto model)
        {
            await _repository.LoginAddAsync(UserFactory.Login(model));
            await _unitOfWork.SaveChangesAsync();
        }

     
        public async Task EditAsync(EditUserModel model, string header)
        {
            var item = await _repository.GetAsync(model.Id, Convert.ToInt32(header));
            UserFactory.Create(model, item, _userId, header);
            _repository.Edit(item);
            await _unitOfWork.SaveChangesAsync();
        }

       


        public async Task UpdateStatus(UserStatus model, string header)
        {
            var item = await _repository.GetAsync(model.UserId, Convert.ToInt32(header));
            UserFactory.Create(model, item, _userId, header);
            _repository.Edit(item);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task EditImgAsync(EditImgModel model, string header)
        {
            var item = await _repository.GetAsync(model.Id, Convert.ToInt32(header));
            UserFactory.EditImag(model, item, _userId, header);
            _repository.Edit(item);
            await _unitOfWork.SaveChangesAsync();
        }
        public async Task<UserDetailDto> GetDetailAsync(int id, int header)
        {
            return await _repository.GetDetailAsync(id, header);
        }


        public async Task<JqDataTableResponse<UserDetailDto>> GetPagedResultAsync(JqDataTableRequest model, int header)
        {
            return await _repository.GetPagedResultAsync(model, header);
        }

        public async Task DeleteAsync(int id, int header)
        {
            await _repository.DeleteAsync(id, header);
            await _unitOfWork.SaveChangesAsync();
        }
        public bool UserAllReadyLogin(int userid)
        {
            return _repository.GetByUserAllradyAsync(userid);
        }

      
        public async Task<UserDetailDto> CheckUser(string username)
        {
            return await _repository.GetByUserAsync(username);
        }
        public async Task<UserDetailDto> ChecknxtUser(int userid)
        {
            return await _repository.GetBynxtUserAsync(userid);
        }
        public async Task<UserDetailDto> Login(UserLoginModel model)
        {
            return await _repository.Login(model);
        }


        public async Task LogOut(int id, int header)
        {
            await _repository.LogOut(id, header);
           
        }

        public async Task saveOtp(string email, int otp)
        {
            await _repository.saveOtp(email, otp);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task changePassword(string email, string password)
        {
            await _repository.changePassword(email, password);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task NxtChangePassword(int userid, string Newpassword)
        {
            await _repository.NxtchangePassword(userid, Newpassword);
            await _unitOfWork.SaveChangesAsync();
        }
        public async Task<UserDetailDto> isExist(string email)
        {
            try
            {
                return await _repository.isExist(email);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<UserDetailDto> getOtp(string email)
        {
            return await _repository.getOtp(email);
        }
        public async Task<JqDataTableResponse<UserDetailDto>> OnlineUserPagedResult(JqDataTableRequest model, int header)
        {
            return await _repository.OnlineUserPagedResult(model, header);
        }

        


        public async Task<List<UserDetailDto>> GetAllAsync(int header)
        {
            return await _repository.GetAllAsync(header);
        }

        public bool CheckPassword(int adminid, string adminPassword)
        {
            return _repository.CheckPasswordAsync(adminid, adminPassword);
        }
        public async Task ChangePasswordAdmin(ChangePasswordModel model)
        {
            await _repository.ChangePasswordAdmin(model);
            await _unitOfWork.SaveChangesAsync();
        }

    
    }
}