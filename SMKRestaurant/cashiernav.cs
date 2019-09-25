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
    public partial class cashiernav : Form
    {
        public cashiernav()
        {
            InitializeComponent();
        }

        
        

        private void cashiernav_Load(object sender, EventArgs e)
        {
            login lg = new login();
            lblwelcome.Text = "Welcome," + login.nama;
        }

        private void btnpay_Click(object sender, EventArgs e)
        {
            paymentform pf = new paymentform();
            pf.Show();
        }

        private void btnorder_Click(object sender, EventArgs e)
        {
            orderform of = new orderform();
            of.Show();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.Show();
            this.Hide();
        }
    }
}
