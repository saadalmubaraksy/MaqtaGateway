using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maqta.GateWay.EmployeeCRUD.Domain
{
    public interface IRepositoryWrapper
    {
        IEmployeeRepository Employee { get; }
        Task SaveAsync();
    }
}
