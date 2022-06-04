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

        public void InsertOrder(Order order)
        {
            string query = $"INSERT INTO [ORDER] VALUES ('{order.Order_Time:yyyy-MM-dd HH:mm:ss}', '{order.Is_Paid}', {order.Table.Table_Number}, {order.Employee.Employee_Number}, {order.Item_Count}, {(int)order.Order_Status});";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
         public void UpdateOrder() {}

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

        /*
        public Order GetOrderById(int orderId)
        {
            string query = $"SELECT ORDER_ID, ORDER_DATE, ORDER_STATUS, IS_PAID, TABLE_ID, EMPLOYEE_NUMBER [ORDER] where ORDER_ID = {orderId}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTable(ExecuteSelectQuery(query, sqlParameters));
        }
        */
        private List<Order> ReadTables(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
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

                orders.Add(order);
            }
            return orders;
        }
    }
}