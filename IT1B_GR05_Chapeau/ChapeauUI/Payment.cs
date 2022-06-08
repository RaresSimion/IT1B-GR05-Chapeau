using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauModel;
using ChapeauLogic;

namespace ChapeauUI
{
    public partial class Payment : Form
    {
        private OrderItemService orderItemService = new OrderItemService();
        public Payment()
        {
            InitializeComponent();
            DisplayTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void DisplayTable()
        {
            listViewTable.Items.Clear();
            Table table = new Table(9, false);
            List<OrderItem> orderItems = orderItemService.GetAllOrderItemsFromTable(table);
            foreach (OrderItem item in orderItems)
            {
                ListViewItem listViewItem = new ListViewItem(item.Order_Item_Quantity.ToString());
                listViewItem.Tag = item;
                listViewItem.SubItems.Add(item.MenuItem.Menu_Item_Name);
                listViewItem.SubItems.Add(item.MenuItem.Menu_Item_Price.ToString());
                listViewItem.SubItems.Add(item.Order_Item_Comment.ToString());
                listViewTable.Items.Add(listViewItem);
               
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
