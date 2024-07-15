﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace employee_management.Data
{
    public class EmployeeRepository
    {
        private readonly AppDbContext _appDbContext;

        public EmployeeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task AddEmployeeAsync(Employee employee)
        {
            await _appDbContext.Set<Employee>().AddAsync(employee);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<List<Employee>> GetAllEmployeeAsync()
        {
            return await _appDbContext.Employees.ToListAsync();
        }

        public async Task<Employee> GetEmployeeByIdAsync(int id)
        {
            return await _appDbContext.Employees.FindAsync(id);

        }

        public async Task UpdateEmployeeAsync(int id, Employee model)
        {
            var employeee = await _appDbContext.Employees.FindAsync(id);
            if (employeee == null)
            {
                throw new Exception("Employee not found");
            }
            employeee.FirstName = model.FirstName;
            employeee.LastName = model.LastName;
            employeee.Email = model.Email;
            employeee.PhoneNumber = model.PhoneNumber;
            employeee.Position = model.Position;
            employeee.Department = model.Department;
            await _appDbContext.SaveChangesAsync();
        }

        public async Task DeleteEmployeeAsnyc(int id)
        {
            var employeee = await _appDbContext.Employees.FindAsync(id);
            if (employeee == null)
            {
                throw new Exception("Employee not found");
            }
            _appDbContext.Employees.Remove(employeee);
            await _appDbContext.SaveChangesAsync();
        }

    }
}
