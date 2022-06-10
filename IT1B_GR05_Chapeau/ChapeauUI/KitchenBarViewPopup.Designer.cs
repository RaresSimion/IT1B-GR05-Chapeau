namespace ChapeauUI
{
    partial class KitchenBarViewPopup
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
            this.orderNumberLbl = new System.Windows.Forms.Label();
            this.categoryNameLbl = new System.Windows.Forms.Label();
            this.itemListView = new System.Windows.Forms.ListView();
            this.Quantity = new System.Windows.Forms.ColumnHeader();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.MarkReadyBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // orderNumberLbl
            // 
            this.orderNumberLbl.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.orderNumberLbl.ForeColor = System.Drawing.Color.Black;
            this.orderNumberLbl.Location = new System.Drawing.Point(550, 2);
            this.orderNumberLbl.Name = "orderNumberLbl";
            this.orderNumberLbl.Size = new System.Drawing.Size(300, 40);
            this.orderNumberLbl.TabIndex = 0;
            this.orderNumberLbl.Text = "Order#";
            this.orderNumberLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // categoryNameLbl
            // 
            this.categoryNameLbl.BackColor = System.Drawing.Color.Black;
            this.categoryNameLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.categoryNameLbl.Location = new System.Drawing.Point(0, 46);
            this.categoryNameLbl.Name = "categoryNameLbl";
            this.categoryNameLbl.Size = new System.Drawing.Size(1400, 36);
            this.categoryNameLbl.TabIndex = 1;
            this.categoryNameLbl.Text = "Category";
            this.categoryNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemListView
            // 
            this.itemListView.CheckBoxes = true;
            this.itemListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Quantity});
            this.itemListView.GridLines = true;
            this.itemListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.itemListView.HideSelection = false;
            this.itemListView.Location = new System.Drawing.Point(0, 82);
            this.itemListView.Name = "itemListView";
            this.itemListView.Size = new System.Drawing.Size(1400, 613);
            this.itemListView.TabIndex = 2;
            this.itemListView.UseCompatibleStateImageBehavior = false;
            this.itemListView.View = System.Windows.Forms.View.Details;
            // 
            // Quantity
            // 
            this.Quantity.Text = "";
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.CancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CancelBtn.Location = new System.Drawing.Point(300, 723);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(250, 50);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.Text = "CANCEL";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // MarkReadyBtn
            // 
            this.MarkReadyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(116)))), ((int)(((byte)(210)))));
            this.MarkReadyBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.MarkReadyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MarkReadyBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MarkReadyBtn.Location = new System.Drawing.Point(850, 723);
            this.MarkReadyBtn.Name = "MarkReadyBtn";
            this.MarkReadyBtn.Size = new System.Drawing.Size(250, 50);
            this.MarkReadyBtn.TabIndex = 4;
            this.MarkReadyBtn.Text = "MARK SELECTED READY";
            this.MarkReadyBtn.UseVisualStyleBackColor = false;
            this.MarkReadyBtn.Click += new System.EventHandler(this.MarkReadyBtn_Click);
            // 
            // KitchenBarViewPopup
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.MarkReadyBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.itemListView);
            this.Controls.Add(this.categoryNameLbl);
            this.Controls.Add(this.orderNumberLbl);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KitchenBarViewPopup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KitchenBarViewPopup";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label orderNumberLbl;
        private System.Windows.Forms.Label categoryNameLbl;
        protected System.Windows.Forms.ListView itemListView;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button MarkReadyBtn;
        private System.Windows.Forms.ColumnHeader Quantity;
    }
}