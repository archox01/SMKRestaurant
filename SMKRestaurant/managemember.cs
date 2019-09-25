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
    public partial class managemember : Form
    {
        public managemember()
        {
            InitializeComponent();
        }
        koneksikuDataContext dbku = new koneksikuDataContext();
        msmember msm = new msmember();
        DateTimePicker dtp = new DateTimePicker();
        private void dbind()
        {
             koneksikuDataContext dbku = new koneksikuDataContext();
            msmember msm = new msmember();
            DataGridView datagrid = new DataGridView();
            BindingSource bs = new BindingSource();

            var ambil = (from s in dbku.msmembers select s).ToList();
            datagrid.ColumnCount = 6;
            datagrid.AutoGenerateColumns = false;
            DataTable dt = new DataTable();
            this.dgrid.DataSource = ambil;
        }
        private void insbtn()
        {

            //int memid = Convert.ToInt32(txtmemid.Text);
            //var member = (from m in dbku.msmembers orderby m.memberid descending select m).First();
            DateTime dtime;
            dtime = dateTimePicker1.Value;
            var member = (from b in dbku.msmembers select b).First(); 
            if (member.memberid != 0)
            {
                var member1 = (from m in dbku.msmembers orderby m.memberid descending select m).First();

                int members = member1.memberid;
                int auto = members + 1;
                msm.memberid = auto;
                msm.email = txtemail.Text;
                msm.handphone = txthp.Text;
                msm.name = txtname.Text;
                msm.joindate = dtime;
                msm.password = txtpass.Text;

                dbku.msmembers.InsertOnSubmit(msm);
                dbku.SubmitChanges();
                MessageBox.Show("Data Member berhasil Di Input");
            }
            //msm.joindate = dtp.ToString(joindHPW
            else {
                int idstart = 1;
                msm.memberid = idstart;
                msm.email = txtemail.Text;
                msm.handphone = txthp.Text;
                msm.name = txtname.Text;
                msm.joindate = dtime;
                dbku.msmembers.InsertOnSubmit(msm);
                dbku.SubmitChanges();
                MessageBox.Show("Data Member berhasil Di Input");

            }

        }
        private void btninsert_Click(object sender, EventArgs e)
        {
            this.insbtn();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row1 = this.dgrid.Rows[e.RowIndex];
            DataGridViewColumn col1 = this.dgrid.Columns[e.ColumnIndex];
            if (e.RowIndex > 0  )
            {
                msmember msm = new msmember();
              DataGridViewRow row = this.dgrid.Rows[e.RowIndex];
                DataGridViewColumn col = this.dgrid.Columns[e.ColumnIndex];

                txtmemid.Text = dgrid[0,e.RowIndex].Value.ToString();
                txtemail.Text = dgrid[2,e.RowIndex].Value.ToString();
                txtname.Text = row.Cells["cname"].Value.ToString();
                txtpass.Text = row.Cells["cpassword"].Value.ToString();
                txthp.Text = row.Cells["chp"].Value.ToString();
                dateTimePicker1.Text = row.Cells["cjdate"].Value.ToString();
                dbind();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            int meid = Convert.ToInt32(txtmemid.Text);
            msmember msm = new msmember();
            var member = (from u in dbku.msmembers where u.memberid == meid select u).First();
            var member1 = (from s in dbku.msmembers where s.memberid == meid select s).First();

            //member.memberid = meid;
            member.name = txtname.Text;
            member.handphone = txthp.Text;
            member.email = txtemail.Text;
            MessageBox.Show("Data Member berhasil Di update");
            dgrid.Update();
            dgrid.Refresh();
            

        }

        private void managemember_Load(object sender, EventArgs e)
        {
            this.dbind();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            int txtm = Convert.ToInt32(txtmemid.Text);
            var userdel = (from d in dbku.msmembers where d.memberid == txtm select d).First();
            dbku.msmembers.DeleteOnSubmit(userdel);
            dbku.SubmitChanges();
            this.dgrid.Update();
            this.dgrid.Refresh();
            
        }
    }
}
