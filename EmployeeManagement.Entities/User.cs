using System;
using System.Collections.Generic;
using System.Text;
using EmployeeManagement.Entities;
using EmployeeManagement.Utilities;

namespace EmployeeManagement.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
       

        public string Mobile { get; set; }
        public int RoleId { get; set; }
        public UserRole Role { get; set; }
        public Constants.RecordStatus Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public DateTime? LastLogin { get; set; }

        public string UpdatedBy { get; set; }
        public int AppId { get; set; }
        public int FinanceYear { get; set; }
        public string IpAddress { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public string Postalcode { get; set; }


        public int otp { get; set;}
        public string image { get; set; }

        public int? LangId { get; set; }
        public Languages Language { get; set; }


    }
}
