using System;

namespace ChapeauModel
{
    public class MenuItem
    {
        //id of the menu item
        public int Menu_Item_Id { get; set; }

        //name of the menu item
        public string Menu_Item_Name { get; set; }

        //the amount of menu items in stock
        public int Menu_Item_Stock { get; set; }

        //price with VAT
        public decimal Menu_Item_Price { get; set; }

        //the id of the category of menu item
        public Category Category { get; set; }

        //constructor
        public MenuItem(int id, string name, int stock, decimal price, Category category)
        {
            Menu_Item_Id = id;
            Menu_Item_Name = name;
            Menu_Item_Stock = stock;
            Menu_Item_Price = price;
            Category = category;
        }

        //constructor 
        public MenuItem()
        {

        }
    }
}

