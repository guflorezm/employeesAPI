using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiEmployees.Business.Helpers;
using WebApiEmployees.DAL;
using WebApiEmployees.Entities.DTOs;

namespace WebApiEmployees.Business
{
    /// <summary>
    /// Manages the business logig of the API
    /// </summary>
    public class EmployeeBL
    {
        /// <summary>
        /// Get all employees
        /// </summary>
        /// <returns></returns>
        public async Task<List<EmployeeBO>> GetEmployees()
        {
            EmployeeDAL _employeeDAL = new EmployeeDAL();
            List<EmployeeBO> employeesBO = new List<EmployeeBO>();

            List<EmployeeDTO> employeesDTO = await _employeeDAL.GetEmployees();

            if(employeesDTO != null && employeesDTO.Count > 0)
            {
                foreach(EmployeeDTO employeeDTO in employeesDTO)
                {
                    employeesBO.Add(EmployeeFactoryBuilder.BuildEmployee(employeeDTO));
                }
            }                

            return employeesBO;
        }

        /// <summary>
        /// Get one employee by his Id
        /// </summary>
        /// <returns></returns>
        public async Task<EmployeeBO> GetEmployeeById(int employeeId)
        {
            EmployeeDAL _employeeDAL = new EmployeeDAL();
            
            List<EmployeeDTO> employeesDTO = await _employeeDAL.GetEmployees();
            EmployeeDTO employeeDTO = employeesDTO.Find(e => e.Id == employeeId);
            EmployeeBO employeeBO = EmployeeFactoryBuilder.BuildEmployee(employeeDTO);

            return employeeBO;
        }
    }
}
