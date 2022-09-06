using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Models.FormBuilder
{
    public  class FormFieldValueAddModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
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

        public int FormId { get; set; }
        public List<FormValue> FormValue { get; set; }
    }
    public class FormValue
    {
        public int UserId { get; set; }
        public int FormId { get; set; }
        public int FormCommonFieldValueId { get; set; }
        public int FormFieldId { get; set; }
        public string Value { get; set; }
    }
}
