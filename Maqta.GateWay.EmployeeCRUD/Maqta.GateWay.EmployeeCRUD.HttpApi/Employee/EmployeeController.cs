using Maqta.GateWay.EmployeeCRUD.ApplicationContract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maqta.GateWay.EmployeeCRUD.HttpApi.Employee
{
    [ApiController]
    [Route("api/[controller]")]
    [AllowAnonymous]
    public class EmployeesController: ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }


        [HttpGet("GetAllEmployees")]
        public async Task<List<EmployeeDto>> GetAllEmployees()
        {
            return await _employeeService.GetAllEmployeesAsync();
        }

        [HttpGet("GetEmployee")]
        public async Task<EmployeeDto> GetEmployee(int employeeId)
        {
            return await _employeeService.GetEmployeeAsync(employeeId);
        }

        [HttpPost("CreateEmployee")]
        public async Task<EmployeeDto> CreateEmployee(EmployeeDto request)
        {
            return await _employeeService.CreateEmployeeAsync(request);
        }

        [HttpPut("UpdateEmployee")]
        public async Task<bool> UpdateEmployee(EmployeeDto request,int employeeId)
        {
            return await _employeeService.UpdateEmployeeAsync(request, employeeId);
        }

        [HttpDelete("DeleteEmployee")]
        public async Task<bool> DeleteEmployee(int employeeId)
        {
           return await _employeeService.DeleteEmployeeAsync(employeeId);
        }
    }
}
