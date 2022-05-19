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

namespace ChapeauUI
{
    public partial class MenuItemPopUp : Form
    {
        private MenuItem menuItem;
        private OrderViewForm orderViewForm;
        public MenuItemPopUp(MenuItem item, OrderViewForm form)
        {
            InitializeComponent();
            menuItem = item;
            orderViewForm = form;
            CustomziePopUp();
        }

        private void CustomziePopUp()
        {
            lblSelectedItemTxt.Text = menuItem.Menu_Item_Name;
            lblIDTxt.Text = menuItem.Menu_Item_Id.ToString();
            textBoxQuantity.Text = "1";
            btnMinus.Enabled = false;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(textBoxQuantity.Text);
            quantity++;
            textBoxQuantity.Text = quantity.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(textBoxQuantity.Text);
            quantity--;

            textBoxQuantity.Text = quantity.ToString();
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(textBoxQuantity.Text);
            string comment = textBoxOrderComment.Text;
            OrderItem orderItem = new OrderItem(menuItem, quantity, comment);

            ListViewItem listItem = new ListViewItem(orderItem.MenuItem.Menu_Item_Id.ToString());
            listItem.SubItems.Add(orderItem.MenuItem.Menu_Item_Name);
            listItem.SubItems.Add(orderItem.Order_Item_Quantity.ToString());

            if (comment != "")
                listItem.SubItems.Add(orderItem.Order_Item_Comment);
            else
                listItem.SubItems.Add("N/A");

            listItem.Tag = orderItem;

            orderViewForm.OrderList.Items.Add(listItem);
            this.Close();
        }

        private void textBoxQuantity_TextChanged(object sender, EventArgs e)
        {
            if(textBoxQuantity.Text == "1")
                btnMinus.Enabled = false;
            else
                btnMinus.Enabled = true;
        }
    }
}
