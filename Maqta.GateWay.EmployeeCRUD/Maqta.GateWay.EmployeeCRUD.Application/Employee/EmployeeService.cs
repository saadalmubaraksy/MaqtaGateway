using AutoMapper;
using Maqta.GateWay.EmployeeCRUD.ApplicationContract;
using Maqta.GateWay.EmployeeCRUD.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maqta.GateWay.EmployeeCRUD.Application
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;

        public EmployeeService(IMapper mapper, IRepositoryWrapper repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<List<EmployeeDto>> GetAllEmployeesAsync()
        {
            var employees = await _repository.Employee.FindAllAsync();
            return _mapper.Map<List<EmployeeDto>>(employees);
        }

        public async Task<EmployeeDto> GetEmployeeAsync(int employeeId)
        {
            var employee = (await _repository.Employee.FindByConditionAsync(x=>x.Id == employeeId)).FirstOrDefault();
            return _mapper.Map<EmployeeDto>(employee);
        }

        public async Task<EmployeeDto> CreateEmployeeAsync(EmployeeDto employee)
        {
            try
            {
                if (employee == null)
                {
                    throw new Exception("Employee can not be emp");
                }
                var newEmployee = Employee.Create(employee.FirstName, employee.LastName, employee.EmailID);

                await _repository.Employee.CreateAsync(newEmployee);

                await _repository.SaveAsync();

                return _mapper.Map<EmployeeDto>(newEmployee);
            }
            catch
            {
                throw new Exception("Something went wrong");
            }
            
        }

        public async Task<bool> UpdateEmployeeAsync(EmployeeDto employee, int employeeId)
        {
            try
            {
                if (employee == null)
                {
                    throw new Exception("Employee can not be empty");
                }
                var oldEmployee = (await _repository.Employee
                    .FindByConditionAsync(x => x.Id == employee.Id))
                    .FirstOrDefault();

                if (oldEmployee == null)
                {
                    throw new Exception("Employee not found");
                }

                oldEmployee.Update(employee.FirstName, employee.LastName, employee.EmailID);

                _repository.Employee.Update(oldEmployee);

                await _repository.SaveAsync();

                return true;
            }
            catch 
            {
                return false;
            }
            
        }

        public async Task<bool> DeleteEmployeeAsync(int employeeId)
        {
            try
            {
                var employee = (await _repository.Employee
                 .FindByConditionAsync(x => x.Id == employeeId))
                 .FirstOrDefault();

                if (employee == null)
                {
                    throw new Exception("Employee not found");
                }

                _repository.Employee.Delete(employee);

                await _repository.SaveAsync();

                return true;
            }
            catch 
            {
                return false;
            }
            
        }
    }
}
