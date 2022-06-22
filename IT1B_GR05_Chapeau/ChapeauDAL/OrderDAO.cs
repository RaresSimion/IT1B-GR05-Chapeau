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
    public class OrderDAO : BaseDao
    {
        private TableDAO tableDAO = new TableDAO();
        private EmployeeDAO empDAO = new EmployeeDAO();

        //inserting an order into the database
        public void InsertOrder(Order order)
        {
            string query = $"INSERT INTO [ORDER] VALUES (@orderTime, @isPaid, @tableNumber, @employeeNumber, @itemCount, @status);";
            SqlParameter[] sqlParameters = { new SqlParameter("@orderTime", order.Order_Time), new SqlParameter("@isPaid", order.Is_Paid), new SqlParameter("@tableNumber", order.Table.Table_Number), new SqlParameter("@employeeNumber", order.Employee.Employee_Number), new SqlParameter("@itemCount", order.Item_Count), new SqlParameter("@status", (int)order.Order_Status) };
            ExecuteEditQuery(query, sqlParameters);
        }
        public void UpdateOrder() { }

        public void UpdateOrderStatus(int orderId, OrderStatus status)
        {
            string query = $"UPDATE [ORDER] SET ORDER_STATUS = {status} WHERE ORDER_ID = {orderId};";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public List<Order> GetFoodOrders()
        {
            string query = $"SELECT DISTINCT [ORDER].ORDER_ID, ORDER_DATE, ORDER_STATUS, IS_PAID, TABLE_ID, EMPLOYEE_NUMBER FROM [ORDER] INNER JOIN ORDER_ITEM ON ORDER_ITEM.ORDER_ID = [ORDER].ORDER_ID INNER JOIN MENU_ITEM ON ORDER_ITEM.MENU_ITEM_ID = MENU_ITEM.MENU_ITEM_ID WHERE MENU_ITEM.CATEGORY_ID < 8";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Order> GetDrinkOrders()
        {
            string query = $"SELECT DISTINCT [ORDER].ORDER_ID, ORDER_DATE, ORDER_STATUS, IS_PAID, TABLE_ID, EMPLOYEE_NUMBER FROM [ORDER] INNER JOIN ORDER_ITEM ON ORDER_ITEM.ORDER_ID = [ORDER].ORDER_ID INNER JOIN MENU_ITEM ON ORDER_ITEM.MENU_ITEM_ID = MENU_ITEM.MENU_ITEM_ID WHERE MENU_ITEM.CATEGORY_ID > 7SS";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }


        public Order GetOrderById(int orderId)
        {
            string query = $"SELECT ORDER_ID, ORDER_DATE, ORDER_STATUS, IS_PAID, TABLE_ID, EMPLOYEE_NUMBER [ORDER] where ORDER_ID = {orderId}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrder(ExecuteSelectQuery(query, sqlParameters));
        }

        //get the id of the last order
        public int GetLastOrderID()
        {
            string query = $"SELECT MAX(ORDER_ID) AS LAST_ORDER_ID FROM [ORDER]";
            return ReadLastOrderID(ExecuteSelectQuery(query));
        }
        private List<Order> ReadTables(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order()
                {
                    Order_Id = (int)dr["ORDER_ID"],
                    Order_Time = (DateTime)dr["ORDER_DATE"],
                    Order_Status = (OrderStatus)(dr["ORDER_STATUS"]),
                    Is_Paid = (bool)dr["IS_PAID"],
                    Table = tableDAO.GetTable((int)dr["TABLE_ID"]),
                    Employee = empDAO.GetEmployeeByID((int)dr["EMPLOYEE_NUMBER"])
                };
                orders.Add(order);
            }
            return orders;
        }

        //reading the id of the last order
        private int ReadLastOrderID(DataTable dataTable)
        {
            int lastOrderID = 0;
            DataRow dr = dataTable.Rows[0];

            if(dr["LAST_ORDER_ID"] != DBNull.Value)
               lastOrderID = (int)dr["LAST_ORDER_ID"];

            return lastOrderID;
        }
        private Order ReadOrder(DataTable dataTable)
        {
            DataRow dr = dataTable.Rows[0];
            Table table = new Table();
            table.Table_Number = (int)dr["TABLE_ID"];
            Employee employee = new Employee();
            employee.Employee_Number = (int)dr["EMPLOYEE_NUMBER"];
            Order order = new Order()
            {
                Order_Id = (int)dr["ORDER_ID"],
                Order_Time = (DateTime)dr["ORDER_DATE"],
                Order_Status = (OrderStatus)Enum.Parse(typeof(OrderStatus), (string)dr["ORDER_STATUS"]),
                Is_Paid = (bool)dr["IS_PAID"],
                Table = table,
                Employee = employee,
            };
            return order;
        }



        public List<Order> GetOrdersByTableNumber(int tableNr)
        {
            string query = $"SELECT ORDER_ID, ORDER_DATE, ORDER_STATUS, IS_PAID, TABLE_ID, EMPLOYEE_NUMBER FROM [ORDER] WHERE TABLE_ID = {tableNr}";
            SqlParameter[] sqlParameter = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameter));
        }

        public List<Order> GetAllOrders()
        {
            string query = $"SELECT ORDER_ID, ORDER_DATE, ORDER_STATUS, IS_PAID, TABLE_ID, EMPLOYEE_NUMBER FROM [ORDER]";
            SqlParameter[] sqlParameter = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameter));
        }
    }
}