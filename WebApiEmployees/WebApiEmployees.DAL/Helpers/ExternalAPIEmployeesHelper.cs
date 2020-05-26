using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using WebApiEmployees.Entities.Models;
using WebApiEmployees.Common;

namespace WebApiEmployees.DAL.Helpers
{
    /// <summary>
    /// Manage the calling to the external API to obtain the employees's data
    /// </summary>    
    public static class ExternalAPIEmployeesHelper
    {
        public static async Task<List<Employee>> CallExternalApiEmployees()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("http://masglobaltestapi.azurewebsites.net/");                    
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    using (var response = await client.GetAsync("api/Employees"))
                    {                        
                        if (response.IsSuccessStatusCode)
                            return await response.Content.ReadAsAsync<List<Employee>>();
                        else
                            return null;
                    }
                }
                catch(Exception ex)
                {
                    throw new HttpRequestException("Problems with the external API", ex);
                }
            }            
        }
    }
}
