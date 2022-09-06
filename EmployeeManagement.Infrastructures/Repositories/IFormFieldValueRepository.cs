using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Dtos.Form;
using EmployeeManagement.Entities;

namespace EmployeeManagement.Infrastructure.Repositories
{
    public interface IFormFieldValueRepository
    {
        Task AddAsync(FormFieldValue entity);
        Task<FormCommonFieldValue> AddCommonValue(FormCommonFieldValue entity);
        // Task AddFormCommonFieldValue(Form entity);
        Task<Form> GetFormDetail(int FormId);
        void Edit(FormCommonFieldValue entity);
        void EditOtp(FormCommonFieldValue entity);

        Task<List<FormWithValueDetailDto>> GetFormDetailWithValuesByBusinessId(int BusinessCategoryId,int BusinessSubCategoryId);
        Task<List<FormWithValueDetailDto>> GetFormDetailWithValues(int FormId);

        Task<List<FormWithValueDetailDto>> GetFormDetailByFormId(int FormId);

        Task<List<FormFieldWithValueDetailDto>> GetFormFieldData(int FormId);
        Task<List<FormFieldWithValues>> GetFormFieldValues(int id);
        Task<List<FormFieldValues>> GetFormFieldVal(int FormCommonFieldValueId);
        Task<List<FormFieldValues>> GetFormFieldVal1(int FormCommonFieldValueId,int FormFieldId);
        Task<Form> GetForm(int FormId);
        Task<FormCommonFieldValue> GetValueForm(int FormId);
        Task<FormCommonFieldValue> GetFormByClaimId(int ClaimUserId, int FormCommonFieldId);

    }
}
