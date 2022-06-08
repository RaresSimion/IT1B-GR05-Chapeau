namespace ChapeauUI
{
    partial class MenuItemPopUp
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
            this.pictureBoxClosePopUp = new System.Windows.Forms.PictureBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.lblComment = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.lblQuantityValue = new System.Windows.Forms.Label();
            this.textBoxItem = new System.Windows.Forms.TextBox();
            this.pnlUpdateOrderItem = new System.Windows.Forms.Panel();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnUpdateOrderItem = new System.Windows.Forms.Button();
            this.lblRestockSoon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClosePopUp)).BeginInit();
            this.pnlUpdateOrderItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxClosePopUp
            // 
            this.pictureBoxClosePopUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.pictureBoxClosePopUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClosePopUp.Image = global::ChapeauUI.Properties.Resources.x_circle4;
            this.pictureBoxClosePopUp.Location = new System.Drawing.Point(471, 2);
            this.pictureBoxClosePopUp.Name = "pictureBoxClosePopUp";
            this.pictureBoxClosePopUp.Size = new System.Drawing.Size(68, 65);
            this.pictureBoxClosePopUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClosePopUp.TabIndex = 0;
            this.pictureBoxClosePopUp.TabStop = false;
            this.pictureBoxClosePopUp.Click += new System.EventHandler(this.pictureBoxClosePopUp_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackgroundImage = global::ChapeauUI.Properties.Resources.plus_png;
            this.btnPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnPlus.Location = new System.Drawing.Point(311, 139);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(40, 40);
            this.btnPlus.TabIndex = 4;
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackgroundImage = global::ChapeauUI.Properties.Resources.minus_png;
            this.btnMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnMinus.Location = new System.Drawing.Point(188, 139);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(40, 40);
            this.btnMinus.TabIndex = 5;
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblComment.Location = new System.Drawing.Point(174, 231);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(199, 44);
            this.lblComment.TabIndex = 6;
            this.lblComment.Text = "Comment";
            // 
            // textBoxComment
            // 
            this.textBoxComment.BackColor = System.Drawing.Color.White;
            this.textBoxComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxComment.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxComment.Location = new System.Drawing.Point(84, 278);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(373, 104);
            this.textBoxComment.TabIndex = 7;
            this.textBoxComment.TextChanged += new System.EventHandler(this.textBoxComment_TextChanged);
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(116)))), ((int)(((byte)(210)))));
            this.btnAddToOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddToOrder.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddToOrder.ForeColor = System.Drawing.Color.White;
            this.btnAddToOrder.Location = new System.Drawing.Point(138, 419);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(264, 58);
            this.btnAddToOrder.TabIndex = 8;
            this.btnAddToOrder.Text = "Add to order";
            this.btnAddToOrder.UseVisualStyleBackColor = false;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // lblQuantityValue
            // 
            this.lblQuantityValue.AutoSize = true;
            this.lblQuantityValue.Font = new System.Drawing.Font("Century Gothic", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuantityValue.Location = new System.Drawing.Point(244, 131);
            this.lblQuantityValue.Name = "lblQuantityValue";
            this.lblQuantityValue.Size = new System.Drawing.Size(46, 52);
            this.lblQuantityValue.TabIndex = 9;
            this.lblQuantityValue.Text = "1";
            this.lblQuantityValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblQuantityValue.TextChanged += new System.EventHandler(this.lblQuantityValue_TextChanged);
            // 
            // textBoxItem
            // 
            this.textBoxItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.textBoxItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxItem.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxItem.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxItem.ForeColor = System.Drawing.Color.Black;
            this.textBoxItem.Location = new System.Drawing.Point(22, 64);
            this.textBoxItem.Multiline = true;
            this.textBoxItem.Name = "textBoxItem";
            this.textBoxItem.Size = new System.Drawing.Size(505, 69);
            this.textBoxItem.TabIndex = 10;
            this.textBoxItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlUpdateOrderItem
            // 
            this.pnlUpdateOrderItem.Controls.Add(this.btnRemoveItem);
            this.pnlUpdateOrderItem.Controls.Add(this.btnUpdateOrderItem);
            this.pnlUpdateOrderItem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUpdateOrderItem.Location = new System.Drawing.Point(0, 388);
            this.pnlUpdateOrderItem.Name = "pnlUpdateOrderItem";
            this.pnlUpdateOrderItem.Size = new System.Drawing.Size(539, 101);
            this.pnlUpdateOrderItem.TabIndex = 11;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnRemoveItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveItem.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveItem.Location = new System.Drawing.Point(12, 22);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(240, 58);
            this.btnRemoveItem.TabIndex = 13;
            this.btnRemoveItem.Text = "Remove item";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnUpdateOrderItem
            // 
            this.btnUpdateOrderItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(116)))), ((int)(((byte)(210)))));
            this.btnUpdateOrderItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateOrderItem.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUpdateOrderItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateOrderItem.Font = new System.Drawing.Font("Century Gothic", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateOrderItem.ForeColor = System.Drawing.Color.White;
            this.btnUpdateOrderItem.Location = new System.Drawing.Point(287, 22);
            this.btnUpdateOrderItem.Name = "btnUpdateOrderItem";
            this.btnUpdateOrderItem.Size = new System.Drawing.Size(240, 58);
            this.btnUpdateOrderItem.TabIndex = 12;
            this.btnUpdateOrderItem.Text = "Update item";
            this.btnUpdateOrderItem.UseVisualStyleBackColor = false;
            this.btnUpdateOrderItem.Click += new System.EventHandler(this.btnUpdateOrderItem_Click);
            // 
            // lblRestockSoon
            // 
            this.lblRestockSoon.AutoSize = true;
            this.lblRestockSoon.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRestockSoon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.lblRestockSoon.Location = new System.Drawing.Point(0, 2);
            this.lblRestockSoon.Name = "lblRestockSoon";
            this.lblRestockSoon.Size = new System.Drawing.Size(180, 30);
            this.lblRestockSoon.TabIndex = 12;
            this.lblRestockSoon.Text = "*Restock soon";
            // 
            // MenuItemPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(539, 489);
            this.ControlBox = false;
            this.Controls.Add(this.lblRestockSoon);
            this.Controls.Add(this.pnlUpdateOrderItem);
            this.Controls.Add(this.textBoxItem);
            this.Controls.Add(this.lblQuantityValue);
            this.Controls.Add(this.btnAddToOrder);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.pictureBoxClosePopUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MenuItemPopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClosePopUp)).EndInit();
            this.pnlUpdateOrderItem.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxClosePopUp;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.Label lblQuantityValue;
        private System.Windows.Forms.TextBox textBoxItem;
        private System.Windows.Forms.Panel pnlUpdateOrderItem;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnUpdateOrderItem;
        private System.Windows.Forms.Label lblRestockSoon;
    }
}