using Bank_Bussiness_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bank
{
    public partial class frmUserCard : Form
    {

        int _id;
        public frmUserCard(int id)
        {
            InitializeComponent();

            this._id = id;
        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
        }

        private void guna2Button3_MouseClick(object sender, MouseEventArgs e)
        {

            frmAddUser update = new frmAddUser(_id);
            update.ShowDialog();
        }

        private void guna2Button2_MouseClick(object sender, MouseEventArgs e)
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

            //private void guna2Button2_Click(object sender, EventArgs e)
            //{

            //}
        }

        private void frmUserCard_Load(object sender, EventArgs e)
        {
            clsUser user = clsUser.Find(_id);
            
            lblemail.Text = user.Email;
            lblfirstname.Text = user.FirstName;
            lbllastname.Text = user.LastName;
            lblpermission.Text = user.Permission.ToString();
            lblphone.Text=user.Phone;
            lbluserid.Text = user.User_ID.ToString();
            lblusrname.Text = user.User_Name;

     







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
