using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Dtos.Form;
using EmployeeManagement.Entities;
using System.Linq;
using System.Linq.Dynamic.Core;
using EmployeeManagement.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.DataLayers.Repositories
{
    public  class FormFieldValueRepository : IFormFieldValueRepository
    {
        public readonly DataContext _dataContext;
        public FormFieldValueRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<FormCommonFieldValue> AddCommonValue(FormCommonFieldValue entity )
        {
            await _dataContext.FormCommonFieldValue.AddAsync(entity);
            await _dataContext.SaveChangesAsync();
            return entity;
        }
        public async Task AddAsync(FormFieldValue entity)
        {
            await _dataContext.FormFieldValue.AddAsync(entity);
            await _dataContext.SaveChangesAsync();
        }
        /* public async Task AddFormCommonFieldValue(Form entity)
         {
             await _dataContext.Forms.AddAsync(entity);
             await _dataContext.SaveChangesAsync();
         }*/
        public void EditOtp(FormCommonFieldValue entity)
        {
            _dataContext.FormCommonFieldValue.Update(entity);
            _dataContext.SaveChanges();
        }
        public void Edit(FormCommonFieldValue entity)
        {
            _dataContext.FormCommonFieldValue.Update(entity);
            _dataContext.SaveChanges();
        }
        public async Task<Form> GetFormDetail(int FormId)
        {
            return _dataContext.Forms.Where(s => s.Id == FormId).FirstOrDefault();
        }
        public async Task<List<FormWithValueDetailDto>> GetFormDetailWithValuesByBusinessId(int BusinessCategoryId,int BusinessSubCategoryId)
        {
            return await (from s in _dataContext.FormCommonFieldValue
                          where s.BusinessCategoryId == BusinessCategoryId && s.BusinessSubCategoryId == BusinessSubCategoryId
                          select new FormWithValueDetailDto 
                          { 
                              FormCommonFieldId = s.id,
                              UserId = s.UserId,
                              FormId = s.FormId,
                              UserName = s.UserName,
                              Description = s.Description,
                              BusinessCategoryId = s.BusinessCategoryId,
                              BusinessSubCategoryId = s.BusinessSubCategoryId,
                              MobileNo = s.MobileNo,
                              BusinessName = s.BusinessName,
                              BusinessAlias = s.BusinessAlias,
                              Address = s.Address,
                              Email = s.Email,
                              Postalcode = s.Postalcode,
                              IsClaim = s.IsClaim,
                              ClaimUserId = s.ClaimUserId
                          }).AsNoTracking().ToListAsync();
        }

        public async Task<List<FormWithValueDetailDto>> GetFormDetailWithValues(int FormId)
        {
            return await (from s in _dataContext.FormCommonFieldValue
                          where s.FormId == FormId
                          select new FormWithValueDetailDto
                          {
                              FormCommonFieldId = s.id,
                              UserId = s.UserId,
                              FormId = s.FormId,
                              UserName = s.UserName,
                              Description = s.Description,
                              BusinessCategoryId = s.BusinessCategoryId,
                              BusinessSubCategoryId = s.BusinessSubCategoryId,
                              MobileNo = s.MobileNo,
                              BusinessName = s.BusinessName,
                              BusinessAlias = s.BusinessAlias,
                              Address = s.Address,
                              Email = s.Email,
                              Postalcode = s.Postalcode,
                              IsClaim = s.IsClaim,
                              ClaimUserId = s.ClaimUserId,
                              
                          }).AsNoTracking().ToListAsync();
        }

        public async Task<List<FormWithValueDetailDto>> GetFormDetailByFormId(int FormId)
        {
            return await (from s in _dataContext.Forms
                          where s.Id == FormId
                          select new FormWithValueDetailDto
                          {
                              FormCommonFieldId = s.Id,
                              UserId = s.UserId,
                              BusinessCategoryId = s.BusinessCategoryId,
                              BusinessSubCategoryId = s.BusinessSubCategoryId,
                              MobileNo = s.MobileNo,
                              BusinessName = s.BusinessName,
                              Address = s.Address,
                              Email = s.Email,
                              Postalcode = s.Postalcode,
                          }).AsNoTracking().ToListAsync();
        }
        public async Task<List<FormFieldWithValues>> GetFormFieldValues(int id)
        {
            return await (from s in _dataContext.FormFieldValue
                          where s.FormCommonFieldValueId == id
                          select new FormFieldWithValues
                          {
                              Id = s.Id,
                              FormId = s.FormId,
                              UserId = s.UserId,
                              FormFieldId = s.FormFieldId,
                              FormCommmonFieldValueId = s.FormCommonFieldValueId,
                         

                          }).AsNoTracking().ToListAsync();
        }

        public async Task<List<FormFieldWithValueDetailDto>> GetFormFieldData(int FormId)
        {
            return await (from s in _dataContext.FormFields
                          where s.FormId == FormId
                          select new FormFieldWithValueDetailDto
                          {
                              Id = s.Id,
                              FormId = s.FormId,
                              type = s.FormFieldType,
                              Label = s.FieldName,
                              ClassName = s.className,
                              Subtype = s.SubType,
                              Value = s.Value,
                              Required = s.Required,
                              Toggle = s.Toggle,
                              Other = s.EnableOther,
                              Inline = s.Inline,
                              Access = s.Access,

                              Style = s.Style,
                              RequireValidOption = s.RequireValidOption,
                              Name = s.Name,
                              MaxLength = s.Maxlength,
                              Multiple = s.Multiple

                          }).AsNoTracking().ToListAsync();
        }

        public async Task<List<FormFieldValues>> GetFormFieldVal(int FormCommonFieldValueId)
        {
            return await (from s in _dataContext.FormFieldValue
                          where s.FormCommonFieldValueId == FormCommonFieldValueId 
                          select new FormFieldValues
                          {
                              Id = s.Id,
                              FormId = s.FormId,
                              UserId = s.UserId,
                              FieldId = s.FormFieldId,
                              Value = s.Value,
                          }).AsNoTracking().ToListAsync();
        }

        public async Task<List<FormFieldValues>> GetFormFieldVal1(int FormCommonFieldValueId, int FormFieldId)
        {
            return await (from s in _dataContext.FormFieldValue
                          where s.FormCommonFieldValueId == FormCommonFieldValueId && s.FormFieldId == FormFieldId
                          select new FormFieldValues
                          {
                              Id = s.Id,
                              FormId = s.FormId,
                              UserId = s.UserId,
                              FieldId = s.FormFieldId,
                              Value = s.Value,
                          }).AsNoTracking().ToListAsync();
        }
        public async Task<Form> GetForm(int FormId)
        {
            return await _dataContext.Forms.FindAsync(FormId);
        }
        public async Task<FormCommonFieldValue> GetValueForm(int FormCommonFieldValueId)
        {
            return await _dataContext.FormCommonFieldValue.FindAsync(FormCommonFieldValueId);
        }

        public async Task<FormCommonFieldValue> GetFormByClaimId(int ClaimUserId, int FormCommonFieldId)
        {
            return _dataContext.FormCommonFieldValue.Where(s => s.ClaimUserId == ClaimUserId && s.id == FormCommonFieldId).FirstOrDefault();

        }
    }
}
