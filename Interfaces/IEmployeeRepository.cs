using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRApi.Dtos;
using HRApi.Models;

namespace HRApi.Interfaces
{
    public interface IEmployeeRepository
    {
        Task CreateEmployeeAsync(CreateEmployeeDto employeeDto);
        Task<Employee> GetEmployeeByIdAsync(Guid id);
    }
}