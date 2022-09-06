using System;
using System.Collections.Generic;
using System.Text;
using EmployeeManagement.Entities;
using EmployeeManagement.Models.FormBuilder;
using EmployeeManagement.Utilities;

namespace EmployeeManagement.Factories
{
   public  class FormFactory
    {
        public static Form Create(FormAddModel model,string userId)
        {
            var data = new Form
            {
                UserId = model.UserId,
                UserName = model.UserName == null ? null :model.UserName,
                Description = model.Description == null ? null : model.Description,
                BusinessName = model.BusinessName == null ? null : model.BusinessName,
                BusinessAlias = model.BusinessAlias == null ? null : model.BusinessAlias,
                BusinessCategoryId = model.BusinessCategoryId == null ? null : model.BusinessCategoryId,
                BusinessSubCategoryId = model.BusinessSubCategoryId == null ? null : model.BusinessSubCategoryId,
                Email = model.Email == null ? null : model.Email,
                MobileNo = model.MobileNo == null ? null : model.MobileNo,
                Postalcode = model.PostalCode == null ? null : model.PostalCode,
                Address = model.Address == null ? null : model.Address,
                IsClaim = false,
                //FormData = model.FormData,
                CreatedOn = DateTime.Now,
                CreatedBy = userId ?? "0",
                Status   = Constants.RecordStatus.Active
            };
            return data;
        }

        public static FormField CreateForm(AddFormFieldsModel model,string userId)
        {
            var data = new FormField
            {
                FormId = model.FormId,
                FormFieldType = model.Type,
                FieldName = model.Label==null ? "" : model.Label,
                Multiple = model.Multiple == null ? null : model.Multiple,
                HelpText = model.HelpText == null ? null : model.HelpText,
                Placeholder = model.Placeholder == null ? null : model.Placeholder,
                RequireValidOption = model.RequireValidOption == null ? null : model.RequireValidOption,
                Required = model.Required == null ? null: model.Required,
                Toggle = model.Toggle == null ? null : model.Toggle,
                EnableOther = model.Other == null ? null : model.Other,
                Inline = model.Inline == null ? null : model.Inline,
                Access = model.Access == null ? null : model.Access,
                SubType = model.SubType == null ? null : model.SubType,
                Style = model.Style == null ? null: model.Style,
                className = model.ClassName == null ? null : model.ClassName,
                Name = model.Name == null ? null : model.Name,
                Value = model.Value == null ? null  : model.Value,
                Maxlength = model.MaxLength== null ? null : model.MaxLength,
                Rows = model.Rows == null ? null : model.Rows,
                Status = Constants.RecordStatus.Active,
                CreatedOn = DateTime.Now,
                CreatedBy = userId ?? "0"
            };
            return data;
        }
        public static FormOption CreateOptions(AddFieldOptionsModel model,string userId)
        {
            var data = new FormOption
            {
                FormId = model.FormId,
                FieldId = model.FieldId,
                OptionName= model.Label == null ? null : model.Label,
                Value = model.Value == null ? null : model.Value,
                IsSelected = model.Selected == null ? null  : model.Selected,
                Status = Constants.RecordStatus.Active,
                CreatedOn = DateTime.Now,
                CreatedBy = userId ?? "0"
            };
            return data;
        }

        public static void CreateOtp(int Otp,Form entity,string userId)
        {
                entity.Otp = Otp;
        }
        public static void CreateBusinessClaim( FormCommonFieldValue entity, string userId)
        {
            entity.IsClaim = true;
        }
        public static void CreateClaim(AddClaimRequestModel model, Form entity, string userId)
        {
            entity.ClaimUserId = model.ClaimUserId;
        }
    }
}
