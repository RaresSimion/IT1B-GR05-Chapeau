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
            this.lblSelectedItem = new System.Windows.Forms.Label();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblSelectedItemTxt = new System.Windows.Forms.Label();
            this.lblIDTxt = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.lblComment = new System.Windows.Forms.Label();
            this.textBoxOrderComment = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSelectedItem
            // 
            this.lblSelectedItem.AutoSize = true;
            this.lblSelectedItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSelectedItem.Location = new System.Drawing.Point(23, 33);
            this.lblSelectedItem.Name = "lblSelectedItem";
            this.lblSelectedItem.Size = new System.Drawing.Size(171, 31);
            this.lblSelectedItem.TabIndex = 0;
            this.lblSelectedItem.Text = "Selected Item: ";
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Location = new System.Drawing.Point(197, 308);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(203, 56);
            this.btnAddToOrder.TabIndex = 1;
            this.btnAddToOrder.Text = "Add to order";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblID.Location = new System.Drawing.Point(23, 69);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(50, 31);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID: ";
            // 
            // lblSelectedItemTxt
            // 
            this.lblSelectedItemTxt.AutoSize = true;
            this.lblSelectedItemTxt.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSelectedItemTxt.Location = new System.Drawing.Point(219, 33);
            this.lblSelectedItemTxt.Name = "lblSelectedItemTxt";
            this.lblSelectedItemTxt.Size = new System.Drawing.Size(0, 31);
            this.lblSelectedItemTxt.TabIndex = 3;
            // 
            // lblIDTxt
            // 
            this.lblIDTxt.AutoSize = true;
            this.lblIDTxt.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIDTxt.Location = new System.Drawing.Point(219, 69);
            this.lblIDTxt.Name = "lblIDTxt";
            this.lblIDTxt.Size = new System.Drawing.Size(0, 31);
            this.lblIDTxt.TabIndex = 4;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuantity.Location = new System.Drawing.Point(23, 111);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(114, 31);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "Quantity:";
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMinus.Location = new System.Drawing.Point(219, 111);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(41, 38);
            this.btnMinus.TabIndex = 7;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPlus.Location = new System.Drawing.Point(330, 111);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(41, 38);
            this.btnPlus.TabIndex = 8;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblComment.Location = new System.Drawing.Point(23, 157);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(129, 31);
            this.lblComment.TabIndex = 9;
            this.lblComment.Text = "Comments";
            // 
            // textBoxOrderComment
            // 
            this.textBoxOrderComment.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxOrderComment.Location = new System.Drawing.Point(23, 206);
            this.textBoxOrderComment.Multiline = true;
            this.textBoxOrderComment.Name = "textBoxOrderComment";
            this.textBoxOrderComment.Size = new System.Drawing.Size(531, 85);
            this.textBoxOrderComment.TabIndex = 10;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxQuantity.Location = new System.Drawing.Point(266, 111);
            this.textBoxQuantity.Multiline = true;
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(58, 38);
            this.textBoxQuantity.TabIndex = 11;
            this.textBoxQuantity.Text = "1";
            this.textBoxQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxQuantity.TextChanged += new System.EventHandler(this.textBoxQuantity_TextChanged);
            // 
            // MenuItemPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 376);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.textBoxOrderComment);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblIDTxt);
            this.Controls.Add(this.lblSelectedItemTxt);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnAddToOrder);
            this.Controls.Add(this.lblSelectedItem);
            this.Name = "MenuItemPopUp";
            this.Text = "Choose options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectedItem;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblSelectedItemTxt;
        private System.Windows.Forms.Label lblIDTxt;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TextBox textBoxOrderComment;
        private System.Windows.Forms.TextBox textBoxQuantity;
    }
}