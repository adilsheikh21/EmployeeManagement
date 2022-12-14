using EmployeeManagement.Utilities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.DataLayers
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? LastLogOn { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Role { get; set; }
        public Constants.RecordStatus Status { get; set; }
    }
}
