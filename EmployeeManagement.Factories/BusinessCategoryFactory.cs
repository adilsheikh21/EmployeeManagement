using EmployeeManagement.Entities;
using EmployeeManagement.Models.Business;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Factories
{
    public class BusinessCategoryFactory
    {
        public static BusinessCategory Create(BusinessCategoryAddModel model,string Userid)
        {
            var data = new BusinessCategory
            {
                BusinessCategoryName = model.BusinessCategoryName,
                CreatedOn = DateTime.Now,
                CreatedBy = Userid ?? "0"
            };
            return data;
        }

        
    }
}
