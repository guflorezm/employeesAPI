using System.Threading.Tasks;
using WebApiEmployees.Entities.DTOs;
using Xunit;

namespace WebApiEmployees.Business.UnitTests
{    
    /// <summary>
    /// Tests the EmployeeBL class. It uses xUnit 
    /// </summary>
    public class EmployeeBLUnitTests
    {
        [Fact]
        public async Task GetEmployeeById_Returns_EmployeeWithId_EqualsTo_2()
        {
            EmployeeBL _employeeBL = new EmployeeBL();
            EmployeeBO employeeBO = await _employeeBL.GetEmployeeById(2);
            Assert.NotNull(employeeBO);
            Assert.True(employeeBO.Id.Equals(2));
        }

        [Fact]
        public async Task GetEmployeeById_CalculateAnnualSalary_EqualsTo_7200000()
        {
            EmployeeBL _employeeBL = new EmployeeBL();
            EmployeeBO employeeBO = await _employeeBL.GetEmployeeById(1);
            Assert.NotNull(employeeBO);
            employeeBO.HourlySalary = 5000;
            Assert.True(employeeBO.AnnualSalary.Equals(7200000));
        }

    }
}
