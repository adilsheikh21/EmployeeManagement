using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Models.RolePermission
{
   public  class AddRolePermission
    {
        public int id { get; set; }
        public  int PermissionId { get; set; }
        public int RoleId { get; set; }
        public bool CanCheck { get; set; }
    }
}
