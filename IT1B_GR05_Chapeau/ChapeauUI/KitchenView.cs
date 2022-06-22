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
        private Employee currentUser;
        public List<Order> orders;
        OrderService orderService;
        OrderItemService orderItemService;
        public KitchenViewForm(Employee currentUser)
        {
            InitializeComponent();                              // Bartender. Username: 2. Password: 2321.                                                               // Chef. Username: 3. Password: 4342.
            this.currentUser = currentUser;                     // Chef. Username: 3. Password: 4342.         
        }


        private void KitchenView_Load(object sender, EventArgs e)
        {
            try
            {
                orderItemService = new OrderItemService();
                orderService = new OrderService();
                if (currentUser.Employee_Role == EmployeeRole.Bartender) //Change label and load drink orders if bartender
                {
                    orders = orderService.GetDrinkOrders();
                    lblHeadingKitchenView.Visible = false;
                }
                else if (currentUser.Employee_Role == EmployeeRole.Chef) //Change label and load drink orders if chef
                {
                    orders = orderService.GetFoodOrders();
                    lblHeadingBarView.Visible = false;
                }
                orders.ForEach(i => i.OrderedItems = orderItemService.GetItems(i.Order_Id));

                //Gets items for each order

                for (int i = orders.Count - 1; i >= 0; i--)
                    if (chefBartenderOrderComplete(orders[i]))
                        orders.RemoveAt(i);

                lblSignedIn.Text = currentUser.Employee_Name;
                lblSignedIn.TextAlign = ContentAlignment.MiddleCenter;
                createOrderCards(orders);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while refreshing the view: " + ex.Message);
                ErrorLogger.LogError(ex);
            }

        }

        private void createOrderCards(List<Order> orders)
        {
            if (flowpnlKitchenView.FlowDirection == FlowDirection.RightToLeft && orders.Count % 4 != 0)
            {
                for (int i = 0; i < (4 - (orders.Count % 4)); i++) //Creates invisible objects to create even pages (if newest orders button is selected)
                {
                    Label blankspace = new Label();
                    blankspace.Size = new Size(400, 900);
                    blankspace.Margin = new(13, 38, 13, 0);
                    flowpnlKitchenView.Controls.Add(blankspace);
                }
            }
            foreach (Order order in orders)
            {
                Panel container = new Panel();  //create container for order card
                container.BackColor = Color.FromArgb(217, 217, 217);
                container.Size = new Size(400, 900);
                container.Name = $"orderContainer{order.Order_Id.ToString()}";
                container.AutoSize = false;
                container.BorderStyle = BorderStyle.FixedSingle;
                container.Margin = new(13, 38, 13, 0);
                container.AutoScroll = false;

                Label heading = new Label(); //creates order ID label
                heading.Text = $"Order #{order.Order_Id}";
                heading.Size = new Size(400, 40);
                heading.Font = new Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                heading.ForeColor = Color.Black;
                heading.TextAlign = ContentAlignment.MiddleCenter;
                container.Controls.Add(heading);

                Label timeSinceCreated = new Label();
                timeSinceCreated.Size = new Size(400, 30);
                timeSinceCreated.Font = new Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                if (int.Parse((DateTime.Now - order.Order_Time).ToString("dd")) > 0)
                    timeSinceCreated.Text = "Created more than a day ago";
                else
                    timeSinceCreated.Text = $"Created {(DateTime.Now - order.Order_Time):hh}h : {(DateTime.Now - order.Order_Time):mm}m ago";
                timeSinceCreated.ForeColor = Color.Black;
                timeSinceCreated.TextAlign = ContentAlignment.MiddleCenter;
                timeSinceCreated.Location = new Point(0, 42);
                container.Controls.Add(timeSinceCreated);

                List<OrderItem> Starters = new List<OrderItem>();  //Creates simplified categories for items
                List<OrderItem> Mains = new List<OrderItem>();
                List<OrderItem> Deserts = new List<OrderItem>();
                List<OrderItem> Entrements = new List<OrderItem>();
                List<OrderItem> Beverages = new List<OrderItem>();

                foreach (OrderItem item in order.OrderedItems)      //Sorts order items into the new simplified categories
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
                        case > 7:
                            Beverages.Add(item);
                            break;
                    }
                }
                string categoryName = "";
                int Ypos = 80;
                if (currentUser.Employee_Role == EmployeeRole.Chef) //If chef is logged in, this adds new simplified categories only if items exist, and updates y coordinates so other components don't overlap
                {
                    if (Starters.Count > 0)
                    {
                        categoryName = "Starters";
                        container.Controls.Add(createCategoryHeader(categoryName, Ypos, out int Xpos));
                        container.Controls.Add(createCategoryCheckmark(Ypos, Xpos, categoryIsComplete(Beverages)));
                        container.Controls.Add(createCategoryBorder(Ypos));
                        Ypos += 35;
                        container.Controls.Add(createCategoryItems(Starters, categoryName, Ypos));
                        Ypos += (Starters.Count * 20);
                        container.Controls.Add(PrepareButton(Ypos, order, categoryIsComplete(Starters), categoryName, Starters));
                        Ypos += 40;
                    }
                    if (Entrements.Count > 0)
                    {
                        categoryName = "Entrements";
                        container.Controls.Add(createCategoryHeader(categoryName, Ypos, out int Xpos));
                        container.Controls.Add(createCategoryCheckmark(Ypos, Xpos, categoryIsComplete(Beverages)));
                        container.Controls.Add(createCategoryBorder(Ypos));
                        Ypos += 35;
                        container.Controls.Add(createCategoryItems(Entrements, categoryName, Ypos));
                        Ypos += (Entrements.Count * 20);
                        container.Controls.Add(PrepareButton(Ypos, order, categoryIsComplete(Entrements), categoryName, Entrements));
                        Ypos += 40;
                    }
                    if (Mains.Count > 0)
                    {
                        categoryName = "Mains";
                        container.Controls.Add(createCategoryHeader(categoryName, Ypos, out int Xpos));
                        container.Controls.Add(createCategoryCheckmark(Ypos, Xpos, categoryIsComplete(Beverages)));
                        container.Controls.Add(createCategoryBorder(Ypos));
                        Ypos += 35;
                        container.Controls.Add(createCategoryItems(Mains, categoryName, Ypos));
                        Ypos += (Mains.Count * 20);
                        container.Controls.Add(PrepareButton(Ypos, order, categoryIsComplete(Mains), categoryName, Mains));
                        Ypos += 40;
                    }
                    if (Deserts.Count > 0)
                    {
                        categoryName = "Deserts";
                        container.Controls.Add(createCategoryHeader(categoryName, Ypos, out int Xpos));
                        container.Controls.Add(createCategoryCheckmark(Ypos, Xpos, categoryIsComplete(Beverages)));
                        container.Controls.Add(createCategoryBorder(Ypos));
                        Ypos += 35;
                        container.Controls.Add(createCategoryItems(Deserts, categoryName, Ypos));
                        Ypos += (Deserts.Count * 20);
                        container.Controls.Add(PrepareButton(Ypos, order, categoryIsComplete(Deserts), categoryName, Deserts));
                        Ypos += 40;
                    }
                }
                else if (currentUser.Employee_Role == EmployeeRole.Bartender) //Creates only one category if the bartender is logged in
                {
                    if (order.OrderedItems.Count > 0)
                    {
                        categoryName = "Beverages";
                        container.Controls.Add(createCategoryHeader(categoryName, Ypos, out int Xpos));
                        container.Controls.Add(createCategoryCheckmark(Ypos, Xpos, categoryIsComplete(Beverages)));
                        container.Controls.Add(createCategoryBorder(Ypos));
                        Ypos += 35;
                        container.Controls.Add(createCategoryItems(Beverages, categoryName, Ypos));
                        Ypos += (Beverages.Count * 20);
                        container.Controls.Add(PrepareButton(Ypos, order, categoryIsComplete(Beverages), categoryName, Beverages));
                        Ypos += 40;
                    }
                }
                flowpnlKitchenView.Controls.Add(container);
            }                                                                                                                                                                                                                               
            if (flowpnlKitchenView.FlowDirection == FlowDirection.RightToLeft && orders.Count % 4 != 0)
            { 
                for (int i = 0; i < (4 - (orders.Count % 4)); i++) //Creates invisible objects to create even pages(if earliest orders button is selected)
                {
                    Label blankspace = new Label();
                    blankspace.Size = new Size(400, 900);
                    blankspace.Margin = new(13, 38, 13, 0);
                    flowpnlKitchenView.Controls.Add(blankspace);
                }
            }
            
        }
        private Button PrepareButton(int Ypos, Order order, bool categoryComplete, string categoryName, List<OrderItem> orderedItems) //Creates prepare button for each category
        {
            Button PrepareBtn = new Button();
            PrepareBtn.Size = new Size(224, 35);
            PrepareBtn.Name = $"PrepareBtnOrder{order.Order_Id.ToString()}";
            PrepareBtn.TextAlign = ContentAlignment.MiddleCenter;
            if (categoryComplete)
            {
                PrepareBtn.Text = "Completed";
                PrepareBtn.Enabled = false;
                PrepareBtn.BackColor = Color.DarkGray;
                PrepareBtn.ForeColor = Color.White;
            }
            else
            {
                PrepareBtn.Text = "Prepare";
                PrepareBtn.BackColor = Color.FromArgb(24, 116, 210);
                PrepareBtn.ForeColor = Color.White;
            }
            PrepareBtn.FlatAppearance.BorderColor = Color.Black;
            PrepareBtn.FlatStyle = FlatStyle.Flat;
            // if (order.Order_Status = order.OrderStatus.Preparing)
            PrepareBtn.Font = new Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            PrepareBtn.Location = new Point(0, Ypos);
            PrepareBtn.Left = ((400 - PrepareBtn.Width) / 2);
            PrepareBtn.Click += (sender, EventArgs) => { Preparebtn_Clicked(sender, EventArgs, order, categoryName, orderedItems); };
            return PrepareBtn;
        }
        private ListView createCategoryItems(List<OrderItem> itemCategory, string categoryName, int YPos)
        {
            ListView ListView = new ListView();
            ListView.Location = new Point(-2, YPos);
            ListView.Name = $"orderListview{categoryName}";
            ListView.Size = new Size(400, 400);
            ListView.BackColor = Color.FromArgb(217, 217, 217);
            ListView.ForeColor = Color.Black;
            ListView.Scrollable = false;
            ListView.HeaderStyle = ColumnHeaderStyle.None;
            ListView.Columns.Add("", 35);
            ListView.Columns.Add("", 365);
            ListView.View = View.Details;
            ListView.BorderStyle = BorderStyle.None;
            ListView.ItemSelectionChanged += DisableSelection;
            ListView.Height = itemCategory.Count * 20;
            foreach (OrderItem item in itemCategory)
            {
                ListViewItem li = new ListViewItem($"x {item.Order_Item_Quantity}");
                li.Tag = item;
                li.SubItems.Add($"{item.MenuItem.Menu_Item_Name}");
                if (item.itemIsReady)
                {
                    li.UseItemStyleForSubItems = true;
                    li.SubItems[0].Font = new Font("Segoe UI", 11F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point);
                }
                else
                {
                    li.UseItemStyleForSubItems = false;
                    li.SubItems[0].Font = new Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    li.SubItems[1].Font = new Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                }
                ListView.Items.Add(li);
            }
            return ListView;
        }
        private Label createCategoryBorder(int Ypos)
        {
            Label categoryBorder = new Label();
            categoryBorder.AutoSize = false;
            categoryBorder.Size = new Size(400, 35);
            categoryBorder.Location = new Point(0, Ypos);
            categoryBorder.BackColor = Color.Black;
            categoryBorder.FlatStyle = FlatStyle.Flat;
            return categoryBorder;

        }
        private Label createCategoryHeader(string categoryName, int Ypos, out int Xpos)
        {
            Label label = new Label();
            label.ForeColor = Color.White;
            label.BackColor = Color.Black;
            label.Font = new Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label.Text = categoryName;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Location = new Point((400 - label.Width) / 2, Ypos);
            Xpos = label.Left + label.Width + 20;
            return label;
        }
        private Label createCategoryCheckmark(int Ypos, int Xpos, bool enabled)
        {
            Label label = new Label(); 
            label.Padding = new Padding(0, 0, 0, 0);
            label.BackColor = Color.Black;                                                                             //Before this line, I change the font and text to get the X position for the checkmark perfectly for any word in the category header
            label.AutoSize = false;
            label.Size = new Size(35, 35);
            label.ForeColor = Color.FromArgb(0, 255, 56);
            label.Text = "✓";
            label.Font = new Font("Segoe UI Semibold", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Location = new Point(Xpos, Ypos);
            label.Visible = !enabled;
            return label;
        }
        private void btnScrollRight_Click(object sender, EventArgs e)
        {
            int currentpos = flowpnlKitchenView.HorizontalScroll.Value;
            flowpnlKitchenView.AutoScrollPosition = new Point(currentpos + 1704);
        }
        private void btnLeftScroll_Click(object sender, EventArgs e)
        {
            int currentpos = flowpnlKitchenView.HorizontalScroll.Value;
            flowpnlKitchenView.AutoScrollPosition = new Point(currentpos - 1704);
        }
        private void DisableSelection(object sender, ListViewItemSelectionChangedEventArgs e)  //Disables ListView selection for order cards
        {
            if (e.IsSelected)
                e.Item.Selected = false;
        }

        private void btnKitchenEarliestOrders_Click_1(object sender, EventArgs e)   //On click, it sets the opposite flow direction, and updates styling of the button to indicate the selected view, then refreshes
        {
            flowpnlKitchenView.FlowDirection = FlowDirection.LeftToRight;
            btnKitchenEarliestOrders.FlatStyle = FlatStyle.Popup;
            btnKitchenEarliestOrders.ForeColor = Color.White;
            btnKitchenNewOrders.FlatStyle = FlatStyle.System;
            btnKitchenNewOrders.ForeColor = Color.Black;
            RefreshKBView();
        }

        private void btnKitchenNewOrders_Click_1(object sender, EventArgs e)        //On click, it sets the opposite flow direction, and updates styling of the button to indicate the selected view, then refreshes
        {
            flowpnlKitchenView.FlowDirection = FlowDirection.RightToLeft;
            btnKitchenNewOrders.FlatStyle = FlatStyle.Popup;
            btnKitchenNewOrders.ForeColor = Color.White;
            btnKitchenEarliestOrders.FlatStyle = FlatStyle.System;
            btnKitchenEarliestOrders.ForeColor = Color.Black;
            RefreshKBView();
        }
        private bool categoryIsComplete(List<OrderItem> items)     //Checks if simplified categories are complete for visual cues
        {
            int count = 0;
            foreach (OrderItem item in items)
                if (item.itemIsReady)
                    count++;
            if (count == items.Count)
                return true;
            else
                return false;
        }
        private void RefreshKBView()                              //clears controls and re-loads the view
        {
            try
            {
                OrderService orderService = new OrderService();
                OrderItemService orderItemService = new OrderItemService();
                flowpnlKitchenView.Controls.Clear();
                orders.Clear();
                if (currentUser.Employee_Role == EmployeeRole.Bartender) //Change label and load drink orders if bartender
                    orders = orderService.GetDrinkOrders();
                else if (currentUser.Employee_Role == EmployeeRole.Chef) //Change label and load drink orders if chef
                    orders = orderService.GetFoodOrders();
                foreach (Order order in orders)
                    order.OrderedItems = orderItemService.GetItems(order.Order_Id);
                createOrderCards(orders);
                flowpnlKitchenView.AutoScrollPosition = new Point(0);
                for (int i = orders.Count - 1; i >= 0; i--)
                    if (chefBartenderOrderComplete(orders[i]))
                        orders.RemoveAt(i);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while refreshing the view: " + ex.Message);
                ErrorLogger.LogError(ex);
            }
        }
        private void Preparebtn_Clicked(object sender, EventArgs e, Order order, string categoryName, List<OrderItem> orderedItems)  //Event handler for prepare buttons clicked
        {
            OrderService orderService = new OrderService();
            KitchenBarViewPopup popup = new KitchenBarViewPopup(order, categoryName, orderedItems);
            popup.FormClosed += new FormClosedEventHandler(KitchenBarViewPopup_FormClosed); //calls event handler when popup is closed
            orderService.UpdateOrderStatus(order.Order_Id, OrderStatus.Preparing);
            popup.ShowDialog();
        }
        private void KitchenBarViewPopup_FormClosed(object sender, FormClosedEventArgs e)     // On popup close, reload items and refresh view
        {
            flowpnlKitchenView.Controls.Clear();
            RefreshKBView();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttonbox = MessageBoxButtons.YesNo;
            string message = "Are you sure you wish to sign out?";
            string title = "Sign out";

            DialogResult result = MessageBox.Show(message, title, buttonbox);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                new LoginForm().Show();
            }
        }
        private bool chefBartenderOrderComplete(Order order)                 //checks if every item is complete for an order when the chef of bartender is logged in
        {
            List<OrderItem> foodItems = new List<OrderItem>();
            List<OrderItem> drinkItems = new List<OrderItem>();

            foreach (OrderItem food in order.OrderedItems)
                if ((int)food.MenuItem.Category < 8)
                        foodItems.Add(food); 

                foreach (OrderItem drink in order.OrderedItems)
                    if ((int)drink.MenuItem.Category > 7)
                        drinkItems.Add(drink);

            int readyDrinks = 0;
            foreach (OrderItem item in drinkItems)
                if (item.Is_Ready)
                    readyDrinks++;

            int readyFood = 0;
            foreach (OrderItem item in drinkItems)
                if (item.Is_Ready)
                    readyFood++;

            if (foodItems.Count == readyFood && drinkItems.Count == readyDrinks)
                orderService.UpdateOrderStatus(order.Order_Id, OrderStatus.Finished);
            if ((readyFood == foodItems.Count) && (currentUser.Employee_Role == EmployeeRole.Chef))
                return true;
            if ((currentUser.Employee_Role == EmployeeRole.Bartender) && (readyDrinks == drinkItems.Count))
                return true;
            else
                return false;
        }



    }
}