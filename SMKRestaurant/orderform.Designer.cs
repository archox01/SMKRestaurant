namespace SMKRestaurant
{
    partial class orderform
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dgatas = new System.Windows.Forms.DataGridView();
            this.smknusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smknus = new SMKRestaurant.smknus();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmname = new System.Windows.Forms.TextBox();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.dgbawah = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmprice2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.cmenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgatas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smknusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smknus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgbawah)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(300, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ORDER FORM";
            // 
            // dgatas
            // 
            this.dgatas.AutoGenerateColumns = false;
            this.dgatas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgatas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmenu,
            this.quantity,
            this.cprice});
            this.dgatas.DataSource = this.smknusBindingSource;
            this.dgatas.Location = new System.Drawing.Point(39, 50);
            this.dgatas.MultiSelect = false;
            this.dgatas.Name = "dgatas";
            this.dgatas.ReadOnly = true;
            this.dgatas.RowTemplate.Height = 28;
            this.dgatas.Size = new System.Drawing.Size(906, 260);
            this.dgatas.TabIndex = 1;
            this.dgatas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgatas.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgatas_CellEnter);
            // 
            // smknusBindingSource
            // 
            this.smknusBindingSource.DataSource = this.smknus;
            this.smknusBindingSource.Position = 0;
            // 
            // smknus
            // 
            this.smknus.DataSetName = "smknus";
            this.smknus.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(449, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Menu Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(39, 316);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 224);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(450, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(450, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Price";
            // 
            // txtmname
            // 
            this.txtmname.Location = new System.Drawing.Point(589, 344);
            this.txtmname.Multiline = true;
            this.txtmname.Name = "txtmname";
            this.txtmname.Size = new System.Drawing.Size(177, 26);
            this.txtmname.TabIndex = 6;
            // 
            // txtqty
            // 
            this.txtqty.Location = new System.Drawing.Point(589, 387);
            this.txtqty.Multiline = true;
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(177, 26);
            this.txtqty.TabIndex = 7;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(589, 432);
            this.txtprice.Multiline = true;
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(177, 26);
            this.txtprice.TabIndex = 8;
            // 
            // dgbawah
            // 
            this.dgbawah.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbawah.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.clmqty,
            this.clmprice2,
            this.clmtotal});
            this.dgbawah.Location = new System.Drawing.Point(39, 556);
            this.dgbawah.Name = "dgbawah";
            this.dgbawah.RowTemplate.Height = 28;
            this.dgbawah.Size = new System.Drawing.Size(906, 262);
            this.dgbawah.TabIndex = 9;
            this.dgbawah.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
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
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(467, 485);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(87, 33);
            this.btnadd.TabIndex = 10;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(646, 485);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(87, 33);
            this.btndel.TabIndex = 11;
            this.btndel.Text = "DELETE";
            this.btndel.UseVisualStyleBackColor = true;
            // 
            // cmenu
            // 
            this.cmenu.DataPropertyName = "name";
            this.cmenu.HeaderText = "Menu";
            this.cmenu.Name = "cmenu";
            this.cmenu.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "qty";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Visible = false;
            // 
            // cprice
            // 
            this.cprice.DataPropertyName = "price";
            this.cprice.HeaderText = "Price";
            this.cprice.Name = "cprice";
            this.cprice.ReadOnly = true;
            // 
            // orderform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 830);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dgbawah);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.txtmname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgatas);
            this.Controls.Add(this.label1);
            this.Name = "orderform";
            this.Text = "ORDER FORM";
            this.Load += new System.EventHandler(this.orderform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgatas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smknusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smknus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgbawah)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgatas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmname;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.DataGridView dgbawah;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmprice2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmtotal;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.BindingSource smknusBindingSource;
        private smknus smknus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn cprice;
    }
}