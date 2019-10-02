namespace SMKRestaurant
{
    partial class ManageMenu
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
            this.txtmenuid = new System.Windows.Forms.TextBox();
            this.dgrid = new System.Windows.Forms.DataGridView();
            this.menuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Photo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmenun = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.btninsert = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.shpht = new System.Windows.Forms.Button();
            this.pbfood = new System.Windows.Forms.PictureBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtpath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbfood)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(740, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "MenuId";
            // 
            // txtmenuid
            // 
            this.txtmenuid.Location = new System.Drawing.Point(824, 86);
            this.txtmenuid.Name = "txtmenuid";
            this.txtmenuid.Size = new System.Drawing.Size(154, 26);
            this.txtmenuid.TabIndex = 1;
            // 
            // dgrid
            // 
            this.dgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menuid,
            this.clmname,
            this.clmprice,
            this.Photo});
            this.dgrid.Location = new System.Drawing.Point(12, 12);
            this.dgrid.MultiSelect = false;
            this.dgrid.Name = "dgrid";
            this.dgrid.ReadOnly = true;
            this.dgrid.RowTemplate.Height = 28;
            this.dgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid.Size = new System.Drawing.Size(683, 602);
            this.dgrid.TabIndex = 2;
            this.dgrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_CellClick);
            this.dgrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgrid_KeyDown);
            this.dgrid.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgrid_KeyUp);
            // 
            // menuid
            // 
            this.menuid.DataPropertyName = "menuid";
            this.menuid.HeaderText = "MenuId";
            this.menuid.Name = "menuid";
            this.menuid.ReadOnly = true;
            // 
            // clmname
            // 
            this.clmname.DataPropertyName = "name";
            this.clmname.HeaderText = "Name";
            this.clmname.Name = "clmname";
            this.clmname.ReadOnly = true;
            // 
            // clmprice
            // 
            this.clmprice.DataPropertyName = "price";
            this.clmprice.HeaderText = "Price";
            this.clmprice.Name = "clmprice";
            this.clmprice.ReadOnly = true;
            // 
            // Photo
            // 
            this.Photo.DataPropertyName = "photo";
            this.Photo.HeaderText = "photo";
            this.Photo.Name = "Photo";
            this.Photo.ReadOnly = true;
            this.Photo.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(742, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(742, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(742, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Path";
            // 
            // txtmenun
            // 
            this.txtmenun.Location = new System.Drawing.Point(824, 136);
            this.txtmenun.Name = "txtmenun";
            this.txtmenun.Size = new System.Drawing.Size(154, 26);
            this.txtmenun.TabIndex = 6;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(824, 191);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(154, 26);
            this.txtprice.TabIndex = 7;
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(745, 294);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(95, 43);
            this.btninsert.TabIndex = 9;
            this.btninsert.Text = "INSERT";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(875, 294);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(95, 43);
            this.btnupdate.TabIndex = 10;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(1025, 294);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(95, 43);
            this.btndel.TabIndex = 11;
            this.btndel.Text = "DELETE";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(808, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "MANAGE MENU";
            // 
            // shpht
            // 
            this.shpht.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.shpht.Location = new System.Drawing.Point(999, 239);
            this.shpht.Name = "shpht";
            this.shpht.Size = new System.Drawing.Size(54, 31);
            this.shpht.TabIndex = 14;
            this.shpht.Text = "...";
            this.shpht.UseVisualStyleBackColor = true;
            this.shpht.Click += new System.EventHandler(this.shpht_Click);
            // 
            // pbfood
            // 
            this.pbfood.Location = new System.Drawing.Point(712, 343);
            this.pbfood.Name = "pbfood";
            this.pbfood.Size = new System.Drawing.Size(443, 261);
            this.pbfood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbfood.TabIndex = 15;
            this.pbfood.TabStop = false;
            this.pbfood.Click += new System.EventHandler(this.pbfood_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(999, 83);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(91, 33);
            this.btnsearch.TabIndex = 16;
            this.btnsearch.Text = "SEARCH";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtpath
            // 
            this.txtpath.Location = new System.Drawing.Point(824, 244);
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(154, 26);
            this.txtpath.TabIndex = 17;
            // 
            // ManageMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 643);
            this.Controls.Add(this.txtpath);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.pbfood);
            this.Controls.Add(this.shpht);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtmenun);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgrid);
            this.Controls.Add(this.txtmenuid);
            this.Controls.Add(this.label1);
            this.Name = "ManageMenu";
            this.Text = "Manage Menu ";
            this.Load += new System.EventHandler(this.ManageMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbfood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmenuid;
        private System.Windows.Forms.DataGridView dgrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmenun;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button shpht;
        private System.Windows.Forms.PictureBox pbfood;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtpath;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Photo;
    }
}