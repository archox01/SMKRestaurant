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
    public partial class orderform : Form
    {
        public orderform()
        {
            InitializeComponent();
        }
        koneksikuDataContext dbku = new koneksikuDataContext();
        msmenu msmenus = new msmenu();
        msmember msmembers = new msmember();

        private void load()
        {
            var st = from s in dbku.msmenus select s;

            this.dgatas.DataSource = st;
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void orderform_Load(object sender, EventArgs e)
        {
            this.load();
        }

        private void dgatas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtmname.Text = dgatas.CurrentRow.Cells[0].Value.ToString();
            txtprice.Text = dgatas.CurrentRow.Cells[1].Value.ToString();
            txtqty.Text = dgatas.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
