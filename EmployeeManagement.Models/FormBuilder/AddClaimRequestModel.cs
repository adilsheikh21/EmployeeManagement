using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Models.FormBuilder
{
    public class AddClaimRequestModel
    {
        public int FormCommonFieldId { get; set; }
        public string Email { get; set;  }
        public int ClaimUserId { get; set; }
    }
}
