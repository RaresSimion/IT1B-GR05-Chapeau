using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;
using System.Data;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class EmployeeDAO : BaseDao
    {
        //for login
        public Employee GetEmployeeByPassword(string employeePassword)
        {
            string query = $"SELECT EMPLOYEE_NUMBER, EMPLOYEE_NAME, EMPLOYEE_ROLE, EMPLOYEE_PASSWORD FROM EMPLOYEE WHERE EMPLOYEE_PASSWORD=(@employeePassword)";
            SqlParameter[] sqlParameters = { new SqlParameter("@employeePassword", employeePassword) };
            return ReadEmployee(ExecuteSelectQuery(query, sqlParameters));
        }

        private Employee ReadEmployee(DataTable dataTable)
        {
            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                Employee employee = new Employee()
                {
                    Employee_Number = (int)(row["EMPLOYEE_NUMBER"]),
                    Employee_Name = (string)(row["EMPLOYEE_NAME"]),
                    Employee_Role = (EmployeeRole)(row["EMPLOYEE_ROLE"]),
                    Employee_Password = (string)(row["EMPLOYEE_PASSWORD"])
                };
                return employee;
            }
            else
                throw new Exception("Incorrect credentials entered");
        }

        public Employee GetEmployeeByIDandPassword(int ID, string employeePassword)
        {
            string query = $"SELECT EMPLOYEE_NUMBER, EMPLOYEE_NAME, EMPLOYEE_ROLE, EMPLOYEE_PASSWORD FROM EMPLOYEE WHERE EMPLOYEE_NUMBER='(@ID) AND EMPLOYEE_PASSWORD = (@employeePassword)';";
            SqlParameter[] sqlParameters = { new SqlParameter("@ID", (int)ID), new SqlParameter("@employeePassword", (string)employeePassword) };
            return ReadEmployee(ExecuteSelectQuery(query, sqlParameters));
        }

        public Employee GetEmployeeByID(int ID)
        {
            string query = $"SELECT EMPLOYEE_NUMBER, EMPLOYEE_NAME, EMPLOYEE_ROLE, EMPLOYEE_PASSWORD FROM EMPLOYEE WHERE EMPLOYEE_NUMBER='{ID}';";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadEmployee(ExecuteSelectQuery(query, sqlParameters));
        }
    }
}
