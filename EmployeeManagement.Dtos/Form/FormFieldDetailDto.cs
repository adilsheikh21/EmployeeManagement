using System;
using System.Collections.Generic;
using System.Text;
using EmployeeManagement.Utilities;

namespace EmployeeManagement.Dtos.Form
{
    public class FormFieldDetailDto
    {
        public int Id { get; set; }
        public int FormId { get; set; }
        public string Type { get; set; }
        public string Label { get; set; }
        public bool? Required { get; set; }
        public bool? Toggle { get; set; }
        public bool? Other { get; set; }
        public bool? Inline { get; set; }
        public bool? Access { get; set; }
        public string SubType { get; set; }
        public string Style { get; set; }
        public string ClassName { get; set; }
        public string Name { get; set; }
        public double? Value { get; set; }
        public double? Maxlength { get; set; }
        public double? Rows { get; set; }
        public Constants.RecordStatus Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
    }
}
