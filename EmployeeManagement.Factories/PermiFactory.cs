using System;
using System.Collections.Generic;
using System.Text;
using EmployeeManagement.Entities;
using EmployeeManagement.Models.Permission;
using EmployeeManagement.Utilities;

namespace EmployeeManagement.Factories
{
    public class PermiFactory
    {
        public static Permi Create(PermissionAddModel model, string userId, string header)
        {
            var data = new Permi()
            {
                Permisions = model.Permissions,
                Permision_Description = model.PermissionDescription,

                ScrenId = model.ScreenId,
                Status = Constants.RecordStatus.Active,
                CreatedBy = userId ?? "0",
                CreatedOn = Utility.GetDateTime(),
                UpdatedBy = userId ?? "0",
                UpdatedOn = Utility.GetDateTime(),
                CompanyId = Convert.ToInt32(header),
               

            };
            return data;
        }


        public static void Create(PermissionEditModel model, Permi entity, string userId, string header)
        {
            entity.Permisions = model.Permissions;
            entity.Permision_Description = model.PermissionDescription;
            entity.ScrenId = model.ScreenId;


            entity.UpdatedBy = userId ?? "0";
            entity.UpdatedOn = Utility.GetDateTime();

            entity.CompanyId = Convert.ToInt32(header);

        }
    }
}
