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
        private OrderForm orderForm;
        public MenuItemPopUp(MenuItem menuItem, OrderForm form)
        {
            InitializeComponent();
            this.menuItem = menuItem;
            this.orderForm = form;
            DisableMinus();
        }

        private void DisableMinus()
        {
            btnMinus.Visible = false;
            btnMinus.Cursor = Cursors.No;
        }

        private void EnableMinus()
        {
            btnMinus.Visible = true;
            btnMinus.Cursor = Cursors.Hand;
        }

        private string GetComment()
        {
            string comment;

            if (textBoxComment.Text == "")
                comment = "N/A";
            else
                comment = textBoxComment.Text;

            return comment;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int value = int.Parse(lblQuantityValue.Text);
            value--;
            lblQuantityValue.Text = value.ToString();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            int value = int.Parse(lblQuantityValue.Text);
            value++;
            lblQuantityValue.Text = value.ToString();
        }

        private void pictureBoxClosePopUp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblQuantityValue_TextChanged(object sender, EventArgs e)
        {
            int value = int.Parse(lblQuantityValue.Text);
            if (value == 1)
                DisableMinus();
            else
                EnableMinus();

        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(lblQuantityValue.Text);
            string comment = GetComment();

            OrderItem orderItem = new OrderItem(2, menuItem, quantity, comment);

            ListViewItem li = new ListViewItem(orderItem.MenuItem.Menu_Item_Id.ToString());
            li.Tag = orderItem;
            li.SubItems.Add(orderItem.MenuItem.Menu_Item_Name);
            li.SubItems.Add(orderItem.Order_Item_Comment);
            li.SubItems.Add(orderItem.Order_Item_Quantity.ToString());

            orderForm.OrderListView.Items.Add(li);
            this.Close();
        }
    }
}
