using EmployeeManagement.Dtos.UserLogin;
using EmployeeManagement.Entities;
using EmployeeManagement.Models.UserLogin;
using EmployeeManagement.Models.User;
using EmployeeManagement.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Dtos.User;

namespace EmployeeManagement.Infrastructure.Repositories
{
    public interface IUserRepository
    {


        Task AddAsync1(User entity);
        Task AddUser(User entity);
        int GetLastNextDoorUserId(string email);
        Task AddAsync(User entity);
        Task LoginAddAsync(LoginModule entity);
        void Edit(User entity);

        Task<User> GetAsync(int id, int header);
        Task<User> GetNextDoorUserAsync(int userid);

        Task<UserDetailDto> GetByUserEmailAsync(string username);

        Task<UserDetailDto> GetDetailAsync(int id, int header);
       
        Task<JqDataTableResponse<UserDetailDto>> GetPagedResultAsync(JqDataTableRequest model, int header);

        Task DeleteAsync(int id, int header);

        Task<UserDetailDto> GetByUserAsync(string username);
        Task<UserDetailDto> GetBynxtUserAsync(int userid);

        bool GetByUserAllradyAsync(int userid);

      


        Task<UserDetailDto> Login(UserLoginModel model);
        Task<UserDetailDto> isExist(string email);
        Task LogOut(int id, int header);
        Task saveOtp(string email, int otp);
        Task<UserDetailDto> getOtp(string email);

        Task changePassword(string email, string password);
        Task NxtchangePassword(int userid, string Newpassword);
        

      
        Task<List<UserDetailDto>> GetAllAsync(int header);
        
        Task<JqDataTableResponse<UserDetailDto>> OnlineUserPagedResult(JqDataTableRequest model, int header);
       
        bool CheckPasswordAsync(int adminid, string adminPassword);
        Task ChangePasswordAdmin(ChangePasswordModel model);
    }
}
