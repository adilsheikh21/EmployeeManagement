using EmployeeManagement.Models.Languages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Models.User;
using EmployeeManagement.Dtos.UserLogin;
using EmployeeManagement.Utilities;
using EmployeeManagement.Models.UserLogin;

namespace EmployeeManagement.Infrastructure.Managers
{
    public interface IUserManager
    {

        Task AddAsync1(AddUserModel model,string header);
        Task AddUser(AddUserModel model);
        int GetLastNextDoorUserId(string email);
        Task AddAsync(AddUserModel model, string header);
        Task LoginAddAsync(UserDetailDto model);
        Task EditAsync(EditUserModel model, string header);
       
        Task EditImgAsync(EditImgModel model, string header);

       
        Task<UserDetailDto> CheckEmail(string Email);


        Task<UserDetailDto> GetDetailAsync(int id, int header);

        Task<JqDataTableResponse<UserDetailDto>> GetPagedResultAsync(JqDataTableRequest model, int header);
        Task DeleteAsync(int id, int header);
        Task<UserDetailDto> CheckUser(string username);
        Task<UserDetailDto> ChecknxtUser(int userid);
        bool UserAllReadyLogin(int userid);
        

        Task<UserDetailDto> Login(UserLoginModel model);
      
        Task LogOut(int id, int header);
        Task<UserDetailDto> isExist(string email);
        Task saveOtp(string email, int otp);
        Task<UserDetailDto> getOtp(string email);

        Task changePassword(string email, string password);
        Task NxtChangePassword(int userid, string Newpassword);
        Task UpdateStatus(UserStatus model, string header);


        Task<List<UserDetailDto>> GetAllAsync(int header);
      
        Task<JqDataTableResponse<UserDetailDto>> OnlineUserPagedResult(JqDataTableRequest model, int header);
        bool CheckPassword(int adminid, string adminPassword);
        Task ChangePasswordAdmin(ChangePasswordModel model);

      
    }

}
