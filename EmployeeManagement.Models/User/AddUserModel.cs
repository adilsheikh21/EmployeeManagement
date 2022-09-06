using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Models.User
{
   public class AddUserModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Mobile { get; set; }
        public int RoleId { get; set; }
        public int AppId { get; set; }
        public int FinanceYear { get; set; }
        public string IpAddress { get; set; }
        public string PostalCode { get; set; }

    }
}
