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
            menuItemDB = new MenuItemDAO();
        }

        public List<MenuItem> GetSubmenu(Category category)
        {
            List<MenuItem> submenu = menuItemDB.GetSubmenu(category);
            return submenu;
        }

        public void UpdateMenuItemStock(OrderItem orderItem)
        {
            menuItemDB.UpdateMenuItemStock(orderItem);
        }
    }
}
