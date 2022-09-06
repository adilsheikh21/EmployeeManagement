using EmployeeManagement.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Entities
{
    public class FormFieldValue
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int FormId { get; set; }
        public int FormFieldId { get; set; }
        public int FormCommonFieldValueId { get; set; }
        public string Value { get; set; }
       
        public Constants.RecordStatus Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
    }
}
