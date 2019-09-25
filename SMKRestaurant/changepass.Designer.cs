namespace SMKRestaurant
{
    partial class changepass
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtoldpass = new System.Windows.Forms.TextBox();
            this.txtnewpass1 = new System.Windows.Forms.TextBox();
            this.txtnewpass2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(153, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Old Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(153, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(153, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm Password";
            // 
            // txtoldpass
            // 
            this.txtoldpass.Location = new System.Drawing.Point(428, 128);
            this.txtoldpass.Name = "txtoldpass";
            this.txtoldpass.Size = new System.Drawing.Size(166, 26);
            this.txtoldpass.TabIndex = 3;
            this.txtoldpass.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtnewpass1
            // 
            this.txtnewpass1.Location = new System.Drawing.Point(428, 199);
            this.txtnewpass1.Name = "txtnewpass1";
            this.txtnewpass1.Size = new System.Drawing.Size(166, 26);
            this.txtnewpass1.TabIndex = 4;
            // 
            // txtnewpass2
            // 
            this.txtnewpass2.Location = new System.Drawing.Point(428, 269);
            this.txtnewpass2.Name = "txtnewpass2";
            this.txtnewpass2.Size = new System.Drawing.Size(166, 26);
            this.txtnewpass2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(262, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "CHANGE PASSWORD";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(159, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 55);
            this.button1.TabIndex = 7;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // changepass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 481);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtnewpass2);
            this.Controls.Add(this.txtnewpass1);
            this.Controls.Add(this.txtoldpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "changepass";
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.changepass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtoldpass;
        private System.Windows.Forms.TextBox txtnewpass1;
        private System.Windows.Forms.TextBox txtnewpass2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}