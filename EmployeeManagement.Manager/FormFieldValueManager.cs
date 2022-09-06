using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Dtos.Form;
using EmployeeManagement.Factories;
using EmployeeManagement.Infrastructure.Managers;
using EmployeeManagement.Infrastructure.Repositories;
using EmployeeManagement.Models.FormBuilder;
using EmployeeManagement.Utilities;
using EmployeeManagement.Infrastructures.DataLayer;

namespace EmployeeManagement.Managers
{
    public class FormFieldValueManager: IFormFieldValueManager
    {
        private readonly IFormFieldValueRepository _repository;
        public readonly IFormRepository _Formrepository;

        private readonly IUnitOfWork _unitOfWork;
        private readonly string _userId;

        public FormFieldValueManager(IFormRepository FormRepository,IHttpContextAccessor contextAccessor, IFormFieldValueRepository repository, IUnitOfWork unitOfWork)
        {
            _userId = contextAccessor.HttpContext.User.GetUserId();
            _repository = repository;
            _unitOfWork = unitOfWork;
            _Formrepository = FormRepository;
        }

        public async Task AddAsync(FormValue model)
        {
            try
            {
            await _repository.AddAsync(FormFieldValueFactory.Create(model,_userId));
            await _unitOfWork.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
         public async Task<int> AddCommonValueAsync(FormFieldValueAddModel model)
        {
            /*var item =await _repository.GetFormDetail(model.FormId);
            FormFieldValueFactory.EditFormcommonValue(model,item,_userId);
            _repository.Edit(item);
            await _unitOfWork.SaveChangesAsync();*/
             var obj = await _repository.AddCommonValue(FormFieldValueFactory.CreateCommonValue(model, _userId));
            return obj.id;
        }
        public async Task<List<FormWithValueDetailDto>> GetFormDetailByBusinessId(int BusinessCategoryId,int BusinessSubCategoryId)
        {
          
            var data2 = await _repository.GetFormDetailWithValuesByBusinessId(BusinessCategoryId,BusinessSubCategoryId);
            foreach (var tt in data2)
            {
                tt.FormField = await _repository.GetFormFieldData(tt.FormId);
                foreach (var s in tt.FormField)
                {
                    

                    s.Fieldvalue = await _repository.GetFormFieldVal1(tt.FormCommonFieldId, s.Id);

                }

            }
            return data2;

        }
        public async Task<List<FormWithValueDetailDto>> GetFormDetailByFormId(int FormId)
        {
            var data2 = await _repository.GetFormDetailWithValues(FormId);
           

                foreach (var tt in data2)
                {
                    tt.FormField = await _repository.GetFormFieldData(tt.FormId);
                    foreach (var s in tt.FormField)
                    {
                        // tt.FormFieldValue = await _repository.GetFormFieldValues(tt.FormCommonFieldId);

                        s.Fieldvalue = await _repository.GetFormFieldVal1(tt.FormCommonFieldId, s.Id);

                    }

               }
            
            return data2;

        }

        /*public async Task AddFormCommonFieldValueAsync(FormFieldValueAddModel model)
        {
            await _repository.AddFormCommonFieldValue(FormFieldValueFactory.Create(model, _userId));
        }*/

        public async Task ClaimAsync(AddClaimRequestModel model)
        {
            var data = await _repository.GetValueForm(model.FormCommonFieldId);
            FormFieldValueFactory.CreateClaim(model, data, _userId);
            _repository.Edit(data);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task SaveOtp(int ClaimUserId, int FormCommonFieldId, int Otp)
        {
            var item = await _repository.GetFormByClaimId(ClaimUserId, FormCommonFieldId);
            FormFieldValueFactory.CreateOtp(Otp, item, _userId);
            _repository.EditOtp(item);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
