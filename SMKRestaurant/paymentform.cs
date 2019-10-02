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
    public partial class paymentform : Form
    {

        orderform of = new orderform();
        public DataTable aDT;
       
        public paymentform(orderform f2)
        {
            

            
        }
        public void getdata(DataTable aDT)
        {
           
        }

        public paymentform()
        {
        }

        private void load2()
        {
            aDT = new DataTable();
            aDT.Columns.Add("Menu");
            aDT.Columns.Add("Quantity");
            aDT.Columns.Add("Price");
            aDT.Columns.Add("Total");
            aDT.Columns.Add("Menuid");
            aDT.Columns.Add("orderid");

            this.dgrid.DataSource = aDT;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void paymentform_Load(object sender, EventArgs e)
        {

        }
    }
}
