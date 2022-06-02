namespace ChapeauUI
{
    partial class OrderItemPopUp
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
            this.lblUpdateItem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUpdateItem
            // 
            this.lblUpdateItem.AutoSize = true;
            this.lblUpdateItem.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUpdateItem.Location = new System.Drawing.Point(90, 9);
            this.lblUpdateItem.Name = "lblUpdateItem";
            this.lblUpdateItem.Size = new System.Drawing.Size(313, 58);
            this.lblUpdateItem.TabIndex = 0;
            this.lblUpdateItem.Text = "Update item";
            // 
            // OrderItemPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(489, 384);
            this.Controls.Add(this.lblUpdateItem);
            this.Name = "OrderItemPopUp";
            this.Text = "OrderItemPopUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUpdateItem;
    }
}