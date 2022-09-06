using EmployeeManagement.Entities;
using EmployeeManagement.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Entities
{
    public class Permission
    {
        public int Id { get; set; }
        public string Permissions { get; set; }
        public string PermissionDescription { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public Constants.RecordStatus Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
    
        public int ScreenId { get; set; }
        public ScreenDetail Screen { get; set; }

    }
}
