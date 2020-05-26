using System.Collections.Generic;
using System.Web.Http;
using WebApiEmployees.Business;
using WebApiEmployees.Entities.DTOs;
using System.Threading.Tasks;
using System;
using System.Net.Http;

namespace WebApiEmployees.Services.Controllers
{
    /// <summary>
    /// Control the operations of the employee
    /// </summary>
    public class EmployeeController : ApiController
    {
        [HttpGet]
        [Route("api/employees")]
        public async Task<List<EmployeeBO>> GetEmployees()
        {
            EmployeeBL _employeeBL = new EmployeeBL();

            try
            {
                return await _employeeBL.GetEmployees();
            }
            catch(Exception ex)
            {
                // we can implement a wrapper to manage the erros in a better way, clasifying the errors by its type,
                // busimess errors etc, but because of the rush of time, all errors will be internal server error
                var response = new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(ex.Message)
                };
                throw new HttpResponseException(response);
            }
        }

        [HttpGet]
        [Route("api/employees/{employeeId}")]
        public async Task<EmployeeBO> GetEmployeeById([FromUri] int employeeId)
        {
            EmployeeBL _employeeBL = new EmployeeBL();

            try
            {
                return await _employeeBL.GetEmployeeById(employeeId);
            }
            catch (Exception ex)
            {
                var response = new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(ex.Message)
                };
                throw new HttpResponseException(response);
            }
        }
    }
}
