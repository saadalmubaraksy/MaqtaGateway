
using Maqta.GateWay.EmployeeCRUD.Domain;
using Maqta.GateWay.EmployeeCRUD.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maqta.GateWay.EmployeeCRUD.EntityFrameworkCore
{
    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(MaqtaGateWayDbContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
