using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maqta.GateWay.EmployeeCRUD.Domain
{
    public class Employee
    {
        [Key]
        public int Id { get; private set; }

        [Required]
        [MaxLength(200)]
        public string FirstName { get; private set; }

        [Required]
        [MaxLength(200)]
        public string LastName { get; private set; }

        [Required]
        [MaxLength(500)]
        public string EmailID { get; private set; }

        private Employee(string firstName, string lastName, string emailID)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailID = emailID;
        }

        public static Employee Create(string firstName, string lastName, string emailID)
        {
            return new Employee(firstName, lastName, emailID);
        }

        public void Update(string firstName, string lastName, string emailID)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailID = emailID;
        }
    }
}
