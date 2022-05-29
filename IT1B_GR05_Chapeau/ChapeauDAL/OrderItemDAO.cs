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
    public class OrderItemDAO : BaseDao
    {
        private SqlConnection databaseConnection;

        public void InsertOrderItem(OrderItem orderItem)
        {
            string query = $"INSERT INTO ORDER_ITEM (ORDER_ID, MENU_ITEM_ID, ORDER_ITEM_QUANTITY, ORDER_ITEM_COMMENT) VALUES ({orderItem.OrderID}, {orderItem.MenuItem.Menu_Item_Id}, {orderItem.Order_Item_Quantity}, '{orderItem.Order_Item_Comment}');";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}