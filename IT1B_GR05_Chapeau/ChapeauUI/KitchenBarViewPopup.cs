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
    public partial class KitchenBarViewPopup : Form
    {
        Order order;
        OrderItemService orderItemService = new OrderItemService();
        OrderService orderService = new OrderService();
        List<OrderItem> selectedItems = new List<OrderItem>();
        List<OrderItem> allOrderItems;
        public KitchenBarViewPopup(Order order, string categoryName, List<OrderItem> orderedItems)
        {
            InitializeComponent();
            this.order = order;
            allOrderItems = orderItemService.GetItems(order.Order_Id);

            itemListView.Columns.Add("Item", 600);
            itemListView.Columns.Add("Comment", 740);
            orderNumberLbl.Text = $"Order #{order.Order_Id}";
            categoryNameLbl.Text = categoryName;
            foreach (OrderItem item in orderedItems)
            {
                if (!item.itemIsReady)
                {
                    ListViewItem li = new ListViewItem($"x{item.Order_Item_Quantity}");
                    li.Tag = item;
                    li.SubItems.Add(item.MenuItem.Menu_Item_Name);
                    li.SubItems.Add(item.Order_Item_Comment);
                    li.UseItemStyleForSubItems = false;
                    li.SubItems[0].Font = new Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    li.SubItems[1].Font = new Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                    li.SubItems[2].Font = new Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    itemListView.Items.Add(li);
                }
            }
            this.itemListView.ColumnWidthChanging += new ColumnWidthChangingEventHandler(itemListView_ColumnWidthChanging);
        }
        private void MarkReadyBtn_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in this.itemListView.CheckedItems)
            {
                OrderItem orderItem = (OrderItem)item.Tag;
                selectedItems.Add(orderItem);
            }
            if (selectedItems.Count == 0)
                MessageBox.Show("Could not mark items ready: Please select at least 1 item!");
            else if (selectedItems.Count > 0)
            {
                foreach (OrderItem orderItem in selectedItems)
                    orderItemService.MarkItemComplete(orderItem.OrderID, orderItem.MenuItem.Menu_Item_Id);
                orderService.UpdateOrderStatus(order.Order_Id, OrderStatus.Ordered);

                int readyItems = 0;
                foreach (OrderItem item in allOrderItems)
                    if (item.itemIsReady)
                        readyItems++;
                if (readyItems == order.OrderedItems.Count)
                    orderService.UpdateOrderStatus(order.Order_Id, OrderStatus.Finished);
                this.Close();
            }

        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void itemListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e) // Disables changing column width
        {
            e.NewWidth = this.itemListView.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }
    }
}
