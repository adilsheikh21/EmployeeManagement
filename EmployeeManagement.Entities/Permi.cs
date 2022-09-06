using EmployeeManagement.Entities;
using EmployeeManagement.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Entities
{
   public class Permi
    {
        public int Id { get; set; }
        public string Permisions { get; set; }
        public string Permision_Description { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public Constants.RecordStatus Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
      

        public int ScrenId { get; set; }
        public ScreenDetail Screen { get; set; }
    }
}
