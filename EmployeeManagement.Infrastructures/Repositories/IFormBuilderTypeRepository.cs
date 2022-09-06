using EmployeeManagement.Dtos.FormBuilderType;
using EmployeeManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace EmployeeManagement.Infrastructure.Repositories
{
    public interface IFormBuilderTypeRepository
    {
        Task AddAsync(FormBuilderType entity);
        Task<List<FormBuilderTypeDetailDto>> GetAll();

    }
}
