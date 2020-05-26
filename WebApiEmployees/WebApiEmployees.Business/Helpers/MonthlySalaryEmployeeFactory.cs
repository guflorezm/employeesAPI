using WebApiEmployees.Entities.DTOs;

namespace WebApiEmployees.Business.Helpers
{
    /// <summary>
    /// Defines a factory to create a monthly salary employee
    /// </summary>
    public class MonthlySalaryEmployeeFactory : EmployeeFactory
    {
        public override EmployeeBO CreateEmployee(EmployeeDTO employeeDTO)
        {
            return new MonthlySalaryEmployeeBO(employeeDTO);
        }
    }
}
