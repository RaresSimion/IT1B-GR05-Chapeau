using System;

namespace ChapeauModel
{

	public class OrderItem
	{
		private const decimal ALCOHOLIC_VAT = 0.21M;
		private const decimal NONALCOHOLIC_VAT = 0.06M;

		public MenuItem MenuItem { get; set; }
		private decimal order_Item_Price_With_VAT;
		public int Order_Item_Quantity { get; set; }
		public string Order_Item_Comment { get; set; }
		private bool Is_Alcoholic
		{
			get { return Is_Alcoholic; }
			set
			{
				if (MenuItem.Category_Id == 9 || MenuItem.Category_Id == 10 || MenuItem.Category_Id == 11)
					Is_Alcoholic = true;
				else
					Is_Alcoholic = false;
			}
		}

		public decimal Order_Item_Price_With_VAT
		{
			get { return order_Item_Price_With_VAT; }
			set
			{
				if (Is_Alcoholic)
					order_Item_Price_With_VAT = MenuItem.Menu_Item_Price * ALCOHOLIC_VAT;
				else
					order_Item_Price_With_VAT = MenuItem.Menu_Item_Price * NONALCOHOLIC_VAT;
			}
		}

		public OrderItem(MenuItem item, int quantity, string comment)
		{
			MenuItem = item;
			Order_Item_Quantity = quantity;
			Order_Item_Comment = comment;
		}

		public OrderItem()
		{

		}
	}
}
