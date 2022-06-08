namespace ChapeauUI
{
    partial class Payment
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTable = new System.Windows.Forms.Label();
            this.listViewTable = new System.Windows.Forms.ListView();
            this.columnHeaderOrderItemAmount = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderOrderItemName = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderOrderItemPrice = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderOrderItemComment = new System.Windows.Forms.ColumnHeader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlTable = new System.Windows.Forms.Panel();
            this.listView2 = new System.Windows.Forms.ListView();
            this.pnlPaymentMethod = new System.Windows.Forms.Panel();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.rbtnCash = new System.Windows.Forms.RadioButton();
            this.rbtnDebitcard = new System.Windows.Forms.RadioButton();
            this.rbtnCreditcard = new System.Windows.Forms.RadioButton();
            this.pnlLeaveTip = new System.Windows.Forms.Panel();
            this.lblLeaveTip = new System.Windows.Forms.Label();
            this.listView3 = new System.Windows.Forms.ListView();
            this.rbtnTipNo = new System.Windows.Forms.RadioButton();
            this.rbtnTipYes = new System.Windows.Forms.RadioButton();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtTipAmount = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.txtVat21 = new System.Windows.Forms.TextBox();
            this.txtVAT6 = new System.Windows.Forms.TextBox();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.lblTip = new System.Windows.Forms.Label();
            this.lblVat = new System.Windows.Forms.Label();
            this.lblTotalOrder = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlTable.SuspendLayout();
            this.pnlPaymentMethod.SuspendLayout();
            this.pnlLeaveTip.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.lblTable.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTable.ForeColor = System.Drawing.Color.Black;
            this.lblTable.Location = new System.Drawing.Point(266, 4);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(75, 28);
            this.lblTable.TabIndex = 4;
            this.lblTable.Text = "Table";
            // 
            // listViewTable
            // 
            this.listViewTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderOrderItemAmount,
            this.columnHeaderOrderItemName,
            this.columnHeaderOrderItemPrice,
            this.columnHeaderOrderItemComment});
            this.listViewTable.HideSelection = false;
            this.listViewTable.Location = new System.Drawing.Point(0, 70);
            this.listViewTable.Name = "listViewTable";
            this.listViewTable.Size = new System.Drawing.Size(626, 244);
            this.listViewTable.TabIndex = 5;
            this.listViewTable.UseCompatibleStateImageBehavior = false;
            this.listViewTable.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderOrderItemAmount
            // 
            this.columnHeaderOrderItemAmount.Text = "Amount";
            this.columnHeaderOrderItemAmount.Width = 80;
            // 
            // columnHeaderOrderItemName
            // 
            this.columnHeaderOrderItemName.Text = "Name";
            this.columnHeaderOrderItemName.Width = 250;
            // 
            // columnHeaderOrderItemPrice
            // 
            this.columnHeaderOrderItemPrice.Text = "Price";
            this.columnHeaderOrderItemPrice.Width = 80;
            // 
            // columnHeaderOrderItemComment
            // 
            this.columnHeaderOrderItemComment.Text = "Comment";
            this.columnHeaderOrderItemComment.Width = 200;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 35);
            this.panel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(175, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Order #1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Table #1";
            // 
            // pnlTable
            // 
            this.pnlTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.pnlTable.Controls.Add(this.lblTable);
            this.pnlTable.Location = new System.Drawing.Point(0, 35);
            this.pnlTable.Name = "pnlTable";
            this.pnlTable.Size = new System.Drawing.Size(626, 36);
            this.pnlTable.TabIndex = 8;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(-1, 354);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(313, 142);
            this.listView2.TabIndex = 9;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // pnlPaymentMethod
            // 
            this.pnlPaymentMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.pnlPaymentMethod.Controls.Add(this.lblPaymentMethod);
            this.pnlPaymentMethod.Location = new System.Drawing.Point(0, 314);
            this.pnlPaymentMethod.Name = "pnlPaymentMethod";
            this.pnlPaymentMethod.Size = new System.Drawing.Size(312, 41);
            this.pnlPaymentMethod.TabIndex = 9;
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.lblPaymentMethod.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPaymentMethod.ForeColor = System.Drawing.Color.Black;
            this.lblPaymentMethod.Location = new System.Drawing.Point(44, 3);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(218, 28);
            this.lblPaymentMethod.TabIndex = 4;
            this.lblPaymentMethod.Text = "Payment method:";
            // 
            // rbtnCash
            // 
            this.rbtnCash.AutoSize = true;
            this.rbtnCash.BackColor = System.Drawing.SystemColors.Window;
            this.rbtnCash.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnCash.Location = new System.Drawing.Point(50, 361);
            this.rbtnCash.Name = "rbtnCash";
            this.rbtnCash.Size = new System.Drawing.Size(92, 34);
            this.rbtnCash.TabIndex = 10;
            this.rbtnCash.TabStop = true;
            this.rbtnCash.Text = "Cash";
            this.rbtnCash.UseVisualStyleBackColor = false;
            // 
            // rbtnDebitcard
            // 
            this.rbtnDebitcard.AutoSize = true;
            this.rbtnDebitcard.BackColor = System.Drawing.SystemColors.Window;
            this.rbtnDebitcard.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnDebitcard.Location = new System.Drawing.Point(50, 441);
            this.rbtnDebitcard.Name = "rbtnDebitcard";
            this.rbtnDebitcard.Size = new System.Drawing.Size(150, 34);
            this.rbtnDebitcard.TabIndex = 11;
            this.rbtnDebitcard.TabStop = true;
            this.rbtnDebitcard.Text = "Debitcard";
            this.rbtnDebitcard.UseVisualStyleBackColor = false;
            // 
            // rbtnCreditcard
            // 
            this.rbtnCreditcard.AutoSize = true;
            this.rbtnCreditcard.BackColor = System.Drawing.SystemColors.Window;
            this.rbtnCreditcard.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnCreditcard.Location = new System.Drawing.Point(50, 401);
            this.rbtnCreditcard.Name = "rbtnCreditcard";
            this.rbtnCreditcard.Size = new System.Drawing.Size(159, 34);
            this.rbtnCreditcard.TabIndex = 12;
            this.rbtnCreditcard.TabStop = true;
            this.rbtnCreditcard.Text = "Creditcard";
            this.rbtnCreditcard.UseVisualStyleBackColor = false;
            // 
            // pnlLeaveTip
            // 
            this.pnlLeaveTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.pnlLeaveTip.Controls.Add(this.lblLeaveTip);
            this.pnlLeaveTip.Location = new System.Drawing.Point(310, 314);
            this.pnlLeaveTip.Name = "pnlLeaveTip";
            this.pnlLeaveTip.Size = new System.Drawing.Size(316, 41);
            this.pnlLeaveTip.TabIndex = 9;
            // 
            // lblLeaveTip
            // 
            this.lblLeaveTip.AutoSize = true;
            this.lblLeaveTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.lblLeaveTip.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLeaveTip.ForeColor = System.Drawing.Color.Black;
            this.lblLeaveTip.Location = new System.Drawing.Point(87, 4);
            this.lblLeaveTip.Name = "lblLeaveTip";
            this.lblLeaveTip.Size = new System.Drawing.Size(148, 28);
            this.lblLeaveTip.TabIndex = 4;
            this.lblLeaveTip.Text = "Leave a tip!";
            // 
            // listView3
            // 
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(310, 354);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(316, 142);
            this.listView3.TabIndex = 13;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // rbtnTipNo
            // 
            this.rbtnTipNo.AutoSize = true;
            this.rbtnTipNo.BackColor = System.Drawing.SystemColors.Window;
            this.rbtnTipNo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnTipNo.Location = new System.Drawing.Point(500, 379);
            this.rbtnTipNo.Name = "rbtnTipNo";
            this.rbtnTipNo.Size = new System.Drawing.Size(65, 34);
            this.rbtnTipNo.TabIndex = 14;
            this.rbtnTipNo.TabStop = true;
            this.rbtnTipNo.Text = "No";
            this.rbtnTipNo.UseVisualStyleBackColor = false;
            // 
            // rbtnTipYes
            // 
            this.rbtnTipYes.AutoSize = true;
            this.rbtnTipYes.BackColor = System.Drawing.SystemColors.Window;
            this.rbtnTipYes.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnTipYes.Location = new System.Drawing.Point(362, 379);
            this.rbtnTipYes.Name = "rbtnTipYes";
            this.rbtnTipYes.Size = new System.Drawing.Size(73, 34);
            this.rbtnTipYes.TabIndex = 15;
            this.rbtnTipYes.TabStop = true;
            this.rbtnTipYes.Text = "Yes";
            this.rbtnTipYes.UseVisualStyleBackColor = false;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.SystemColors.Window;
            this.lblAmount.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAmount.Location = new System.Drawing.Point(352, 446);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(115, 30);
            this.lblAmount.TabIndex = 16;
            this.lblAmount.Text = "Amount:";
            // 
            // txtTipAmount
            // 
            this.txtTipAmount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTipAmount.Location = new System.Drawing.Point(500, 446);
            this.txtTipAmount.Name = "txtTipAmount";
            this.txtTipAmount.Size = new System.Drawing.Size(100, 39);
            this.txtTipAmount.TabIndex = 17;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Window;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.txtTip);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.btnPay);
            this.panel6.Controls.Add(this.txtVat21);
            this.panel6.Controls.Add(this.txtVAT6);
            this.panel6.Controls.Add(this.txtOrder);
            this.panel6.Controls.Add(this.lblTip);
            this.panel6.Controls.Add(this.lblVat);
            this.panel6.Controls.Add(this.lblTotalOrder);
            this.panel6.Location = new System.Drawing.Point(0, 494);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(626, 186);
            this.panel6.TabIndex = 19;
            // 
            // txtTip
            // 
            this.txtTip.BackColor = System.Drawing.SystemColors.Window;
            this.txtTip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTip.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTip.Location = new System.Drawing.Point(307, 104);
            this.txtTip.Name = "txtTip";
            this.txtTip.ReadOnly = true;
            this.txtTip.Size = new System.Drawing.Size(276, 32);
            this.txtTip.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "Total with tip:";
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPay.Location = new System.Drawing.Point(164, 138);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(279, 44);
            this.btnPay.TabIndex = 10;
            this.btnPay.Text = "PAY BILL";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtVat21
            // 
            this.txtVat21.BackColor = System.Drawing.SystemColors.Window;
            this.txtVat21.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVat21.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtVat21.Location = new System.Drawing.Point(307, 74);
            this.txtVat21.Name = "txtVat21";
            this.txtVat21.ReadOnly = true;
            this.txtVat21.Size = new System.Drawing.Size(276, 32);
            this.txtVat21.TabIndex = 8;
            // 
            // txtVAT6
            // 
            this.txtVAT6.BackColor = System.Drawing.SystemColors.Window;
            this.txtVAT6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVAT6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtVAT6.Location = new System.Drawing.Point(307, 44);
            this.txtVAT6.Name = "txtVAT6";
            this.txtVAT6.ReadOnly = true;
            this.txtVAT6.Size = new System.Drawing.Size(276, 32);
            this.txtVAT6.TabIndex = 7;
            // 
            // txtOrder
            // 
            this.txtOrder.BackColor = System.Drawing.SystemColors.Window;
            this.txtOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOrder.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOrder.Location = new System.Drawing.Point(307, 14);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.ReadOnly = true;
            this.txtOrder.Size = new System.Drawing.Size(298, 32);
            this.txtOrder.TabIndex = 5;
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTip.Location = new System.Drawing.Point(28, 75);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(171, 30);
            this.lblTip.TabIndex = 3;
            this.lblTip.Text = "VAT rate 21%:";
            // 
            // lblVat
            // 
            this.lblVat.AutoSize = true;
            this.lblVat.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVat.Location = new System.Drawing.Point(29, 45);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(158, 30);
            this.lblVat.TabIndex = 1;
            this.lblVat.Text = "VAT rate 6%:";
            // 
            // lblTotalOrder
            // 
            this.lblTotalOrder.AutoSize = true;
            this.lblTotalOrder.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalOrder.Location = new System.Drawing.Point(28, 15);
            this.lblTotalOrder.Name = "lblTotalOrder";
            this.lblTotalOrder.Size = new System.Drawing.Size(151, 30);
            this.lblTotalOrder.TabIndex = 0;
            this.lblTotalOrder.Text = "Total Order:";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 689);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txtTipAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.rbtnTipYes);
            this.Controls.Add(this.rbtnTipNo);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.pnlLeaveTip);
            this.Controls.Add(this.rbtnCreditcard);
            this.Controls.Add(this.rbtnDebitcard);
            this.Controls.Add(this.rbtnCash);
            this.Controls.Add(this.pnlPaymentMethod);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.pnlTable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listViewTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Payment";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlTable.ResumeLayout(false);
            this.pnlTable.PerformLayout();
            this.pnlPaymentMethod.ResumeLayout(false);
            this.pnlPaymentMethod.PerformLayout();
            this.pnlLeaveTip.ResumeLayout(false);
            this.pnlLeaveTip.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.ListView listViewTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlTable;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Panel pnlPaymentMethod;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.RadioButton rbtnCash;
        private System.Windows.Forms.RadioButton rbtnDebitcard;
        private System.Windows.Forms.RadioButton rbtnCreditcard;
        private System.Windows.Forms.Panel pnlLeaveTip;
        private System.Windows.Forms.Label lblLeaveTip;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.RadioButton rbtnTipNo;
        private System.Windows.Forms.RadioButton rbtnTipYes;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtTipAmount;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtVat21;
        private System.Windows.Forms.TextBox txtVAT6;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.Label lblTotalOrder;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeaderOrderItemAmount;
        private System.Windows.Forms.ColumnHeader columnHeaderOrderItemName;
        private System.Windows.Forms.ColumnHeader columnHeaderOrderItemPrice;
        private System.Windows.Forms.ColumnHeader columnHeaderOrderItemComment;
    }
}
