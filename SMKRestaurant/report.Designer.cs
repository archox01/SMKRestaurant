namespace SMKRestaurant
{
    partial class report
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
            this.cmbfrom = new System.Windows.Forms.ComboBox();
            this.cmbto = new System.Windows.Forms.ComboBox();
            this.btngen = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmmonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clminc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(276, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "REPORT FORM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Form";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "To";
            // 
            // cmbfrom
            // 
            this.cmbfrom.FormattingEnabled = true;
            this.cmbfrom.Location = new System.Drawing.Point(283, 116);
            this.cmbfrom.Name = "cmbfrom";
            this.cmbfrom.Size = new System.Drawing.Size(232, 28);
            this.cmbfrom.TabIndex = 3;
            // 
            // cmbto
            // 
            this.cmbto.FormattingEnabled = true;
            this.cmbto.Location = new System.Drawing.Point(283, 169);
            this.cmbto.Name = "cmbto";
            this.cmbto.Size = new System.Drawing.Size(232, 28);
            this.cmbto.TabIndex = 4;
            // 
            // btngen
            // 
            this.btngen.Location = new System.Drawing.Point(568, 138);
            this.btngen.Name = "btngen";
            this.btngen.Size = new System.Drawing.Size(149, 51);
            this.btngen.TabIndex = 5;
            this.btngen.Text = "GENERATE";
            this.btngen.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmmonth,
            this.clminc});
            this.dataGridView1.Location = new System.Drawing.Point(143, 223);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(606, 268);
            this.dataGridView1.TabIndex = 6;
            // 
            // clmmonth
            // 
            this.clmmonth.HeaderText = "Month";
            this.clmmonth.Name = "clmmonth";
            // 
            // clminc
            // 
            this.clminc.HeaderText = "Income";
            this.clminc.Name = "clminc";
            // 
            // report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 644);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btngen);
            this.Controls.Add(this.cmbto);
            this.Controls.Add(this.cmbfrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "report";
            this.Text = "report";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbfrom;
        private System.Windows.Forms.ComboBox cmbto;
        private System.Windows.Forms.Button btngen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clminc;
    }
}