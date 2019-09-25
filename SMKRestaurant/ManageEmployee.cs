using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SMKRestaurant
{
    public partial class ManageEmployee : Form
    {
        public ManageEmployee()
        {
            InitializeComponent();
            this.cmbpost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }
        koneksikuDataContext dbku = new koneksikuDataContext();
        private void insertadmin()
        {

            string userem;
            string conv;
            int conv2id;
            ManageEmployee me = new ManageEmployee();
                msemployee mep = new msemployee();
            var usera1 = (from s in dbku.msemployees where s.position =="admin" orderby s.employeeid descending select s).First();
            string potong;
            string user1;
            string dapat;
            int newid;
            if( usera1 != null)
            {
                user1 = usera1.employeeid;
                conv = Convert.ToString(user1);
                potong = conv.Substring( 2, 2);
                conv2id = Convert.ToInt32(potong);
                newid = conv2id + 01;
                userem = Convert.ToString("A-0"+newid);
                dapat = userem;
                mep.name = "" + txtname.Text;
                mep.email = "" + txtemail.Text;
                mep.handphone = "" + txthp.Text;
                mep.position = "" + cmbpost.SelectedItem;
                mep.password = "" + txtpassword.Text;
                mep.employeeid = ""+dapat;

                dbku.msemployees.InsertOnSubmit(mep);
                dbku.SubmitChanges();
                MessageBox.Show("DATA PENGGUNA BERHASIL DI INPUT");
                txtname.Text = null;
                txtemail.Text = null;
                txthp.Text = null;
                txtpassword.Text = null;

            }
            else
            {
                string userid = "A-00".Substring(2, 2);
                int convert = Convert.ToInt32(userid);
                int newids = convert + 01;
                string userid2 = Convert.ToString("A-0" + newids);
                mep.name = "" + txtname.Text;
                mep.email = "" + txtemail.Text;
                mep.handphone = "" + txthp.Text;
                mep.position = "" + cmbpost.SelectedItem;
                mep.password = "" + txtpassword.Text;
                mep.employeeid = "" + userid2;

                dbku.msemployees.InsertOnSubmit(mep);
                dbku.SubmitChanges();
                MessageBox.Show("DATA PENGGUNA BERHASIL DI INPUT");
                txtname.Text = null;
                txtemail.Text = null;
                txthp.Text = null;
                txtpassword.Text = null;

            }
               
        }
        private void insertChef()
        {
            msemployee emp = new msemployee();
            var chef = (from s in dbku.msemployees where s.position == "chef" orderby s.employeeid descending select s).First();
            if (chef != null)
            {
                string user1 = chef.employeeid.Substring(2, 2);
                int convid = Convert.ToInt32(user1);
                int id1;
                id1 = convid + 1;
                string jadi = "C-" + id1;
                emp.email = "" + txtemail.Text;
                emp.password = "" + txtpassword.Text;
                emp.handphone = "" + txthp.Text;
                emp.name = "" + txtname.Text;
                emp.position = "" + cmbpost.SelectedItem;
                emp.employeeid = "" + jadi;
                dbku.msemployees.InsertOnSubmit(emp);
                dbku.SubmitChanges();
                MessageBox.Show("DATA PENGGUNA BERHASIL DI INPUT");
                txtname.Text = null;
                txtemail.Text = null;
                txthp.Text = null;
                txtpassword.Text = null;
            }
            else
            {
                msemployee mep = new msemployee();
                string user1 = "C-00".Substring(2, 2);
                int converuser1 = Convert.ToInt32(user1);
                int id1;string convertid;
                id1 = converuser1 + 01;
                convertid = Convert.ToString("C-0"+id1);
               
                mep.name = "" + txtname.Text;
                mep.email = "" + txtemail.Text;
                mep.handphone = "" + txthp.Text;
                mep.position = "" + cmbpost.SelectedItem;
                mep.password = "" + txtpassword.Text;
                mep.employeeid = "" + convertid;

                dbku.msemployees.InsertOnSubmit(mep);
                dbku.SubmitChanges();
                MessageBox.Show("DATA PENGGUNA BERHASIL DI INPUT");
                txtname.Text = null;
                txtemail.Text = null;
                txthp.Text = null;
                txtpassword.Text = null;
            }

            
        }
        private void insertM()
        {
            var member1 = (from m in dbku.msemployees where m.position == "member" select m);
            if ( member1 == null)
            {

                msemployee emp = new msemployee();
                int id = 0; 
                string members = "M-0";
                string gabung;
                int tambahm = id + 1;
                gabung = members + id;

                emp.email =  txtemail.Text+"@smknus.com";
                emp.password = "" + txtpassword.Text;
                emp.handphone = "" + txthp.Text;
                emp.name = "" + txtname.Text;
                emp.position = "" + cmbpost.SelectedItem;
                emp.employeeid = "" + gabung;
                dbku.msemployees.InsertOnSubmit(emp);
                dbku.SubmitChanges();
                MessageBox.Show("DATA PENGGUNA BERHASIL DI INPUT");
                txtname.Text = null;
                txtemail.Text = null;
                txthp.Text = null;
                txtpassword.Text = null;
            }
            else
            {

                var member3 = (from m in dbku.msemployees where m.position == "member" orderby m.employeeid descending select m).FirstOrDefault();
               
                msemployee mep = new msemployee();
                string member2 = member3.employeeid.Substring(2, 2);
                int convertmember = Convert.ToInt32(member2);
                int tambah = convertmember + 1;
                string convertidm = Convert.ToString("M-0" + tambah);


                mep.name = "" + txtname.Text;
                mep.email = "" + txtemail.Text;
                mep.handphone = "" + txthp.Text;
                mep.position = "" + cmbpost.SelectedItem;
                mep.password = "" + txtpassword.Text;
                mep.employeeid = "" + convertidm;

                dbku.msemployees.InsertOnSubmit(mep);
                dbku.SubmitChanges();
                MessageBox.Show("DATA PENGGUNA BERHASIL DI INPUT");
                txtname.Text = null;
                txtemail.Text = null;
                txthp.Text = null;
                txtpassword.Text = null;
            }
        }

        private void inscash()
        {
            koneksikuDataContext dbku = new koneksikuDataContext();
            var chaspos = (from u in dbku.msemployees where u.position == "cashier" orderby u.employeeid descending select u).First();
            string chaspost = chaspos.employeeid;
            int start = +1;
            msemployee mse = new msemployee();
            if ( chaspost != null )
            {
                string chasa = chaspost.Substring(3, 2);
                int convertchas = Convert.ToInt32(chasa);
                int tambah = convertchas + start;
                string convst = Convert.ToString("CH-0"+tambah);
                mse.name = "" + txtname.Text;
                mse.email = "" + txtemail.Text;
                mse.handphone = "" + txthp.Text;
                mse.position = "" + cmbpost.SelectedItem;
                mse.password = "" + txtpassword.Text;
                mse.employeeid = "" + convst;

                dbku.msemployees.InsertOnSubmit(mse);
                dbku.SubmitChanges();
                MessageBox.Show("DATA PENGGUNA BERHASIL DI INPUT");
                txtname.Text = null;
                txtemail.Text = null;
                txthp.Text = null;
                txtpassword.Text = null;


            }
        }
        private void mcontoh()
        {
            if(txtemail.Text == "")
            {
                txtemail.Text = "e.g JohnDoe@company.com";
            }
            if (txthp.Text == "")
            {
                txthp.Text = "e.g 08537512312";
            }
            if (txtname.Text == "")
            {
                txtname.Text = "John Doe";
            }
            if (txtpassword.Text == "")
            {
                txtpassword.Text= "johnydoe123";
            }
        }
        private void oper(object sender,DataGridViewCellEventArgs e)
        {
         
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                //msemployee mep = new msemployee();
                DataGridViewRow row = this.datagrid.Rows[e.RowIndex];
                DataGridViewColumn col = this.datagrid.Columns[e.ColumnIndex];

                txtemid.Text = row.Cells["cemid"].Value.ToString();
                txtname.Text = row.Cells["cname"].Value.ToString();
                txtemail.Text = row.Cells["cemail"].Value.ToString();
                txtpassword.Text = row.Cells["cpass"].Value.ToString();
                txthp.Text = row.Cells["chp"].Value.ToString();
                cmbpost.Text = row.Cells["cpos"].Value.ToString();
                //var user = (from u in dbku.msemployees where u.employeeid == txtemid.Text select u).First();
                
            }

        }

        private void bindtable()
        {
            koneksikuDataContext dbku = new koneksikuDataContext();
            msemployee mep = new msemployee();
            DataGridView datagrid = new DataGridView();
            BindingSource bs = new BindingSource();

            var ambil = (from s in dbku.msemployees select s).ToList();
            datagrid.ColumnCount = 6;
            datagrid.AutoGenerateColumns = false;
            DataTable dt = new DataTable();
            this.datagrid.DataSource = ambil;
        }
        private void ManageEmployee_Load(object sender, EventArgs e)
        {
            
            this.bindtable();
                    }

        private void btninsert_Click(object sender, EventArgs e)
            
        {
            if (txtemail.Text == null && txthp.Text == null && txtname.Text == null && txtpassword.Text == null && cmbpost.SelectedText == null) {
                MessageBox.Show("DATA WAJIB DIISI!!");
                

        }
            else
            {
                string selected = cmbpost.Text;
                if (selected == "admin")
                {
                    this.insertadmin();
                }
                else if (selected == "chef")
                {
                    this.insertChef();
                }
                else if (selected == "member")
                {
                    this.insertM();
                }
                else if ( selected == "cashier")
                {
                    this.inscash();
                }
                this.bindtable();
                datagrid.Update();
                datagrid.Refresh();
                
            }
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            if(txtname.Text == "JohnDoe")
            {
                txtname.Text = "";
                txtname.ForeColor = Color.Gray;
            }
            
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {
            if ( txtemail.Text == "e.g JohnDoe@company.com")
            {
                txtemail.Text = "";
            }
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            if (txtpassword.Text == "johndoe123")
            {
                txtpassword.Text ="";

            }
        }

        private void txthp_TextChanged(object sender, EventArgs e)
        {
            if ( txthp.Text == "e.g 08537512312")
            {
                txthp.Text = "";
            }
        }
        private void update()
        {
            cmbpost.Enabled = false;
            msemployee mep = new msemployee();
            var updateus = (from u in dbku.msemployees where u.employeeid == txtemid.Text select u).First();
            updateus.email = txtemail.Text + "@smknus.com";
            updateus.handphone = txthp.Text;
            updateus.password = txtpassword.Text;
            updateus.name = txtemail.Text;

            dbku.SubmitChanges();
            txtemail.Text = "";
            txtpassword.Text = "";
            txtname.Text = "";
            txthp.Text = "";

            MessageBox.Show("DATA BERHASIL DI UPDATE");
            this.bindtable();
            datagrid.Update();
            datagrid.Refresh();
        }
        private void deletedata()
        {
            msemployee mep = new msemployee();
            var deluser = (from d in dbku.msemployees where d.employeeid == txtemid.Text select d).First();

            dbku.msemployees.DeleteOnSubmit(deluser);
            dbku.SubmitChanges();
            MessageBox.Show("DATA USER BERHASIL DI HAPUS");

            


        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            this.update();
            this.bindtable();
            datagrid.Update();
            datagrid.Refresh();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            this.deletedata();
            this.bindtable();
            datagrid.Update();
            datagrid.Refresh();
        }
    }
}
