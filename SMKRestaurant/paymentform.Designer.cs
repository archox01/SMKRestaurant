namespace SMKRestaurant
{
    partial class paymentform
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmborderid = new System.Windows.Forms.ComboBox();
            this.dgrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmprice2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbpay = new System.Windows.Forms.ComboBox();
            this.cmbbank = new System.Windows.Forms.ComboBox();
            this.txtcard = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbltotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(268, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORM PAYMENT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(77, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Order Id";
            // 
            // cmborderid
            // 
            this.cmborderid.FormattingEnabled = true;
            this.cmborderid.Location = new System.Drawing.Point(232, 91);
            this.cmborderid.Name = "cmborderid";
            this.cmborderid.Size = new System.Drawing.Size(300, 28);
            this.cmborderid.TabIndex = 2;
            // 
            // dgrid
            // 
            this.dgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.clmqty,
            this.clmprice2,
            this.clmtotal});
            this.dgrid.Location = new System.Drawing.Point(33, 138);
            this.dgrid.Name = "dgrid";
            this.dgrid.RowTemplate.Height = 28;
            this.dgrid.Size = new System.Drawing.Size(686, 242);
            this.dgrid.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Menu";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // clmqty
            // 
            this.clmqty.HeaderText = "Quantity";
            this.clmqty.Name = "clmqty";
            // 
            // clmprice2
            // 
            this.clmprice2.HeaderText = "Price";
            this.clmprice2.Name = "clmprice2";
            // 
            // clmtotal
            // 
            this.clmtotal.HeaderText = "Total";
            this.clmtotal.Name = "clmtotal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(56, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Payment Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(56, 464);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Card Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(56, 510);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Bank Name";
            // 
            // cmbpay
            // 
            this.cmbpay.FormattingEnabled = true;
            this.cmbpay.Items.AddRange(new object[] {
            "Bank Transfer",
            "Credit Card"});
            this.cmbpay.Location = new System.Drawing.Point(247, 418);
            this.cmbpay.Name = "cmbpay";
            this.cmbpay.Size = new System.Drawing.Size(300, 28);
            this.cmbpay.TabIndex = 14;
            // 
            // cmbbank
            // 
            this.cmbbank.FormattingEnabled = true;
            this.cmbbank.Items.AddRange(new object[] {
            "BNI",
            "BRI",
            "Mandiri"});
            this.cmbbank.Location = new System.Drawing.Point(247, 510);
            this.cmbbank.Name = "cmbbank";
            this.cmbbank.Size = new System.Drawing.Size(300, 28);
            this.cmbbank.TabIndex = 15;
            // 
            // txtcard
            // 
            this.txtcard.Location = new System.Drawing.Point(247, 467);
            this.txtcard.Name = "txtcard";
            this.txtcard.Size = new System.Drawing.Size(300, 26);
            this.txtcard.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(449, 561);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 37);
            this.button1.TabIndex = 17;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lbltotal.Location = new System.Drawing.Point(534, 383);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(56, 20);
            this.lbltotal.TabIndex = 18;
            this.lbltotal.Text = "Total : ";
            // 
            // paymentform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 657);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtcard);
            this.Controls.Add(this.cmbbank);
            this.Controls.Add(this.cmbpay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgrid);
            this.Controls.Add(this.cmborderid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "paymentform";
            this.Text = "paymentform";
            this.Load += new System.EventHandler(this.paymentform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmborderid;
        private System.Windows.Forms.DataGridView dgrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmprice2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmtotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbpay;
        private System.Windows.Forms.ComboBox cmbbank;
        private System.Windows.Forms.TextBox txtcard;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbltotal;
    }
}