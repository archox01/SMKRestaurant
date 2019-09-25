namespace SMKRestaurant
{
    partial class managemember
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
            this.dgrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmemid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.btninsert = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txthp = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmemberid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cjdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrid
            // 
            this.dgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmemberid,
            this.cname,
            this.cemail,
            this.cpassword,
            this.chp,
            this.cjdate});
            this.dgrid.Location = new System.Drawing.Point(12, 71);
            this.dgrid.Name = "dgrid";
            this.dgrid.RowTemplate.Height = 28;
            this.dgrid.Size = new System.Drawing.Size(1193, 395);
            this.dgrid.TabIndex = 0;
            this.dgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(203, 549);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(418, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "MemberId";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(203, 596);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // txtmemid
            // 
            this.txtmemid.Location = new System.Drawing.Point(569, 474);
            this.txtmemid.Name = "txtmemid";
            this.txtmemid.Size = new System.Drawing.Size(146, 26);
            this.txtmemid.TabIndex = 4;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(384, 549);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(146, 26);
            this.txtname.TabIndex = 5;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(384, 596);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(146, 26);
            this.txtemail.TabIndex = 6;
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(617, 592);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(121, 35);
            this.btninsert.TabIndex = 7;
            this.btninsert.Text = "INSERT";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(773, 592);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(121, 35);
            this.btnupdate.TabIndex = 8;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(916, 590);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(121, 35);
            this.btndel.TabIndex = 9;
            this.btndel.Text = "DELETE";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(755, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(455, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "MANAGE MEMBER ";
            // 
            // txthp
            // 
            this.txthp.Location = new System.Drawing.Point(384, 694);
            this.txthp.Name = "txthp";
            this.txthp.Size = new System.Drawing.Size(146, 26);
            this.txthp.TabIndex = 15;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(384, 647);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(146, 26);
            this.txtpass.TabIndex = 14;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(203, 694);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Handphone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(203, 647);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(203, 738);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 29);
            this.label7.TabIndex = 16;
            this.label7.Text = "Join Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/mm/yyyy";
            this.dateTimePicker1.Location = new System.Drawing.Point(384, 741);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(280, 26);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.Value = new System.DateTime(2019, 9, 23, 10, 19, 29, 0);
            // 
            // cmemberid
            // 
            this.cmemberid.DataPropertyName = "memberid";
            this.cmemberid.HeaderText = "MemberId";
            this.cmemberid.Name = "cmemberid";
            this.cmemberid.ReadOnly = true;
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
            // cpassword
            // 
            this.cpassword.DataPropertyName = "password";
            this.cpassword.HeaderText = "Password";
            this.cpassword.Name = "cpassword";
            this.cpassword.ReadOnly = true;
            // 
            // chp
            // 
            this.chp.DataPropertyName = "handphone";
            this.chp.HeaderText = "Handphone";
            this.chp.Name = "chp";
            this.chp.ReadOnly = true;
            // 
            // cjdate
            // 
            this.cjdate.DataPropertyName = "joindate";
            this.cjdate.HeaderText = "Join Date";
            this.cjdate.Name = "cjdate";
            this.cjdate.ReadOnly = true;
            // 
            // managemember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 789);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txthp);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtmemid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgrid);
            this.Name = "managemember";
            this.Text = "Manage Member ";
            this.Load += new System.EventHandler(this.managemember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmemid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txthp;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmemberid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cemail;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn chp;
        private System.Windows.Forms.DataGridViewTextBoxColumn cjdate;
    }
}