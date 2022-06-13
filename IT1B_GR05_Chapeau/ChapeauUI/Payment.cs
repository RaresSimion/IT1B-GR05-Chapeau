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
    public partial class Payment : Form
    {
        private OrderItemService orderItemService = new OrderItemService();
        private OrderService orderService = new OrderService();
        private TableService tableService = new TableService();
        private Table currentTable;
        private Order currentOrder;
        private TableOverView tableView;
        private OrderForm orderForm;
        public Payment()
        {
            InitializeComponent();
            btnPay.Enabled = false;
            txtTipAmount.Visible = false;
            lblAmount.Visible = false;
            lblTotalTip.Visible = false;
            txtTipAmount.Visible = false;
            rbtnCash.Checked = false;
            txtTip.Visible = false;
            btnAddTip.Enabled = false;
            btnAddTip.Visible = false;
            DisplayTable();
            
            //this.tableView = tableOverView;
            //this.currentTable = tableOverView.table;
            //this.orderForm = orderForm;
            //this.currentOrder = orderForm;
            
        }

        public void DisplayTable()
        {
            decimal totalPrice = 0;
            int count = 0;
            decimal vat6 = 0;
            decimal vat21 = 0;
            listViewTable.Items.Clear();
            Table table = new Table(9, false);
            List<OrderItem> orderItems = orderItemService.GetAllOrderItemsFromTable(table);
            foreach (OrderItem item in orderItems)
            {
                ListViewItem listViewItem = new ListViewItem(item.Order_Item_Quantity.ToString());
                listViewItem.Tag = item;
                listViewItem.SubItems.Add(item.MenuItem.Menu_Item_Name);
                listViewItem.SubItems.Add(item.MenuItem.Menu_Item_Price.ToString());
                listViewItem.SubItems.Add(item.Order_Item_Comment.ToString());
                listViewTable.Items.Add(listViewItem);
               
            }
            foreach(OrderItem item in orderItems)
            {
                decimal itemPrice = item.MenuItem.Menu_Item_Price * item.Order_Item_Quantity;
                totalPrice = totalPrice + itemPrice;
                if(!item.Is_Alcoholic)
                {
                    vat6 = vat6 + (item.VAT_In_Price * item.Order_Item_Quantity);
                }
                else
                {
                    vat21 = vat21 + (item.VAT_In_Price * item.Order_Item_Quantity);
                }
                count++;
            }
            

            // string stringTip = tipAmount;
            // decimal decimalTip = decimal.Parse(stringTip);
            // tipTotal = totalPrice + decimalTip;
            txtOrder.Text = totalPrice.ToString("€0.00");
            txtVAT6.Text = vat6.ToString("€0.00");
            txtVat21.Text = vat21.ToString("€0.00");
            
            
        }
        private void rbtnTipYes_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnTipYes.Checked)
            {
                txtTipAmount.Visible = true;
                lblAmount.Visible = true;
                lblTotalTip.Visible = true;
                txtTipAmount.Visible = true;
                txtTip.Visible = true;
                btnAddTip.Enabled = true;
                btnAddTip.Visible = true;
            }
            if ((rbtnCash.Checked || rbtnCreditcard.Checked || rbtnDebitcard.Checked) && (rbtnTipNo.Checked || rbtnTipYes.Checked))
            {
                btnPay.Enabled = true;
            }
        }

        private void rbtnTipNo_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnTipNo.Checked)
            {
                txtTipAmount.Visible = false;
                lblAmount.Visible = false;
                lblTotalTip.Visible = false;
                txtTipAmount.Visible = false;
                txtTip.Visible = false;
                btnAddTip.Enabled = false;
                btnAddTip.Visible = false;
            }
            if ((rbtnCash.Checked || rbtnCreditcard.Checked || rbtnDebitcard.Checked) && (rbtnTipNo.Checked || rbtnTipYes.Checked))
            {
                btnPay.Enabled = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(!rbtnTipYes.Checked || !rbtnTipNo.Checked)
            {
                MessageBox.Show($"Please select yes or no for tip!");
            }
            //MessageBox.Show($"{currentTable.Table_Number} bill has been paid!");
        }

        private void btnAddTip_Click(object sender, EventArgs e)
        {
            
        }
    }
}
