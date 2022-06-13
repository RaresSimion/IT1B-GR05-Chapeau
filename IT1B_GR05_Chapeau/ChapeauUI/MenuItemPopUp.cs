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
        //field to store the clicked menu item
        private MenuItem menuItem;

        //field to store the clicked order item
        private OrderItem orderItem;

        //field to store the order form, in order to have access to its list views
        private OrderForm orderForm;

        //constructor used when a menu item is clicked
        public MenuItemPopUp(MenuItem menuItem, OrderForm form)
        {
            InitializeComponent();

            //assign the menu item
            this.menuItem = menuItem;

            //assign the order form
            this.orderForm = form;

            //customize the pop up
            CustomizeMenuItemPopUp();
        }

        //constructor used when an order item is clicked
        public MenuItemPopUp(OrderItem orderItem, OrderForm form)
        {
            InitializeComponent();

            //assign the order item
            this.orderItem = orderItem;

            //assign the order form
            this.orderForm = form;

            //customize the pop up
            CustomizeOrderItemPopUp();
        }

        //method to customize the menu item pop up
        private void CustomizeMenuItemPopUp()
        {
            //disable the update button
            pnlUpdateOrderItem.Visible = false;

            //customize the text of the form
            CustomizeText();

            //check the stock of the menu item
            CheckStock();

            //disable the minus because the form starts with 1 as quantity
            DisableMinus();
        }

        private void CustomizeOrderItemPopUp()
        {
            //customize the text of the form
            CustomizeText();

            //check the stock of the order item
            CheckStock();

            //disable the update button until changes are made
            DisableUpdateButton();

            //if the quantity is 1, disable the minus
            if (orderItem.Order_Item_Quantity == 1)
                DisableMinus();
        }

        //method to customize the text
        private void CustomizeText()
        {
            //if the pop up is for an order item, customize accordingly
            if (menuItem == null)
            {
                //assign the name of the item
                textBoxItem.Text = orderItem.MenuItem.Menu_Item_Name;

                //display the quantity
                lblQuantityValue.Text = orderItem.Order_Item_Quantity.ToString();

                //display the comment
                textBoxComment.Text = orderItem.Order_Item_Comment;
            }

            //if the pop up is for a menu item, customize accordingly
            else
            {
                //assign the name of the item
                textBoxItem.Text = menuItem.Menu_Item_Name;

                //display 1 as default quantity
                lblQuantityValue.Text = "1";
            }

            //make the text box read only
            textBoxItem.ReadOnly = true;
        }

        private void DisableUpdateButton()
        {
            //disable update button and display it with a different color
            btnUpdateOrderItem.Enabled = false;
            btnUpdateOrderItem.BackColor = Color.FromArgb(190, 203, 250);
        }

        private void EnableUpdateButton()
        {
            //enable update button and change its color back to normal
            btnUpdateOrderItem.Enabled = true;
            btnUpdateOrderItem.BackColor = Color.FromArgb(24, 116, 210);
        }

        private void DisableMinus()
        {
            btnMinus.Visible = false;
        }

        private void EnableMinus()
        {
            btnMinus.Visible = true;
        }

        private void DisablePlus()
        {
            btnPlus.Visible = false;
        }

        private void EnablePlus()
        {
            btnPlus.Visible = true;
        }

        //method to check the stock
        private void CheckStock()
        {
            int itemStock = GetStock();

            //if the stock is below 10, display the restock message
            if (itemStock < 10)
                lblRestockSoon.Visible = true;
            else
                lblRestockSoon.Visible = false;
        }

        private string GetComment()
        {
            string comment;

            //if there is no custom comment, assign "N/A" as the comment
            if (textBoxComment.Text.Trim() == "")
                comment = "N/A";

            //if user entered a comment, assign it
            else
                comment = textBoxComment.Text.Trim();

            return comment;
        }

        private int GetStock()
        {
            int itemStock;

            //if menu item is not null, return its stock, else return the stock of the order item
            if (menuItem != null)
                itemStock = menuItem.Menu_Item_Stock;
            else
                itemStock = orderItem.MenuItem.Menu_Item_Stock;

            return itemStock;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            //if user clicks -, lower the quantity by 1
            int value = int.Parse(lblQuantityValue.Text);
            value--;

            lblQuantityValue.Text = value.ToString();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            //if user clicks +, raise the quantity by 1
            int value = int.Parse(lblQuantityValue.Text);
            value++;

            lblQuantityValue.Text = value.ToString();
        }

        private void pictureBoxClosePopUp_Click(object sender, EventArgs e)
        {
            //close the pop up if the X picture box is clicked
            this.Close();
        }

        private void lblQuantityValue_TextChanged(object sender, EventArgs e)
        {
            //get the quantity of the item
            int quantity = int.Parse(lblQuantityValue.Text);

            //get the amount which is in stock
            int stockValue = GetStock();

            //if the selected quantity is equal to the one in stock, disable + button
            if (quantity == stockValue)
            {
                DisablePlus();
            }

            //if the selected quantity is 1, disable - button
            else if(quantity == 1)
            {
                DisableMinus();
            }

            //else enable both buttons
            else
            {
                EnablePlus();
                EnableMinus();
            }

            //check for changes everytime the quantity changes
            CheckForChanges();
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            try
            {
                //get the quantity in the label
                int quantity = int.Parse(lblQuantityValue.Text);

                //get the comment
                string comment = GetComment();

                //get the next order id
                int nextOrderId = orderForm.GetNextOrderID();

                //create a new order item
                OrderItem orderItem = new OrderItem(nextOrderId, menuItem, quantity, comment, false);

                //if the item is not already in the order list view, add it
                if (!IsOrderItemInList(orderItem))
                {
                    //create list view item to store the order item
                    ListViewItem li = new ListViewItem(orderItem.Order_Item_Quantity.ToString());

                    //add the order item tag
                    li.Tag = orderItem;

                    li.SubItems.Add(orderItem.MenuItem.Menu_Item_Name);
                    li.SubItems.Add(orderItem.Order_Item_Comment);

                    //add the item to order list view
                    orderForm.OrderListView.Items.Add(li);

                    //enable the remove order and submit order buttons
                    orderForm.EnableButtons();
                }

                //if the item is in the list, show a pop up warning the user
                else
                {
                    MessageBox.Show("Item is already in the order.", "Warning", MessageBoxButtons.OK);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while trying to add the item to the order: " + ex.Message); //error pop up
                ErrorLogger.LogError(ex); //log the error
            }
        }

        //method to tell if an order item is already in the order
        private bool IsOrderItemInList(OrderItem orderItem)
        {
            //get all order items from the order list view
            List<OrderItem> orderItems = orderForm.GetOrderItems();

            foreach(OrderItem item in orderItems)
            {
                //if the item is already in the list, return true
                if(item.MenuItem == orderItem.MenuItem)
                    return true;
            }

            return false;
        }

        private void btnUpdateOrderItem_Click(object sender, EventArgs e)
        {
            //get the new quantity
            orderItem.Order_Item_Quantity = int.Parse(lblQuantityValue.Text);

            //get the new comment without leading or trailing white spaces
            orderItem.Order_Item_Comment = textBoxComment.Text.Trim();

            //update the order item in the order list view
            orderForm.OrderListView.SelectedItems[0].SubItems[0].Text = orderItem.Order_Item_Quantity.ToString();
            orderForm.OrderListView.SelectedItems[0].SubItems[2].Text = orderItem.Order_Item_Comment;

            this.Close();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            //get the id of the selected item
            int idOfSelectedItem = orderForm.OrderListView.SelectedItems[0].Index;

            //remove the item at that position in the order list view
            orderForm.OrderListView.Items.RemoveAt(idOfSelectedItem);

            //get the current items in the order
            List<OrderItem> orderItems = orderForm.GetOrderItems();

            //if there are no items left, disable the submit and remove order buttons
            if(orderItems.Count == 0)
                orderForm.DisableButtons();

            this.Close();
        }

        private void textBoxComment_TextChanged(object sender, EventArgs e)
        {
            //check for changes everytime the text changes
            CheckForChanges();
        }

        private void CheckForChanges()
        {
            //get the comment without leading or trailing spaces
            string comment = textBoxComment.Text.Trim();

            //get the new quantity
            int quantity = int.Parse(lblQuantityValue.Text);

            if (orderItem != null)
            {   
                //if the comment changed or the quantity changed, enable the update button
                if (comment != orderItem.Order_Item_Comment || quantity != orderItem.Order_Item_Quantity)
                    EnableUpdateButton();
                else
                    DisableUpdateButton();
            }
        }
    }
}
