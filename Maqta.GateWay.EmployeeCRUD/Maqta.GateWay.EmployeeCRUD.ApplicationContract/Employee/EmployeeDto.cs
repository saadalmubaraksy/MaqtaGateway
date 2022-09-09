using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maqta.GateWay.EmployeeCRUD.ApplicationContract
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string EmailID { get; set; }
    }
}
