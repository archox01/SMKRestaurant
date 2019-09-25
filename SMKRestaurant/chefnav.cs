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
    public partial class chefnav : Form
    {
        public chefnav()
        {
            InitializeComponent();
        }

        private void btnvorder_Click(object sender, EventArgs e)
        {
            vieworder vo = new vieworder();
            vo.Show();
            this.Hide();
        }

        private void btnchpass_Click(object sender, EventArgs e)
        {
            changepass cp = new changepass();
            cp.Show();
            this.Hide();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();

        }
    }
}
