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
    public partial class frmGetIDcs : Form
    {
        clsClient client;
        public frmGetIDcs()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnconfirm_MouseClick(object sender, MouseEventArgs e)
        {
         //   this.Close();
            int id =Convert.ToInt32(txtid.Text);
            if(clsClient.Find(id)!=null)
            {
                frmCard card = new frmCard( id);
                this.Close();
                card.Show();

            }
            else
            {
                MessageBox.Show("Client Not Found ");
            }

        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGetIDcs_Load(object sender, EventArgs e)
        {

        }
    }
}
