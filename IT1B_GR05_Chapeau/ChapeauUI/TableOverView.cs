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

namespace ChapeauUI
{
    public partial class TableOverView : Form
    {
        private Table table = new Table();
        private TableService tableService = new TableService();
        public TableOverView()
        {
            InitializeComponent();
        }

        private void TableOverView_Load(object sender, EventArgs e)
        {
            panelNoOrder.Hide();
            panelTable6.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonTable1_Click(object sender, EventArgs e)
        {
            table = tableService.GetTable(1);
            labelTableNumber.Text = $"Table # {table.Table_Number}";

            if (!table.Table_Availability)
            {
                panelNoOrder.Show();
            }
            else
            {
               panelTable6.Show();
            }


        }

        private void buttonTable2_Click(object sender, EventArgs e)
        {
            table = tableService.GetTable(2);
            labelTableNumber.Text = $"Table # {table.Table_Number}";

            if (!table.Table_Availability)
            {
                panelNoOrder.Show();
            }

            else
            {
                panelTable6.Show();
            }
        }

        private void buttonTable3_Click(object sender, EventArgs e)
        {
            table = tableService.GetTable(3);
            labelTableNumber.Text = $"Table # {table.Table_Number}";

            if (!table.Table_Availability)
            {
                panelNoOrder.Show();
            }
            else
            {
                panelTable6.Show();
            }
        }

        private void buttonTable4_Click(object sender, EventArgs e)
        {
            table = tableService.GetTable(4);
            labelTableNumber.Text = $"Table # {table.Table_Number}";

            if (!table.Table_Availability)
            {
                panelNoOrder.Show();
            }
            else
            {
                panelTable6.Show();
            }
        }

        private void buttonTable5_Click(object sender, EventArgs e)
        {
            table = tableService.GetTable(5);
            labelTableNumber.Text = $"Table # {table.Table_Number}";

            if (!table.Table_Availability)
            {
                panelNoOrder.Show();
            }
            else
            {
                panelTable6.Show();
            }
        }

        private void buttonTable6_Click(object sender, EventArgs e)
        {
            panelTable6.Show();
            labelTableNumber.Text = $"Table # {table.Table_Number}";


            if (!table.Table_Availability)
            {
                panelNoOrder.Show();
            }
            else
            {
                panelTable6.Show();
            }
        }

        private void buttonTable7_Click(object sender, EventArgs e)
        {
            panelNoOrder.Show();
            labelTableNumber.Text = $"Table # {table.Table_Number}";

            if (!table.Table_Availability)
            {
                panelNoOrder.Show();
            }
            else
            {
                panelTable6.Show();
            }
        }

        private void buttonTable8_Click(object sender, EventArgs e)
        {
            panelNoOrder.Show();
            labelTableNumber.Text = $"Table # {table.Table_Number}";

            if (!table.Table_Availability)
            {
                panelNoOrder.Show();
            }
            else
            {
                panelTable6.Show();
            }

        }

        private void buttonTable9_Click(object sender, EventArgs e)
        {
            panelNoOrder.Show();
            labelTableNumber.Text = $"Table # {table.Table_Number}";

            if (!table.Table_Availability)
            {
                panelNoOrder.Show();
            }
            else
            {
                panelTable6.Show();
            }

        }

        private void buttonTable10_Click(object sender, EventArgs e)
        {
            panelNoOrder.Show();
            labelTableNumber.Text = $"Table # {table.Table_Number}";

            if (!table.Table_Availability)
            {
                panelNoOrder.Show();
            }
            else
            {
                panelTable6.Show();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelTable6.Hide();
        }

        private void buttonReturnToTableView_Click(object sender, EventArgs e)
        {
            panelNoOrder.Hide();
        }

        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            table.Table_Number = this.table.Table_Number;
            OrderForm orderForm = new OrderForm();
            this.Hide();

            orderForm.Show();
        }
    }
}
