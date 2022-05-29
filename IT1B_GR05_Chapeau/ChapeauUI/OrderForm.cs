﻿using System;
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
        private Panel currentPanel = new Panel();

        public ListView OrderListView
        {
            get { return listViewOrder; }
        }

        public OrderForm()
        {
            InitializeComponent();
            ShowPanel("Menu");
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
            HidePanels();
            if (panel == pnlDrinks || panel == pnlLunch)
                ShowPanel("Menu");
            else if (panel == pnlSubMenu && IsLunchSubmenu(textBoxSubmenu.Text))
                ShowPanel("Lunch");
            else if (panel == pnlSubMenu && IsDinnerSubmenu(textBoxSubmenu.Text))
                ShowPanel("Dinner");
            else
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
                li.SubItems.Add(item.Category_Id.ToString());

                listViewMenu.Items.Add(li);
            }
        }

        private List<OrderItem> GetOrderItems()
        {
            List<OrderItem> orderItems = new List<OrderItem>();

            foreach(ListViewItem item in listViewOrder.Items)
            {
                OrderItem orderItem = (OrderItem)item.Tag;
                orderItems.Add(orderItem);
            }
            return orderItems;
        }
        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Close();
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
            AddItemsToMenu(menuItemService.GetSoftDrinks());
        }

        private void btnBeers_Click(object sender, EventArgs e)
        {
            ShowSubPanel("Beers");
            AddItemsToMenu(menuItemService.GetBeers());
        }

        private void btnWines_Click(object sender, EventArgs e)
        {
            ShowSubPanel("Wines");
            AddItemsToMenu(menuItemService.GetWines());
        }

        private void btnSpirits_Click(object sender, EventArgs e)
        {
            ShowSubPanel("Spirits");
            AddItemsToMenu(menuItemService.GetSpiritDrinks());
        }

        private void btnCoffeeTea_Click(object sender, EventArgs e)
        {
            ShowSubPanel("Coffee/Tea");
            AddItemsToMenu(menuItemService.GetCoffeeTea());
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            ShowPanel("Lunch");
        }

        private void btnLunchStarters_Click(object sender, EventArgs e)
        {
            ShowSubPanel("Lunch Starters");
            AddItemsToMenu(menuItemService.GetLunchStarters());
        }

        private void btnLunchMains_Click(object sender, EventArgs e)
        {
            ShowSubPanel("Lunch Mains");
            AddItemsToMenu(menuItemService.GetLunchMains());
        }

        private void btnDesserts_Click(object sender, EventArgs e)
        {
            ShowSubPanel("Lunch Desserts");
            AddItemsToMenu(menuItemService.GetLunchDesserts());
        }

        private void btnDinnerStarters_Click(object sender, EventArgs e)
        {
            ShowSubPanel("Dinner Starters");
            AddItemsToMenu(menuItemService.GetDinnerStarters());
        }

        private void btnDinnerEntremets_Click(object sender, EventArgs e)
        {
            ShowSubPanel("Dinner Entremets");
            AddItemsToMenu(menuItemService.GetDinnerEntremets());
        }

        private void btnDinnerMains_Click(object sender, EventArgs e)
        {
            ShowSubPanel("Dinner Mains");
            AddItemsToMenu(menuItemService.GetDinnerMains());
        }

        private void btnDinnerDesserts_Click(object sender, EventArgs e)
        {
            ShowSubPanel("Dinner Desserts");
            AddItemsToMenu(menuItemService.GetDinnerDesserts());
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
            }
        }
    }
}
