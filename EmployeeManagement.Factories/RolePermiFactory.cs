using System;
using System.Collections.Generic;
using System.Text;
using EmployeeManagement.Entities;
using EmployeeManagement.Models.RolePermission;

namespace EmployeeManagement.Factories
{
    public  class RolePermiFactory
    {
        public static RolePermi Create(AddRolePermission model, string userId, string header)
        {
            var data = new RolePermi()
            {
                PermissionId = model.PermissionId,
                Roleid = model.RoleId,

                
                Companyid = Convert.ToInt32(header),
               
            };
            return data;
        }

        
    }
}
