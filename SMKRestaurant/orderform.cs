using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace SMKRestaurant
{
    public partial class orderform : Form
    {
         public DataTable datable;

        public DataTable dt3
        {
            get { return datable; }
        }

        public orderform()
        {
            datable = dt2.Copy();
            InitializeComponent();
            dgbawah.AutoGenerateColumns = false;
            
        }
        koneksikuDataContext dbku = new koneksikuDataContext();
        msmenu msmenus = new msmenu();
        msmember msmembers = new msmember();

        public DataTable  getData
        {
            get { return datable; }
        }

        DataTable dt2 = new DataTable();
        private void load()
        {
            var st = (from s in dbku.msmenus select s);

            this.dgatas.DataSource = st;
        }
        public DataGridView dgv { get; set; }
        DataTable dt = new DataTable();
        
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void orderform_Load(object sender, EventArgs e)
        {
            this.load();
        }

        private void dgatas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ManageMenu mm = new ManageMenu();
            txtmname.Text = dgatas.SelectedCells[0].Value.ToString();
            txtprice.Text = dgatas.SelectedCells[1].Value.ToString();
            var st = (from s in dbku.msmenus where s.name == txtmname.Text select s).First();
            pbfood.Image = mm.arraytoimg(st.photo.ToArray());
        }

        

        public DataTable  tempgrid2()
        {
            int price = int.Parse(txtprice.Text);
            int quantity = int.Parse(txtqty.Text);
            int total = price * quantity;
            
            dt2.Columns.Add("Menu");
            dt2.Columns.Add("Quantity");
            dt2.Columns.Add("Price");
            dt2.Columns.Add("Total");

            DataRow row = dt2.NewRow();

            row["Menu"] = txtmname.Text;
            row["Quantity"] = txtqty.Text;
            row["Price"] = txtprice.Text;
            row["Total"] = total;
            dt2.Rows.Add(row);

            foreach ( DataRow row2 in dt2.Rows)
            {
                int tambah = dgbawah.Rows.Add();
                dgbawah.Rows[tambah].Cells[0].Value = row2["Menu"].ToString();
                dgbawah.Rows[tambah].Cells[1].Value = row2["Quantity"].ToString();
                dgbawah.Rows[tambah].Cells[2].Value = row2["Price"].ToString();
                dgbawah.Rows[tambah].Cells[3].Value = row2["Total"].ToString();
            }
            return dt2;

           
        }
        

        private void btnadd_Click(object sender, EventArgs e)
        {
            tempgrid2();
            


        }
        
        private void btnprocess_Click(object sender, EventArgs e)
        {
            
        }

    }
}

