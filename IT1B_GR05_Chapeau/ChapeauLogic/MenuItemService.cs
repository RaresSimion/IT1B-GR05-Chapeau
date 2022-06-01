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

        /* public List<MenuItem> GetMenu()
        {
            List<MenuItem> menu = menuItemDB.GetMenu();
            return menu;
        }
       public List<MenuItem> GetFoodItems()
        {
            List<MenuItem> foodItems = menuItemDB.GetFoodItems();
            return foodItems;
        }

        public List<MenuItem> GetLunchItems()
        {
            List<MenuItem> lunchItems = menuItemDB.GetLunchItems();
            return lunchItems;
        }*/

        public List<MenuItem> GetLunchStarters()
        {
            List<MenuItem> lunchStarters = menuItemDB.GetLunchStarters();
            return lunchStarters;
        }

        public List<MenuItem> GetLunchMains()
        {
            List<MenuItem> lunchMains = menuItemDB.GetLunchMains();
            return lunchMains;
        }

        public List<MenuItem> GetLunchDesserts()
        {
            List<MenuItem> lunchDesserts = menuItemDB.GetLunchDesserts();
            return lunchDesserts;
        }

        //public List<MenuItem> GetDinnerItems()
        //{
        //    List<MenuItem> dinnerItems = menuItemDB.GetDinnerItems();
        //    return dinnerItems;
        //}

        public List<MenuItem> GetDinnerStarters()
        {
            List<MenuItem> dinnerStarters = menuItemDB.GetDinnerStarters();
            return dinnerStarters;
        }

        public List<MenuItem> GetDinnerEntremets()
        {
            List<MenuItem> dinnerEntremets = menuItemDB.GetDinnerEntremets();
            return dinnerEntremets;
        }

        public List<MenuItem> GetDinnerMains()
        {
            List<MenuItem> dinnerMains = menuItemDB.GetDinnerMains();
            return dinnerMains;
        }

        public List<MenuItem> GetDinnerDesserts()
        {
            List<MenuItem> dinnerDesserts = menuItemDB.GetDinnerDesserts();
            return dinnerDesserts;
        }

        //public List<MenuItem> GetDrinks()
        //{
        //    List<MenuItem> drinks = menuItemDB.GetDrinks();
        //    return drinks;
        //}

        public List<MenuItem> GetSoftDrinks()
        {
            List<MenuItem> softDrinks = menuItemDB.GetSoftDrinks();
            return softDrinks;
        }

        public List<MenuItem> GetBeers()
        {
            List<MenuItem> beers = menuItemDB.GetBeers();
            return beers;
        }

        public List<MenuItem> GetWines()
        {
            List<MenuItem> wines = menuItemDB.GetWines();
            return wines;
        }

        public List<MenuItem> GetSpiritDrinks()
        {
            List<MenuItem> spiritDrinks = menuItemDB.GetSpiritDrinks();
            return spiritDrinks;
        }

        public List<MenuItem> GetCoffeeTea()
        {
            List<MenuItem> coffeeTea = menuItemDB.GetCoffeeTea();
            return coffeeTea;
        }

        public MenuItem GetMenuItemByID(int menuItemID)
        {
            return menuItemDB.GetMenuItemByID(menuItemID);
        }
    }
}
