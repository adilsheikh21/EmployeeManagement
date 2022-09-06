using System;
using System.Collections.Generic;
using System.Text;
using EmployeeManagement.Entities;
using EmployeeManagement.Models.Languages;
using EmployeeManagement.Utilities;

namespace EmployeeManagement.Factories
{
  public  class FieldFactory
    {
        public static Languages Create(LanguagesAddModel model, string userId)
        {
            var data = new Languages
            {
                LanguageName = model.LanguageName,
                LanguageOrientation = model.LanguageOrientation,
                Status = Constants.RecordStatus.Active,
                CreatedBy = userId ?? "0",
                CreatedOn = Utility.GetDateTime(),
             
            };
            return data;
        }

        
        public static void Update(LanguagesUpdateModel model, User entity, string userId)
        {
            entity.LangId = model.LanguageId;
        }
        public static void Create(LanguagesEditModel model, Languages entity, string userId)
        {
            entity.LanguageName = model.LanguageName;
            entity.LanguageOrientation = model.LanguageOrientation;
            entity.UpdatedBy = userId ?? "0";
            entity.UpdatedOn = Utility.GetDateTime();

        }
    }
}
