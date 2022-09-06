using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmployeeManagement.Models.UserLogin
{
    public class ChangePasswordModel
    {
        
            [Required]
            [MinLength(6)]
            [MaxLength(50)]
            public string AdminPassword { get; set; }
            public int Adminid { get; set; }


           public int id;
           
            [Required]
            [MinLength(6)]
            [MaxLength(50)]
            public string NewPassword { get; set; }
           

        
    }
}

         