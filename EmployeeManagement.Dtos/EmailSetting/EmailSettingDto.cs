using System;
using System.Collections.Generic;
using System.Text;
using EmployeeManagement.Utilities;

namespace EmployeeManagement.Dtos.EmailSetting
{
     public class EmailSettingDto
    {
        public int Id { get; set; }
        public int? CompanyId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Portnumber { get; set; }
        public Constants.RecordStatus Status { get; set; }
        public int DeletedBy { get; set; }
        public string Description { get; set; }
        public string SmtpNo { get; set; }
    }
}
