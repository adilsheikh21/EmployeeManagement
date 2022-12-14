using EmployeeManagement.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Entities
{
    public class FormBuilderType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public Constants.RecordStatus Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
    }
}
