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
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.lblComment = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.lblQuantityValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClosePopUp)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxClosePopUp
            // 
            this.pictureBoxClosePopUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.pictureBoxClosePopUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClosePopUp.Image = global::ChapeauUI.Properties.Resources.x_circle3;
            this.pictureBoxClosePopUp.Location = new System.Drawing.Point(580, 12);
            this.pictureBoxClosePopUp.Name = "pictureBoxClosePopUp";
            this.pictureBoxClosePopUp.Size = new System.Drawing.Size(68, 65);
            this.pictureBoxClosePopUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClosePopUp.TabIndex = 0;
            this.pictureBoxClosePopUp.TabStop = false;
            this.pictureBoxClosePopUp.Click += new System.EventHandler(this.pictureBoxClosePopUp_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuantity.Location = new System.Drawing.Point(179, 52);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(301, 78);
            this.lblQuantity.TabIndex = 1;
            this.lblQuantity.Text = "Quantity";
            // 
            // btnPlus
            // 
            this.btnPlus.BackgroundImage = global::ChapeauUI.Properties.Resources.plus_png;
            this.btnPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnPlus.Location = new System.Drawing.Point(358, 150);
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
            this.btnMinus.Location = new System.Drawing.Point(257, 150);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(40, 40);
            this.btnMinus.TabIndex = 5;
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblComment.Location = new System.Drawing.Point(205, 225);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(260, 58);
            this.lblComment.TabIndex = 6;
            this.lblComment.Text = "Comment";
            // 
            // textBoxComment
            // 
            this.textBoxComment.BackColor = System.Drawing.Color.White;
            this.textBoxComment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxComment.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxComment.Location = new System.Drawing.Point(70, 302);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(518, 104);
            this.textBoxComment.TabIndex = 7;
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            this.btnAddToOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToOrder.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddToOrder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddToOrder.Location = new System.Drawing.Point(205, 423);
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
            this.lblQuantityValue.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuantityValue.Location = new System.Drawing.Point(303, 141);
            this.lblQuantityValue.Name = "lblQuantityValue";
            this.lblQuantityValue.Size = new System.Drawing.Size(52, 58);
            this.lblQuantityValue.TabIndex = 9;
            this.lblQuantityValue.Text = "1";
            this.lblQuantityValue.TextChanged += new System.EventHandler(this.lblQuantityValue_TextChanged);
            // 
            // MenuItemPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(660, 493);
            this.ControlBox = false;
            this.Controls.Add(this.lblQuantityValue);
            this.Controls.Add(this.btnAddToOrder);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.pictureBoxClosePopUp);
            this.Name = "MenuItemPopUp";
            this.Text = "MenuItemPopUp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClosePopUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxClosePopUp;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.Label lblQuantityValue;
    }
}