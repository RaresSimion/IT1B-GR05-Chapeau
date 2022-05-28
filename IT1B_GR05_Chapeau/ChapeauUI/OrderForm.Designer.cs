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
            this.pnlDrinks = new System.Windows.Forms.Panel();
            this.btnCoffeeTea = new System.Windows.Forms.Button();
            this.btnSpirits = new System.Windows.Forms.Button();
            this.btnWines = new System.Windows.Forms.Button();
            this.btnBeers = new System.Windows.Forms.Button();
            this.btnSoftDrinks = new System.Windows.Forms.Button();
            this.lblDrinks = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Label();
            this.pnlSoftDrinks = new System.Windows.Forms.Panel();
            this.listViewMenu = new System.Windows.Forms.ListView();
            this.columnHeaderID = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderName = new System.Windows.Forms.ColumnHeader();
            this.lblSoftDrinks = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.pnlDrinks.SuspendLayout();
            this.pnlSoftDrinks.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::ChapeauUI.Properties.Resources.Chapeau_Logo;
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
            this.pictureBoxBack.Image = global::ChapeauUI.Properties.Resources.arrow_left_circle;
            this.pictureBoxBack.Location = new System.Drawing.Point(27, 22);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(68, 65);
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
            this.pnlOrder.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlOrder.Location = new System.Drawing.Point(364, 112);
            this.pnlOrder.Name = "pnlOrder";
            this.pnlOrder.Size = new System.Drawing.Size(364, 849);
            this.pnlOrder.TabIndex = 3;
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
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBack.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblBack.ForeColor = System.Drawing.Color.Red;
            this.lblBack.Location = new System.Drawing.Point(123, 900);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(108, 44);
            this.lblBack.TabIndex = 6;
            this.lblBack.Text = "Back";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // pnlSoftDrinks
            // 
            this.pnlSoftDrinks.Controls.Add(this.listViewMenu);
            this.pnlSoftDrinks.Controls.Add(this.lblSoftDrinks);
            this.pnlSoftDrinks.Location = new System.Drawing.Point(0, 112);
            this.pnlSoftDrinks.Name = "pnlSoftDrinks";
            this.pnlSoftDrinks.Size = new System.Drawing.Size(364, 776);
            this.pnlSoftDrinks.TabIndex = 6;
            // 
            // listViewMenu
            // 
            this.listViewMenu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderName});
            this.listViewMenu.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewMenu.HideSelection = false;
            this.listViewMenu.Location = new System.Drawing.Point(4, 111);
            this.listViewMenu.Name = "listViewMenu";
            this.listViewMenu.Size = new System.Drawing.Size(354, 414);
            this.listViewMenu.TabIndex = 1;
            this.listViewMenu.UseCompatibleStateImageBehavior = false;
            this.listViewMenu.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            this.columnHeaderID.Width = 40;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 250;
            // 
            // lblSoftDrinks
            // 
            this.lblSoftDrinks.AutoSize = true;
            this.lblSoftDrinks.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSoftDrinks.Location = new System.Drawing.Point(19, 30);
            this.lblSoftDrinks.Name = "lblSoftDrinks";
            this.lblSoftDrinks.Size = new System.Drawing.Size(339, 78);
            this.lblSoftDrinks.TabIndex = 0;
            this.lblSoftDrinks.Text = "Soft drinks";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(728, 961);
            this.ControlBox = false;
            this.Controls.Add(this.pnlSoftDrinks);
            this.Controls.Add(this.pnlDrinks);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.pnlOrder);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlHeader);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlDrinks.ResumeLayout(false);
            this.pnlDrinks.PerformLayout();
            this.pnlSoftDrinks.ResumeLayout(false);
            this.pnlSoftDrinks.PerformLayout();
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
        private System.Windows.Forms.Panel pnlSoftDrinks;
        private System.Windows.Forms.ListView listViewMenu;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.Label lblSoftDrinks;
    }
}