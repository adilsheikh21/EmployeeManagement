using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Models.FormBuilder
{
    public class ClaimBusinessModel
    {
        public int ClaimUserId { get; set; }
        public int Otp { get; set; }
        public int FormCommonFieldId { get; set; }
    }
}
