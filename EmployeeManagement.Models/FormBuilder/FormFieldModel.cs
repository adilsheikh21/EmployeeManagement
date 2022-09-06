using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Models.FormBuilder
{
    public  class FormFieldModel
    {
       
            public int Id { get; set; }
            public int FormId { get; set; }
            public string Type { get; set; }
            public string Label { get; set; }
            public bool? RequireValidOption { get; set; }

            public bool? Required { get; set; }
            public bool? Toggle { get; set; }
            public bool? Other { get; set; }
            public bool? Inline { get; set; }
            public string SubType { get; set; }
            public string Style { get; set; }
            public string ClassName { get; set; }
            public string Name { get; set; }
            public double? Value { get; set; }
            public double? MaxLength { get; set; }
            public double? Rows { get; set; }
            public bool? Access { get; set; }
            public List<AddFieldOptionsModel> Values { get; set; }
        
    }
}
