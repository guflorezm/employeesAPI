using System;
using WebApiEmployees.Entities.DTOs;
using WebApiEmployees.Common;

namespace WebApiEmployees.Business.Helpers
{
    class EmployeeFactoryBuilder
    {
        /// <summary>
        /// Builds an employee business object using the factory
        /// </summary>
        /// <param name="employeeDTO"></param>
        /// <returns></returns>
        public static EmployeeBO BuildEmployee(EmployeeDTO employeeDTO)
        {
            EmployeeFactory employeeFactory = null;

            switch (employeeDTO.ContractTypeName)
            {                
                case nameof(Enumerations.EmployeeContractType.HourlySalaryEmployee):
                    employeeFactory = new HourlySalaryEmployeeFactory();
                    break;             
                case nameof(Enumerations.EmployeeContractType.MonthlySalaryEmployee):
                    employeeFactory = new MonthlySalaryEmployeeFactory();
                    break;
                default:
                    throw new Exception("Invalid contract type of employee");
            }

            return employeeFactory.CreateEmployee(employeeDTO);
        }
    }
}
