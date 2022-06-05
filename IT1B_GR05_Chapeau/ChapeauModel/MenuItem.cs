using System;

namespace ChapeauModel
{
    public class MenuItem
    {
        public int Menu_Item_Id { get; set; }
        public string Menu_Item_Name { get; set; }
        public int Menu_Item_Stock { get; set; }
        public decimal Menu_Item_Price { get; set; } //price with VAT
        public Category Category { get; set; } //the id of the category of menu item

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

