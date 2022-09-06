using EmployeeManagement.Entities;
using EmployeeManagement.Models.UserLogin;
using EmployeeManagement.Models.User;
using EmployeeManagement.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using EmployeeManagement.Dtos.UserLogin;

namespace EmployeeManagement.Factories
{
    public class UserFactory
    {
        public static User Create(AddUserModel model, string userId, string header)
        {
            var data = new User
            {
                UserFirstName = model.FirstName,
                UserLastName = model.LastName,
                UserName = model.UserName,
                Email = model.Email,
                AppId = model.AppId,
                FinanceYear = model.FinanceYear,
               
                IpAddress = model.IpAddress,
                Password = Utility.Encrypt(model.Password),
                Mobile = model.Mobile,
                RoleId = model.RoleId,


                Status = Constants.RecordStatus.Active,
                CreatedBy = userId ?? "0",
                CreatedOn = Utility.GetDateTime(),
                Postalcode = model.PostalCode,
                CompanyId = 1,
                LangId = 1,

            };
            return data;
        }

        public static User Create(AddUserModel model, string userId)
        {
            var data = new User
            {
                UserFirstName = model.FirstName,
                UserLastName = model.LastName,
                UserName = model.UserName,
                Email = model.Email,
                AppId = model.AppId,
                FinanceYear = model.FinanceYear,
                
                IpAddress = model.IpAddress,
                Password = Utility.Encrypt(model.Password),
                Mobile = model.Mobile,
                RoleId = model.RoleId,

                Status = Constants.RecordStatus.Active,
                CreatedBy = userId ?? "0",
                CreatedOn = Utility.GetDateTime(),
                CompanyId = 1,
                LangId = 1,

            };
            return data;
        }
        public static void Create(EditUserModel model, User entity, string userId, string header)
        {
            entity.UserFirstName = model.FirstName;
            entity.UserLastName = model.LastName;
            entity.UserName = model.UserName;
            entity.Email = model.Email;
            entity.RoleId = model.RoleId;
           
            entity.Mobile = model.Mobile;
            entity.UpdatedBy = userId ?? "0";
            entity.UpdatedOn = Utility.GetDateTime();
            entity.IpAddress = model.IpAddress;
            entity.FinanceYear = model.FinanceYear;
            entity.AppId = model.AppId;
            entity.CompanyId = Convert.ToInt32(header);
            entity.image = model.ImageUrl;
        }
        public static void Create(UserStatus model, User entity, string userId, string header)
        {

            entity.UpdatedBy = userId ?? "0";
            entity.UpdatedOn = Utility.GetDateTime();
            entity.Status = model.Status;
            entity.CompanyId = Convert.ToInt32(header);


        }
        public static void EditImag(EditImgModel model, User entity, string userId, string header)
        {

            
            entity.UpdatedBy = userId ?? "0";
            entity.UpdatedOn = Utility.GetDateTime();
            entity.image = model.ImageUrl;
            entity.CompanyId = Convert.ToInt32(header);

        }
            public static LoginModule Login(UserDetailDto model)
        {
            
            var data = new LoginModule
            {
                

                UserId = model.Id,
                Status1 = true,
                createdOn = Utility.GetDateTime(),
                RoleId = model.RoleId,
                CompanyId = model.CompanyId,
                IpAddress = model.Ip_Address,
                BrowserAgent = model.BrowserAgent,
                
            };

            return data;
        }
    }
}
