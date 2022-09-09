using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maqta.GateWay.EmployeeCRUD.ApplicationContract
{
    public interface IEmployeeService
    {
        Task<List<EmployeeDto>> GetAllEmployeesAsync();
        Task<EmployeeDto> GetEmployeeAsync(int employeeId);
        Task<EmployeeDto> CreateEmployeeAsync(EmployeeDto employee);
        Task<bool> UpdateEmployeeAsync(EmployeeDto employee, int employeeId);
        Task<bool> DeleteEmployeeAsync(int employeeId);
    }
}
