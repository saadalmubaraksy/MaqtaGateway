using AutoMapper;
using Maqta.GateWay.EmployeeCRUD.ApplicationContract;
using Maqta.GateWay.EmployeeCRUD.Domain;

namespace Maqta.GateWay.EmployeeCRUD.Application
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EmployeeDto>();
        }   
    }
}
