using EmployeeManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Entities
{
    public class RolePermi
    {
        public int Id { get; set; }
        public int Companyid { get; set; }
        public int PermissionId { get; set; }     
        public int Roleid { get; set; }
        public Permi Permi { get; set; }
        public UserRole Role { get; set; }
    }
}
