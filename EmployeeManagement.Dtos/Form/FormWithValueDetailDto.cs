using System;
using System.Collections.Generic;
using System.Text;
using EmployeeManagement.Utilities;

namespace EmployeeManagement.Dtos.Form
{
    public class FormWithValueDetailDto
    {
        public int FormCommonFieldId { get; set; }
        public int UserId { get; set; }
        public int FormId { get; set; }
        public string UserName { get; set; }
        public string Description { get; set; }
        public int? BusinessCategoryId { get; set; }
        public int? BusinessSubCategoryId { get; set; }
        public int? MobileNo { get; set; }
        public string BusinessName { get; set; }
        public string BusinessAlias { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Postalcode { get; set; }
        public bool IsClaim { get; set; }
        public int? ClaimUserId { get; set; }
        public Constants.RecordStatus Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public List<FormFieldWithValueDetailDto> FormField { get; set; }
        public List<FormFieldWithValues> FormFieldValue { get; set; }
    }

    public class FormFieldWithValues
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int FormId { get; set; }
        public int FormFieldId { get; set; }
        public int FormCommmonFieldValueId { get; set; }
        public List<FormFieldValues> Fieldvalue { get; set; }

    }
    public class FormFieldWithValueDetailDto
    {
        public int Id { get; set; }
        public int FormId { get; set; }
        public string type { get; set; }
        public string Label { get; set; }
        public bool? Required { get; set; }
        public bool? Toggle { get; set; }
        public bool? Other { get; set; }
        public bool? Inline { get; set; }
        public bool? Access { get; set; }
        public string Style { get; set; }
        public bool? Multiple { get; set; }
        public string Name { get; set; }
        public double? Value { get; set; }
        public double? MaxLength { get; set; }
        public double? Rows { get; set; }
        public string ClassName { get; set; }
        public string Subtype { get; set; }
        public bool? RequireValidOption { get; set; }

        public Constants.RecordStatus Status { get; set; }
        public List<FormFieldValues> Fieldvalue { get; set; }
    }
    public class FormFieldValues
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int FormId { get; set; }
        public int FieldId { get; set; }
        public string Value { get; set; }
    }
}
