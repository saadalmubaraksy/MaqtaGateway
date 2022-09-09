using AutoMapper;
using Maqta.GateWay.EmployeeCRUD.ApplicationContract;
using Maqta.GateWay.EmployeeCRUD.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maqta.GateWay.EmployeeCRUD.Application
{
    public class EmployeeService: IEmployeeService
    {
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;

        public EmployeeService(IMapper mapper, IRepositoryWrapper repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public void GetAllEmployees()
        {

        }

        public void CreateEmployee(EmployeeDto employee)
        {
          
        }

        public void UpdateEmployee(EmployeeDto employee)
        {

        }

        public void DeleteEmployee(int employeeId)
        {

        }
    }
}
