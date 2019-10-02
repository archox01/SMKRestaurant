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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        koneksikuDataContext dbku = new koneksikuDataContext();
        public static string nama;
        public static string id;
        static string position;
        public static string password;
        public static string getpos()
        {
            return position;
        }
        public static string getpass()
        {
            return password;
        }
        public static string getEmid()
        {
            return id;
        }
        public static  string dapat()
        {

            return nama;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            var authz = (from a in dbku.msemployees select a).First();
            if (txtemail.Text == null )
            {
                MessageBox.Show("EMAIL WAJIB DIISI");
            }
            else if (tpassword == null)
            {
                MessageBox.Show("PASSWORD WAJIB DIISI");
            }

            else if ( txtemail.Text != null && tpassword.Text != null) {
                try
                {
                    koneksikuDataContext dbku = new koneksikuDataContext();
                    var auth = (from z in dbku.msemployees where z.email == txtemail.Text  select z).First();
                    nama = auth.name;
                    password = auth.password;
                    if (txtemail.Text == auth.email && tpassword.Text ==auth.password)
                    {
                        position = auth.position;
                        if (auth.password == tpassword.Text && auth.position == "admin")
                        {
                            AdmNav adm = new AdmNav();
                            adm.Show();
                            this.Hide();
                            //MessageBox.Show("Login Sukses, Anda Masuk Sebagai  " + position);

                        }
                        else if (auth.password == tpassword.Text && auth.position == "chef")
                        {
                            chefnav chf = new chefnav();
                            chf.Show();
                            this.Hide();
                            //MessageBox.Show("Login Sukses, Anda Masuk Sebagai  " + position);

                        }
                        else  if (auth.password == tpassword.Text && auth.position == "cashier")
                        {
                            cashiernav chn = new cashiernav();
                            chn.Show();
                            this.Hide();



                        }
                    }
                    MessageBox.Show("Login Sukses, Anda Masuk Sebagai  " + position);


                }
                catch (Exception )
                {
                        MessageBox.Show("Email Atau password yang anda masukkan salah", "Peringatan!!");
                    
                }
                finally {
                    
                }
                
            }
            
            

        }

        private void tpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnlogin.PerformClick();
            }
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
    }


