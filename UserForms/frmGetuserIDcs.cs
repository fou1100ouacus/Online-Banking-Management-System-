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
    public partial class frmGetuserIDcs : Form
    {
        public frmGetuserIDcs()
        {
            InitializeComponent();
        }

        private void guna2Button2_MouseClick(object sender, MouseEventArgs e)
        {

            int id = Convert.ToInt32(txtIDcard.Text);
           


            if (clsClient.Find(id) != null)
            {
                frmUserCard card = new frmUserCard(id);


                this.Close();
                card.Show();

            }
            else
            {
                MessageBox.Show("Client Not Found ");
            }






        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();

               
        }
    }
}
