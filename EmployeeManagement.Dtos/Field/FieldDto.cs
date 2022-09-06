using System;
using System.Collections.Generic;
using System.Text;
using EmployeeManagement.Utilities;

namespace EmployeeManagement.Dtos.Field
{
    public class FieldDto
    {
        public int? lang_id { get; set; }
        public int screen_id { get; set; }
        public string field { get; set; }
        public string description { get; set; }
        public Constants.RecordStatus Status { get; set; }
    }
}
