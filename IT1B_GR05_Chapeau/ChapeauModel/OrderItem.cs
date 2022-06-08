using System;

namespace ChapeauModel
{

	public class OrderItem
	{
		private const decimal ALCOHOLIC_VAT = 0.21M;
		private const decimal NONALCOHOLIC_VAT = 0.06M;
		private decimal vat_In_Price;
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

		public decimal VAT_In_Price
		{
			get 
			{
				if (Is_Alcoholic)
					vat_In_Price = MenuItem.Menu_Item_Price * ALCOHOLIC_VAT;
				else
					vat_In_Price = MenuItem.Menu_Item_Price * NONALCOHOLIC_VAT;

				return vat_In_Price; 
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
