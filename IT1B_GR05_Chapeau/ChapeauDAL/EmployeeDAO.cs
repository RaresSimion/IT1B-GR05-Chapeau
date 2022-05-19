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
        private SqlConnection databaseConnection;


        public EmployeeDAO()
        {
                
        }

        public List<Employee> GetAll()
        {
            databaseConnection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Employee", databaseConnection);
            SqlDataReader dataReader = command.ExecuteReader();
            List<Employee> employees = new List<Employee>();

            while (dataReader.Read())
            {
                Employee employee = Reademployee(dataReader);
                employees.Add(employee);
            }

            dataReader.Close();
            databaseConnection.Close();

            return employees;
        }

        private Employee Reademployee(SqlDataReader dataReader)
        {
            int Employee_Number = (int)dataReader["employee_number"];
            string Employee_Name = (string)dataReader["employee_name"];
            EmployeeRole Employee_Role = (EmployeeRole)dataReader["employee_role"];
            string Employee_Password = (string)dataReader["employee_password"];

            return new Employee(Employee_Number, Employee_Name, Employee_Role, Employee_Password);
        }

        private Employee ReadEmployee(DataTable dataTable)
        {
            Employee employee = null;
            foreach (DataRow row in dataTable.Rows)
            {
                employee = new Employee()
                {
                    Employee_Number = (int)(row["employee_number"]),
                    Employee_Name = (string)(row["employee_name"]),
                    Employee_Role = (EmployeeRole)(row["employee_role"]),
                    Employee_Password = ((string)row["employee_password"])
                };
            }
            return employee;
        }


        //public Employee GetEmployeeById(int employee_number)
        //{
        //    databaseConnection.Open();
        //    SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Employee WHERE employee_number = @emploee_number", databaseConnection);

        //    sqlCommand.Parameters.AddWithValue("@Id", employee_number);

        //    SqlDataReader dataReader = sqlCommand.ExecuteReader();
        //    Employee employee = null;

        //    if (dataReader.Read())
        //    {
        //        employee = ReadEmployee(dataReader);
        //    }

        //    dataReader.Close();
        //    databaseConnection.Close();
        //    return employee;
        //}

        //public Employee GetEmployeeByPassword(string employee_password)
        //{

        //}
    }
}
