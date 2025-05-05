using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRApi.Data;
using HRApi.Dtos;
using HRApi.Interfaces;
using HRApi.Models;

namespace HRApi.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;
        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task CreateEmployeeAsync(CreateEmployeeDto employeeDto)
        {
            var employee = new Employee
            {
                Name = employeeDto.Name,
                Surname = employeeDto.Surname,
                Email = employeeDto.Email,
                Phone = employeeDto.Phone,
                Department = employeeDto.Department,
                Position = employeeDto.Position,
                Salary = employeeDto.Salary,
                Address = employeeDto.Address,
                City = employeeDto.City,
                State = employeeDto.State,
                Country = employeeDto.Country,
                ZipCode = employeeDto.ZipCode,
                Manager = employeeDto.Manager,
                EmploymentType = employeeDto.EmploymentType,
                Recruiter = employeeDto.Recruiter, //giriş yapmış olan işe alımcının id bilgisi
                EmergencyContactName = employeeDto.EmergencyContactName,
                EmergencyContactPhone = employeeDto.EmergencyContactPhone,
                EmergencyContactEmail = employeeDto.EmergencyContactEmail,
                EmergencyContactRelationship = employeeDto.EmergencyContactRelationship,
                EmergencyContactAddress = employeeDto.EmergencyContactAddress,
                EmergencyContactCity = employeeDto.EmergencyContactCity,
                EmergencyContactState = employeeDto.EmergencyContactState,
                EmergencyContactZipCode = employeeDto.EmergencyContactZipCode,
                EmergencyContactCountry = employeeDto.EmergencyContactCountry,
                EmergencyContactNotes = employeeDto.EmergencyContactNotes
            };
            await _context.Employees.AddAsync(employee);
            await _context.SaveChangesAsync();
        }
        public async Task<Employee> GetEmployeeByIdAsync(Guid id)
        {
            return await _context.Employees.FindAsync(id);
        }
    }
}