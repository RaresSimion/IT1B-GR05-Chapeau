namespace ChapeauUI
{
    partial class KitchenViewForm
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
            this.lblHeadingKitchenView = new System.Windows.Forms.Label();
            this.viewLogo1 = new System.Windows.Forms.PictureBox();
            this.lblLine1 = new System.Windows.Forms.Label();
            this.lblOverview = new System.Windows.Forms.Label();
            this.btnKitchenNewOrders = new System.Windows.Forms.Button();
            this.btnKitchenEarliestOrders = new System.Windows.Forms.Button();
            this.flowpnlKitchenView = new System.Windows.Forms.FlowLayoutPanel();
            this.PageLbl = new System.Windows.Forms.Label();
            this.btnLeftScroll = new System.Windows.Forms.Button();
            this.btnScrollRight = new System.Windows.Forms.Button();
            this.lblHeadingBarView = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.viewLogo1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeadingKitchenView
            // 
            this.lblHeadingKitchenView.AutoSize = true;
            this.lblHeadingKitchenView.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeadingKitchenView.Location = new System.Drawing.Point(783, -10);
            this.lblHeadingKitchenView.Name = "lblHeadingKitchenView";
            this.lblHeadingKitchenView.Size = new System.Drawing.Size(353, 72);
            this.lblHeadingKitchenView.TabIndex = 0;
            this.lblHeadingKitchenView.Text = "Kitchen view";
            // 
            // viewLogo1
            // 
            this.viewLogo1.Image = global::ChapeauUI.Properties.Resources.Chapeau_Logo1;
            this.viewLogo1.Location = new System.Drawing.Point(0, 0);
            this.viewLogo1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewLogo1.Name = "viewLogo1";
            this.viewLogo1.Size = new System.Drawing.Size(210, 102);
            this.viewLogo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.viewLogo1.TabIndex = 1;
            this.viewLogo1.TabStop = false;
            // 
            // lblLine1
            // 
            this.lblLine1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLine1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLine1.Location = new System.Drawing.Point(0, 100);
            this.lblLine1.Name = "lblLine1";
            this.lblLine1.Size = new System.Drawing.Size(1920, 2);
            this.lblLine1.TabIndex = 2;
            // 
            // lblOverview
            // 
            this.lblOverview.AutoSize = true;
            this.lblOverview.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOverview.Location = new System.Drawing.Point(880, 50);
            this.lblOverview.Name = "lblOverview";
            this.lblOverview.Size = new System.Drawing.Size(159, 46);
            this.lblOverview.TabIndex = 3;
            this.lblOverview.Text = "Overview";
            // 
            // btnKitchenNewOrders
            // 
            this.btnKitchenNewOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(116)))), ((int)(((byte)(210)))));
            this.btnKitchenNewOrders.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnKitchenNewOrders.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnKitchenNewOrders.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKitchenNewOrders.ForeColor = System.Drawing.Color.Black;
            this.btnKitchenNewOrders.Location = new System.Drawing.Point(1431, 3);
            this.btnKitchenNewOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKitchenNewOrders.Name = "btnKitchenNewOrders";
            this.btnKitchenNewOrders.Size = new System.Drawing.Size(177, 45);
            this.btnKitchenNewOrders.TabIndex = 4;
            this.btnKitchenNewOrders.Text = "Newest orders";
            this.btnKitchenNewOrders.UseVisualStyleBackColor = false;
            this.btnKitchenNewOrders.Click += new System.EventHandler(this.btnKitchenNewOrders_Click_1);
            // 
            // btnKitchenEarliestOrders
            // 
            this.btnKitchenEarliestOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(116)))), ((int)(((byte)(210)))));
            this.btnKitchenEarliestOrders.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnKitchenEarliestOrders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKitchenEarliestOrders.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKitchenEarliestOrders.ForeColor = System.Drawing.Color.White;
            this.btnKitchenEarliestOrders.Location = new System.Drawing.Point(1431, 52);
            this.btnKitchenEarliestOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKitchenEarliestOrders.Name = "btnKitchenEarliestOrders";
            this.btnKitchenEarliestOrders.Size = new System.Drawing.Size(177, 45);
            this.btnKitchenEarliestOrders.TabIndex = 5;
            this.btnKitchenEarliestOrders.Text = "Earliest orders";
            this.btnKitchenEarliestOrders.UseVisualStyleBackColor = false;
            this.btnKitchenEarliestOrders.Click += new System.EventHandler(this.btnKitchenEarliestOrders_Click_1);
            // 
            // flowpnlKitchenView
            // 
            this.flowpnlKitchenView.AutoScroll = true;
            this.flowpnlKitchenView.Location = new System.Drawing.Point(108, 102);
            this.flowpnlKitchenView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowpnlKitchenView.Name = "flowpnlKitchenView";
            this.flowpnlKitchenView.Size = new System.Drawing.Size(1704, 1000);
            this.flowpnlKitchenView.TabIndex = 6;
            this.flowpnlKitchenView.WrapContents = false;
            // 
            // PageLbl
            // 
            this.PageLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PageLbl.Location = new System.Drawing.Point(910, 1050);
            this.PageLbl.Name = "PageLbl";
            this.PageLbl.Size = new System.Drawing.Size(100, 20);
            this.PageLbl.TabIndex = 10;
            this.PageLbl.Text = "Page";
            this.PageLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLeftScroll
            // 
            this.btnLeftScroll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(116)))), ((int)(((byte)(210)))));
            this.btnLeftScroll.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLeftScroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeftScroll.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLeftScroll.ForeColor = System.Drawing.Color.White;
            this.btnLeftScroll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLeftScroll.Location = new System.Drawing.Point(25, 420);
            this.btnLeftScroll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeftScroll.Name = "btnLeftScroll";
            this.btnLeftScroll.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLeftScroll.Size = new System.Drawing.Size(70, 400);
            this.btnLeftScroll.TabIndex = 8;
            this.btnLeftScroll.Text = "←";
            this.btnLeftScroll.UseVisualStyleBackColor = false;
            this.btnLeftScroll.Click += new System.EventHandler(this.btnLeftScroll_Click);
            // 
            // btnScrollRight
            // 
            this.btnScrollRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(116)))), ((int)(((byte)(210)))));
            this.btnScrollRight.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnScrollRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScrollRight.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnScrollRight.ForeColor = System.Drawing.Color.White;
            this.btnScrollRight.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnScrollRight.Location = new System.Drawing.Point(1825, 420);
            this.btnScrollRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnScrollRight.Name = "btnScrollRight";
            this.btnScrollRight.Size = new System.Drawing.Size(70, 400);
            this.btnScrollRight.TabIndex = 8;
            this.btnScrollRight.Text = "→";
            this.btnScrollRight.UseVisualStyleBackColor = false;
            this.btnScrollRight.Click += new System.EventHandler(this.btnScrollRight_Click);
            // 
            // lblHeadingBarView
            // 
            this.lblHeadingBarView.AutoSize = true;
            this.lblHeadingBarView.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeadingBarView.Location = new System.Drawing.Point(837, -10);
            this.lblHeadingBarView.Name = "lblHeadingBarView";
            this.lblHeadingBarView.Size = new System.Drawing.Size(246, 72);
            this.lblHeadingBarView.TabIndex = 9;
            this.lblHeadingBarView.Text = "Bar view";
            // 
            // KitchenViewForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.PageLbl);
            this.Controls.Add(this.lblHeadingBarView);
            this.Controls.Add(this.btnScrollRight);
            this.Controls.Add(this.btnLeftScroll);
            this.Controls.Add(this.flowpnlKitchenView);
            this.Controls.Add(this.btnKitchenEarliestOrders);
            this.Controls.Add(this.btnKitchenNewOrders);
            this.Controls.Add(this.lblOverview);
            this.Controls.Add(this.lblLine1);
            this.Controls.Add(this.viewLogo1);
            this.Controls.Add(this.lblHeadingKitchenView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "KitchenViewForm";
            this.ShowIcon = false;
            this.Text = "KitchenView";
            this.Load += new System.EventHandler(this.KitchenView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewLogo1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeadingKitchenView;
        private System.Windows.Forms.PictureBox viewLogo1;
        private System.Windows.Forms.Label lblLine1;
        private System.Windows.Forms.Label lblOverview;
        private System.Windows.Forms.Label lblHeadingBarView;
        public System.Windows.Forms.Button btnKitchenNewOrders;
        public System.Windows.Forms.Button btnKitchenEarliestOrders;
        public System.Windows.Forms.Button btnLeftScroll;
        public System.Windows.Forms.Button btnScrollRight;
        public System.Windows.Forms.Label PageLbl;
        public System.Windows.Forms.FlowLayoutPanel flowpnlKitchenView;
    }
}