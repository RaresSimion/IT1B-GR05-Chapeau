using System;
using ChapeauDAL;
using ChapeauModel;
using System.Collections.Generic;

namespace ChapeauLogic
{
    public class EmployeeService
    {
        EmployeeDAO employeedatabase;

        public EmployeeService()
        {
            employeedatabase = new EmployeeDAO();
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> employeesList = new List<Employee>();
            return employeesList;
        }

        //public Employee GetEmployeeByPassword(string password)
        //{
        //    Employee employee = employeedatabase.GetEmployeeByPassword(password);
        //    return employee;
        //}
    }
}
