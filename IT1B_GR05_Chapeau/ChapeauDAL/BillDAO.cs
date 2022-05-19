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
    public class BillDAO : BaseDao
    {
        private SqlConnection databaseConnection;

        public BillDAO()
        {

        }

        //public List<Bill> GetAll()
        //{
        //    databaseConnection.Open();
        //    SqlCommand command = new SqlCommand("SELECT * FROM Bill", databaseConnection);
        //    SqlDataReader dataReader = command.ExecuteReader();
        //    List<Bill> bills = new List<Bill>();

        //    while (dataReader.Read())
        //    {
        //        //Bill bill = Readbill(dataReader);
        //        //employees.Add(employee);
        //    }

        //    dataReader.Close();
        //    databaseConnection.Close();

        //    return;
        //}

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

        ////public Employee GetEmployeeById(int employee_number)
        //{

        //}

       //// public Employee GetEmployeeByPassword(string employee_password)
       // {

       // }
    }
}

