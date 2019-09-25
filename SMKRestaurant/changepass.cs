using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMKRestaurant
{
    public partial class changepass : Form
    {
        public changepass()
        {
            InitializeComponent();
        }
        koneksikuDataContext dbku = new koneksikuDataContext();
        public static string getpass;

        login lg = new login();
        public static string pass()
        {
            return getpass;
        }
        private void changepass_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pass, pass1, pass2;
            msmenu sm = new msmenu();
            var userpass = (from u in dbku.msemployees where u.password == txtoldpass.Text select u).First();

            string newpass1 = txtnewpass1.Text;
            string newpass2 = txtnewpass2.Text;
            string oldpass = txtoldpass.Text;
            if(oldpass == userpass.password)
            {
                if( newpass1 == newpass2)
                {
                    userpass.password = newpass1;
                    dbku.SubmitChanges();
                    MessageBox.Show("Password Berhasil Di Perbaharui");
                }
                else
                {
                    MessageBox.Show("Password Tidak Cocok, Silahkan Check Kembali");
                    oldpass = "";
                    newpass1 = "";
                    newpass2 = "";
                }
            }
            else
            {
                MessageBox.Show("Password Lama Salah");
                oldpass = "";
                newpass1 = "";
                newpass2 = "";
            }
        }
    }
}
