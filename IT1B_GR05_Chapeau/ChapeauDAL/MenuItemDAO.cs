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
        public List<MenuItem> GetSubmenu(Category category)
        {
            string query = $"SELECT MENU_ITEM_ID, MENU_ITEM_NAME, MENU_ITEM_STOCK, MENU_ITEM_PRICE, CATEGORY_ID FROM MENU_ITEM WHERE CATEGORY_ID = {(int)category}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public MenuItem GetMenuItemByID(int menuItemID)
        {
            string query = $"SELECT MENU_ITEM_ID, MENU_ITEM_NAME, MENU_ITEM_STOCK, MENU_ITEM_PRICE, CATEGORY_ID FROM MENU_ITEM WHERE MENU_ITEM_ID = {menuItemID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTable(ExecuteSelectQuery(query, sqlParameters));
        }

        public void UpdateMenuItemStock(OrderItem orderItem)
        {
            string query = $"UPDATE MENU_ITEM SET MENU_ITEM_STOCK = MENU_ITEM_STOCK - {orderItem.Order_Item_Quantity} WHERE MENU_ITEM_ID = {orderItem.MenuItem.Menu_Item_Id};";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<MenuItem> ReadTables(DataTable dataTable)
        {
            //create list to store the menu
            List<MenuItem> menu = new List<MenuItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                //store each room with the following fields from the database
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

        private MenuItem ReadTable(DataTable dataTable)
        {
            DataRow dr = dataTable.Rows[0];

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
    }
}