using Maqta.GateWay.EmployeeCRUD.ApplicationContract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maqta.GateWay.EmployeeCRUD.HttpApi.Employee
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController: ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }


        [HttpGet(Name = "GetAllEmployees")]
        public void GetAllEmployees(EmployeeDto request)
        {
            _employeeService.GetAllEmployees();
        }

        [HttpPost(Name = "CreateEmployee")]
        public void CreateAccount(EmployeeDto request)
        {
            _employeeService.CreateEmployee(request);
        }

        [HttpPut(Name = "UpdateEmployee")]
        public void UpdateEmployee(EmployeeDto request)
        {
            _employeeService.UpdateEmployee(request);
        }

        [HttpDelete(Name = "DeleteEmployee")]
        public void DeleteEmployee(int employeeId)
        {
            _employeeService.DeleteEmployee(employeeId);
        }
    }
}
