using Maqta.GateWay.EmployeeCRUD.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maqta.GateWay.EmployeeCRUD.EntityFrameworkCore
{
    public class MaqtaGateWayDbContext : DbContext
    {
        public MaqtaGateWayDbContext(DbContextOptions options)
       : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
