using Bank_Bussiness_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bank
{
    public partial class frmCard : Form
    {
        int _id;
        public frmCard(int id)
        {
            InitializeComponent();
            this._id = id;

        }

        private void frmCard_Load(object sender, EventArgs e)
        {

            clsClient client = clsClient.Find(_id);
            lblbalance.Text = client.Balance.ToString();
            lblfirstname.Text = client.AccountNumber.ToString();
            lbllastname.Text = client.FirstName.ToString();
            lblphone.Text = client.Phone.ToString();
            lblaccount.Text = client.Street.ToString();
            lblemail.Text = client.Email.ToString();
            lblpincode.Text = client.PinCode.ToString();
            lblid.Text = client.Client_ID.ToString();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_MouseClick(object sender, MouseEventArgs e)
        {
            frmAddClient frm = new frmAddClient(_id);
            frm.Show();






        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this Client  " + _id, "Confirm Delete"

               , MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (clsClient.DeleteClient(_id))
                {
                    //  _RefreshClientList();

                }
                else
                {
                    MessageBox.Show("Client is not deleted");
                }


                MessageBox.Show("Client Deleted Successfully");




            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_MouseClick(object sender, MouseEventArgs e)
        {
            
           //frmTransactions frm= new frmTransactions(_user);
           // frm.Show();







        }
    }
}