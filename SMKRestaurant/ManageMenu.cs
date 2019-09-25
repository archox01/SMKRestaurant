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
        List<msmenu> list;
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
            imgc img1 = new imgc();
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
            dataGridView1.Refresh();


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
            dataGridView1.DataSource = st;

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex > 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtmenuid.Text = row.Cells["menuid"].Value.ToString();
                var data = (from g in dbku.msmenus where g.menuid == int.Parse(txtmenuid.Text) select g).First();
                txtmenun.Text = data.name;
                txtprice.Text = data.price.ToString();

                pbfood.Image = arraytoimg(data.photo.ToArray());

            }
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
            catch(Exception s)
            {
                MessageBox.Show("Masukkan ID data yang ingin di hapus");
            }
        }
    }
}
