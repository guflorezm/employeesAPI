using WebApiEmployees.Common;

namespace WebApiEmployees.Entities.DTOs
{
    /// <summary>
    /// Defines an employee of monthly salary type and is used in the factory of these employees,
    /// In this class we can see the principles of encapsulation, polymorphism and heritance
    /// </summary>
    public class MonthlySalaryEmployeeBO : EmployeeBO
    {
        private int _id;
        private string _name; 
        private string _contractTypeName;
        private int _roleId;
        private string _roleName;
        private string _roleDescription;
        private decimal _hourlySalary;
        private decimal _monthlySalary;

        public MonthlySalaryEmployeeBO(EmployeeDTO employee)
        {
            _id = employee.Id;
            _name = employee.Name;
            _contractTypeName = employee.ContractTypeName;
            _roleId = employee.RoleId;
            _roleName = employee.RoleName;
            _roleDescription = employee.RoleDescription;
            _hourlySalary = employee.HourlySalary;
            _monthlySalary = employee.MonthlySalary;            
        }

        public MonthlySalaryEmployeeBO( int id, 
                                        string name, 
                                        string contractTypeName, 
                                        int roleId, 
                                        string roleName,
                                        string roleDescription,
                                        decimal hourlySalary,
                                        decimal monthlySalary)
        {
            _id = id;
            _name = name;
            _contractTypeName = contractTypeName;
            _roleId = roleId;
            _roleName = roleName;
            _roleDescription = roleDescription;
            _hourlySalary = hourlySalary;
            _monthlySalary = monthlySalary;            
        }

        public override int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public override string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public override string ContractTypeName
        {
            get { return _contractTypeName; }
            set { _contractTypeName = value; }
        }

        public override int RoleId
        {
            get { return _roleId; }
            set { _roleId = value; }
        }

        public override string RoleName
        {
            get { return _roleName; }
            set { _roleName = value; }
        }

        public override string RoleDescription
        {
            get { return _roleDescription; }
            set { _roleDescription = value; }
        }

        public override decimal HourlySalary
        {
            get { return _hourlySalary; }
            set { _hourlySalary = value; }
        }

        public override decimal MonthlySalary
        {
            get { return _monthlySalary; }
            set { _monthlySalary = value; }
        }

        /// <summary>
        /// In this way we can have an autocalulated property and calculate the annual salary of the employee
        /// we can use a methos but this aprroach is more effective everytime the monthly salary change, it calculates
        /// the annual salary every time
        /// </summary>
        public override decimal AnnualSalary
        {
            get { return (_monthlySalary * Constants.MONTHS); }  
        }
    }
}
