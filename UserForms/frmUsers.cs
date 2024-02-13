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
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }
     

        private void guna2Button4_MouseClick(object sender, MouseEventArgs e)
        {
            frmListUsers frm=new frmListUsers();
            frm.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_MouseClick(object sender, MouseEventArgs e)
        {
            frmAddUser frm = new frmAddUser(-1);
            frm.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_MouseClick(object sender, MouseEventArgs e)
        {
            
            frmGetuserIDcs frm = new frmGetuserIDcs();
            frm.Show();
        }

        private void guna2Button3_MouseClick(object sender, MouseEventArgs e)
        {
            frmGetuserIDcs frm = new frmGetuserIDcs();
            frm.Show();
        }

        private void guna2Button5_MouseClick(object sender, MouseEventArgs e)
        {
            frmGetuserIDcs frm = new frmGetuserIDcs();
            frm.Show();
        }

        private void guna2Button6_MouseClick(object sender, MouseEventArgs e)
        {
            frmGetuserIDcs frm = new frmGetuserIDcs();
            frm.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
