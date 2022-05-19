namespace ChapeauUI
{
    partial class OrderViewForm
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHamburgerMenu = new System.Windows.Forms.Button();
            this.pnlHamburgerMenu = new System.Windows.Forms.Panel();
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.listViewOrder = new System.Windows.Forms.ListView();
            this.columnHeaderOrderItemID = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderOrderItemDescription = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderOrderItemQuantity = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderOrderItemComment = new System.Windows.Forms.ColumnHeader();
            this.btnDrinks = new System.Windows.Forms.Button();
            this.pnlSubDrinks = new System.Windows.Forms.Panel();
            this.btnCoffeeTea = new System.Windows.Forms.Button();
            this.btnSpiritDrinks = new System.Windows.Forms.Button();
            this.btnWines = new System.Windows.Forms.Button();
            this.btnBeers = new System.Windows.Forms.Button();
            this.btnSoftDrinks = new System.Windows.Forms.Button();
            this.listViewMenu = new System.Windows.Forms.ListView();
            this.columnHeaderID = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderDescription = new System.Windows.Forms.ColumnHeader();
            this.btnLunch = new System.Windows.Forms.Button();
            this.btnDinner = new System.Windows.Forms.Button();
            this.pnlSubLunch = new System.Windows.Forms.Panel();
            this.btnLunchDesserts = new System.Windows.Forms.Button();
            this.btnLunchMains = new System.Windows.Forms.Button();
            this.btnLunchStarters = new System.Windows.Forms.Button();
            this.pnlSubDinner = new System.Windows.Forms.Panel();
            this.btnDinnerDesserts = new System.Windows.Forms.Button();
            this.btnDinnerMains = new System.Windows.Forms.Button();
            this.btnDinnerEntremets = new System.Windows.Forms.Button();
            this.btnDinnerStarters = new System.Windows.Forms.Button();
            this.btnRemoveOrder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlSubDrinks.SuspendLayout();
            this.pnlSubLunch.SuspendLayout();
            this.pnlSubDinner.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.btnHamburgerMenu);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1322, 90);
            this.pnlHeader.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ChapeauUI.Properties.Resources.Chapeau_original;
            this.pictureBox1.Location = new System.Drawing.Point(515, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnHamburgerMenu
            // 
            this.btnHamburgerMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(186)))));
            this.btnHamburgerMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnHamburgerMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHamburgerMenu.Location = new System.Drawing.Point(1228, 0);
            this.btnHamburgerMenu.Name = "btnHamburgerMenu";
            this.btnHamburgerMenu.Size = new System.Drawing.Size(94, 90);
            this.btnHamburgerMenu.TabIndex = 0;
            this.btnHamburgerMenu.Text = "_____\r\n_____\r\n_____\r\n";
            this.btnHamburgerMenu.UseVisualStyleBackColor = false;
            this.btnHamburgerMenu.Click += new System.EventHandler(this.btnHamburgerMenu_Click);
            // 
            // pnlHamburgerMenu
            // 
            this.pnlHamburgerMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(186)))));
            this.pnlHamburgerMenu.Location = new System.Drawing.Point(1072, 96);
            this.pnlHamburgerMenu.Name = "pnlHamburgerMenu";
            this.pnlHamburgerMenu.Size = new System.Drawing.Size(250, 241);
            this.pnlHamburgerMenu.TabIndex = 1;
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrder.Location = new System.Drawing.Point(938, 106);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(109, 45);
            this.lblOrder.TabIndex = 7;
            this.lblOrder.Text = "Order";
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMenu.Location = new System.Drawing.Point(288, 106);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(110, 45);
            this.lblMenu.TabIndex = 5;
            this.lblMenu.Text = "Menu";
            // 
            // listViewOrder
            // 
            this.listViewOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            this.listViewOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderOrderItemID,
            this.columnHeaderOrderItemDescription,
            this.columnHeaderOrderItemQuantity,
            this.columnHeaderOrderItemComment});
            this.listViewOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listViewOrder.FullRowSelect = true;
            this.listViewOrder.HideSelection = false;
            this.listViewOrder.Location = new System.Drawing.Point(681, 155);
            this.listViewOrder.Name = "listViewOrder";
            this.listViewOrder.Size = new System.Drawing.Size(629, 520);
            this.listViewOrder.TabIndex = 6;
            this.listViewOrder.UseCompatibleStateImageBehavior = false;
            this.listViewOrder.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderOrderItemID
            // 
            this.columnHeaderOrderItemID.Text = "ID";
            this.columnHeaderOrderItemID.Width = 40;
            // 
            // columnHeaderOrderItemDescription
            // 
            this.columnHeaderOrderItemDescription.Text = "Description";
            this.columnHeaderOrderItemDescription.Width = 750;
            // 
            // columnHeaderOrderItemQuantity
            // 
            this.columnHeaderOrderItemQuantity.Text = "Quantity";
            this.columnHeaderOrderItemQuantity.Width = 100;
            // 
            // columnHeaderOrderItemComment
            // 
            this.columnHeaderOrderItemComment.Text = "Notes";
            this.columnHeaderOrderItemComment.Width = 200;
            // 
            // btnDrinks
            // 
            this.btnDrinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(186)))));
            this.btnDrinks.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDrinks.Location = new System.Drawing.Point(22, 427);
            this.btnDrinks.Name = "btnDrinks";
            this.btnDrinks.Size = new System.Drawing.Size(206, 58);
            this.btnDrinks.TabIndex = 8;
            this.btnDrinks.Text = "Drinks";
            this.btnDrinks.UseVisualStyleBackColor = false;
            this.btnDrinks.Click += new System.EventHandler(this.btnDrinks_Click);
            // 
            // pnlSubDrinks
            // 
            this.pnlSubDrinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(186)))));
            this.pnlSubDrinks.Controls.Add(this.btnCoffeeTea);
            this.pnlSubDrinks.Controls.Add(this.btnSpiritDrinks);
            this.pnlSubDrinks.Controls.Add(this.btnWines);
            this.pnlSubDrinks.Controls.Add(this.btnBeers);
            this.pnlSubDrinks.Controls.Add(this.btnSoftDrinks);
            this.pnlSubDrinks.Location = new System.Drawing.Point(24, 491);
            this.pnlSubDrinks.Name = "pnlSubDrinks";
            this.pnlSubDrinks.Size = new System.Drawing.Size(204, 230);
            this.pnlSubDrinks.TabIndex = 9;
            // 
            // btnCoffeeTea
            // 
            this.btnCoffeeTea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(186)))));
            this.btnCoffeeTea.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCoffeeTea.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCoffeeTea.Location = new System.Drawing.Point(0, 184);
            this.btnCoffeeTea.Name = "btnCoffeeTea";
            this.btnCoffeeTea.Size = new System.Drawing.Size(204, 46);
            this.btnCoffeeTea.TabIndex = 4;
            this.btnCoffeeTea.Text = "Coffee/Tea";
            this.btnCoffeeTea.UseVisualStyleBackColor = false;
            this.btnCoffeeTea.Click += new System.EventHandler(this.btnCoffeeTea_Click);
            // 
            // btnSpiritDrinks
            // 
            this.btnSpiritDrinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(186)))));
            this.btnSpiritDrinks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSpiritDrinks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSpiritDrinks.Location = new System.Drawing.Point(0, 138);
            this.btnSpiritDrinks.Name = "btnSpiritDrinks";
            this.btnSpiritDrinks.Size = new System.Drawing.Size(204, 46);
            this.btnSpiritDrinks.TabIndex = 3;
            this.btnSpiritDrinks.Text = "Spirit drinks";
            this.btnSpiritDrinks.UseVisualStyleBackColor = false;
            this.btnSpiritDrinks.Click += new System.EventHandler(this.btnSpiritDrinks_Click);
            // 
            // btnWines
            // 
            this.btnWines.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(186)))));
            this.btnWines.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWines.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWines.Location = new System.Drawing.Point(0, 92);
            this.btnWines.Name = "btnWines";
            this.btnWines.Size = new System.Drawing.Size(204, 46);
            this.btnWines.TabIndex = 2;
            this.btnWines.Text = "Wines";
            this.btnWines.UseVisualStyleBackColor = false;
            this.btnWines.Click += new System.EventHandler(this.btnWines_Click);
            // 
            // btnBeers
            // 
            this.btnBeers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(186)))));
            this.btnBeers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBeers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBeers.Location = new System.Drawing.Point(0, 46);
            this.btnBeers.Name = "btnBeers";
            this.btnBeers.Size = new System.Drawing.Size(204, 46);
            this.btnBeers.TabIndex = 1;
            this.btnBeers.Text = "Beers";
            this.btnBeers.UseVisualStyleBackColor = false;
            this.btnBeers.Click += new System.EventHandler(this.btnBeers_Click);
            // 
            // btnSoftDrinks
            // 
            this.btnSoftDrinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(186)))));
            this.btnSoftDrinks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSoftDrinks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSoftDrinks.Location = new System.Drawing.Point(0, 0);
            this.btnSoftDrinks.Name = "btnSoftDrinks";
            this.btnSoftDrinks.Size = new System.Drawing.Size(204, 46);
            this.btnSoftDrinks.TabIndex = 0;
            this.btnSoftDrinks.Text = "Soft drinks";
            this.btnSoftDrinks.UseVisualStyleBackColor = false;
            this.btnSoftDrinks.Click += new System.EventHandler(this.btnSoftDrinks_Click);
            // 
            // listViewMenu
            // 
            this.listViewMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.listViewMenu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderDescription});
            this.listViewMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listViewMenu.FullRowSelect = true;
            this.listViewMenu.HideSelection = false;
            this.listViewMenu.Location = new System.Drawing.Point(12, 155);
            this.listViewMenu.Name = "listViewMenu";
            this.listViewMenu.Size = new System.Drawing.Size(646, 253);
            this.listViewMenu.TabIndex = 10;
            this.listViewMenu.UseCompatibleStateImageBehavior = false;
            this.listViewMenu.View = System.Windows.Forms.View.Details;
            this.listViewMenu.SelectedIndexChanged += new System.EventHandler(this.listViewMenu_SelectedIndexChanged);
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            this.columnHeaderID.Width = 40;
            // 
            // columnHeaderDescription
            // 
            this.columnHeaderDescription.Text = "Description";
            this.columnHeaderDescription.Width = 750;
            // 
            // btnLunch
            // 
            this.btnLunch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(186)))));
            this.btnLunch.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLunch.Location = new System.Drawing.Point(234, 427);
            this.btnLunch.Name = "btnLunch";
            this.btnLunch.Size = new System.Drawing.Size(204, 58);
            this.btnLunch.TabIndex = 11;
            this.btnLunch.Text = "Lunch";
            this.btnLunch.UseVisualStyleBackColor = false;
            this.btnLunch.Click += new System.EventHandler(this.btnLunch_Click);
            // 
            // btnDinner
            // 
            this.btnDinner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(186)))));
            this.btnDinner.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDinner.Location = new System.Drawing.Point(444, 427);
            this.btnDinner.Name = "btnDinner";
            this.btnDinner.Size = new System.Drawing.Size(204, 58);
            this.btnDinner.TabIndex = 12;
            this.btnDinner.Text = "Dinner";
            this.btnDinner.UseVisualStyleBackColor = false;
            this.btnDinner.Click += new System.EventHandler(this.btnDinner_Click);
            // 
            // pnlSubLunch
            // 
            this.pnlSubLunch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(186)))));
            this.pnlSubLunch.Controls.Add(this.btnLunchDesserts);
            this.pnlSubLunch.Controls.Add(this.btnLunchMains);
            this.pnlSubLunch.Controls.Add(this.btnLunchStarters);
            this.pnlSubLunch.Location = new System.Drawing.Point(234, 491);
            this.pnlSubLunch.Name = "pnlSubLunch";
            this.pnlSubLunch.Size = new System.Drawing.Size(204, 138);
            this.pnlSubLunch.TabIndex = 13;
            // 
            // btnLunchDesserts
            // 
            this.btnLunchDesserts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(186)))));
            this.btnLunchDesserts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLunchDesserts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLunchDesserts.Location = new System.Drawing.Point(0, 92);
            this.btnLunchDesserts.Name = "btnLunchDesserts";
            this.btnLunchDesserts.Size = new System.Drawing.Size(204, 46);
            this.btnLunchDesserts.TabIndex = 2;
            this.btnLunchDesserts.Text = "Lunch desserts";
            this.btnLunchDesserts.UseVisualStyleBackColor = false;
            this.btnLunchDesserts.Click += new System.EventHandler(this.btnLunchDesserts_Click);
            // 
            // btnLunchMains
            // 
            this.btnLunchMains.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(186)))));
            this.btnLunchMains.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLunchMains.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLunchMains.Location = new System.Drawing.Point(0, 46);
            this.btnLunchMains.Name = "btnLunchMains";
            this.btnLunchMains.Size = new System.Drawing.Size(204, 46);
            this.btnLunchMains.TabIndex = 1;
            this.btnLunchMains.Text = "Lunch mains";
            this.btnLunchMains.UseVisualStyleBackColor = false;
            this.btnLunchMains.Click += new System.EventHandler(this.btnLunchMains_Click);
            // 
            // btnLunchStarters
            // 
            this.btnLunchStarters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(186)))));
            this.btnLunchStarters.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLunchStarters.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLunchStarters.Location = new System.Drawing.Point(0, 0);
            this.btnLunchStarters.Name = "btnLunchStarters";
            this.btnLunchStarters.Size = new System.Drawing.Size(204, 46);
            this.btnLunchStarters.TabIndex = 0;
            this.btnLunchStarters.Text = "Lunch starters";
            this.btnLunchStarters.UseVisualStyleBackColor = false;
            this.btnLunchStarters.Click += new System.EventHandler(this.btnLunchStarters_Click);
            // 
            // pnlSubDinner
            // 
            this.pnlSubDinner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(186)))));
            this.pnlSubDinner.Controls.Add(this.btnDinnerDesserts);
            this.pnlSubDinner.Controls.Add(this.btnDinnerMains);
            this.pnlSubDinner.Controls.Add(this.btnDinnerEntremets);
            this.pnlSubDinner.Controls.Add(this.btnDinnerStarters);
            this.pnlSubDinner.Location = new System.Drawing.Point(444, 491);
            this.pnlSubDinner.Name = "pnlSubDinner";
            this.pnlSubDinner.Size = new System.Drawing.Size(204, 184);
            this.pnlSubDinner.TabIndex = 14;
            // 
            // btnDinnerDesserts
            // 
            this.btnDinnerDesserts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(186)))));
            this.btnDinnerDesserts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDinnerDesserts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDinnerDesserts.Location = new System.Drawing.Point(0, 138);
            this.btnDinnerDesserts.Name = "btnDinnerDesserts";
            this.btnDinnerDesserts.Size = new System.Drawing.Size(204, 46);
            this.btnDinnerDesserts.TabIndex = 3;
            this.btnDinnerDesserts.Text = "Dinner desserts";
            this.btnDinnerDesserts.UseVisualStyleBackColor = false;
            this.btnDinnerDesserts.Click += new System.EventHandler(this.btnDinnerDesserts_Click);
            // 
            // btnDinnerMains
            // 
            this.btnDinnerMains.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(186)))));
            this.btnDinnerMains.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDinnerMains.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDinnerMains.Location = new System.Drawing.Point(0, 92);
            this.btnDinnerMains.Name = "btnDinnerMains";
            this.btnDinnerMains.Size = new System.Drawing.Size(204, 46);
            this.btnDinnerMains.TabIndex = 2;
            this.btnDinnerMains.Text = "Dinner mains";
            this.btnDinnerMains.UseVisualStyleBackColor = false;
            this.btnDinnerMains.Click += new System.EventHandler(this.btnDinnerMains_Click);
            // 
            // btnDinnerEntremets
            // 
            this.btnDinnerEntremets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(186)))));
            this.btnDinnerEntremets.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDinnerEntremets.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDinnerEntremets.Location = new System.Drawing.Point(0, 46);
            this.btnDinnerEntremets.Name = "btnDinnerEntremets";
            this.btnDinnerEntremets.Size = new System.Drawing.Size(204, 46);
            this.btnDinnerEntremets.TabIndex = 1;
            this.btnDinnerEntremets.Text = "Dinner entremets";
            this.btnDinnerEntremets.UseVisualStyleBackColor = false;
            this.btnDinnerEntremets.Click += new System.EventHandler(this.btnDinnerEntremets_Click);
            // 
            // btnDinnerStarters
            // 
            this.btnDinnerStarters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(186)))));
            this.btnDinnerStarters.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDinnerStarters.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDinnerStarters.Location = new System.Drawing.Point(0, 0);
            this.btnDinnerStarters.Name = "btnDinnerStarters";
            this.btnDinnerStarters.Size = new System.Drawing.Size(204, 46);
            this.btnDinnerStarters.TabIndex = 0;
            this.btnDinnerStarters.Text = "Dinner starters";
            this.btnDinnerStarters.UseVisualStyleBackColor = false;
            this.btnDinnerStarters.Click += new System.EventHandler(this.btnDinnerStarters_Click);
            // 
            // btnRemoveOrder
            // 
            this.btnRemoveOrder.BackColor = System.Drawing.Color.Red;
            this.btnRemoveOrder.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveOrder.Location = new System.Drawing.Point(1032, 683);
            this.btnRemoveOrder.Name = "btnRemoveOrder";
            this.btnRemoveOrder.Size = new System.Drawing.Size(238, 58);
            this.btnRemoveOrder.TabIndex = 15;
            this.btnRemoveOrder.Text = "Remove order";
            this.btnRemoveOrder.UseVisualStyleBackColor = false;
            this.btnRemoveOrder.Click += new System.EventHandler(this.btnRemoveOrder_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(186)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(726, 683);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 58);
            this.button1.TabIndex = 16;
            this.button1.Text = "Submit order";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // OrderViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 753);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRemoveOrder);
            this.Controls.Add(this.pnlSubDinner);
            this.Controls.Add(this.pnlSubLunch);
            this.Controls.Add(this.btnDinner);
            this.Controls.Add(this.btnLunch);
            this.Controls.Add(this.listViewMenu);
            this.Controls.Add(this.pnlSubDrinks);
            this.Controls.Add(this.btnDrinks);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.listViewOrder);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlHamburgerMenu);
            this.Name = "OrderViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order #";
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlSubDrinks.ResumeLayout(false);
            this.pnlSubLunch.ResumeLayout(false);
            this.pnlSubDinner.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnHamburgerMenu;
        private System.Windows.Forms.Panel pnlHamburgerMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.ListView listViewOrder;
        private System.Windows.Forms.ColumnHeader columnHeaderOrderItemID;
        private System.Windows.Forms.ColumnHeader columnHeaderOrderItemDescription;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Button btnDrinks;
        private System.Windows.Forms.Panel pnlSubDrinks;
        private System.Windows.Forms.Button btnCoffeeTea;
        private System.Windows.Forms.Button btnSpiritDrinks;
        private System.Windows.Forms.Button btnWines;
        private System.Windows.Forms.Button btnBeers;
        private System.Windows.Forms.Button btnSoftDrinks;
        private System.Windows.Forms.ListView listViewMenu;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderDescription;
        private System.Windows.Forms.Button btnLunch;
        private System.Windows.Forms.Button btnDinner;
        private System.Windows.Forms.Panel pnlSubLunch;
        private System.Windows.Forms.Button btnLunchDesserts;
        private System.Windows.Forms.Button btnLunchMains;
        private System.Windows.Forms.Button btnLunchStarters;
        private System.Windows.Forms.Panel pnlSubDinner;
        private System.Windows.Forms.Button btnDinnerDesserts;
        private System.Windows.Forms.Button btnDinnerMains;
        private System.Windows.Forms.Button btnDinnerEntremets;
        private System.Windows.Forms.Button btnDinnerStarters;
        private System.Windows.Forms.Button btnRemoveOrder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeaderOrderItemQuantity;
        private System.Windows.Forms.ColumnHeader columnHeaderOrderItemComment;
    }
}