using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Models.EmailSetting
{
     public class EmailSettingAddModel
    {
       
        public string Email { get; set; }
        public string Password { get; set; }
        public int Portnumber { get; set; }
        public string Description { get; set; }
        public int DeletedBy { get; set; }
        public string SmtpNo { get; set; }
    }
}
