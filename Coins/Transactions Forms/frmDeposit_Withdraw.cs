using Bank_Bussiness_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Windows.Forms;

namespace bank
{
    public partial class frmDeposit_Withdraw : Form
    {
        private clsUser _user;
        public frmDeposit_Withdraw(clsUser user)
        {
            this._user = user;
            InitializeComponent();
        }

        private void frmDeposit_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_MouseClick(object sender, MouseEventArgs e)
        
        {
            clsClient client =new clsClient();
             client = clsClient.Find(Convert.ToInt32(txtid.Text));
            clsTransaction trans = null;

            trans.User_ID = _user.User_ID;
            trans.TransactionType_ID = 1; // deposit
            trans.TransactionType = clsTransaction.enTransaction.eDeposit;
            trans.TransactionDateTime = DateTime.Now;
            trans.ATM_ID = 0;

            if (client != null)
            {
                if (txtamount.Text!=" " && txtamount.Text!=Convert.ToString (0) )
                {
                    trans.Amount = Convert.ToDouble(txtamount.Text);
                    client.Balance += Convert.ToDouble (txtamount.Text);
                    client.Save();
                    frmCard card = new frmCard(client.Client_ID);
                    card.Show();

                }
                else
                {
                    MessageBox.Show("Enter valid amount ");
                }

            }
            else
            {
                MessageBox.Show("Error ,Client not found ");
            }



        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button3_MouseClick(object sender, MouseEventArgs e)
        {
            clsClient client = new clsClient();
            clsTransaction trans = null;
            client = clsClient.Find(Convert.ToInt32(txtid.Text));
          
            trans.User_ID = _user.User_ID;
            trans.TransactionType_ID = 2; // withdraw
            trans.TransactionType = clsTransaction.enTransaction.eWithdraw;
            trans.TransactionDateTime = DateTime.Now;
            trans.ATM_ID = 0;


            if (client != null&& client.Balance >= Convert.ToDouble(txtamount.Text))
            {
                if (txtamount.Text != " " && txtamount.Text != Convert.ToString(0))
                {
                    trans.Amount = Convert.ToDouble(txtamount.Text);
                    client.Balance -= Convert.ToDouble(txtamount.Text);
                    client.Save();
                    frmCard card = new frmCard(client.Client_ID);
                    card.Show();

                }
                else
                {
                    MessageBox.Show("Enter valid amount ");
                }

            }
            else
            {
                MessageBox.Show("Error ,Client not found ");
            }









        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }
    }
}
