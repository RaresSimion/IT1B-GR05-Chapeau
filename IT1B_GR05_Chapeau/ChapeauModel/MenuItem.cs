using System;

namespace ChapeauModel
{
    public class MenuItem
    {
        public int Menu_Item_Id { get; set; } //id of the menu item
        public string Menu_Item_Name { get; set; } //name of the menu item
        public int Menu_Item_Stock { get; set; } //the amount of menu items in stock
        public decimal Menu_Item_Price { get; set; } //price with VAT
        public Category Category { get; set; } //the id of the category of menu item

        //constructor
        public MenuItem(int id, string name, int stock, decimal price, Category category)
        {
            Menu_Item_Id = id;
            Menu_Item_Name = name;
            Menu_Item_Stock = stock;
            Menu_Item_Price = price;
            Category = category;
        }
        public MenuItem()
        {

        }
    }
}

