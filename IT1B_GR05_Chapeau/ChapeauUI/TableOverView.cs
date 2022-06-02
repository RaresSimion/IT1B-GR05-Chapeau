﻿using System;
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
            panelTable1Order.Hide();
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
            panelNoOrder.Show();
            table = tableService.GetTable(1);
            labelTableNumber.Text = $"Table # {table.Table_Number}";
        }

        private void buttonTable2_Click(object sender, EventArgs e)
        {
            panelNoOrder.Show();

        }

        private void buttonTable3_Click(object sender, EventArgs e)
        {
            panelNoOrder.Show();

        }

        private void buttonTable4_Click(object sender, EventArgs e)
        {
            panelNoOrder.Show();

        }

        private void buttonTable5_Click(object sender, EventArgs e)
        {
            panelNoOrder.Show();

        }

        private void buttonTable6_Click(object sender, EventArgs e)
        {
            panelTable6.Show();
        }

        private void buttonTable7_Click(object sender, EventArgs e)
        {
            panelNoOrder.Show();

        }

        private void buttonTable8_Click(object sender, EventArgs e)
        {
            panelNoOrder.Show();

        }

        private void buttonTable9_Click(object sender, EventArgs e)
        {
            panelNoOrder.Show();

        }

        private void buttonTable10_Click(object sender, EventArgs e)
        {
            panelNoOrder.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelTable1Order.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelTable6.Hide();
        }

        private void buttonReturnToTableView_Click(object sender, EventArgs e)
        {
            panelNoOrder.Hide();
        }
    }
}
