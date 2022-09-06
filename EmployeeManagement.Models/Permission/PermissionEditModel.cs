using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Models.Permission
{
    public class PermissionEditModel
    {
        public int Id { get; set; }
        public string Permissions { get; set; }
        public string PermissionDescription { get; set; }
        public int ScreenId { get; set; }

    }
}
