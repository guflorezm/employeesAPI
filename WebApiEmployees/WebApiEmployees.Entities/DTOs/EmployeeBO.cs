
using Newtonsoft.Json;

namespace WebApiEmployees.Entities.DTOs
{
    /// <summary>
    /// Defines an employee's BO - DTO for the BL to tranport data to services layer
    /// </summary>
    public abstract class EmployeeBO
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public abstract int Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public abstract string Name { get; set; }

        [JsonProperty("contractTypeName", NullValueHandling = NullValueHandling.Ignore)]
        public abstract string ContractTypeName { get; set; }

        [JsonProperty("roleId", NullValueHandling = NullValueHandling.Ignore)]
        public abstract int RoleId { get; set; }

        [JsonProperty("roleName", NullValueHandling = NullValueHandling.Ignore)]
        public abstract string RoleName { get; set; }

        [JsonProperty("roleDescription", NullValueHandling = NullValueHandling.Ignore)]
        public abstract string RoleDescription { get; set; }

        [JsonProperty("hourlySalary", NullValueHandling = NullValueHandling.Ignore)]
        public abstract decimal HourlySalary { get; set; }

        [JsonProperty("monthlySalary", NullValueHandling = NullValueHandling.Ignore)]
        public abstract decimal MonthlySalary { get; set; }

        [JsonProperty("annualSalary", NullValueHandling = NullValueHandling.Ignore)]
        public abstract decimal AnnualSalary { get; }
    }
}
