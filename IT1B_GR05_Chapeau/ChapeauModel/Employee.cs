using System;

namespace ChapeauModel
{
    public class Employee
    {
        public int Employee_Number { get; set; }
        public string Employee_Name { get; set; }
        public EmployeeRole Employee_Role { get; set; }
        public string Employee_Password { get; set; }

        public Employee(int employee_Number, string employee_Name, EmployeeRole employeeRole, string employeePassword)
        {
            this.Employee_Number = employee_Number;
            this.Employee_Name = employee_Name;
            this.Employee_Role = employeeRole;
            this.Employee_Password = employeePassword;
        }

        public Employee() { }
    }
}
