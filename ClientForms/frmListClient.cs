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
    public partial class frmListClient : Form
    {
        public frmListClient()
        {
            InitializeComponent();
        }

        private void _RefreshClientList()
        {
          dgvAllClients.DataSource = clsClient.ListClient();
        }
        private void frmListClient_Load(object sender, EventArgs e)
        {
         _RefreshClientList();
        }

        private void addNewClientToolStripMenuItem_Click(object sender, EventArgs e)
        {


            //    int currentID = (int)dgvAllClients.CurrentRow.Cells[0].Value;
          
            frmAddClient frm = new frmAddClient(-1);
            frm.ShowDialog();
        //    _RefreshClientList();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to delete this Client  " + dgvAllClients.CurrentRow.Cells[0].Value ,"Confirm Delete"
                
                ,MessageBoxButtons.OKCancel )==DialogResult.OK )
            {
                if(clsClient.DeleteClient((int)dgvAllClients.CurrentRow.Cells[0].Value))
                {
                    _RefreshClientList();

                }
                else
                {
                    MessageBox.Show("Client is not deleted");
                }

            }
            MessageBox.Show("Client Deleted Successfully");



        }

        private void dgvAllClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int currentid = (int )dgvAllClients.CurrentRow.Cells[0].Value;
         
            frmAddClient frm=new frmAddClient(currentid);

            frm.Show();

            

        }

        private void showCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int currentid = (int)dgvAllClients.CurrentRow.Cells[0].Value;

            frmCard frm=new frmCard(currentid);
            frm.Show();
        }
    }
}
