using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Models.FormBuilder
{
    public class FormAddModel
    {
        public int Id { get; set; }
        public int UserId{get;set; }
        public string UserName { get; set; }
        public string Description { get; set; }
        public int? BusinessCategoryId{get;set;}
        public int? BusinessSubCategoryId{get;set; }
        public string BusinessName { get; set; }
        public string BusinessAlias { get; set; }
        public string Email { get; set; }
        public int? MobileNo { get; set; }
        public string PostalCode { get; set; }
        public string Address { get; set; }
        public bool IsClaim { get;set; }


        public List<AddFormFieldsModel> Form { get; set; }
    }

    public class AddFormFieldsModel
    {
        public int Id { get; set; }
        public int FormId { get; set; }
        public string Type { get; set; }
        public string Label { get; set; }
        public string HelpText { get; set; }
        public string Placeholder { get; set; }
        public bool? RequireValidOption { get; set;  }
     
        public bool? Required { get; set; }
        public bool? Toggle { get; set; }
        public bool? Other { get; set; }
        public bool? Inline { get; set; }
        public bool? Multiple { get; set; }
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
    public class AddFieldOptionsModel
    {
        public int Id { get; set; }
        public int FormId { get; set; }
        public int FieldId { get; set; }
        public string Label { get; set; }
        public string Value { get; set; }
        public bool? Selected { get; set; }
    }
}
