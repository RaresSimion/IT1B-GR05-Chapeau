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
            this.btnLeftScroll = new System.Windows.Forms.Button();
            this.btnScrollRight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewLogo1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeadingKitchenView
            // 
            this.lblHeadingKitchenView.AutoSize = true;
            this.lblHeadingKitchenView.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeadingKitchenView.Location = new System.Drawing.Point(720, -14);
            this.lblHeadingKitchenView.Name = "lblHeadingKitchenView";
            this.lblHeadingKitchenView.Size = new System.Drawing.Size(437, 89);
            this.lblHeadingKitchenView.TabIndex = 0;
            this.lblHeadingKitchenView.Text = "Kitchen view";
            // 
            // viewLogo1
            // 
            this.viewLogo1.Image = global::ChapeauUI.Properties.Resources.Chapeau_Logo1;
            this.viewLogo1.Location = new System.Drawing.Point(27, 12);
            this.viewLogo1.Name = "viewLogo1";
            this.viewLogo1.Size = new System.Drawing.Size(188, 97);
            this.viewLogo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.viewLogo1.TabIndex = 1;
            this.viewLogo1.TabStop = false;
            // 
            // lblLine1
            // 
            this.lblLine1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLine1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLine1.Location = new System.Drawing.Point(-1, 133);
            this.lblLine1.Name = "lblLine1";
            this.lblLine1.Size = new System.Drawing.Size(1900, 2);
            this.lblLine1.TabIndex = 2;
            // 
            // lblOverview
            // 
            this.lblOverview.AutoSize = true;
            this.lblOverview.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOverview.Location = new System.Drawing.Point(848, 67);
            this.lblOverview.Name = "lblOverview";
            this.lblOverview.Size = new System.Drawing.Size(196, 57);
            this.lblOverview.TabIndex = 3;
            this.lblOverview.Text = "Overview";
            // 
            // btnKitchenNewOrders
            // 
            this.btnKitchenNewOrders.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKitchenNewOrders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKitchenNewOrders.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKitchenNewOrders.ForeColor = System.Drawing.Color.Black;
            this.btnKitchenNewOrders.Location = new System.Drawing.Point(1635, 4);
            this.btnKitchenNewOrders.Name = "btnKitchenNewOrders";
            this.btnKitchenNewOrders.Size = new System.Drawing.Size(202, 60);
            this.btnKitchenNewOrders.TabIndex = 4;
            this.btnKitchenNewOrders.Text = "Newest orders";
            this.btnKitchenNewOrders.UseVisualStyleBackColor = false;
            // 
            // btnKitchenEarliestOrders
            // 
            this.btnKitchenEarliestOrders.BackColor = System.Drawing.Color.CadetBlue;
            this.btnKitchenEarliestOrders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKitchenEarliestOrders.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKitchenEarliestOrders.ForeColor = System.Drawing.Color.Black;
            this.btnKitchenEarliestOrders.Location = new System.Drawing.Point(1635, 70);
            this.btnKitchenEarliestOrders.Name = "btnKitchenEarliestOrders";
            this.btnKitchenEarliestOrders.Size = new System.Drawing.Size(202, 60);
            this.btnKitchenEarliestOrders.TabIndex = 5;
            this.btnKitchenEarliestOrders.Text = "Earliest orders";
            this.btnKitchenEarliestOrders.UseVisualStyleBackColor = false;
            // 
            // flowpnlKitchenView
            // 
            this.flowpnlKitchenView.Location = new System.Drawing.Point(95, 133);
            this.flowpnlKitchenView.Name = "flowpnlKitchenView";
            this.flowpnlKitchenView.Size = new System.Drawing.Size(1715, 902);
            this.flowpnlKitchenView.TabIndex = 6;
            // 
            // btnLeftScroll
            // 
            this.btnLeftScroll.Location = new System.Drawing.Point(-1, 349);
            this.btnLeftScroll.Name = "btnLeftScroll";
            this.btnLeftScroll.Size = new System.Drawing.Size(94, 29);
            this.btnLeftScroll.TabIndex = 7;
            this.btnLeftScroll.Text = "<";
            this.btnLeftScroll.UseVisualStyleBackColor = true;
            this.btnLeftScroll.Click += new System.EventHandler(this.btnLeftScroll_Click);
            // 
            // btnScrollRight
            // 
            this.btnScrollRight.Location = new System.Drawing.Point(1805, 440);
            this.btnScrollRight.Name = "btnScrollRight";
            this.btnScrollRight.Size = new System.Drawing.Size(94, 29);
            this.btnScrollRight.TabIndex = 8;
            this.btnScrollRight.Text = ">";
            this.btnScrollRight.UseVisualStyleBackColor = true;
            this.btnScrollRight.Click += new System.EventHandler(this.btnScrollRight_Click);
            // 
            // KitchenViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.btnScrollRight);
            this.Controls.Add(this.btnLeftScroll);
            this.Controls.Add(this.flowpnlKitchenView);
            this.Controls.Add(this.btnKitchenEarliestOrders);
            this.Controls.Add(this.btnKitchenNewOrders);
            this.Controls.Add(this.lblOverview);
            this.Controls.Add(this.lblLine1);
            this.Controls.Add(this.viewLogo1);
            this.Controls.Add(this.lblHeadingKitchenView);
            this.Name = "KitchenViewForm";
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
        private System.Windows.Forms.Button btnKitchenNewOrders;
        private System.Windows.Forms.Button btnKitchenEarliestOrders;
        private System.Windows.Forms.FlowLayoutPanel flowpnlKitchenView;
        private System.Windows.Forms.Button btnLeftScroll;
        private System.Windows.Forms.Button btnScrollRight;
    }
}