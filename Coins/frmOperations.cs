using Bank_Bussiness_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bank
{
    public partial class frmOperations : Form
    {
        public frmOperations()
        {
         
            InitializeComponent();
        }


        private void guna2Button2_MouseClick(object sender, MouseEventArgs e)
        {
            frmListTransactions frmListTransactions = new frmListTransactions();
            frmListTransactions.Show();


















        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
