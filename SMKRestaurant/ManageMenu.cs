using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace SMKRestaurant
{
    public partial class ManageMenu : Form
    {
        string filename;
        public ManageMenu()
        {
            InitializeComponent();
        }
        koneksikuDataContext dbku = new koneksikuDataContext();
        


        private void ManageMenu_Load(object sender, EventArgs e)
        {
            this.bind();
        }

        public Image arraytoimg(byte[] bytearrayin)
        {
            MemoryStream ms = new MemoryStream(bytearrayin);
            Image img = Image.FromStream(ms);
            return img;
        }
        public byte[] imgtoarray(System.Drawing.Image imagein)
        {
            MemoryStream ms = new MemoryStream();
            imagein.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofp = new OpenFileDialog();
            byte[] fileb = imgtoarray(pbfood.Image);
            System.Data.Linq.Binary filebi = new System.Data.Linq.Binary(fileb);
            string paths = txtpath.Text;
            //System.Data.Linq.Binary pathbi = new System.Data.Linq.Binary(paths);
            int menus = Convert.ToInt32(txtmenuid.Text);
            int prices = Convert.ToInt32(txtprice.Text);
            var tabs = new msmenu
            {
                menuid = menus,
                photo = filebi,
                name = txtmenun.Text,
                price = prices,
                path = txtpath.Text,
                
                
            }; 
            dbku.msmenus.InsertOnSubmit(tabs);
            dbku.SubmitChanges();
            MessageBox.Show("Successfull");

            this.bind();
            dgrid.Refresh();


        }

        private void pbfood_Click(object sender, EventArgs e)
        {
        }
        
        private void shpht_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = " Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                filename = opf.FileName;
                pbfood.Image =Image.FromFile(filename);
                txtpath.Text = filename;

            }
            
        }
        private void bind()
        {
            var st = from s in dbku.msmenus select s;
            dgrid.DataSource = st;

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Apakah anda yakin dengan pembaharuan yang anda buat ? ", "Konfirmasi Pembaharuan", MessageBoxButtons.OKCancel);
            byte[] file_bi = imgtoarray(pbfood.Image);
            System.Data.Linq.Binary file_bin = new System.Data.Linq.Binary(file_bi);
            int menusid = int.Parse(txtmenuid.Text);
            var sts = (from u in dbku.msmenus where u.menuid == menusid select u).First();
            sts.menuid = int.Parse(txtmenuid.Text);
                sts.name = txtmenun.Text;
                sts.price = int.Parse(txtprice.Text);
                sts.photo = file_bin;
            sts.path = txtpath.Text;
            dbku.SubmitChanges();
            MessageBox.Show("Data berhasil di update","SUKSES !!");
            this.bind();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            
            var st = (from s in dbku.msmenus where s.menuid == int.Parse(txtmenuid.Text) select s).First();
            txtmenun.Text = st.name;
            txtprice.Text = st.price.ToString();
            pbfood.Image = arraytoimg(st.photo.ToArray());
            txtpath.Text = st.path;            
        }

        private void btndel_Click(object sender, EventArgs e)
        {

            try {
                MessageBox.Show("Apakah anda ingin menghapus makanan ini?", "Peringatan", MessageBoxButtons.OKCancel);
                var st = (from s in dbku.msmenus where s.menuid == int.Parse(txtmenuid.Text) select s).First();
                dbku.msmenus.DeleteOnSubmit(st);
                dbku.SubmitChanges();
                this.bind();
                MessageBox.Show("Data Berhasil Di hapus", "Sukses !! ");
            }
            catch(Exception )
            {
                MessageBox.Show("Masukkan ID data yang ingin di hapus");
            }
        }
        private void bawahkey()
        {
            

            txtmenuid.Text = dgrid.SelectedCells[0].Value.ToString();
            txtmenun.Text = dgrid.SelectedCells[1].Value.ToString();
            txtprice.Text = dgrid.SelectedCells[2].Value.ToString();
            txtpath.Text = dgrid.SelectedCells[3].Value.ToString();
            txtpath.Text = dgrid.SelectedCells[4].Value.ToString();

            var st = (from s in dbku.msmenus where s.menuid == int.Parse(txtmenuid.Text) select s).First();

            pbfood.Image = arraytoimg(st.photo.ToArray());
        }

        private void operdata()
        {
            
            
            txtmenuid.Text = dgrid.SelectedCells[0].Value.ToString();
            txtmenun.Text = dgrid.SelectedCells[1].Value.ToString();
            txtprice.Text = dgrid.SelectedCells[2].Value.ToString();
            txtpath.Text = dgrid.SelectedCells[3].Value.ToString();
            txtpath.Text = dgrid.SelectedCells[4].Value.ToString();

            var st = (from s in dbku.msmenus where s.menuid == int.Parse(txtmenuid.Text) select s).First();

            pbfood.Image = arraytoimg(st.photo.ToArray());

        }

        private void dgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            operdata();
        }

        private void dgrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                operdata();
            }

            else if (e.KeyCode == Keys.Down)
            {
                bawahkey();
                
                
            }
            
            
        }

        private void dgrid_KeyUp(object sender, KeyEventArgs e)
        {
             
        }
    }
}
