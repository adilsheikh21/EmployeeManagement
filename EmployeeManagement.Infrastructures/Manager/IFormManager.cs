using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Dtos.Form;
using EmployeeManagement.Dtos.FormBuilderType;
using EmployeeManagement.Models.FormBuilder;

namespace EmployeeManagement.Infrastructure.Managers
{
    public interface IFormManager
    {
        Task<int> AddAsync(FormAddModel model);
        Task ClaimAsync(AddClaimRequestModel model);
        Task ClaimBusinessAsync(int ClaimUserId,int FormCommonFieldId);
        Task<List<FormDetailDto>> GetAll();
        Task SaveOtp(int ClaimUserId,int FormId,int Otp);
        Task<BusinessFormDetailDto> GetOtp(int ClaimUserId,int FormCommonFieldId);
        Task<List<FormDetailDto>> GetDetailByIdAsync(int Id);
        Task<List<FormDetailDto>> GetFormDetailAsync(int Userid, int BusinessCategoryId, int BusinessSubcategoryId);
        Task<List<FormDetailDto>> GetFormDetailByCategoryIdAsync(int BusinessCategoryId,int BusinessSubCategoryId);
        Task<FormDetailDto> GetFormDetail(int Id);
        Task<FormFieldDetailDto> GetFieldDetail(int FormId,string FormFieldType);
        Task AddFormField(AddFormFieldsModel model);
        Task AddFieldOptions(AddFieldOptionsModel model);
        Task DeleteForm(int FormId);
    }
}
