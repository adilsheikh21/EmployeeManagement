using System;
using System.Collections.Generic;
using System.Text;
using EmployeeManagement.Utilities;

namespace EmployeeManagement.Dtos.Form
{
   public class FormDetailDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Description { get; set; }
        public int? BusinessCategoryId { get; set; }
        public int? BusinessSubCategoryId { get; set; }
        public bool IsClaim { get;set; }
        public int? ClaimUserId { get; set; }
        public int? Otp { get; set; }
        public string BusinessAlias { get; set; }
        public int? MobileNo { get; set; }
        public string BusinessName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Postalcode { get; set; }
        public Constants.RecordStatus Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public List<FieldDetailDto> Fields { get; set; }
      
    }
    public class FieldDetailDto
    {
        public int Id { get; set; }
        public int FormId { get; set; }
        public string Type { get; set; }
       // public int? FormBuilderTypeId { get; set; }
        // public FormBuilderType FormBuilderType { get; set; }
        public string Label { get; set; }
        public string ClassName { get; set; }
       /* public string HelpText { get; set; }
        public string Placeholder { get; set; }*/
        public string Subtype { get; set; }
        public bool? RequireValidOption { get; set;  }
        public bool? Required { get; set; }
        public bool? Toggle { get; set; }
        public bool? Other { get; set; }
        public bool? Multiple { get; set; }
        public bool? Inline { get; set; }
        public bool? Access { get; set; }
        public string Style { get; set; }
        public string Class { get; set; }
        public string Name { get; set; }
        public double? Value { get; set; }
        public Constants.RecordStatus Status { get; set; }

        public List<OptionDetailDto> Values { get; set; }

    }
    public class OptionDetailDto
    {
        public int Id { get; set; }
        public int FormId { get; set; }
        public int FieldId { get; set; }
        public string label { get; set; }
        public string value { get; set; }
        public bool? selected { get; set; }
        public Constants.RecordStatus Status { get; set; }

    }
}
