namespace ChapeauUI
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnDinner = new System.Windows.Forms.Button();
            this.btnLunch = new System.Windows.Forms.Button();
            this.btnDrinks = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.pnlOrder = new System.Windows.Forms.Panel();
            this.btnRemoveOrder = new System.Windows.Forms.Button();
            this.btnSubmitOrder = new System.Windows.Forms.Button();
            this.listViewOrder = new System.Windows.Forms.ListView();
            this.columnHeaderOrderQuantity = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderOrderItemName = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderComment = new System.Windows.Forms.ColumnHeader();
            this.lblTable = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.pnlDrinks = new System.Windows.Forms.Panel();
            this.btnCoffeeTea = new System.Windows.Forms.Button();
            this.btnSpirits = new System.Windows.Forms.Button();
            this.btnWines = new System.Windows.Forms.Button();
            this.btnBeers = new System.Windows.Forms.Button();
            this.btnSoftDrinks = new System.Windows.Forms.Button();
            this.lblDrinks = new System.Windows.Forms.Label();
            this.pnlLunch = new System.Windows.Forms.Panel();
            this.btnDesserts = new System.Windows.Forms.Button();
            this.btnLunchMains = new System.Windows.Forms.Button();
            this.btnLunchStarters = new System.Windows.Forms.Button();
            this.lblLunch = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Label();
            this.pnlSubMenu = new System.Windows.Forms.Panel();
            this.lblLowStock = new System.Windows.Forms.Label();
            this.txtBoxColorIndicato = new System.Windows.Forms.TextBox();
            this.textBoxSubmenu = new System.Windows.Forms.TextBox();
            this.listViewMenu = new System.Windows.Forms.ListView();
            this.columnHeaderID = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderName = new System.Windows.Forms.ColumnHeader();
            this.pnlDinner = new System.Windows.Forms.Panel();
            this.btnDinnerDesserts = new System.Windows.Forms.Button();
            this.btnDinnerMains = new System.Windows.Forms.Button();
            this.btnDinnerEntremets = new System.Windows.Forms.Button();
            this.btnDinnerStarters = new System.Windows.Forms.Button();
            this.lblDinner = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.pnlOrder.SuspendLayout();
            this.pnlDrinks.SuspendLayout();
            this.pnlLunch.SuspendLayout();
            this.pnlSubMenu.SuspendLayout();
            this.pnlDinner.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::ChapeauUI.Properties.Resources.Chapeau_Logo1;
            this.pictureBoxLogo.Location = new System.Drawing.Point(252, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(223, 89);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.pictureBoxBack);
            this.pnlHeader.Controls.Add(this.pictureBoxLogo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(728, 112);
            this.pnlHeader.TabIndex = 1;
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBack.Image = global::ChapeauUI.Properties.Resources.arrow_left_circle2;
            this.pictureBoxBack.Location = new System.Drawing.Point(27, 22);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(68, 65);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBack.TabIndex = 1;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnDinner);
            this.pnlMenu.Controls.Add(this.btnLunch);
            this.pnlMenu.Controls.Add(this.btnDrinks);
            this.pnlMenu.Controls.Add(this.lblMenu);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 112);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(364, 849);
            this.pnlMenu.TabIndex = 2;
            // 
            // btnDinner
            // 
            this.btnDinner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnDinner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDinner.FlatAppearance.BorderSize = 0;
            this.btnDinner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDinner.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDinner.Image = global::ChapeauUI.Properties.Resources.Restaurant_Fork_Knife;
            this.btnDinner.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDinner.Location = new System.Drawing.Point(51, 340);
            this.btnDinner.Name = "btnDinner";
            this.btnDinner.Size = new System.Drawing.Size(254, 75);
            this.btnDinner.TabIndex = 3;
            this.btnDinner.Text = "  Dinner";
            this.btnDinner.UseVisualStyleBackColor = false;
            this.btnDinner.Click += new System.EventHandler(this.btnDinner_Click);
            // 
            // btnLunch
            // 
            this.btnLunch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnLunch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLunch.FlatAppearance.BorderSize = 0;
            this.btnLunch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLunch.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLunch.Image = global::ChapeauUI.Properties.Resources.Bread_Baguette;
            this.btnLunch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLunch.Location = new System.Drawing.Point(51, 240);
            this.btnLunch.Name = "btnLunch";
            this.btnLunch.Size = new System.Drawing.Size(254, 75);
            this.btnLunch.TabIndex = 2;
            this.btnLunch.Text = "  Lunch";
            this.btnLunch.UseVisualStyleBackColor = false;
            this.btnLunch.Click += new System.EventHandler(this.btnLunch_Click);
            // 
            // btnDrinks
            // 
            this.btnDrinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnDrinks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDrinks.FlatAppearance.BorderSize = 0;
            this.btnDrinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrinks.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDrinks.Image = global::ChapeauUI.Properties.Resources.drink;
            this.btnDrinks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrinks.Location = new System.Drawing.Point(51, 143);
            this.btnDrinks.Name = "btnDrinks";
            this.btnDrinks.Size = new System.Drawing.Size(254, 75);
            this.btnDrinks.TabIndex = 1;
            this.btnDrinks.Text = "  Drinks";
            this.btnDrinks.UseVisualStyleBackColor = false;
            this.btnDrinks.Click += new System.EventHandler(this.btnDrinks_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMenu.Location = new System.Drawing.Point(77, 30);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(212, 78);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "Menu";
            // 
            // pnlOrder
            // 
            this.pnlOrder.Controls.Add(this.btnRemoveOrder);
            this.pnlOrder.Controls.Add(this.btnSubmitOrder);
            this.pnlOrder.Controls.Add(this.listViewOrder);
            this.pnlOrder.Controls.Add(this.lblTable);
            this.pnlOrder.Controls.Add(this.lblOrder);
            this.pnlOrder.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlOrder.Location = new System.Drawing.Point(364, 112);
            this.pnlOrder.Name = "pnlOrder";
            this.pnlOrder.Size = new System.Drawing.Size(364, 849);
            this.pnlOrder.TabIndex = 3;
            // 
            // btnRemoveOrder
            // 
            this.btnRemoveOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnRemoveOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveOrder.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveOrder.Location = new System.Drawing.Point(100, 559);
            this.btnRemoveOrder.Name = "btnRemoveOrder";
            this.btnRemoveOrder.Size = new System.Drawing.Size(173, 49);
            this.btnRemoveOrder.TabIndex = 9;
            this.btnRemoveOrder.Text = "Remove order";
            this.btnRemoveOrder.UseVisualStyleBackColor = false;
            this.btnRemoveOrder.Click += new System.EventHandler(this.btnRemoveOrder_Click);
            // 
            // btnSubmitOrder
            // 
            this.btnSubmitOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(116)))), ((int)(((byte)(210)))));
            this.btnSubmitOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmitOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitOrder.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSubmitOrder.ForeColor = System.Drawing.Color.White;
            this.btnSubmitOrder.Location = new System.Drawing.Point(111, 783);
            this.btnSubmitOrder.Name = "btnSubmitOrder";
            this.btnSubmitOrder.Size = new System.Drawing.Size(152, 49);
            this.btnSubmitOrder.TabIndex = 4;
            this.btnSubmitOrder.Text = "Submit order";
            this.btnSubmitOrder.UseVisualStyleBackColor = false;
            this.btnSubmitOrder.Click += new System.EventHandler(this.btnSubmitOrder_Click);
            // 
            // listViewOrder
            // 
            this.listViewOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.listViewOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderOrderQuantity,
            this.columnHeaderOrderItemName,
            this.columnHeaderComment});
            this.listViewOrder.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listViewOrder.FullRowSelect = true;
            this.listViewOrder.GridLines = true;
            this.listViewOrder.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewOrder.HideSelection = false;
            this.listViewOrder.Location = new System.Drawing.Point(7, 143);
            this.listViewOrder.Name = "listViewOrder";
            this.listViewOrder.Size = new System.Drawing.Size(354, 395);
            this.listViewOrder.TabIndex = 3;
            this.listViewOrder.TileSize = new System.Drawing.Size(3, 3);
            this.listViewOrder.UseCompatibleStateImageBehavior = false;
            this.listViewOrder.View = System.Windows.Forms.View.Details;
            this.listViewOrder.SelectedIndexChanged += new System.EventHandler(this.listViewOrder_SelectedIndexChanged);
            // 
            // columnHeaderOrderQuantity
            // 
            this.columnHeaderOrderQuantity.Text = "Amount";
            this.columnHeaderOrderQuantity.Width = 95;
            // 
            // columnHeaderOrderItemName
            // 
            this.columnHeaderOrderItemName.Text = "Name";
            this.columnHeaderOrderItemName.Width = 300;
            // 
            // columnHeaderComment
            // 
            this.columnHeaderComment.Text = "Comment";
            this.columnHeaderComment.Width = 200;
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTable.Location = new System.Drawing.Point(90, 81);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(194, 58);
            this.lblTable.TabIndex = 2;
            this.lblTable.Text = "Table 1";
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOrder.Location = new System.Drawing.Point(45, 3);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(266, 78);
            this.lblOrder.TabIndex = 1;
            this.lblOrder.Text = "Order 2";
            // 
            // pnlDrinks
            // 
            this.pnlDrinks.Controls.Add(this.btnCoffeeTea);
            this.pnlDrinks.Controls.Add(this.btnSpirits);
            this.pnlDrinks.Controls.Add(this.btnWines);
            this.pnlDrinks.Controls.Add(this.btnBeers);
            this.pnlDrinks.Controls.Add(this.btnSoftDrinks);
            this.pnlDrinks.Controls.Add(this.lblDrinks);
            this.pnlDrinks.Location = new System.Drawing.Point(0, 112);
            this.pnlDrinks.Name = "pnlDrinks";
            this.pnlDrinks.Size = new System.Drawing.Size(364, 776);
            this.pnlDrinks.TabIndex = 4;
            // 
            // btnCoffeeTea
            // 
            this.btnCoffeeTea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnCoffeeTea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCoffeeTea.FlatAppearance.BorderSize = 0;
            this.btnCoffeeTea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoffeeTea.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCoffeeTea.Image = global::ChapeauUI.Properties.Resources.Coffee_Cup_Hot_png;
            this.btnCoffeeTea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCoffeeTea.Location = new System.Drawing.Point(51, 541);
            this.btnCoffeeTea.Name = "btnCoffeeTea";
            this.btnCoffeeTea.Size = new System.Drawing.Size(254, 75);
            this.btnCoffeeTea.TabIndex = 5;
            this.btnCoffeeTea.Text = "   Coffee/Tea";
            this.btnCoffeeTea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCoffeeTea.UseVisualStyleBackColor = false;
            this.btnCoffeeTea.Click += new System.EventHandler(this.btnCoffeeTea_Click);
            // 
            // btnSpirits
            // 
            this.btnSpirits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnSpirits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpirits.FlatAppearance.BorderSize = 0;
            this.btnSpirits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpirits.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSpirits.Image = global::ChapeauUI.Properties.Resources.Food_Restaurant_Drink_Whiskey_png;
            this.btnSpirits.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpirits.Location = new System.Drawing.Point(51, 440);
            this.btnSpirits.Name = "btnSpirits";
            this.btnSpirits.Size = new System.Drawing.Size(254, 75);
            this.btnSpirits.TabIndex = 4;
            this.btnSpirits.Text = "   Spirits";
            this.btnSpirits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpirits.UseVisualStyleBackColor = false;
            this.btnSpirits.Click += new System.EventHandler(this.btnSpirits_Click);
            // 
            // btnWines
            // 
            this.btnWines.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnWines.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWines.FlatAppearance.BorderSize = 0;
            this.btnWines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWines.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnWines.Image = ((System.Drawing.Image)(resources.GetObject("btnWines.Image")));
            this.btnWines.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWines.Location = new System.Drawing.Point(51, 340);
            this.btnWines.Name = "btnWines";
            this.btnWines.Size = new System.Drawing.Size(254, 75);
            this.btnWines.TabIndex = 3;
            this.btnWines.Text = "   Wines";
            this.btnWines.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWines.UseVisualStyleBackColor = false;
            this.btnWines.Click += new System.EventHandler(this.btnWines_Click);
            // 
            // btnBeers
            // 
            this.btnBeers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnBeers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBeers.FlatAppearance.BorderSize = 0;
            this.btnBeers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeers.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBeers.Image = global::ChapeauUI.Properties.Resources.Beer_Mug_png;
            this.btnBeers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBeers.Location = new System.Drawing.Point(51, 240);
            this.btnBeers.Name = "btnBeers";
            this.btnBeers.Size = new System.Drawing.Size(254, 75);
            this.btnBeers.TabIndex = 2;
            this.btnBeers.Text = "   Beers";
            this.btnBeers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBeers.UseVisualStyleBackColor = false;
            this.btnBeers.Click += new System.EventHandler(this.btnBeers_Click);
            // 
            // btnSoftDrinks
            // 
            this.btnSoftDrinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnSoftDrinks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSoftDrinks.FlatAppearance.BorderSize = 0;
            this.btnSoftDrinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoftDrinks.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSoftDrinks.Image = global::ChapeauUI.Properties.Resources.Soft_Drinks_Glass_png;
            this.btnSoftDrinks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSoftDrinks.Location = new System.Drawing.Point(51, 143);
            this.btnSoftDrinks.Name = "btnSoftDrinks";
            this.btnSoftDrinks.Size = new System.Drawing.Size(254, 75);
            this.btnSoftDrinks.TabIndex = 1;
            this.btnSoftDrinks.Text = "Soft drinks";
            this.btnSoftDrinks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSoftDrinks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSoftDrinks.UseVisualStyleBackColor = false;
            this.btnSoftDrinks.Click += new System.EventHandler(this.btnSoftDrinks_Click);
            // 
            // lblDrinks
            // 
            this.lblDrinks.AutoSize = true;
            this.lblDrinks.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDrinks.Location = new System.Drawing.Point(77, 30);
            this.lblDrinks.Name = "lblDrinks";
            this.lblDrinks.Size = new System.Drawing.Size(210, 78);
            this.lblDrinks.TabIndex = 0;
            this.lblDrinks.Text = "Drinks";
            // 
            // pnlLunch
            // 
            this.pnlLunch.Controls.Add(this.btnDesserts);
            this.pnlLunch.Controls.Add(this.btnLunchMains);
            this.pnlLunch.Controls.Add(this.btnLunchStarters);
            this.pnlLunch.Controls.Add(this.lblLunch);
            this.pnlLunch.Location = new System.Drawing.Point(0, 112);
            this.pnlLunch.Name = "pnlLunch";
            this.pnlLunch.Size = new System.Drawing.Size(364, 776);
            this.pnlLunch.TabIndex = 6;
            // 
            // btnDesserts
            // 
            this.btnDesserts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnDesserts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesserts.FlatAppearance.BorderSize = 0;
            this.btnDesserts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesserts.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDesserts.Image = global::ChapeauUI.Properties.Resources.Ice_Cream_Bowl_png;
            this.btnDesserts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesserts.Location = new System.Drawing.Point(51, 340);
            this.btnDesserts.Name = "btnDesserts";
            this.btnDesserts.Size = new System.Drawing.Size(254, 75);
            this.btnDesserts.TabIndex = 3;
            this.btnDesserts.Text = "   Desserts";
            this.btnDesserts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesserts.UseVisualStyleBackColor = false;
            this.btnDesserts.Click += new System.EventHandler(this.btnDesserts_Click);
            // 
            // btnLunchMains
            // 
            this.btnLunchMains.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnLunchMains.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLunchMains.FlatAppearance.BorderSize = 0;
            this.btnLunchMains.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLunchMains.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLunchMains.Image = global::ChapeauUI.Properties.Resources.Barbecue_Steak_png;
            this.btnLunchMains.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLunchMains.Location = new System.Drawing.Point(51, 240);
            this.btnLunchMains.Name = "btnLunchMains";
            this.btnLunchMains.Size = new System.Drawing.Size(254, 75);
            this.btnLunchMains.TabIndex = 2;
            this.btnLunchMains.Text = "   Mains";
            this.btnLunchMains.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLunchMains.UseVisualStyleBackColor = false;
            this.btnLunchMains.Click += new System.EventHandler(this.btnLunchMains_Click);
            // 
            // btnLunchStarters
            // 
            this.btnLunchStarters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnLunchStarters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLunchStarters.FlatAppearance.BorderSize = 0;
            this.btnLunchStarters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLunchStarters.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLunchStarters.Image = global::ChapeauUI.Properties.Resources.Food_Soup_Bowl_png;
            this.btnLunchStarters.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLunchStarters.Location = new System.Drawing.Point(51, 143);
            this.btnLunchStarters.Name = "btnLunchStarters";
            this.btnLunchStarters.Size = new System.Drawing.Size(254, 75);
            this.btnLunchStarters.TabIndex = 1;
            this.btnLunchStarters.Text = "Starters";
            this.btnLunchStarters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLunchStarters.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLunchStarters.UseVisualStyleBackColor = false;
            this.btnLunchStarters.Click += new System.EventHandler(this.btnLunchStarters_Click);
            // 
            // lblLunch
            // 
            this.lblLunch.AutoSize = true;
            this.lblLunch.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLunch.Location = new System.Drawing.Point(77, 30);
            this.lblLunch.Name = "lblLunch";
            this.lblLunch.Size = new System.Drawing.Size(221, 78);
            this.lblLunch.TabIndex = 0;
            this.lblLunch.Text = "Lunch";
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBack.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.lblBack.Location = new System.Drawing.Point(123, 900);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(108, 44);
            this.lblBack.TabIndex = 6;
            this.lblBack.Text = "Back";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // pnlSubMenu
            // 
            this.pnlSubMenu.Controls.Add(this.lblLowStock);
            this.pnlSubMenu.Controls.Add(this.txtBoxColorIndicato);
            this.pnlSubMenu.Controls.Add(this.textBoxSubmenu);
            this.pnlSubMenu.Controls.Add(this.listViewMenu);
            this.pnlSubMenu.Location = new System.Drawing.Point(0, 112);
            this.pnlSubMenu.Name = "pnlSubMenu";
            this.pnlSubMenu.Size = new System.Drawing.Size(364, 776);
            this.pnlSubMenu.TabIndex = 6;
            // 
            // lblLowStock
            // 
            this.lblLowStock.AutoSize = true;
            this.lblLowStock.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLowStock.Location = new System.Drawing.Point(84, 454);
            this.lblLowStock.Name = "lblLowStock";
            this.lblLowStock.Size = new System.Drawing.Size(185, 42);
            this.lblLowStock.TabIndex = 4;
            this.lblLowStock.Text = "< 10 items";
            // 
            // txtBoxColorIndicato
            // 
            this.txtBoxColorIndicato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.txtBoxColorIndicato.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxColorIndicato.Enabled = false;
            this.txtBoxColorIndicato.Location = new System.Drawing.Point(35, 457);
            this.txtBoxColorIndicato.Multiline = true;
            this.txtBoxColorIndicato.Name = "txtBoxColorIndicato";
            this.txtBoxColorIndicato.Size = new System.Drawing.Size(43, 39);
            this.txtBoxColorIndicato.TabIndex = 3;
            // 
            // textBoxSubmenu
            // 
            this.textBoxSubmenu.BackColor = System.Drawing.Color.White;
            this.textBoxSubmenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSubmenu.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSubmenu.Location = new System.Drawing.Point(12, 68);
            this.textBoxSubmenu.Name = "textBoxSubmenu";
            this.textBoxSubmenu.Size = new System.Drawing.Size(346, 50);
            this.textBoxSubmenu.TabIndex = 2;
            this.textBoxSubmenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listViewMenu
            // 
            this.listViewMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.listViewMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewMenu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderName});
            this.listViewMenu.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listViewMenu.FullRowSelect = true;
            this.listViewMenu.GridLines = true;
            this.listViewMenu.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewMenu.HideSelection = false;
            this.listViewMenu.Location = new System.Drawing.Point(3, 143);
            this.listViewMenu.Name = "listViewMenu";
            this.listViewMenu.Size = new System.Drawing.Size(354, 281);
            this.listViewMenu.TabIndex = 1;
            this.listViewMenu.TileSize = new System.Drawing.Size(3, 3);
            this.listViewMenu.UseCompatibleStateImageBehavior = false;
            this.listViewMenu.View = System.Windows.Forms.View.Details;
            this.listViewMenu.SelectedIndexChanged += new System.EventHandler(this.listViewMenu_SelectedIndexChanged);
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            this.columnHeaderID.Width = 40;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 400;
            // 
            // pnlDinner
            // 
            this.pnlDinner.Controls.Add(this.btnDinnerDesserts);
            this.pnlDinner.Controls.Add(this.btnDinnerMains);
            this.pnlDinner.Controls.Add(this.btnDinnerEntremets);
            this.pnlDinner.Controls.Add(this.btnDinnerStarters);
            this.pnlDinner.Controls.Add(this.lblDinner);
            this.pnlDinner.Location = new System.Drawing.Point(0, 112);
            this.pnlDinner.Name = "pnlDinner";
            this.pnlDinner.Size = new System.Drawing.Size(364, 776);
            this.pnlDinner.TabIndex = 7;
            // 
            // btnDinnerDesserts
            // 
            this.btnDinnerDesserts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnDinnerDesserts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDinnerDesserts.FlatAppearance.BorderSize = 0;
            this.btnDinnerDesserts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDinnerDesserts.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDinnerDesserts.Image = global::ChapeauUI.Properties.Resources.Ice_Cream_Bowl_png;
            this.btnDinnerDesserts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDinnerDesserts.Location = new System.Drawing.Point(51, 440);
            this.btnDinnerDesserts.Name = "btnDinnerDesserts";
            this.btnDinnerDesserts.Size = new System.Drawing.Size(254, 75);
            this.btnDinnerDesserts.TabIndex = 4;
            this.btnDinnerDesserts.Text = "   Desserts";
            this.btnDinnerDesserts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDinnerDesserts.UseVisualStyleBackColor = false;
            this.btnDinnerDesserts.Click += new System.EventHandler(this.btnDinnerDesserts_Click);
            // 
            // btnDinnerMains
            // 
            this.btnDinnerMains.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnDinnerMains.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDinnerMains.FlatAppearance.BorderSize = 0;
            this.btnDinnerMains.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDinnerMains.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDinnerMains.Image = global::ChapeauUI.Properties.Resources.Barbecue_Steak_png;
            this.btnDinnerMains.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDinnerMains.Location = new System.Drawing.Point(51, 340);
            this.btnDinnerMains.Name = "btnDinnerMains";
            this.btnDinnerMains.Size = new System.Drawing.Size(254, 75);
            this.btnDinnerMains.TabIndex = 3;
            this.btnDinnerMains.Text = "   Mains";
            this.btnDinnerMains.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDinnerMains.UseVisualStyleBackColor = false;
            this.btnDinnerMains.Click += new System.EventHandler(this.btnDinnerMains_Click);
            // 
            // btnDinnerEntremets
            // 
            this.btnDinnerEntremets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnDinnerEntremets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDinnerEntremets.FlatAppearance.BorderSize = 0;
            this.btnDinnerEntremets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDinnerEntremets.Font = new System.Drawing.Font("Century Gothic", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDinnerEntremets.Image = global::ChapeauUI.Properties.Resources.Vegetables_Mushroom_Soup_png;
            this.btnDinnerEntremets.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDinnerEntremets.Location = new System.Drawing.Point(51, 240);
            this.btnDinnerEntremets.Name = "btnDinnerEntremets";
            this.btnDinnerEntremets.Size = new System.Drawing.Size(254, 75);
            this.btnDinnerEntremets.TabIndex = 2;
            this.btnDinnerEntremets.Text = "   Entremets";
            this.btnDinnerEntremets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDinnerEntremets.UseVisualStyleBackColor = false;
            this.btnDinnerEntremets.Click += new System.EventHandler(this.btnDinnerEntremets_Click);
            // 
            // btnDinnerStarters
            // 
            this.btnDinnerStarters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnDinnerStarters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDinnerStarters.FlatAppearance.BorderSize = 0;
            this.btnDinnerStarters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDinnerStarters.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDinnerStarters.Image = global::ChapeauUI.Properties.Resources.Food_Soup_Bowl_png;
            this.btnDinnerStarters.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDinnerStarters.Location = new System.Drawing.Point(51, 143);
            this.btnDinnerStarters.Name = "btnDinnerStarters";
            this.btnDinnerStarters.Size = new System.Drawing.Size(254, 75);
            this.btnDinnerStarters.TabIndex = 1;
            this.btnDinnerStarters.Text = "Starters";
            this.btnDinnerStarters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDinnerStarters.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDinnerStarters.UseVisualStyleBackColor = false;
            this.btnDinnerStarters.Click += new System.EventHandler(this.btnDinnerStarters_Click);
            // 
            // lblDinner
            // 
            this.lblDinner.AutoSize = true;
            this.lblDinner.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDinner.Location = new System.Drawing.Point(77, 30);
            this.lblDinner.Name = "lblDinner";
            this.lblDinner.Size = new System.Drawing.Size(234, 78);
            this.lblDinner.TabIndex = 0;
            this.lblDinner.Text = "Dinner";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(728, 961);
            this.ControlBox = false;
            this.Controls.Add(this.pnlSubMenu);
            this.Controls.Add(this.pnlLunch);
            this.Controls.Add(this.pnlDrinks);
            this.Controls.Add(this.pnlDinner);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.pnlOrder);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlOrder.ResumeLayout(false);
            this.pnlOrder.PerformLayout();
            this.pnlDrinks.ResumeLayout(false);
            this.pnlDrinks.PerformLayout();
            this.pnlLunch.ResumeLayout(false);
            this.pnlLunch.PerformLayout();
            this.pnlSubMenu.ResumeLayout(false);
            this.pnlSubMenu.PerformLayout();
            this.pnlDinner.ResumeLayout(false);
            this.pnlDinner.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnDrinks;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Panel pnlOrder;
        private System.Windows.Forms.Button btnDinner;
        private System.Windows.Forms.Button btnLunch;
        private System.Windows.Forms.Panel pnlDrinks;
        private System.Windows.Forms.Button btnWines;
        private System.Windows.Forms.Button btnBeers;
        private System.Windows.Forms.Button btnSoftDrinks;
        private System.Windows.Forms.Label lblDrinks;
        private System.Windows.Forms.Button btnCoffeeTea;
        private System.Windows.Forms.Button btnSpirits;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Panel pnlSubMenu;
        private System.Windows.Forms.ListView listViewMenu;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.TextBox textBoxSubmenu;
        private System.Windows.Forms.Panel pnlLunch;
        private System.Windows.Forms.Button btnDesserts;
        private System.Windows.Forms.Button btnLunchMains;
        private System.Windows.Forms.Button btnLunchStarters;
        private System.Windows.Forms.Label lblLunch;
        private System.Windows.Forms.Panel pnlDinner;
        private System.Windows.Forms.Button btnDinnerDesserts;
        private System.Windows.Forms.Button btnDinnerMains;
        private System.Windows.Forms.Button btnDinnerEntremets;
        private System.Windows.Forms.Button btnDinnerStarters;
        private System.Windows.Forms.Label lblDinner;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.ListView listViewOrder;
        private System.Windows.Forms.ColumnHeader columnHeaderOrderItemName;
        private System.Windows.Forms.ColumnHeader columnHeaderComment;
        private System.Windows.Forms.ColumnHeader columnHeaderOrderQuantity;
        private System.Windows.Forms.Button btnSubmitOrder;
        private System.Windows.Forms.Button btnRemoveOrder;
        private System.Windows.Forms.Label lblLowStock;
        private System.Windows.Forms.TextBox txtBoxColorIndicato;
    }
}