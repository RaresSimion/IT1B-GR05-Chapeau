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
using ChapeauUI.Properties;

namespace ChapeauUI
{
    public partial class TableOverView : Form
    {
        public Table table = new Table();
        public Employee user = new Employee();
        private TableService tableService = new TableService();
        private List<Table> tables = new List<Table>();
        private List<OrderItem> orderedItems = new List<OrderItem>();
        private OrderItemService OrderItemService = new OrderItemService();
        private OrderService orderService = new OrderService();
        private List<Order> orders = new List<Order>();

        public TableOverView(Employee employee)
        {
            InitializeComponent();
            // gets the user 
            this.user = employee;
            
            //this gets all the tables. necessary to get the table availability status to determine the availability and show it on the buttons below
            tables = tableService.GetTables();

            //gets a list of all the ordered items on a specific table 
            orderedItems = OrderItemService.GetAllOrderItemsFromTable(table);

            //gets orders by table number
            orders = orderService.GetOrdersByTableId(table.Table_Number);

            //This switch statement determains the image on each table button. This shows if the table is available or occupied. 
            foreach (Table table in tables)
                switch (table.Table_Number)
                {

                    case 1:
                        if (table.Table_Availability)
                            buttonTable1.Image = Resources.Table_1_Occupied;
                        else
                            buttonTable1.Image = Resources.Table_1;
                        break;

                    case 2:
                        if (table.Table_Availability)
                            buttonTable2.Image = Resources.Table_2_Occupied;
                        else
                            buttonTable2.Image = Resources.Table_2;
                        break;
                    case 3:
                        if (table.Table_Availability)
                            buttonTable3.Image = Resources.Table_3_Occupied;
                        else
                            buttonTable3.Image = Resources.Table_3;
                        break;
                    case 4:
                        if (table.Table_Availability)
                            buttonTable4.Image = Resources.Table_4_Occupied;
                        else
                            buttonTable4.Image = Resources.Table_4;
                        break;
                    case 5:
                        if (table.Table_Availability)
                            buttonTable5.Image = Resources.Table_5_Occupied;
                        else
                            buttonTable5.Image = Resources.Table_5;
                        break;
                    case 6:
                        if (table.Table_Availability)
                            buttonTable6.Image = Resources.Table_6;
                        else
                            buttonTable6.Image = Resources.Table_6_Unoccupied;
                        break;
                    case 7:
                        if (table.Table_Availability)
                            buttonTable7.Image = Resources.Table_7_Occupied;
                        else
                            buttonTable7.Image = Resources.Table_7;
                        break;
                    case 8:
                        if (table.Table_Availability)
                            buttonTable8.Image = Resources.Table_8_Occupied;
                        else
                            buttonTable8.Image = Resources.Table_8;
                        break;
                    case 9:
                        if (table.Table_Availability)
                            buttonTable9.Image = Resources.Table_9_Occupied;
                        else
                            buttonTable9.Image = Resources.Table_9;
                        break;
                    case 10:
                        if (table.Table_Availability)
                            buttonTable10.Image = Resources.Table_10_Occupied;
                        else
                            buttonTable10.Image = Resources.Table_10;
                        break;
                }
        }

        private void TableOverView_Load(object sender, EventArgs e)
        {
            //hides all the panels when the form loads
            panelNoOrder.Hide();
            panelMakeOrder.Hide();
            panelCreateOrderViewBill.Hide();
            panelOrderStatus.Hide();
            labelUser.Text = $"{user.Employee_Name}";
        }

        //method that hides all the panels
        public void HidePanels()
        {
            panelCreateOrderViewBill.Hide();
            panelMakeOrder.Hide();
            panelNoOrder.Hide();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void buttonTable1_Click(object sender, EventArgs e)
        {
            //gets table number from table service and feeds the info to the table
            table = tableService.GetTable(1);
            labelTableNumber.Text = $"Table #{table.Table_Number}";
            labelTableNumberCreateOrder1.Text = $"Table #{table.Table_Number}";
            labelTableNumberCreateOrderViewBill.Text = $"Table #{table.Table_Number}";
            //gets all order items for this table
            List<OrderItem> orderedItems = OrderItemService.GetAllOrderItemsFromTable(table);
            PanelUpdater(table, orderedItems);
        }

        private void buttonTable2_Click(object sender, EventArgs e)
        {
            table = tableService.GetTable(2);
            labelTableNumber.Text = $"Table #{table.Table_Number}";
            labelTableNumberCreateOrder1.Text = $"Table #{table.Table_Number}";
            labelTableNumberCreateOrderViewBill.Text = $"Table #{table.Table_Number}";
            List<OrderItem> orderedItems = OrderItemService.GetAllOrderItemsFromTable(table);
            PanelUpdater(table, orderedItems);
        }

        private void buttonTable3_Click(object sender, EventArgs e)
        {
            table = tableService.GetTable(3);
            labelTableNumber.Text = $"Table #{table.Table_Number}";
            labelTableNumberCreateOrder1.Text = $"Table #{table.Table_Number}";
            labelTableNumberCreateOrderViewBill.Text = $"Table #{table.Table_Number}";
            List<OrderItem> orderedItems = OrderItemService.GetAllOrderItemsFromTable(table);
            PanelUpdater(table, orderedItems);
        }

        private void buttonTable4_Click(object sender, EventArgs e)
        {
            table = tableService.GetTable(4);
            labelTableNumber.Text = $"Table #{table.Table_Number}";
            labelTableNumberCreateOrder1.Text = $"Table #{table.Table_Number}";
            labelTableNumberCreateOrderViewBill.Text = $"Table #{table.Table_Number}";
            List<OrderItem> orderedItems = OrderItemService.GetAllOrderItemsFromTable(table);
            PanelUpdater(table, orderedItems);
        }

        private void buttonTable5_Click(object sender, EventArgs e)
        {
            table = tableService.GetTable(5);
            labelTableNumber.Text = $"Table #{table.Table_Number}";
            labelTableNumberCreateOrder1.Text = $"Table #{table.Table_Number}";
            labelTableNumberCreateOrderViewBill.Text = $"Table #{table.Table_Number}";
            List<OrderItem> orderedItems = OrderItemService.GetAllOrderItemsFromTable(table);
            PanelUpdater(table, orderedItems);
        }

        private void buttonTable6_Click(object sender, EventArgs e)
        {
            table = tableService.GetTable(6);
            labelTableNumber.Text = $"Table #{table.Table_Number}";
            labelTableNumberCreateOrder1.Text = $"Table #{table.Table_Number}";
            labelTableNumberCreateOrderViewBill.Text = $"Table #{table.Table_Number}";
            List<OrderItem> orderedItems = OrderItemService.GetAllOrderItemsFromTable(table);
            PanelUpdater(table, orderedItems);
        }

        private void buttonTable7_Click(object sender, EventArgs e)
        {
            table = tableService.GetTable(7);
            labelTableNumber.Text = $"Table #{table.Table_Number}";
            labelTableNumberCreateOrder1.Text = $"Table #{table.Table_Number}";
            labelTableNumberCreateOrderViewBill.Text = $"Table #{table.Table_Number}";
            List<OrderItem> orderedItems = OrderItemService.GetAllOrderItemsFromTable(table);
            PanelUpdater(table, orderedItems);
        }

        private void buttonTable8_Click(object sender, EventArgs e)
        {
            table = tableService.GetTable(8);
            labelTableNumber.Text = $"Table #{table.Table_Number}";
            labelTableNumberCreateOrder1.Text = $"Table #{table.Table_Number}";
            labelTableNumberCreateOrderViewBill.Text = $"Table #{table.Table_Number}";
            List<OrderItem> orderedItems = OrderItemService.GetAllOrderItemsFromTable(table);
            PanelUpdater(table, orderedItems);

        }

        private void buttonTable9_Click(object sender, EventArgs e)
        {
            table = tableService.GetTable(9);
            labelTableNumber.Text = $"Table #{table.Table_Number}";
            labelTableNumberCreateOrder1.Text = $"Table #{table.Table_Number}";
            labelTableNumberCreateOrderViewBill.Text = $"Table #{table.Table_Number}";
            List<OrderItem> orderedItems = OrderItemService.GetAllOrderItemsFromTable(table);
            PanelUpdater(table, orderedItems);
        }

        private void buttonTable10_Click(object sender, EventArgs e)
        {
            table = tableService.GetTable(10);
            labelTableNumber.Text = $"Table #{table.Table_Number}";
            labelTableNumberCreateOrder1.Text = $"Table #{table.Table_Number}";
            labelTableNumberCreateOrderViewBill.Text = $"Table #{table.Table_Number}";
            List<OrderItem> orderedItems = OrderItemService.GetAllOrderItemsFromTable(table);
            PanelUpdater(table, orderedItems);
        }

        //this function is used to choose the right panel to display when the user clicks on a table
        //firstly it hides all the panels.
        //if the table is available it shows panel to seat guests
        //if the table is not available, the function determines if the table has one (or more) order items on it already
        //if the table has one or more order items on it, the function shows a panel that says the table has an order already, and would user like to make another order or view the bill
        //if the table has no order items on it, panel displays asking user if they want to create an order
        private void PanelUpdater(Table table, List<OrderItem> orderedItems)
        {
            HidePanels();

            if (!table.Table_Availability)
                panelNoOrder.Show();
            else if (table.Table_Availability)
            {
                if (orderedItems.Count > 0)
                    panelCreateOrderViewBill.Show();
                else
                    panelMakeOrder.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelMakeOrder.Hide();
        }

        private void buttonReturnToTableView_Click(object sender, EventArgs e)
        {
            panelNoOrder.Hide();
        }
        //this switch statement changes the table availability on a table. it also changes the image.
        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            table.Table_Availability = true;
            tableService.UpdateTable(table);
            switch (table.Table_Number)
            {

                case 1:
                    buttonTable1.Image = Resources.Table_1_Occupied;
                    break;
                case 2:
                    buttonTable2.Image = Resources.Table_2_Occupied;
                    break;
                case 3:
                    buttonTable3.Image = Resources.Table_3_Occupied;
                    break;
                case 4:
                    buttonTable4.Image = Resources.Table_4_Occupied;
                    break;
                case 5:
                    buttonTable5.Image = Resources.Table_5_Occupied;
                    break;
                case 6:
                    buttonTable6.Image = Resources.Table_6;
                    break;
                case 7:
                    buttonTable7.Image = Resources.Table_7_Occupied;
                    break;
                case 8:
                    buttonTable8.Image = Resources.Table_8_Occupied;
                    break;
                case 9:
                    buttonTable9.Image = Resources.Table_9_Occupied;
                    break;
                case 10:
                    buttonTable10.Image = Resources.Table_10_Occupied;
                    break;
            }
            panelNoOrder.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }



        private void buttonCreateOrderAgain_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm(this);
            panelNoOrder.Hide();
            this.Hide();

            orderForm.Show();

        }

        private void buttonViewBill_Click(object sender, EventArgs e)
        {
            //  Payment paymentForm = new Payment(this);
            MessageBox.Show("Payment View Not Available");

            // paymentForm.Show();
        }

        private void buttonReturnToTableViewOrderOnTable_Click(object sender, EventArgs e)
        {
            panelCreateOrderViewBill.Hide();
        }

        //signs out
        private void labelSignOut_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttonbox = MessageBoxButtons.YesNo;
            string message = "Do you want to sign out?";
            string title = "Sign out?";

            DialogResult result = MessageBox.Show(message, title, buttonbox);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                new LoginForm().Show();
            }
            else
            {

            }
        }

       

        private void buttonNewOrderAlreadyOrder_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm(this);
            panelNoOrder.Hide();
            this.Hide();

            orderForm.Show();
        }

        private void buttonReturnTable_Click(object sender, EventArgs e)
        {
            panelOrderStatus.Hide();
        }
        //list view that shows the order status of the orders for the tables.
        private void buttonOrderStatus_Click(object sender, EventArgs e)
        {
            panelOrderStatus.Show();
            List<Order> orders = orderService.GetAllOrders();

            foreach(Order order in orders)
            {
                ListViewItem listViewItem = new ListViewItem(order.Order_Id.ToString());
                listViewItem.Tag = order;

                listViewItem.SubItems.Add(order.Table.Table_Number.ToString());
                listViewItem.SubItems.Add(order.Order_Status.ToString());
                listViewItem.SubItems.Add(order.Order_Time.ToString());

                listView1.Items.Add(listViewItem);
            }
        }

        private void panelMakeOrder_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

