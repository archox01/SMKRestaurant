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
    public partial class AdmNav : Form
    {
        public AdmNav()
        {
            InitializeComponent();
            
        }
        login log = new login();

        private void btnmanemp_Click(object sender, EventArgs e)
        {
            ManageEmployee manmem = new ManageEmployee();
            manmem.Show();
            
        }

        private void btnmanmenu_Click(object sender, EventArgs e)
        {
            ManageMenu manmenu = new ManageMenu();
            manmenu.Show();
            
        }

        private void btnmanmem_Click(object sender, EventArgs e)
        {
            managemember manmem = new managemember();
            manmem.Show();
            
        }

        private void btnchpass_Click(object sender, EventArgs e)
        {
            changepass cp = new changepass();
            cp.Show();
            
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void AdmNav_Load(object sender, EventArgs e)
        {
            label2.Text = "Welcome," +login.dapat();
        }
    }
}
