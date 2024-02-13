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
    public partial class frmListTransactions : Form
    {
        public frmListTransactions()
        {
            InitializeComponent();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void _RefreshClientList()
        {
            guna2DataGridView1.DataSource = clsTransaction.Table();
        }
      

        private void frmListTransactions_Load(object sender, EventArgs e)
        {
            _RefreshClientList();

        }
    }
}
