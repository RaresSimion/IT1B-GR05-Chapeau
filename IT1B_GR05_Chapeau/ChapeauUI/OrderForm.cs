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
        private MenuItemService menuItemService = new MenuItemService();
        private OrderItemService orderItemService = new OrderItemService();
        private OrderService orderService = new OrderService();
        private Panel currentPanel = new Panel();
        private Table currentTable;
        private Employee currentWaiter;
        private TableOverView tableOverView;

        public ListView OrderListView
        {
            get { return listViewOrder; }
        }

        /*public Label TotalValue
        {
            get { return lblTotalValue; }
        }

        public Label TotalWithVatValue
        {
            get { return lblTotalWithVATValue; }
        }*/

        public OrderForm(TableOverView tableOverView)
        {
            InitializeComponent();
            this.tableOverView = tableOverView;
            this.currentTable = tableOverView.table;
            this.currentWaiter = tableOverView.user;
            lblTable.Text = $"Table {currentTable.Table_Number}";
            ShowPanel("Menu");
            DisableButtons();
        }

        private void DisableButtons()
        {
            btnRemoveOrder.Visible = false;
            btnSubmitOrder.Visible = false;
        }

        public void EnableButtons()
        {
            btnRemoveOrder.Visible = true;
            btnSubmitOrder.Visible = true;
        }

        private void HidePanels()
        {
            pnlMenu.Hide();
            pnlDrinks.Hide();
            pnlLunch.Hide();
            pnlDinner.Hide();
            pnlSubMenu.Hide();
        }

        private void ShowPanel(string name)
        {
            HidePanels();
            lblBack.Show();
            switch (name)
            {
                case "Drinks":
                    pnlDrinks.Show();
                    currentPanel = pnlDrinks;
                    break;

                case "Lunch":
                    pnlLunch.Show();
                    currentPanel = pnlLunch;
                    break;

                case "Dinner":
                    pnlDinner.Show();
                    currentPanel = pnlDinner;
                    break;

                default:
                    pnlMenu.Show();
                    currentPanel = pnlMenu;
                    lblBack.Hide();
                    break;
            }
        }

        private void ShowSubPanel(string name)
        {
            HidePanels();
            pnlSubMenu.Show();
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
            currentPanel = pnlSubMenu;
        }

        private bool IsLunchSubmenu(string name)
        {
            return (name == "Lunch Starters" || name == "Lunch Mains" || name == "Lunch Desserts");
        }

        private bool IsDinnerSubmenu(string name)
        {
            return (name == "Dinner Starters" || name == "Dinner Entremets" || name == "Dinner Mains" || name == "Dinner Desserts");
        }


        private void BackToPreviousPanel(Panel panel)
        {
            if (panel == pnlDrinks || panel == pnlLunch || panel == pnlDinner)
                ShowPanel("Menu");
            else if (panel == pnlSubMenu && IsLunchSubmenu(textBoxSubmenu.Text))
                ShowPanel("Lunch");
            else if (panel == pnlSubMenu && IsDinnerSubmenu(textBoxSubmenu.Text))
                ShowPanel("Dinner");
            else if (panel == pnlSubMenu)
                ShowPanel("Drinks");
        }

        private void AddItemsToMenu(List<MenuItem> items)
        {
            listViewMenu.Items.Clear();
            foreach (MenuItem item in items)
            {
                ListViewItem li = new ListViewItem(item.Menu_Item_Id.ToString());
                li.Tag = item;
                li.SubItems.Add(item.Menu_Item_Name);
                li.SubItems.Add(item.Menu_Item_Stock.ToString());
                li.SubItems.Add(item.Menu_Item_Price.ToString());
                li.SubItems.Add(item.Category.ToString());

                listViewMenu.Items.Add(li);
            }
        }

        public List<OrderItem> GetOrderItems()
        {
            List<OrderItem> orderItems = new List<OrderItem>();

            foreach(ListViewItem item in listViewOrder.Items)
            {
                OrderItem orderItem = (OrderItem)item.Tag;
                orderItems.Add(orderItem);
            }
            return orderItems;
        }

        private void RemoveOrderItems()
        {
            listViewOrder.Items.Clear();
            //lblTotalValue.Text = "";
            //lblTotalWithVATValue.Text = "";
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Close();
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
            AddItemsToMenu(menuItemService.GetSubmenu(Category.SoftDrinks));
        }

        private void btnBeers_Click(object sender, EventArgs e)
        {
            ShowSubPanel("Beers");
            AddItemsToMenu(menuItemService.GetSubmenu(Category.Beers));
        }

        private void btnWines_Click(object sender, EventArgs e)
        {
            ShowSubPanel("Wines");
            AddItemsToMenu(menuItemService.GetSubmenu(Category.Wines));
        }

        private void btnSpirits_Click(object sender, EventArgs e)
        {
            ShowSubPanel("Spirits");
            AddItemsToMenu(menuItemService.GetSubmenu(Category.SpiritDrinks));
        }

        private void btnCoffeeTea_Click(object sender, EventArgs e)
        {
            ShowSubPanel("Coffee/Tea");
            AddItemsToMenu(menuItemService.GetSubmenu(Category.CoffeeTea));
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            ShowPanel("Lunch");
        }

        private void btnLunchStarters_Click(object sender, EventArgs e)
        {
            ShowSubPanel("Lunch Starters");
            AddItemsToMenu(menuItemService.GetSubmenu(Category.LunchStarters));
        }

        private void btnLunchMains_Click(object sender, EventArgs e)
        {
            ShowSubPanel("Lunch Mains");
            AddItemsToMenu(menuItemService.GetSubmenu(Category.LunchMains));
        }

        private void btnDesserts_Click(object sender, EventArgs e)
        {
            ShowSubPanel("Lunch Desserts");
            AddItemsToMenu(menuItemService.GetSubmenu(Category.LunchDesserts));
        }

        private void btnDinnerStarters_Click(object sender, EventArgs e)
        {
            ShowSubPanel("Dinner Starters");
            AddItemsToMenu(menuItemService.GetSubmenu(Category.DinnerStarters));
        }

        private void btnDinnerEntremets_Click(object sender, EventArgs e)
        {
            ShowSubPanel("Dinner Entremets");
            AddItemsToMenu(menuItemService.GetSubmenu(Category.DinnerEntremets));
        }

        private void btnDinnerMains_Click(object sender, EventArgs e)
        {
            ShowSubPanel("Dinner Mains");
            AddItemsToMenu(menuItemService.GetSubmenu(Category.DinnerMains));
        }

        private void btnDinnerDesserts_Click(object sender, EventArgs e)
        {
            ShowSubPanel("Dinner Desserts");
            AddItemsToMenu(menuItemService.GetSubmenu(Category.DinnerDesserts));
        }

        private void btnDinner_Click(object sender, EventArgs e)
        {
            ShowPanel("Dinner");
        }

        private void listViewMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewMenu.SelectedItems.Count > 0)
            {
                MenuItem menuItem = (MenuItem)listViewMenu.SelectedItems[0].Tag;

                MenuItemPopUp menuItemPopUp = new MenuItemPopUp(menuItem, this);
                menuItemPopUp.ShowDialog();
            }
        }

        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            List<OrderItem> orderItems = GetOrderItems();
            foreach(OrderItem item in orderItems)
            {
                orderItemService.InsertOrderItem(item);
                menuItemService.UpdateMenuItemStock(item);
            }

           // Table table = new Table(1, false); //replace with current table
            //Employee employee = new Employee(1, "barry", EmployeeRole.Waiter, "1234"); //replace with current waiter

            Order order = new Order(orderItems, currentTable, currentWaiter, OrderStatus.Ordered, false, DateTime.Now);
            orderService.InsertOrder(order);

            RemoveOrderItems();
            MessageBox.Show("Order successfully submitted, press OK to go back to Table View", "Order", MessageBoxButtons.OK);
            this.Close();
            tableOverView.Show();
        }

        private void btnRemoveOrder_Click(object sender, EventArgs e)
        {
            RemoveOrderItems();
            DisableButtons();
        }

        private void listViewOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewOrder.SelectedItems.Count > 0)
            {
                OrderItem orderItem = (OrderItem)listViewOrder.SelectedItems[0].Tag;

                MenuItemPopUp orderItemPopUp = new MenuItemPopUp(orderItem, this);
                orderItemPopUp.ShowDialog();
            }
        }
    }
}
