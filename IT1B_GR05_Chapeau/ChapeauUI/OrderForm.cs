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
        private Panel currentPanel = new Panel();

        public OrderForm()
        {
            InitializeComponent();
            HidePanels();
            ShowPanel("Menu");
        }
        private void HidePanels()
        {
            pnlMenu.Hide();
            pnlDrinks.Hide();
            pnlSoftDrinks.Hide();
        }

        private void ShowPanel(string name)
        {
            lblBack.Show();
            switch (name)
            {
                case "Drinks":
                    pnlDrinks.Show();
                    currentPanel = pnlDrinks;
                    break;

                case "Soft drinks":
                    pnlSoftDrinks.Show();
                    currentPanel = pnlSoftDrinks;
                    break;

                default:
                    pnlMenu.Show();
                    currentPanel = pnlMenu;
                    lblBack.Hide();
                    break;
            }
        }

        private void BackToPreviousPanel(Panel panel)
        {
            HidePanels();
            if (panel == pnlDrinks)
                ShowPanel("Menu");
            else if (panel == pnlSoftDrinks)
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
        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            HidePanels();
            ShowPanel("Drinks");
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            BackToPreviousPanel(currentPanel);
        }

        private void btnSoftDrinks_Click(object sender, EventArgs e)
        {
            HidePanels();
            ShowPanel("Soft drinks");
            AddItemsToMenu(menuItemService.GetSoftDrinks());
        }
    }
}
