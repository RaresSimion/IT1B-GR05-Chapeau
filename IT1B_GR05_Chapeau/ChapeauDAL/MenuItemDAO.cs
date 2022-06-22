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
    public class MenuItemDAO : BaseDao
    {
        //get the submenu depending on the category
        public List<MenuItem> GetSubmenu(Category category)
        {
            string query = $"SELECT MENU_ITEM_ID, MENU_ITEM_NAME, MENU_ITEM_STOCK, MENU_ITEM_PRICE, CATEGORY_ID FROM MENU_ITEM WHERE CATEGORY_ID = @category";
            SqlParameter[] sqlParameters = { new SqlParameter("@category", (int)category) };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        //get a menu item depending on the id
        public MenuItem GetMenuItemByID(int menuItemID)
        {
            string query = $"SELECT MENU_ITEM_ID, MENU_ITEM_NAME, MENU_ITEM_STOCK, MENU_ITEM_PRICE, CATEGORY_ID FROM MENU_ITEM WHERE MENU_ITEM_ID = @menuItemID";
            SqlParameter[] sqlParameters = {new SqlParameter("@menuItemID", menuItemID)};
            return ReadTable(ExecuteSelectQuery(query, sqlParameters));
        }

        //update the stock
        public void UpdateMenuItemStock(OrderItem orderItem)
        {
            string query = $"UPDATE MENU_ITEM SET MENU_ITEM_STOCK = MENU_ITEM_STOCK - @quantity WHERE MENU_ITEM_ID = @menuItemID;";
            SqlParameter[] sqlParameters = {new SqlParameter("@quantity", orderItem.Order_Item_Quantity), new SqlParameter("@menuItemID", orderItem.MenuItem.Menu_Item_Id)};
            ExecuteEditQuery(query, sqlParameters);
        }

        //get the stock amount of a specific item
        public int GetStockOfMenuItem(MenuItem menuItem)
        {
            string query = $"SELECT MENU_ITEM_STOCK FROM MENU_ITEM WHERE MENU_ITEM_ID = @menuItemID";
            SqlParameter[] sqlParameters = {new SqlParameter("@menuItemID", menuItem.Menu_Item_Id)};
            return ReadStock(ExecuteSelectQuery(query, sqlParameters));
        }

        //method for reading multiple menu items from the data table
        private List<MenuItem> ReadTables(DataTable dataTable)
        {
            //create list to store the menu
            List<MenuItem> menu = new List<MenuItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                //insert values into object
                MenuItem menuItem = new MenuItem()
                {
                    Menu_Item_Id = (int)(dr["MENU_ITEM_ID"]),
                    Menu_Item_Name = (string)(dr["MENU_ITEM_NAME"]),
                    Menu_Item_Stock = (int)(dr["MENU_ITEM_STOCK"]),
                    Menu_Item_Price = (decimal)(dr["MENU_ITEM_PRICE"]),
                    Category = (Category)(dr["CATEGORY_ID"])
                };
                menu.Add(menuItem);
            }

            return menu;
        }


        //method for reading one menu item from the data table
        private MenuItem ReadTable(DataTable dataTable)
        {
            DataRow dr = dataTable.Rows[0];

            //insert each value in the menu item
            MenuItem menuItem = new MenuItem()
            {
                Menu_Item_Id = (int)(dr["MENU_ITEM_ID"]),
                Menu_Item_Name = (string)(dr["MENU_ITEM_NAME"]),
                Menu_Item_Stock = (int)(dr["MENU_ITEM_STOCK"]),
                Menu_Item_Price = (decimal)(dr["MENU_ITEM_PRICE"]),
                Category = (Category)(dr["CATEGORY_ID"])
            };
            return menuItem;
        }

        //method for reading the stock (which is an int)
        private int ReadStock(DataTable dataTable)
        {
            DataRow dr = dataTable.Rows[0];
            int lastOrderID = (int)dr["MENU_ITEM_STOCK"];
            return lastOrderID;
        }
    }
}