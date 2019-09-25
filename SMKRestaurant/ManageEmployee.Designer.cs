namespace SMKRestaurant
{
    partial class ManageEmployee
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txthp = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.btninsert = new System.Windows.Forms.Button();
            this.btnup = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.cmbpost = new System.Windows.Forms.ComboBox();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.cemid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtemid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(85, 517);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(85, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(85, 479);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(85, 599);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Position";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(85, 557);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "HandPhone";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(240, 516);
            this.txtpassword.Multiline = true;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(233, 26);
            this.txtpassword.TabIndex = 6;
            this.txtpassword.Text = "johndoe123";
            this.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpassword.UseSystemPasswordChar = true;
            this.txtpassword.Click += new System.EventHandler(this.txtpassword_TextChanged);
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(240, 440);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(233, 26);
            this.txtname.TabIndex = 7;
            this.txtname.Text = "JohnDoe";
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtname.Click += new System.EventHandler(this.txtname_TextChanged);
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // txthp
            // 
            this.txthp.Location = new System.Drawing.Point(240, 556);
            this.txthp.Multiline = true;
            this.txthp.Name = "txthp";
            this.txthp.Size = new System.Drawing.Size(233, 26);
            this.txthp.TabIndex = 9;
            this.txthp.Text = "e.g 08537512312";
            this.txthp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txthp.Click += new System.EventHandler(this.txthp_TextChanged);
            this.txthp.TextChanged += new System.EventHandler(this.txthp_TextChanged);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(240, 479);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(233, 26);
            this.txtemail.TabIndex = 8;
            this.txtemail.Text = "e.g JohnDoe@company.com";
            this.txtemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtemail.Click += new System.EventHandler(this.txtemail_TextChanged);
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(525, 385);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(91, 47);
            this.btninsert.TabIndex = 11;
            this.btninsert.Text = "INSERT";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btnup
            // 
            this.btnup.Location = new System.Drawing.Point(645, 385);
            this.btnup.Name = "btnup";
            this.btnup.Size = new System.Drawing.Size(114, 47);
            this.btnup.TabIndex = 12;
            this.btnup.Text = "UPDATE";
            this.btnup.UseVisualStyleBackColor = true;
            this.btnup.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(775, 385);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(91, 47);
            this.btndel.TabIndex = 13;
            this.btndel.Text = "DELETE";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // cmbpost
            // 
            this.cmbpost.FormattingEnabled = true;
            this.cmbpost.Items.AddRange(new object[] {
            "admin",
            "chef",
            "member",
            "cashier"});
            this.cmbpost.Location = new System.Drawing.Point(240, 599);
            this.cmbpost.Name = "cmbpost";
            this.cmbpost.Size = new System.Drawing.Size(233, 28);
            this.cmbpost.TabIndex = 14;
            // 
            // datagrid
            // 
            this.datagrid.AllowUserToOrderColumns = true;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cemid,
            this.cname,
            this.cemail,
            this.cpass,
            this.chp,
            this.cpos});
            this.datagrid.Location = new System.Drawing.Point(56, 43);
            this.datagrid.Name = "datagrid";
            this.datagrid.RowTemplate.Height = 28;
            this.datagrid.Size = new System.Drawing.Size(1084, 304);
            this.datagrid.TabIndex = 0;
            this.datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cemid
            // 
            this.cemid.DataPropertyName = "employeeid";
            this.cemid.HeaderText = "EmployeeID";
            this.cemid.Name = "cemid";
            this.cemid.ReadOnly = true;
            // 
            // cname
            // 
            this.cname.DataPropertyName = "name";
            this.cname.HeaderText = "Name";
            this.cname.Name = "cname";
            this.cname.ReadOnly = true;
            // 
            // cemail
            // 
            this.cemail.DataPropertyName = "email";
            this.cemail.HeaderText = "Email";
            this.cemail.Name = "cemail";
            this.cemail.ReadOnly = true;
            // 
            // cpass
            // 
            this.cpass.DataPropertyName = "password";
            this.cpass.HeaderText = "Password";
            this.cpass.Name = "cpass";
            this.cpass.ReadOnly = true;
            // 
            // chp
            // 
            this.chp.DataPropertyName = "handphone";
            this.chp.HeaderText = "HandPhone";
            this.chp.Name = "chp";
            this.chp.ReadOnly = true;
            // 
            // cpos
            // 
            this.cpos.DataPropertyName = "Position";
            this.cpos.HeaderText = "Position";
            this.cpos.Name = "cpos";
            this.cpos.ReadOnly = true;
            // 
            // txtemid
            // 
            this.txtemid.Location = new System.Drawing.Point(240, 400);
            this.txtemid.Multiline = true;
            this.txtemid.Name = "txtemid";
            this.txtemid.Size = new System.Drawing.Size(233, 26);
            this.txtemid.TabIndex = 16;
            this.txtemid.Text = "e.g A-xx";
            this.txtemid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(85, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "EmployeeID";
            // 
            // ManageEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 650);
            this.Controls.Add(this.txtemid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbpost);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnup);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.txthp);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datagrid);
            this.Name = "ManageEmployee";
            this.Text = "ManageEmployee";
            this.Load += new System.EventHandler(this.ManageEmployee_Load);
            this.Click += new System.EventHandler(this.ManageEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txthp;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btnup;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.ComboBox cmbpost;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.TextBox txtemid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn cemid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cemail;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpass;
        private System.Windows.Forms.DataGridViewTextBoxColumn chp;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpos;
    }
}