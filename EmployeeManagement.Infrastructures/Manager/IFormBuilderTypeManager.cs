using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Dtos.FormBuilderType;
using EmployeeManagement.Models.FormBuilder;

namespace EmployeeManagement.Infrastructure.Managers
{
    public  interface IFormBuilderTypeManager
    {
        Task AddAsync(FormBuilderTypeAddModel model);
        Task<List<FormBuilderTypeDetailDto>> GetAll();
    }
}
