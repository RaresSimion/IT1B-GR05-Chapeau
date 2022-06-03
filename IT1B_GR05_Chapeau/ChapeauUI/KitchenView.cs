using ChapeauLogic;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class KitchenViewForm : Form
    {
        public KitchenViewForm()
        {
            InitializeComponent();
        }

        private void KitchenView_Load(object sender, EventArgs e)
        {
            OrderService orderService = new OrderService();
            List<Order> orders = orderService.GetFoodOrders();
            ticketOrderTemplate(orders);
                     
        }

        private void ticketOrderTemplate(List<Order> orders)
        {
            int locationX = 26;
            OrderItemService orderItemService = new OrderItemService();

            foreach (Order order in orders)
            {
                order.OrderedItems = orderItemService.GetItems(order.Order_Id);
                
                Label container = new Label();
                container.BackColor = Color.Gray;
                container.Location = new Point(locationX, 22);
                container.Name = $"orderContainer{order.Order_Id.ToString()}";
                container.AutoSize = false;
                container.BorderStyle = BorderStyle.Fixed3D;
                container.Size = new Size(424, 858);
                container.TabIndex = 0;

                locationX += 458;

                Label heading = new Label();
                heading.Text = $"Order #{order.Order_Id}";
                heading.Location = new Point(200, 30);
                heading.Name = $"orderHeading{order.Order_Id.ToString()}";
                heading.ForeColor = Color.White;

                Button PrepareBtn = new Button();
                PrepareBtn.Text = "Prepare";
                PrepareBtn.Location = new Point(150, 80);
                PrepareBtn.Name = $"PrepareBtnOrder{order.Order_Id.ToString()}";

                PrepareBtn.BackColor = Color.CadetBlue;
                PrepareBtn.FlatStyle = FlatStyle.Popup;
                PrepareBtn.Font = new Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                PrepareBtn.ForeColor = Color.Black;
                PrepareBtn.Size = new Size(200, 60);
                PrepareBtn.UseVisualStyleBackColor = false;

                ListView orderItemsView = new ListView();
                orderItemsView.Size = new Size(600, 350);
                orderItemsView.Location = new Point(25, 110);
                orderItemsView.Columns.Add("Category");

                //
                List<OrderItem> Starters = new List<OrderItem>();
                List<OrderItem> Mains = new List<OrderItem>();
                List<OrderItem> Deserts = new List<OrderItem>();
                List<OrderItem> Entrements = new List<OrderItem>();

                foreach (OrderItem item in order.OrderedItems)
                {
                    switch ((int)item.MenuItem.Category)
                    {
                        case 1:
                        case 4:
                            Starters.Add(item);
                            break;
                        case 2:
                        case 6:
                            Mains.Add(item);
                            break;
                        case 3:
                        case 7:
                            Deserts.Add(item);
                            break;
                        case 5:
                            Entrements.Add(item);
                            break;
                        default:
                            break;
                    }
                }
                container.Controls.Add(heading);
                container.Controls.Add(PrepareBtn);
                if (Starters.Count > 0)
                    container.Controls.Add(listTemplate(Starters));
                if (Mains.Count > 0)
                    container.Controls.Add(listTemplate(Mains));
                if (Deserts.Count > 0)
                    container.Controls.Add(listTemplate(Deserts));
                if (Entrements.Count > 0)
                    container.Controls.Add(listTemplate(Entrements));

                //
               
                flowpnlKitchenView.Controls.Add(container);
                flowpnlKitchenView.AutoScroll = true;
                flowpnlKitchenView.WrapContents = false;
            }
        }


        private ListView listTemplate(List<OrderItem> itemCategory)
        {

            ListView ListView1 = new ListView();
            ListView1.Location = new Point(100, 200);
            ListView1.Name = $"orderListview{itemCategory[0].MenuItem.Category}";
            ListView1.Size = new Size(245, 200);
            ListView1.BackColor = Color.Orange;
            ListView1.ForeColor = Color.Black;

            ListView1.Columns.Add("", 100);
            ListView1.Columns.Add("", 100);
            ListView1.View = View.Details;
            foreach (OrderItem item in itemCategory)
            {
              ListViewItem li = new ListViewItem(item.MenuItem.Menu_Item_Name);
                li.SubItems.Add(item.Order_Item_Quantity.ToString());
              ListView1.Items.Add(li);
            }

            return ListView1;

        }
        private void btnScrollRight_Click(object sender, EventArgs e)
        {
            flowpnlKitchenView.AutoScrollPosition = new Point(flowpnlKitchenView.HorizontalScroll.Value + 1832, 0);
        }

        private void btnLeftScroll_Click(object sender, EventArgs e)
        {
            flowpnlKitchenView.AutoScrollPosition = new Point(flowpnlKitchenView.HorizontalScroll.Value - 1832, 0);
        }
    }
}
