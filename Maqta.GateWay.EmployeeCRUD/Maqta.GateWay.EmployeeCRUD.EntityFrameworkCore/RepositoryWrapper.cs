using Maqta.GateWay.EmployeeCRUD.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maqta.GateWay.EmployeeCRUD.EntityFrameworkCore
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private MaqtaGateWayDbContext _repoContext;
        private IEmployeeRepository _employee;
        public IEmployeeRepository Employee
        {
            get
            {
                if (_employee == null)
                {
                    _employee = new EmployeeRepository(_repoContext);
                }
                return _employee;
            }
        }
       
        public RepositoryWrapper(MaqtaGateWayDbContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }
        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
