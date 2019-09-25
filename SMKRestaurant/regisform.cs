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
    public partial class regisform : Form
    {
        public regisform()
        {
            InitializeComponent();
        }

        private void btnregis_Click(object sender, EventArgs e)
        {
            koneksikuDataContext dbku = new koneksikuDataContext();

        }
    }
}
