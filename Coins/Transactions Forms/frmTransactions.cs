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
    public partial class frmTransactions : Form
    {
        private clsUser _user;
        public frmTransactions(clsUser user)
        {
            this._user = user;
            InitializeComponent();
        }

        private void guna2Button1_MouseClick(object sender, MouseEventArgs e)
        {
            frmDeposit_Withdraw frmDeposit = new frmDeposit_Withdraw(_user);
            frmDeposit.Show();




        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_MouseClick(object sender, MouseEventArgs e)
        {
           

            frmDeposit_Withdraw frm = new frmDeposit_Withdraw(_user);
            frm.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_MouseClick(object sender, MouseEventArgs e)
        {
            frmTransfere frm=new frmTransfere(_user);
            frm.Show(); 
            // After transfere ==> add transaction operation to transfere logs & update total balances in transactions all of that inside 
            // frmtransfere





        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_MouseClick(object sender, MouseEventArgs e)
        {
            //frmListTransactions frmListTransactions = new frmListTransactions();
            //frmListTransactions.Show();







        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
