using EmployeeManagement.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Dtos.Languages
{
   public class LanguagesDto
    {
        public int LanguageId { get; set; }
        public string LanguageName { get; set; }
        public string LanguageOrientation { get; set; }
        public Constants.RecordStatus Status { get; set; }

    }
}
