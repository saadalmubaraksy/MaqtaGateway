using Maqta.GateWay.EmployeeCRUD.ApplicationContract;
using Maqta.GateWay.EmployeeCRUD.HttpApi.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee.API.Test
{
    public class EmployeeControllerTest
    {
        private readonly EmployeesController _controller;
        private readonly EmployeeServiceFake _service;
        public EmployeeControllerTest()
        {
            _service = new EmployeeServiceFake();
            _controller = new EmployeesController(_service);
        }
        [Fact]
        public async Task Get_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = await _controller.GetEmployee(1);
            // Assert
            Assert.IsType<EmployeeDto>(okResult as EmployeeDto);
        }
        [Fact]
        public async Task Get_WhenCalled_ReturnsAllItems()
        {
            // Act
            var okResult = await _controller.GetEmployee(2) as EmployeeDto;
            // Assert
            var items = Assert.IsType<List<EmployeeDto>>(okResult.FirstName);
            Assert.Equal(3, items.Count);
        }
    }
}

