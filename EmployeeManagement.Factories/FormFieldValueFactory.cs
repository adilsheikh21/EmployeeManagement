using System;
using System.Collections.Generic;
using System.Text;
using EmployeeManagement.Entities;
using EmployeeManagement.Models.FormBuilder;

namespace EmployeeManagement.Factories
{
    public class FormFieldValueFactory
    {
        public static FormCommonFieldValue CreateCommonValue(FormFieldValueAddModel model,string userid)
        {
            var data = new FormCommonFieldValue
            {
                UserId = model.UserId,
                FormId = model.FormId,
                UserName = model.UserName,
                Description = model.Description,
                BusinessCategoryId = model.BusinessCategoryId,
                BusinessSubCategoryId = model.BusinessSubCategoryId,
                MobileNo = model.MobileNo,
                BusinessName = model.BusinessName,
                BusinessAlias = model.BusinessAlias,
                Email = model.Email,
                Address = model.Address,
                Postalcode = model.Postalcode,
                IsClaim = false,
                CreatedOn = DateTime.Now,
                CreatedBy = userid ?? "0"
            };
            return data;
        }
        public static FormFieldValue Create(FormValue model, string userid)
        {
            var data = new FormFieldValue
            {
                UserId = model.UserId,
                FormId = model.FormId,
                FormFieldId = model.FormFieldId,
                FormCommonFieldValueId = model.FormCommonFieldValueId,
                Value = model.Value,
                CreatedOn = DateTime.Now,
                CreatedBy = userid ?? "0"
            };
            return data;
        }
        public static void  EditFormcommonValue(FormFieldValueAddModel model, Form entity, string userid)
        {
          
            entity.UserName = model.UserName;
            entity.Description = model.Description;
            entity.BusinessCategoryId = model.BusinessCategoryId;
            entity.BusinessSubCategoryId = model.BusinessSubCategoryId;
            entity.MobileNo = model.MobileNo;
            entity.BusinessName = model.BusinessName;
            entity.BusinessAlias = model.BusinessAlias;
            entity.Email = model.Email;
            entity.Address = model.Address;
            entity.Postalcode = model.Postalcode;
           
        }

        public static void CreateClaim(AddClaimRequestModel model, FormCommonFieldValue entity, string userId)
        {
            entity.ClaimUserId = model.ClaimUserId;
        }
        public static void CreateOtp(int Otp, FormCommonFieldValue entity, string userId)
        {
            entity.Otp = Otp;
        }
    }
}
