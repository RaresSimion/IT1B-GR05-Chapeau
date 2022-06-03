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
        public void InsertOrderItem(OrderItem orderItem)
        {
            string query = $"INSERT INTO ORDER_ITEM (ORDER_ID, MENU_ITEM_ID, ORDER_ITEM_QUANTITY, ORDER_ITEM_COMMENT) VALUES ({orderItem.OrderID}, {orderItem.MenuItem.Menu_Item_Id}, {orderItem.Order_Item_Quantity}, '{orderItem.Order_Item_Comment}');";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateOrderItem(OrderItem orderItem)
        {
            string query = $"UPDATE ORDER_ITEM SET ORDER_ITEM_QUANTITY = {orderItem.Order_Item_Quantity}, ORDER_ITEM_COMMENT = '{orderItem.Order_Item_Comment}' WHERE ORDER_ID = {orderItem.OrderID} AND MENU_ITEM_ID = {orderItem.MenuItem.Menu_Item_Id};";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        private MenuItem GetMenuItemByOrderID(int ID)
        {
            string query = $"SELECT MENU_ITEM_ID, MENU_ITEM_NAME, CATEGORY_ID FROM MENU_ITEM WHERE MENU_ITEM_ID = {ID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTable(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<OrderItem> GetOrderItemsByOrderID(int ID)
        {
            string query = $"SELECT ORDER_ID, MENU_ITEM_ID, ORDER_ITEM_QUANTITY, ORDER_ITEM_COMMENT FROM ORDER_ITEM WHERE ORDER_ID = {ID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<OrderItem> ReadTables(DataTable dataTable)
        {
            List<OrderItem> orderItem = new List<OrderItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem item = new OrderItem()
                {
                    OrderID = (int)(dr["ORDER_ID"]),
                    MenuItem = GetMenuItemByOrderID((int)(dr["MENU_ITEM_ID"])),
                    Order_Item_Quantity = (int)(dr["ORDER_ITEM_QUANTITY"]),
                    Order_Item_Comment = (string)(dr["ORDER_ITEM_COMMENT"]),
                };
                orderItem.Add(item);
            }
            return orderItem;
        }
        private MenuItem ReadTable(DataTable dataTable)
        {
            DataRow dr = dataTable.Rows[0];

            MenuItem menuItem = new MenuItem()
            {
                Menu_Item_Id = (int)(dr["MENU_ITEM_ID"]),
                Menu_Item_Name = (string)(dr["MENU_ITEM_NAME"]),
                Category = (Category)(dr["CATEGORY_ID"])
            };
            return menuItem;
        }
    }
}