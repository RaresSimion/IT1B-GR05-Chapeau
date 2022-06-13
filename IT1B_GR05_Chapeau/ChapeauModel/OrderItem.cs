using System;

namespace ChapeauModel
{

	public class OrderItem
	{
		//alcoholic vat percentage
		private const decimal ALCOHOLIC_VAT = 0.21M;

		//nonalcoholic vat percentage
		private const decimal NONALCOHOLIC_VAT = 0.06M;

		//the part of the price represented by vat
		private decimal vat_In_Price;

		//the order id of the order item
		public int OrderID { get; set; }

		//the menu item insinde the order item
		public MenuItem MenuItem { get; set; }

		//the quantity of items ordered
		public int Order_Item_Quantity { get; set; }

		//comment of the order item
		public string Order_Item_Comment { get; set; }

		//whether the order item is ready to be served or not
		public bool Is_Ready { get; set; } //0 = not ready, 1 = ready

		//calculated property to tell if the item is alcoholic
		public bool Is_Alcoholic
		{
			get
			{
				return (MenuItem.Category == Category.Beers || MenuItem.Category == Category.Wines || MenuItem.Category == Category.SpiritDrinks);
			}
		}

		//calculated property to get the vat in the price of the item
		public decimal VAT_In_Price
		{
			get 
			{
				//if the item is alcoholic, use the 21% vat
				if (Is_Alcoholic)
					vat_In_Price = MenuItem.Menu_Item_Price * ALCOHOLIC_VAT;

				//if the item is nonalcohlic, use the 6% vat
				else
					vat_In_Price = MenuItem.Menu_Item_Price * NONALCOHOLIC_VAT;

				return vat_In_Price; 
			}
		}

		//constructor 
		public OrderItem(int orderID, MenuItem item, int quantity, string comment, bool isReady)
		{
			OrderID = orderID;
			MenuItem = item;
			Order_Item_Quantity = quantity;
			Order_Item_Comment = comment;
			Is_Ready = isReady;
		}

		//constructor
		public OrderItem()
		{

		}
	}
}
