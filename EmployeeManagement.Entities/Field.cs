using EmployeeManagement.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Entities
{
    public class Field
    {
        public int Id { get; set; }
      
        public string field { get; set; }
        public string description { get; set; }
        public int ScreenId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public Constants.RecordStatus Status { get; set; }

        public int LanguageId { get; set; }
        public Languages Language { get; set; }


    }
}
