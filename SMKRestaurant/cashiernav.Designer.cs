namespace SMKRestaurant
{
    partial class cashiernav
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
            this.btnpay = new System.Windows.Forms.Button();
            this.btnchpass = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.lblwelcome = new System.Windows.Forms.Label();
            this.btnorder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(235, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "CASHIER NAV";
            // 
            // btnpay
            // 
            this.btnpay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnpay.Location = new System.Drawing.Point(252, 144);
            this.btnpay.Name = "btnpay";
            this.btnpay.Size = new System.Drawing.Size(275, 59);
            this.btnpay.TabIndex = 1;
            this.btnpay.Text = "Payment";
            this.btnpay.UseVisualStyleBackColor = true;
            this.btnpay.Click += new System.EventHandler(this.btnpay_Click);
            // 
            // btnchpass
            // 
            this.btnchpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnchpass.Location = new System.Drawing.Point(252, 306);
            this.btnchpass.Name = "btnchpass";
            this.btnchpass.Size = new System.Drawing.Size(275, 59);
            this.btnchpass.TabIndex = 2;
            this.btnchpass.Text = "Change Password";
            this.btnchpass.UseVisualStyleBackColor = true;
            // 
            // btnlogout
            // 
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnlogout.Location = new System.Drawing.Point(252, 386);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(275, 59);
            this.btnlogout.TabIndex = 3;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblwelcome.Location = new System.Drawing.Point(35, 82);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(121, 29);
            this.lblwelcome.TabIndex = 4;
            this.lblwelcome.Text = "Welcome,";
            // 
            // btnorder
            // 
            this.btnorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnorder.Location = new System.Drawing.Point(252, 227);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(275, 57);
            this.btnorder.TabIndex = 5;
            this.btnorder.Text = "Order List";
            this.btnorder.UseVisualStyleBackColor = true;
            this.btnorder.Click += new System.EventHandler(this.btnorder_Click);
            // 
            // cashiernav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 489);
            this.Controls.Add(this.btnorder);
            this.Controls.Add(this.lblwelcome);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnchpass);
            this.Controls.Add(this.btnpay);
            this.Controls.Add(this.label1);
            this.Name = "cashiernav";
            this.Text = "cashiernav";
            this.Load += new System.EventHandler(this.cashiernav_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnpay;
        private System.Windows.Forms.Button btnchpass;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Label lblwelcome;
        private System.Windows.Forms.Button btnorder;
    }
}