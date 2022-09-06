using EmployeeManagement.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Models.User
{
   public class UserStatus
    {
        public int UserId { get; set; }
        public Constants.RecordStatus Status { get; set; }
    }
}
