using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Models.UserLogin
{
    public class CheckPasswordModel
    {
        public int UserId { get; set; }
        public string OldPassword { get; set; }
    }
}
