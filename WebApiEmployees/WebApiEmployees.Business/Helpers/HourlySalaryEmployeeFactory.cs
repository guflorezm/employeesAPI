using WebApiEmployees.Entities.DTOs;

namespace WebApiEmployees.Business.Helpers
{
    /// <summary>
    /// Defines a factory to create an hourly salary employee
    /// </summary>
    public class HourlySalaryEmployeeFactory : EmployeeFactory
    {
        public override EmployeeBO CreateEmployee(EmployeeDTO employeeDTO)
        {
            return new HourlySalaryEmployeeBO(employeeDTO);
        }
    }
}
