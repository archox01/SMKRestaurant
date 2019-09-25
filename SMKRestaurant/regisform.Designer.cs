namespace SMKRestaurant
{
    partial class regisform
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
            this.txtuname = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btnregis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // txtuname
            // 
            this.txtuname.Location = new System.Drawing.Point(295, 109);
            this.txtuname.Multiline = true;
            this.txtuname.Name = "txtuname";
            this.txtuname.Size = new System.Drawing.Size(204, 32);
            this.txtuname.TabIndex = 2;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(295, 154);
            this.txtpass.Multiline = true;
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(204, 32);
            this.txtpass.TabIndex = 3;
            // 
            // btnregis
            // 
            this.btnregis.Location = new System.Drawing.Point(403, 237);
            this.btnregis.Name = "btnregis";
            this.btnregis.Size = new System.Drawing.Size(82, 35);
            this.btnregis.TabIndex = 4;
            this.btnregis.Text = "register";
            this.btnregis.UseVisualStyleBackColor = true;
            this.btnregis.Click += new System.EventHandler(this.btnregis_Click);
            // 
            // regisform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 455);
            this.Controls.Add(this.btnregis);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "regisform";
            this.Text = "regisform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtuname;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button btnregis;
    }
}