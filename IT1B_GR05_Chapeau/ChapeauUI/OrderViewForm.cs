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
    public partial class OrderViewForm : Form
    {
        private MenuItemService menuService = new MenuItemService();
        private bool HamburgerEnabled = false;
        public OrderViewForm()
        {
            InitializeComponent();
            DisplayMenu();
            HideSubPanels();
        }

        public ListView OrderList
        {
            get { return listViewOrder; }
            set { ; }
        }

        private void btnHamburgerMenu_Click(object sender, EventArgs e)
        {
            if (HamburgerEnabled == true)
            {
                pnlHamburgerMenu.Visible = false;
                HamburgerEnabled = false;
            }
            else
            {
                pnlHamburgerMenu.Visible = true;
                HamburgerEnabled = true;
            }
        }

        private void DisplayMenu()
        {
            GenerateMenu();
        }

        private void GenerateMenu()
        {
            List<MenuItem> menu = menuService.GetMenu();
            listViewMenu.Items.Clear();

            foreach(MenuItem item in menu)
            {
                ListViewItem listItem = new ListViewItem(item.Menu_Item_Id.ToString());
                listItem.SubItems.Add(item.Menu_Item_Name);
                listItem.Tag = item;

                listViewMenu.Items.Add(listItem);
            }
        }

        private void GenerateSubmenu(string name)
        {
            List<MenuItem> items = GetItems(name);
            listViewMenu.Items.Clear();
            foreach(MenuItem item in items)
            {
                ListViewItem listItem = new ListViewItem(item.Menu_Item_Id.ToString());
                listItem.SubItems.Add(item.Menu_Item_Name);
                listItem.Tag = item;

                listViewMenu.Items.Add(listItem);
            }
        }

        private List<MenuItem> GetItems(string name)
        {
            List<MenuItem> items = new List<MenuItem>();
            if (name == "Drinks")
                items = menuService.GetDrinks();
            else if (name == "Soft drinks")
                items = menuService.GetSoftDrinks();
            else if (name == "Beers")
                items = menuService.GetBeers();
            else if (name == "Wines")
                items = menuService.GetWines();
            else if (name == "Spirit drinks")
                items = menuService.GetSpiritDrinks();
            else if (name == "Coffee/Tea")
                items = menuService.GetCoffeeTea();
            else if (name == "Lunch")
                items = menuService.GetLunchItems();
            else if (name == "Lunch starters")
                items = menuService.GetLunchStarters();
            else if (name == "Lunch mains")
                items = menuService.GetLunchMains();
            else if (name == "Lunch desserts")
                items = menuService.GetLunchDesserts();
            else if (name == "Dinner")
                items = menuService.GetDinnerItems();
            else if (name == "Dinner starters")
                items = menuService.GetDinnerStarters();
            else if (name == "Dinner entremets")
                items = menuService.GetDinnerEntremets();
            else if (name == "Dinner mains")
                items = menuService.GetDinnerMains();
            else if (name == "Dinner desserts")
                items = menuService.GetDinnerDesserts();

            return items;
        }

        private void HideSubPanels()
        {
            pnlHamburgerMenu.Visible = false;
            pnlSubDrinks.Visible = false;
            pnlSubLunch.Visible = false;
            pnlSubDinner.Visible = false;
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            HideSubPanels();
            pnlSubDrinks.Visible = true;
            GenerateSubmenu(btnDrinks.Text);
        }

        private void btnSoftDrinks_Click(object sender, EventArgs e)
        {
            GenerateSubmenu(btnSoftDrinks.Text);
        }

        private void btnBeers_Click(object sender, EventArgs e)
        {
            GenerateSubmenu(btnBeers.Text);
        }

        private void btnWines_Click(object sender, EventArgs e)
        {
            GenerateSubmenu(btnWines.Text);
        }

        private void btnSpiritDrinks_Click(object sender, EventArgs e)
        {
            GenerateSubmenu(btnSpiritDrinks.Text);
        }

        private void btnCoffeeTea_Click(object sender, EventArgs e)
        {
            GenerateSubmenu(btnCoffeeTea.Text);
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            HideSubPanels();
            pnlSubLunch.Visible = true;
            GenerateSubmenu(btnLunch.Text);
        }

        private void btnLunchStarters_Click(object sender, EventArgs e)
        {
            GenerateSubmenu(btnLunchStarters.Text);
        }

        private void btnLunchMains_Click(object sender, EventArgs e)
        {
            GenerateSubmenu(btnLunchMains.Text);
        }

        private void btnLunchDesserts_Click(object sender, EventArgs e)
        {
            GenerateSubmenu(btnLunchDesserts.Text);
        }

        private void btnDinner_Click(object sender, EventArgs e)
        {
            HideSubPanels();
            pnlSubDinner.Visible = true;
            GenerateSubmenu(btnDinner.Text);

        }

        private void btnDinnerStarters_Click(object sender, EventArgs e)
        {
            GenerateSubmenu(btnDinnerStarters.Text);
        }

        private void btnDinnerEntremets_Click(object sender, EventArgs e)
        {
            GenerateSubmenu(btnDinnerEntremets.Text);
        }

        private void btnDinnerMains_Click(object sender, EventArgs e)
        {
            GenerateSubmenu(btnDinnerMains.Text);
        }

        private void btnDinnerDesserts_Click(object sender, EventArgs e)
        {
            GenerateSubmenu(btnDinnerDesserts.Text);
        }

        private void listViewMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewMenu.SelectedItems.Count > 0)
            {
                int itemID = int.Parse(listViewMenu.SelectedItems[0].SubItems[0].Text);
                MenuItem menuItem = menuService.GetMenuItemByID(itemID);

                MenuItemPopUp menuItemPopUp = new MenuItemPopUp(menuItem, this);
                menuItemPopUp.ShowDialog();
            }
        }

        private void btnRemoveOrder_Click(object sender, EventArgs e)
        {
            listViewOrder.Items.Clear();
        }
    }
}
