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
            string query = $"INSERT INTO [ORDER] VALUES ('{order.Order_Time:yyyy-MM-dd HH:mm:ss}', '{order.Order_Status}', '{order.Is_Paid}', {order.Table.Table_Number}, {order.Employee.Employee_Number}, {order.Item_Count});";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void InsertOrder()
        {

        }

        public void UpdateOrder()
        {

        }

        public List<Order> GetOrders()
        {
            return null;
        }

        public Order GetOrdersById()
        {
            return null;
        }

        public List<Order> ReadOrders()
        {
            return null;
        }
    }
}