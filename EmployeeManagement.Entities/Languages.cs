using EmployeeManagement.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Entities
{
 public   class Languages
    {
        public int LanguageId { get; set; }
        public string LanguageName { get; set; }
        public string LanguageOrientation { get; set; }

        public Constants.RecordStatus Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }

    }
}
