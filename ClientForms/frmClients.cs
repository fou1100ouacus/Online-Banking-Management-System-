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
    public partial class frmClients : Form
    {
        public frmClients()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmClients_Load(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclientsList_MouseClick(object sender, MouseEventArgs e)
        {
            frmListClient frm = new frmListClient();

            frm.Show();

           


        }
        private void _RefreshClientList()
        {
            frmListClient frm2 = new frmListClient();
           


         //  frm2.dgvAllClients.DataSource = clsClient.ListClient();
        }

        private void btnaddclient_Click(object sender, EventArgs e)
        {
           

        }

        private void btnaddclient_MouseClick(object sender, MouseEventArgs e)
        {
            frmAddClient frm = new frmAddClient(-1);
            frm.ShowDialog();
          //  _RefreshClientList();
        }

        private void btnclientsList_Click(object sender, EventArgs e)
        {

        }

        private void btnupdateclient_MouseClick(object sender, MouseEventArgs e)
        {
            frmGetIDcs frmget=new frmGetIDcs();
            frmget.Show();
       
        }

        private void btnupdateclient_Click(object sender, EventArgs e)
        {

        }

        private void btnclientcard_MouseClick(object sender, MouseEventArgs e)
        {
            frmGetIDcs frm = new frmGetIDcs();
            frm.Show();
          

        }

        private void btnfindclient_Click(object sender, EventArgs e)
        {

        }

        private void btnfindclient_MouseClick(object sender, MouseEventArgs e)
        {
            frmGetIDcs frm = new frmGetIDcs();
            frm.Show();

           
         }

        private void btndeleteclient_MouseClick(object sender, MouseEventArgs e)
        {


            frmGetIDcs frmGetIDcs = new frmGetIDcs();
           frmGetIDcs.Show();
        }
    }
}
