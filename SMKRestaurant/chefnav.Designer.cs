namespace SMKRestaurant
{
    partial class chefnav
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
            this.lblchefnav = new System.Windows.Forms.Label();
            this.btnvorder = new System.Windows.Forms.Button();
            this.btnchpass = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblchefnav
            // 
            this.lblchefnav.AutoSize = true;
            this.lblchefnav.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblchefnav.Location = new System.Drawing.Point(255, 45);
            this.lblchefnav.Name = "lblchefnav";
            this.lblchefnav.Size = new System.Drawing.Size(289, 36);
            this.lblchefnav.TabIndex = 0;
            this.lblchefnav.Text = "CHEF NAVIGATION";
            // 
            // btnvorder
            // 
            this.btnvorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnvorder.Location = new System.Drawing.Point(261, 184);
            this.btnvorder.Name = "btnvorder";
            this.btnvorder.Size = new System.Drawing.Size(293, 54);
            this.btnvorder.TabIndex = 1;
            this.btnvorder.Text = "View Order";
            this.btnvorder.UseVisualStyleBackColor = true;
            this.btnvorder.Click += new System.EventHandler(this.btnvorder_Click);
            // 
            // btnchpass
            // 
            this.btnchpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnchpass.Location = new System.Drawing.Point(261, 259);
            this.btnchpass.Name = "btnchpass";
            this.btnchpass.Size = new System.Drawing.Size(293, 54);
            this.btnchpass.TabIndex = 3;
            this.btnchpass.Text = "Change Password";
            this.btnchpass.UseVisualStyleBackColor = true;
            this.btnchpass.Click += new System.EventHandler(this.btnchpass_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnlogout.Location = new System.Drawing.Point(261, 334);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(293, 54);
            this.btnlogout.TabIndex = 4;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(49, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome,";
            // 
            // chefnav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 476);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnchpass);
            this.Controls.Add(this.btnvorder);
            this.Controls.Add(this.lblchefnav);
            this.Name = "chefnav";
            this.Text = "chefnav";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblchefnav;
        private System.Windows.Forms.Button btnvorder;
        private System.Windows.Forms.Button btnchpass;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Label label1;
    }
}