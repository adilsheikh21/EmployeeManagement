using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Dtos.Form;
using EmployeeManagement.Models.FormBuilder;

namespace EmployeeManagement.Infrastructure.Managers
{
    public interface IFormFieldValueManager
    {
        Task AddAsync(FormValue model);
        Task<int> AddCommonValueAsync(FormFieldValueAddModel model);
        // Task AddFormCommonFieldValueAsync(FormFieldValueAddModel model);
        Task<List<FormWithValueDetailDto>> GetFormDetailByBusinessId(int BusinessCategoryId,int BusinessSubCategoryId);
        Task<List<FormWithValueDetailDto>> GetFormDetailByFormId(int FormId);
        Task ClaimAsync(AddClaimRequestModel model);
        Task SaveOtp(int ClaimUserId, int FormCommonFieldValueId, int Otp);

    }
}
