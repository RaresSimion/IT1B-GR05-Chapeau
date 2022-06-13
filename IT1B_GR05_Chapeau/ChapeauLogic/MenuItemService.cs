using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    public class MenuItemService
    {
        MenuItemDAO menuItemDB;

        public MenuItemService()
        {        
            //create connection to database
            menuItemDB = new MenuItemDAO();
        }

        public List<MenuItem> GetSubmenu(Category category)
        {
            //get all menu items from the specific category
            List<MenuItem> submenu = menuItemDB.GetSubmenu(category);
            return submenu;
        }

        public void UpdateMenuItemStock(OrderItem orderItem)
        {
            //update the stock of a menu item
            menuItemDB.UpdateMenuItemStock(orderItem);
        }
        public MenuItem GetMenuItemByID(int menuItemId)
        {
            //get the menu item by its id
            MenuItem menuItem = menuItemDB.GetMenuItemByID(menuItemId);
            return menuItem;
        }

        public int GetStockOfMenuItem(MenuItem menuItem)
        {
            //get the stock of a menu item
            return menuItemDB.GetStockOfMenuItem(menuItem);
        }
    }
}
