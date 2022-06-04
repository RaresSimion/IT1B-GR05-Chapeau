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
        private OrderItem orderItem;
        private OrderForm orderForm;

        public MenuItemPopUp(MenuItem menuItem, OrderForm form)
        {
            InitializeComponent();
            this.menuItem = menuItem;
            this.orderForm = form;
            CustomizeMenuItemPopUp();
        }

        public MenuItemPopUp(OrderItem orderItem, OrderForm form)
        {
            InitializeComponent();
            this.orderItem = orderItem;
            this.orderForm = form;
            textBoxItem.Text = orderItem.MenuItem.Menu_Item_Name;
            CustomizeOrderItemPopUp();
        }

        private void CustomizeMenuItemPopUp()
        {
            pnlUpdateOrderItem.Visible = false;
            textBoxItem.Text = menuItem.Menu_Item_Name;
            textBoxItem.Enabled = false;
            lblQuantityValue.Text = "1";
            DisableMinus();
        }

        private void CustomizeOrderItemPopUp()
        {
            textBoxItem.Text = orderItem.MenuItem.Menu_Item_Name;
            lblQuantityValue.Text = orderItem.Order_Item_Quantity.ToString();
            textBoxComment.Text = orderItem.Order_Item_Comment;
            textBoxItem.Enabled = false;

            DisableUpdateButton();
            if (orderItem.Order_Item_Quantity == 1)
                DisableMinus();
        }

        private void DisableUpdateButton()
        {
            btnUpdateOrderItem.Enabled = false;
            btnUpdateOrderItem.BackColor = Color.FromArgb(190, 203, 250);
        }

        private void EnableUpdateButton()
        {
            btnUpdateOrderItem.Enabled = true;
            btnUpdateOrderItem.BackColor = Color.FromArgb(24, 116, 210);
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
            {
                DisableMinus();
            }
            else
            {
                EnableMinus();
            }

            CheckForChanges();
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(lblQuantityValue.Text);
            string comment = GetComment();

            OrderItem orderItem = new OrderItem(3, menuItem, quantity, comment);

            if (!IsOrderItemInList(orderItem))
            {

                ListViewItem li = new ListViewItem(orderItem.Order_Item_Quantity.ToString());
                li.Tag = orderItem;
                li.SubItems.Add(orderItem.MenuItem.Menu_Item_Name);
                li.SubItems.Add(orderItem.Order_Item_Comment);
                //li.SubItems.Add(orderItem.Order_Item_Quantity.ToString());

                orderForm.OrderListView.Items.Add(li);
                //UpdateTotal();
                orderForm.EnableButtons();
            }
            else
            {
                MessageBox.Show("Item is already in the order.", "Warning", MessageBoxButtons.OK);
            }
            this.Close();
        }

        /*private void UpdateTotal()
        {
            List<OrderItem> items = orderForm.GetOrderItems();
            decimal valueOfItems = 0;
            decimal valueOfItemsWithVat = 0;

            foreach(OrderItem item in items)
            {
                valueOfItems += item.MenuItem.Menu_Item_Price * item.Order_Item_Quantity;
                valueOfItemsWithVat += item.Order_Item_Price_With_VAT * item.Order_Item_Quantity;
            }

            SetNewTotal(valueOfItems, valueOfItemsWithVat);
        }

        private void SetNewTotal(decimal value, decimal valueWithVat)
        {
            orderForm.TotalValue.Text = $"€{value:0.00}";
            orderForm.TotalWithVatValue.Text = $"€{valueWithVat:0.00}";
        }*/

        private bool IsOrderItemInList(OrderItem orderItem)
        {
            List<OrderItem> orderItems = orderForm.GetOrderItems();
            foreach(OrderItem item in orderItems)
            {
                if(item.MenuItem == orderItem.MenuItem)
                    return true;
            }

            return false;
        }

        private void btnUpdateOrderItem_Click(object sender, EventArgs e)
        {
            orderItem.Order_Item_Quantity = int.Parse(lblQuantityValue.Text);
            orderItem.Order_Item_Comment = textBoxComment.Text;

            orderForm.OrderListView.SelectedItems[0].SubItems[0].Text = orderItem.Order_Item_Quantity.ToString();
            orderForm.OrderListView.SelectedItems[0].SubItems[2].Text = orderItem.Order_Item_Comment;

            //UpdateTotal();
            this.Close();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            int idOfSelectedItem = orderForm.OrderListView.SelectedItems[0].Index;
            orderForm.OrderListView.Items.RemoveAt(idOfSelectedItem);
            //UpdateTotal();
            this.Close();
        }

        private void textBoxComment_TextChanged(object sender, EventArgs e)
        {
            CheckForChanges();
        }

        private void CheckForChanges()
        {
            string comment = textBoxComment.Text;
            int value = int.Parse(lblQuantityValue.Text);

            if (orderItem != null)
            {
                if (comment != orderItem.Order_Item_Comment || value != orderItem.Order_Item_Quantity)
                    EnableUpdateButton();
                else
                    DisableUpdateButton();
            }
        }

    }
}
