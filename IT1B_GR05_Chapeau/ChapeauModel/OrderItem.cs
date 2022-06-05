using System;

namespace ChapeauModel
{

	public class OrderItem
	{
		private const decimal ALCOHOLIC_VAT = 1.21M;
		private const decimal NONALCOHOLIC_VAT = 1.06M;
		private decimal order_Item_Price_Without_VAT;
		public int OrderID { get; set; }
		public MenuItem MenuItem { get; set; }
		public int Order_Item_Quantity { get; set; }
		public string Order_Item_Comment { get; set; }
		private bool Is_Alcoholic
		{
			get
			{
				return (MenuItem.Category == Category.Beers || MenuItem.Category == Category.Wines || MenuItem.Category == Category.SpiritDrinks);
			}
		}

		public decimal Order_Item_Price_Without_VAT
		{
			get 
			{
				if (Is_Alcoholic)
					order_Item_Price_Without_VAT = MenuItem.Menu_Item_Price / ALCOHOLIC_VAT;
				else
					order_Item_Price_Without_VAT = MenuItem.Menu_Item_Price / NONALCOHOLIC_VAT;

				return order_Item_Price_Without_VAT; 
			}
		}

		public OrderItem(int orderID, MenuItem item, int quantity, string comment)
		{
			OrderID = orderID;
			MenuItem = item;
			Order_Item_Quantity = quantity;
			Order_Item_Comment = comment;
		}

		public OrderItem()
		{

		}
	}
}
