namespace SMKRestaurant
{
    partial class AdmNav
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
            this.btnmanemp = new System.Windows.Forms.Button();
            this.btnmanmenu = new System.Windows.Forms.Button();
            this.btnmanmem = new System.Windows.Forms.Button();
            this.btnchpass = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(234, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMIN NAVIGATION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "WELCOME,  ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnmanemp
            // 
            this.btnmanemp.Location = new System.Drawing.Point(233, 132);
            this.btnmanemp.Name = "btnmanemp";
            this.btnmanemp.Size = new System.Drawing.Size(297, 41);
            this.btnmanemp.TabIndex = 2;
            this.btnmanemp.Text = "MANAGE EMPLOYEE";
            this.btnmanemp.UseVisualStyleBackColor = true;
            this.btnmanemp.Click += new System.EventHandler(this.btnmanemp_Click);
            // 
            // btnmanmenu
            // 
            this.btnmanmenu.Location = new System.Drawing.Point(233, 197);
            this.btnmanmenu.Name = "btnmanmenu";
            this.btnmanmenu.Size = new System.Drawing.Size(297, 41);
            this.btnmanmenu.TabIndex = 3;
            this.btnmanmenu.Text = "MANAGE MENU";
            this.btnmanmenu.UseVisualStyleBackColor = true;
            this.btnmanmenu.Click += new System.EventHandler(this.btnmanmenu_Click);
            // 
            // btnmanmem
            // 
            this.btnmanmem.Location = new System.Drawing.Point(233, 260);
            this.btnmanmem.Name = "btnmanmem";
            this.btnmanmem.Size = new System.Drawing.Size(297, 41);
            this.btnmanmem.TabIndex = 4;
            this.btnmanmem.Text = "MANAGE MEMBER";
            this.btnmanmem.UseVisualStyleBackColor = true;
            this.btnmanmem.Click += new System.EventHandler(this.btnmanmem_Click);
            // 
            // btnchpass
            // 
            this.btnchpass.Location = new System.Drawing.Point(233, 316);
            this.btnchpass.Name = "btnchpass";
            this.btnchpass.Size = new System.Drawing.Size(297, 41);
            this.btnchpass.TabIndex = 5;
            this.btnchpass.Text = "CHANGE PASSWORD";
            this.btnchpass.UseVisualStyleBackColor = true;
            this.btnchpass.Click += new System.EventHandler(this.btnchpass_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(233, 375);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(297, 41);
            this.btnlogout.TabIndex = 6;
            this.btnlogout.Text = "LOGOUT";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // AdmNav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 474);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnchpass);
            this.Controls.Add(this.btnmanmem);
            this.Controls.Add(this.btnmanmenu);
            this.Controls.Add(this.btnmanemp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdmNav";
            this.Text = "AdmNav";
            this.Load += new System.EventHandler(this.AdmNav_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnmanemp;
        private System.Windows.Forms.Button btnmanmenu;
        private System.Windows.Forms.Button btnmanmem;
        private System.Windows.Forms.Button btnchpass;
        private System.Windows.Forms.Button btnlogout;
    }
}