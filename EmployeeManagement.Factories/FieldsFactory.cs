using EmployeeManagement.Entities;
using EmployeeManagement.Models.Field;
using EmployeeManagement.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Factories
{
    public class FieldsFactory
    {
        public static Field Create(FieldsAddModel model, string userId)
        {
            var data = new Field()
            {
                LanguageId = model.LanguageId,
                ScreenId = model.ScreenId,
                field = model.Field,
                description = model.Description,
                Status = Constants.RecordStatus.Active,
                CreatedBy = userId ?? "0",
                CreatedOn = Utility.GetDateTime(),
                UpdatedBy = userId??"0",
                UpdatedOn = Utility.GetDateTime(),
               
            };
            return data;
        }

        public static void Create(FieldEditModel model, Field entity, string userId)
        {
            entity.LanguageId = model.LanguageId;
            entity.ScreenId = model.ScreenId;
            entity.field = model.Field;
            entity.description =model.Description;
            entity.UpdatedBy = userId ?? "0";
            entity.UpdatedOn = Utility.GetDateTime();

        }
    }
}


