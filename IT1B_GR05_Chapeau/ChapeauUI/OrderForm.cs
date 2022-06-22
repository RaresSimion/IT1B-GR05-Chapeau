using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauLogic;
using ChapeauModel;

namespace ChapeauUI
{
    public partial class OrderForm : Form
    {
        //menu item service for menu items
        private MenuItemService menuItemService = new MenuItemService();

        //order item service for order items
        private OrderItemService orderItemService = new OrderItemService();

        //order service for orders
        private OrderService orderService = new OrderService();

        //storing the current panel in order to know to which panel to go back to
        private Panel currentPanel = new Panel();

        //storing the table that was clicked in tableView
        private Table currentTable;

        //storing the waiter who is logged in
        private Employee currentWaiter;

        //storing the tableView in order to show it after closing 
        private TableOverView tableOverView;

        //property to pass the order list view to the item pop up
        public ListView OrderListView
        {
            get { return listViewOrder; }
        }

        //constructor
        public OrderForm(TableOverView tableOverView)
        {
            InitializeComponent();
            this.tableOverView = tableOverView;
            this.currentTable = tableOverView.table;
            this.currentWaiter = tableOverView.user;

            //insert the table number and order number in the labels
            lblTable.Text = $"Table {currentTable.Table_Number}";
            string orderID = GetNextOrderID().ToString();
            string shortOrderID;
            if (GetNextOrderID() < 10)
                shortOrderID = orderID;
            else
                shortOrderID = orderID.Substring(orderID.Length - 2);

            lblOrder.Text = $"Order {shortOrderID}";

            //show the menu
            ShowPanel("Menu");

            //disable buttons
            DisableButtons();
        }

        //get the id of the next order
        public int GetNextOrderID()
        {
            int lastOrderID = orderService.GetLastOrderID();
            int nextOrderID = lastOrderID + 1;
            return nextOrderID;
        }

        //disable the remove order and submit order buttons
        public void DisableButtons()
        {
            btnRemoveOrder.Visible = false;
            btnSubmitOrder.Visible = false;
        }

        //enable the remove order and submit order buttons
        public void EnableButtons()
        {
            btnRemoveOrder.Visible = true;
            btnSubmitOrder.Visible = true;
        }

        //hide the panels
        private void HidePanels()
        {
            pnlMenu.Hide();
            pnlDrinks.Hide();
            pnlLunch.Hide();
            pnlDinner.Hide();
            pnlSubMenu.Hide();
        }

        //show panel depending on the name
        private void ShowPanel(string name)
        {
            //hide the panels
            HidePanels();

            //show the back label
            lblBack.Show();
            switch (name)
            {
                //if name is drinks then show the drinks panel
                case "Drinks":
                    pnlDrinks.Show();
                    currentPanel = pnlDrinks; //store the drinks panel in currentPanel
                    break;

                //if name is drinks then show the lunch panel
                case "Lunch":
                    pnlLunch.Show();
                    currentPanel = pnlLunch; //store the lunch panel in currentPanel
                    break;

                //if name is dinner then show the dinner panel
                case "Dinner":
                    pnlDinner.Show();
                    currentPanel = pnlDinner; //store the dinner panel in currentPanel
                    break;

                //if the name is different show the menu
                default:
                    pnlMenu.Show();
                    currentPanel = pnlMenu; //store the menu panel in currentPanel
                    lblBack.Hide();
                    break;
            }
        }

        //method to show the sub panel (starters, mains, etc)
        private void ShowSubPanel(string name)
        {
            //hide panels
            HidePanels();

            //show the submenu
            pnlSubMenu.Show();

            //depending on the name, change the title
            switch (name)
            {
                case "Soft drinks":
                    textBoxSubmenu.Text = "Soft drinks";
                    break;

                case "Beers":
                    textBoxSubmenu.Text = "Beers";
                    break;

                case "Wines":
                    textBoxSubmenu.Text = "Wines";
                    break;

                case "Spirits":
                    textBoxSubmenu.Text = "Spirits";
                    break;

                case "Coffee/Tea":
                    textBoxSubmenu.Text = "Coffee/Tea";
                    break;

                case "Lunch Starters":
                    textBoxSubmenu.Text = "Lunch Starters";
                    break;

                case "Lunch Mains":
                    textBoxSubmenu.Text = "Lunch Mains";
                    break;

                case "Lunch Desserts":
                    textBoxSubmenu.Text = "Lunch Desserts";
                    break;

                case "Dinner Starters":
                    textBoxSubmenu.Text = "Dinner Starters";
                    break;

                case "Dinner Entremets":
                    textBoxSubmenu.Text = "Dinner Entremets";
                    break;

                case "Dinner Mains":
                    textBoxSubmenu.Text = "Dinner Mains";
                    break;

                case "Dinner Desserts":
                    textBoxSubmenu.Text = "Dinner Desserts";
                    break;

                default:
                    break;
            }
            currentPanel = pnlSubMenu; //store the submenu panel in the current panel
        }

        //method to check if the submenu is from the lunch category
        private bool IsLunchSubmenu(string name)
        {
            return (name == "Lunch Starters" || name == "Lunch Mains" || name == "Lunch Desserts");
        }

        //method to check if the submenu is from the dinner category
        private bool IsDinnerSubmenu(string name)
        {
            return (name == "Dinner Starters" || name == "Dinner Entremets" || name == "Dinner Mains" || name == "Dinner Desserts");
        }

        //method to choose which panel the back label goes to
        private void BackToPreviousPanel(Panel panel)
        {
            //if panel is drinks/lunch/dinner go back to menu
            if (panel == pnlDrinks || panel == pnlLunch || panel == pnlDinner)
                ShowPanel("Menu");

            //if panel is lunch submenu go back to lunch
            else if (panel == pnlSubMenu && IsLunchSubmenu(textBoxSubmenu.Text))
                ShowPanel("Lunch");

            //if panel is dinner submenu go back to dinner
            else if (panel == pnlSubMenu && IsDinnerSubmenu(textBoxSubmenu.Text))
                ShowPanel("Dinner");

            //the only option left is drink submenu so go back to drinks
            else if (panel == pnlSubMenu)
                ShowPanel("Drinks");
        }

        //method to add the items in the list to the menu list view
        private void AddItemsToMenu(List<MenuItem> items)
        {
            //remove old items
            RemoveMenuItems();

            try
            {
                foreach (MenuItem item in items)
                {
                    //if an item is no longer in stock, dont show it
                    if (item.Menu_Item_Stock == 0)
                        continue;

                    //create a list view item for each menu item
                    ListViewItem li = new ListViewItem(item.Menu_Item_Id.ToString());
                    li.Tag = item; //add the menu item tag
                    li.SubItems.Add(item.Menu_Item_Name);
                    li.SubItems.Add(item.Menu_Item_Stock.ToString());
                    li.SubItems.Add(item.Menu_Item_Price.ToString());
                    li.SubItems.Add(item.Category.ToString());

                    //get the stock of the menu item
                    int itemStock = menuItemService.GetStockOfMenuItem(item);

                    //if the stock is lower than 10, make the list view item have an orange backgroud
                    if (itemStock < 10)
                        li.BackColor = Color.FromArgb(253, 102, 0);

                    //add the item to the menu list view
                    listViewMenu.Items.Add(li);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while loading the menu: " + ex.Message); //error pop up
                ErrorLogger.LogError(ex); //log the error
            }
        }

        //method to get all order items from inside the order list view
        public List<OrderItem> GetOrderItems()
        {
            //create list to store order items
            List<OrderItem> orderItems = new List<OrderItem>();

            foreach(ListViewItem item in listViewOrder.Items)
            {
                //convert each list view item to order item
                OrderItem orderItem = (OrderItem)item.Tag;

                //add item to list
                orderItems.Add(orderItem);
            }
            return orderItems;
        }

        //method to remove the order items from the order list view
        private void RemoveOrderItems()
        {
            listViewOrder.Items.Clear();
        }

        //method to remove the menu items from the menu list view
        private void RemoveMenuItems()
        {
            listViewMenu.Items.Clear();
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            //close the order form
            this.Close();

            //show the table view form
            tableOverView.Show();
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            ShowPanel("Drinks");
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            BackToPreviousPanel(currentPanel);
        }

        private void btnSoftDrinks_Click(object sender, EventArgs e)
        {
            ShowSubPanel("Soft drinks");

            //add soft drinks to menu
            try
            {
                AddItemsToMenu(menuItemService.GetSubmenu(Category.SoftDrinks));
            }
            catch (Exception ex)
            {

                MessageBox.Show("Something went wrong while displaying the soft drinks: " + ex.Message); //error pop up
                ErrorLogger.LogError(ex);
                ShowPanel("Menu");
            }
        }

        private void btnBeers_Click(object sender, EventArgs e)
        {
            ShowSubPanel("Beers");

            //add beers to menu
            try
            {
                AddItemsToMenu(menuItemService.GetSubmenu(Category.Beers));
            }
            catch (Exception ex)
            {

                MessageBox.Show("Something went wrong while displaying the beers: " + ex.Message); //error pop up
                ErrorLogger.LogError(ex);
                ShowPanel("Menu");
            }
        }

        private void btnWines_Click(object sender, EventArgs e)
        {
            ShowSubPanel("Wines");

            //add wines to menu
            try
            {
                AddItemsToMenu(menuItemService.GetSubmenu(Category.Wines));
            }
            catch (Exception ex)
            {

                MessageBox.Show("Something went wrong while displaying the wines: " + ex.Message); //error pop up
                ErrorLogger.LogError(ex);
                ShowPanel("Menu");
            }
        }

        private void btnSpirits_Click(object sender, EventArgs e)
        {
            ShowSubPanel("Spirits");

            //add spirits to menu
            try
            {
                AddItemsToMenu(menuItemService.GetSubmenu(Category.SpiritDrinks));
            }
            catch (Exception ex)
            {

                MessageBox.Show("Something went wrong while displaying the spirits: " + ex.Message); //error pop up
                ErrorLogger.LogError(ex);
                ShowPanel("Menu");
            }
        }

        private void btnCoffeeTea_Click(object sender, EventArgs e)
        {
            ShowSubPanel("Coffee/Tea");

            //add coffee/tea to menu
            try
            {
                AddItemsToMenu(menuItemService.GetSubmenu(Category.CoffeeTea));
            }
            catch (Exception ex)
            {

                MessageBox.Show("Something went wrong while displaying the coffee/tea: " + ex.Message); //error pop up
                ErrorLogger.LogError(ex);
                ShowPanel("Menu");
            }
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            ShowPanel("Lunch");
        }

        private void btnLunchStarters_Click(object sender, EventArgs e)
        {
            ShowSubPanel("Lunch Starters");

            //add lunch starters to menu
            try
            {
                AddItemsToMenu(menuItemService.GetSubmenu(Category.LunchStarters));
            }
            catch (Exception ex)
            {

                MessageBox.Show("Something went wrong while displaying the lunch starters: " + ex.Message); //error pop up
                ErrorLogger.LogError(ex);
                ShowPanel("Menu");
            }
        }

        private void btnLunchMains_Click(object sender, EventArgs e)
        {
            ShowSubPanel("Lunch Mains");

            //add lunch mains to menu
            try
            {
                AddItemsToMenu(menuItemService.GetSubmenu(Category.LunchMains));
            }
            catch (Exception ex)
            {

                MessageBox.Show("Something went wrong while displaying the lunch mains: " + ex.Message); //error pop up
                ErrorLogger.LogError(ex);
                ShowPanel("Menu");
            }
        }

        private void btnDesserts_Click(object sender, EventArgs e)
        {
            ShowSubPanel("Lunch Desserts");

            //add lunch desserts to menu
            try
            {
                AddItemsToMenu(menuItemService.GetSubmenu(Category.LunchDesserts));
            }
            catch (Exception ex)
            {

                MessageBox.Show("Something went wrong while displaying the lunch desserts: " + ex.Message); //error pop up
                ErrorLogger.LogError(ex);
                ShowPanel("Menu");
            }
        }

        private void btnDinnerStarters_Click(object sender, EventArgs e)
        {
            ShowSubPanel("Dinner Starters");

            //add dinner starters to menu
            try
            {
                AddItemsToMenu(menuItemService.GetSubmenu(Category.DinnerStarters));
            }
            catch (Exception ex)
            {

                MessageBox.Show("Something went wrong while displaying the dinner starters: " + ex.Message); //error pop up
                ErrorLogger.LogError(ex);
                ShowPanel("Menu");
            }
        }

        private void btnDinnerEntremets_Click(object sender, EventArgs e)
        {
            ShowSubPanel("Dinner Entremets");

            //add dinner entremets to menu
            try
            {
                AddItemsToMenu(menuItemService.GetSubmenu(Category.DinnerEntremets));
            }
            catch (Exception ex)
            {

                MessageBox.Show("Something went wrong while displaying the dinner entremets: " + ex.Message); //error pop up
                ErrorLogger.LogError(ex);
                ShowPanel("Menu");
            }
        }

        private void btnDinnerMains_Click(object sender, EventArgs e)
        {
            ShowSubPanel("Dinner Mains");

            //add dinner mains to menu
            try
            {
                AddItemsToMenu(menuItemService.GetSubmenu(Category.DinnerMains));
            }
            catch (Exception ex)
            {

                MessageBox.Show("Something went wrong while displaying the dinner mains: " + ex.Message); //error pop up
                ErrorLogger.LogError(ex);
                ShowPanel("Menu");
            }
        }

        private void btnDinnerDesserts_Click(object sender, EventArgs e)
        {
            ShowSubPanel("Dinner Desserts");

            //add dinner desserts to menu
            try
            {
                AddItemsToMenu(menuItemService.GetSubmenu(Category.DinnerDesserts));
            }
            catch (Exception ex)
            {

                MessageBox.Show("Something went wrong while displaying the dinner desserts: " + ex.Message); //error pop up
                ErrorLogger.LogError(ex);
                ShowPanel("Menu");
            }
        }

        private void btnDinner_Click(object sender, EventArgs e)
        {
            ShowPanel("Dinner");
        }

        private void listViewMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listViewMenu.SelectedItems.Count > 0)
            {
                //get the selected menu item
                MenuItem menuItem = (MenuItem)listViewMenu.SelectedItems[0].Tag;

                //create a pop-up to select quantity and add comment
                MenuItemPopUp menuItemPopUp = new MenuItemPopUp(menuItem, this);

                //show the pop-up as a dialog
                menuItemPopUp.ShowDialog();
            }
            else
            {
                return;
            }
        }

        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            //get the order items in the order
            List<OrderItem> orderItems = GetOrderItems();

            //create a new order containing the order items, the table, the waiter who took the order, the status 'ordered',
            //false because the order is not paid and the time at which the order was taken
            Order order = new Order(orderItems, currentTable, currentWaiter, OrderStatus.Ordered, false, DateTime.Now);

            try
            {
                //insert the order in the database
                orderService.InsertOrder(order);

                foreach (OrderItem item in orderItems)
                {
                    //insert the order items in the database
                    orderItemService.InsertOrderItem(item);

                    //update the stock
                    menuItemService.UpdateMenuItemStock(item);
                }

                //remove order items from the list view 
                RemoveOrderItems();

                //show a message to confirm the order
                MessageBox.Show("Order successfully submitted, press OK to go back to Table View", "Order", MessageBoxButtons.OK);
                
                //close the order form
                this.Close();

                //show the table view
                tableOverView.Show();
                tableOverView.HidePanels();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while inserting the order: " + ex.Message); //error pop up
                ErrorLogger.LogError(ex); //log the error
            }
        }

        private void btnRemoveOrder_Click(object sender, EventArgs e)
        {
            //remove order items from order list view
            RemoveOrderItems();

            //disable the buttons
            DisableButtons();
        }

        private void listViewOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewOrder.SelectedItems.Count > 0)
            {
                //get the selected order item
                OrderItem orderItem = (OrderItem)listViewOrder.SelectedItems[0].Tag;

                //create a pop-up to apply changes
                MenuItemPopUp orderItemPopUp = new MenuItemPopUp(orderItem, this);

                //show the pop-up as a dialog
                orderItemPopUp.ShowDialog();
            }
            else
            {
                return;
            }
        }
    }
}
