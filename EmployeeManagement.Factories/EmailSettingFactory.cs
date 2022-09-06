using System;
using System.Collections.Generic;
using System.Text;
using EmployeeManagement.Entities;
using EmployeeManagement.Models.EmailSetting;
using EmployeeManagement.Utilities;

namespace EmployeeManagement.Factories
{
    public class EmailSettingFactory
    {
        public static EmailSetting Create(EmailSettingAddModel model, string userId,string header)
        {
            var data = new EmailSetting
            {
                Email = model.Email,
                password = model.Password,
                Portnumber = model.Portnumber,
                DeletedBy = model.DeletedBy,
              
                CreatedOn = Utility.GetDateTime(),
                CreatedBy = userId ?? "0",
                Description = model.Description,
                SmtpNo = model.SmtpNo,
                CompanyId = Convert.ToInt32(header),
          

            };
            return data;
        }

        public static void Create(EmailSettingEditModel model, EmailSetting entity, string userId,string header)
        {

            entity.Email = model.Email;
            entity.password = model.password;
            entity.Portnumber = model.Portnumber;
            entity.DeletedBy = model.DeletedBy;
            entity.Description = model.Description;
            entity.SmtpNo = model.SmtpNo;
            entity.UpdatedBy = userId ?? "0";
            entity.UpdatedOn = Utility.GetDateTime();
            entity.CompanyId = Convert.ToInt32(header);


        }
    }
}
