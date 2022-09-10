using Maqta.GateWay.EmployeeCRUD.ApplicationContract;
using Maqta.GateWay.EmployeeCRUD.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee.API.Test
{
    public class EmployeeServiceFake:IEmployeeService
    {
        private readonly List<EmployeeDto> _employees;
        public EmployeeServiceFake()
        {
            _employees = new List<EmployeeDto>()
            {
                 new EmployeeDto() { Id=1,  FirstName= "test1", LastName = "test1Last", EmailID ="test1email" },
                new EmployeeDto() { Id=2,  FirstName= "test2", LastName = "test2Last", EmailID ="test2email" },
                 new EmployeeDto() { Id=3,  FirstName= "test3", LastName = "test3Last", EmailID ="test3email" },
            };
        }
        public Task<List<EmployeeDto>> GetAllEmployeesAsync()
        {
            return Task.FromResult(_employees);
        }
        public Task<EmployeeDto> CreateEmployeeAsync(EmployeeDto newEmployee)
        {
            _employees.Add(newEmployee);
            return Task.FromResult(newEmployee);
        }
        public Task<EmployeeDto> GetEmployeeAsync(int id)
        {
            return Task.FromResult(_employees.Where(a => a.Id == id)
                .FirstOrDefault());
        }
        public Task<bool> DeleteEmployeeAsync(int id)
        {
            var existing = _employees.First(a => a.Id == id);
            _employees.Remove(existing);
            return Task.FromResult(true);
        }


        public Task<bool> UpdateEmployeeAsync(EmployeeDto employee, int employeeId)
        {
            throw new NotImplementedException();
        }
    }
}
