using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maqta.GateWay.EmployeeCRUD.ApplicationContract
{
    public interface IEmployeeService
    {
        void GetAllEmployees();
        void CreateEmployee(EmployeeDto employee);
        void UpdateEmployee(EmployeeDto employee);
        void DeleteEmployee(int employeeId);
    }
}
