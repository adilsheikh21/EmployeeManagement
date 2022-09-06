using EmployeeManagement.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Entities
{
    public class LoginModule
    {
        public int Id { get; set; }
        public int UserId { get; set; } 
        public DateTime? createdOn { get; set; }
        public bool? Status1 { get; set; }
        public Constants.RecordStatus Status { get; set; }
        public int? RoleId { get; set; }
        public User user { get; set; }
        public int? CompanyId { get; set; }
       
        public DateTime? LastLogin { get; set; }
        public string IpAddress { get; set; }
        public string BrowserAgent { get; set; }


    }
}
