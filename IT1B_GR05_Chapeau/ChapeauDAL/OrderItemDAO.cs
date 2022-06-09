﻿using System;
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
        //a private MenuItemDAO object in order to read a menu item by its id, to insert it into the order item
        private MenuItemDAO menuItemDAO = new MenuItemDAO();

        //inserting a new order item
        public void InsertOrderItem(OrderItem orderItem)
        {
            string query = $"INSERT INTO ORDER_ITEM (ORDER_ID, MENU_ITEM_ID, ORDER_ITEM_QUANTITY, ORDER_ITEM_COMMENT, ORDER_ITEM_IS_READY) VALUES ({orderItem.OrderID}, {orderItem.MenuItem.Menu_Item_Id}, {orderItem.Order_Item_Quantity}, '{orderItem.Order_Item_Comment}', '{orderItem.Is_Ready}');";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        //updating an order item if the quantity or comment changed
        public void UpdateOrderItem(OrderItem orderItem)
        {
            string query = $"UPDATE ORDER_ITEM SET ORDER_ITEM_QUANTITY = {orderItem.Order_Item_Quantity}, ORDER_ITEM_COMMENT = '{orderItem.Order_Item_Comment}' WHERE ORDER_ID = {orderItem.OrderID} AND MENU_ITEM_ID = {orderItem.MenuItem.Menu_Item_Id};";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        // !!! not needed !!! //
        private MenuItem GetMenuItemByOrderID(int ID)
        {
            string query = $"SELECT MENU_ITEM_ID, MENU_ITEM_NAME, CATEGORY_ID FROM MENU_ITEM WHERE MENU_ITEM_ID = {ID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTable(ExecuteSelectQuery(query, sqlParameters));
        }

        //get the order items from a specific order
        public List<OrderItem> GetOrderItemsByOrderID(int ID)
        {
            string query = $"SELECT ORDER_ID, MENU_ITEM_ID, ORDER_ITEM_QUANTITY, ORDER_ITEM_COMMENT FROM ORDER_ITEM WHERE ORDER_ID = {ID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        //get all order items from a table
        public List<OrderItem> GetAllOrderItemsFromTable(Table table)
        {
            string query = $"SELECT ORDER_ITEM.ORDER_ID, ORDER_ITEM.MENU_ITEM_ID, ORDER_ITEM.ORDER_ITEM_QUANTITY, ORDER_ITEM.ORDER_ITEM_COMMENT FROM ORDER_ITEM JOIN[ORDER] ON ORDER_ITEM.ORDER_ID = [ORDER].ORDER_ID WHERE[ORDER].TABLE_ID = {table.Table_Number}  AND[ORDER].IS_PAID = 'false'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrderItems(ExecuteSelectQuery(query, sqlParameters));
        }

        //method for reading multiple order items from the data table
        private List<OrderItem> ReadTables(DataTable dataTable)
        {
            //create list to store values
            List<OrderItem> orderItem = new List<OrderItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                //insert values into object
                OrderItem item = new OrderItem()
                {
                    OrderID = (int)(dr["ORDER_ID"]),
                    MenuItem = GetMenuItemByOrderID((int)(dr["MENU_ITEM_ID"])),
                    Order_Item_Quantity = (int)(dr["ORDER_ITEM_QUANTITY"]),
                    Order_Item_Comment = (string)(dr["ORDER_ITEM_COMMENT"]),
                    Is_Ready = (bool)(dr["ORDER_ITEM_IS_READY"])
                };
                orderItem.Add(item);
            }
            return orderItem;
        }

        //method for reading one order item from the data table
        private MenuItem ReadTable(DataTable dataTable)
        {
            DataRow dr = dataTable.Rows[0];

            //insert values into object
            MenuItem menuItem = new MenuItem()
            {
                Menu_Item_Id = (int)(dr["MENU_ITEM_ID"]),
                Menu_Item_Name = (string)(dr["MENU_ITEM_NAME"]),
                Category = (Category)(dr["CATEGORY_ID"])
            };
            return menuItem;
        }

        // !!! not needed? !!! //
        private List<OrderItem> ReadOrderItems(DataTable dataTable)
        {
            List<OrderItem> orderItem = new List<OrderItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem item = new OrderItem()
                {
                    OrderID = (int)(dr["ORDER_ID"]),
                    MenuItem = menuItemDAO.GetMenuItemByID((int)(dr["MENU_ITEM_ID"])),
                    Order_Item_Quantity = (int)(dr["ORDER_ITEM_QUANTITY"]),
                    Order_Item_Comment = (string)(dr["ORDER_ITEM_COMMENT"]),
                };
                orderItem.Add(item);
            }
            return orderItem;
        }
    }
}