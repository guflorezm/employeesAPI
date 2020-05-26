using WebApiEmployees.Entities.DTOs;

namespace WebApiEmployees.Business.Helpers
{
    /// <summary>
    /// Defines a factory to create an employee
    /// </summary>
    public abstract class EmployeeFactory
    {
        public abstract EmployeeBO CreateEmployee(EmployeeDTO employeeDTO);
    }
}
