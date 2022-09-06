using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Dtos.Field
{
     public class FieldDetailDto
    {
        public int LanguageId { get; set; }
        public int ScreenId { get; set; }
        public string Field { get; set; }
        public string Description { get; set; }
        
    }
}
