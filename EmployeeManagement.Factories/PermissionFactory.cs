using System;
using System.Collections.Generic;
using System.Text;
using EmployeeManagement.Entities;
using EmployeeManagement.Models.Permission;
using EmployeeManagement.Utilities;

namespace EmployeeManagement.Factories
{
     public  class PermissionFactory
    {

        public static Permission Create(PermissionAddModel model, string userId, string header)
        {
            var data = new Permission()
            {
                 Permissions = model.Permissions,
                PermissionDescription= model.PermissionDescription,
                
                ScreenId = model.ScreenId,
                Status = Constants.RecordStatus.Active,
                CreatedBy = userId ?? "0",
                CreatedOn = Utility.GetDateTime(),
                UpdatedBy = userId ?? "0",
                UpdatedOn = Utility.GetDateTime(),
                CompanyId = Convert.ToInt32(header),
               
            };
            return data;
        }


        public static void Create(PermissionEditModel model, Permission entity, string userId, string header)
        {
            entity.Permissions = model.Permissions;
            entity.PermissionDescription = model.PermissionDescription;
            entity.ScreenId = model.ScreenId;
            
            
            entity.UpdatedBy = userId ?? "0";
            entity.UpdatedOn = Utility.GetDateTime();
            
            entity.CompanyId = Convert.ToInt32(header);
            
        }
    }
}
