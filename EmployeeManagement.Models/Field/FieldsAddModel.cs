using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Models.Field
{
    public class FieldsAddModel
    {
        public int LanguageId { get; set; }
        public int ScreenId { get; set; }
        public string Field { get; set; }
        public string Description { get; set; }
    }
}
