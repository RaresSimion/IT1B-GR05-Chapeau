using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    public class EmployeeService
    {
        EmployeeDAO employeedao;

        public EmployeeService()
        {
            employeedao = new EmployeeDAO();
        }

        public Employee GetEmployeeByPassword(string password)
        {
            Employee employee = employeedao.GetEmployeeByPassword(password);
            return employee;
        }
    }
}
