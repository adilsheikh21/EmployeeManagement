using EmployeeManagement.Entities;
using EmployeeManagement.Models.UserLogin;
using EmployeeManagement.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using EmployeeManagement.Models.Screen;

namespace EmployeeManagement.Factories
{
    public class ScreenFactory
    {
        public static ScreenDetail Create(ScreenAddModel model, string userId, string header)
        {
            var data = new ScreenDetail
            {
                ScreenName=model.ScreenName,
                ScreenCode=model.ScreenCode,
                Status = Constants.RecordStatus.Active,
                CreatedBy = userId ?? "0",
                CreatedOn = Utility.GetDateTime(),
                CompanyId = Convert.ToInt32(header),
                ScreenUrl=model.ScreenUrl,

            };
            return data;
        }
        public static void Create(ScreenEditModel model, ScreenDetail entity, string userId, string header)
        {
            entity.ScreenCode = model.ScreenCode;
            entity.ScreenName = model.ScreenName;
            entity.UpdatedBy = userId ?? "0";
            entity.UpdatedOn = Utility.GetDateTime();
            entity.CompanyId = Convert.ToInt32(header);
            entity.ScreenUrl = model.ScreenUrl;

        }
    }
}
