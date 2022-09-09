using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maqta.GateWay.EmployeeCRUD.Domain
{
    public class Employee
    {
        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string EmaiID { get; private set; }

        private Employee(string firstName, string lastName, string emaiID)
        {
            FirstName = firstName;
            LastName = lastName;
            EmaiID = emaiID;
        }

        public static Employee Create(string firstName, string lastName, string emaiID)
        {
            return new Employee(firstName, lastName, emaiID);
        }

        public void Update(string firstName, string lastName, string emaiID)
        {
            FirstName = firstName;
            LastName = lastName;
            EmaiID = emaiID;
        }
    }
}
