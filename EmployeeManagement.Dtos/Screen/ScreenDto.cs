using System;
using System.Collections.Generic;
using System.Text;
using EmployeeManagement.Utilities;

namespace EmployeeManagement.Dtos.Screen
{
   public class ScreenDto
    {
        public int Id { get; set; }
        public string ScreenName { get; set; }
        public string ScreenCode { get; set; }
        public string ScreenUrl { get; set; }
        public int CompanyId { get; set; }
        public Constants.RecordStatus Status { get; set; }


    }
}
