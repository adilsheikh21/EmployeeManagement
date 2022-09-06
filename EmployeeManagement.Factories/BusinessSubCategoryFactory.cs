using System;
using System.Collections.Generic;
using System.Text;
using EmployeeManagement.Entities;
using EmployeeManagement.Models.Business;

namespace EmployeeManagement.Factories
{
    public class BusinessSubCategoryFactory
    {
        public static BusinessSubCategory Create(BusinessSubCategoryAddModel model, string Userid)
        {
            var data = new BusinessSubCategory
            {
                BusinessCategoryId = model.BusinessCategoryId,
                BusinessSubCategoryName = model.BusinessSubCategoryName,
                CreatedOn = DateTime.Now,
                CreatedBy = Userid ?? "0"
            };
            return data;
        }
    }
}
