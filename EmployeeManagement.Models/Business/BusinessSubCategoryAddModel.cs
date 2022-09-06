using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Models.Business
{
    public class BusinessSubCategoryAddModel
    {
        public int Id { get; set; }
        public int BusinessCategoryId { get; set; }
        public string BusinessSubCategoryName { get; set; }
    }
}
