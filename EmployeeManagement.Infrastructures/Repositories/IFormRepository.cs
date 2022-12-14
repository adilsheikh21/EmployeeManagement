using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Dtos.Form;
using EmployeeManagement.Dtos.FormBuilderType;
using EmployeeManagement.Entities;

namespace EmployeeManagement.Infrastructure.Repositories
{
    public interface IFormRepository
    {
        Task<Form> AddAsync(Form entity);
        Task AddFormField(FormField entity);
        Task AddFieldOptions(FormOption entity);
        Task<List<FormDetailDto>> GetAll();
        Task<Form> GetForm(int FormId);
        Task<FormCommonFieldValue> GetFormByClaimUserId(int claimUserId,int FormCommonFieldId);
        Task<Form> GetFormByClaimId(int ClaimUserId,int FormId);
        Task<List<FieldDetailDto>> GetAllFields(int id);
        Task<List<OptionDetailDto>> GetAllOptions(int id);
        Task<FormDetailDto> GetFormDetail(int id);
        Task<List<FormDetailDto>> GetFormDetailById(int Id);
        Task<List<FormDetailDto>> GetFormDetailByBusinessId(int UserId,int BusinessCategoryId,int BusinessSubCategoryId);

        Task<List<FormDetailDto>> GetFormDetailByCategoryId(int BusinessCategoryId,int BusinessSubCategoryId);
        Task<FormFieldDetailDto> GetFieldDetail(int FormId,string FormFieldType);
        Task<List<FormFieldDetailDto>> GetFieldDetailByFormId(int FormId);
        Task<List<OptionDetailDto>> GetFieldOptionsByFormId(int FormId);
        Task DeleteFieldOption(int FormId);
        Task DeleteField(int FormId);
        Task DeleteForm(int FormId);
        Task<BusinessFormDetailDto> GetOtpAsync(int ClaimUserId,int FormCommonFieldId);
        void Edit(Form entity);
        void EditOtp(Form entity);
        void EditIsClaim(FormCommonFieldValue entity);

    }
}
