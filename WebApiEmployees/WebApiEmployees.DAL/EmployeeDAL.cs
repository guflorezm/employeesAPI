using Nelibur.ObjectMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiEmployees.DAL.Helpers;
using WebApiEmployees.Entities.DTOs;
using WebApiEmployees.Entities.Models;

namespace WebApiEmployees.DAL
{
    /// <summary>
    /// Manage the data access of the employees, in this case we call an External API
    /// </summary>
    public class EmployeeDAL
    {
        public async Task<List<EmployeeDTO>> GetEmployees()
        {            
            TinyMapper.Bind<List<Employee>, List<EmployeeDTO>>(); //// We use TinyMapper to map the objects

            List<Employee> employees = await ExternalAPIEmployeesHelper.CallExternalApiEmployees();

            return TinyMapper.Map<List<EmployeeDTO>>(employees);            
        }
    }
}
