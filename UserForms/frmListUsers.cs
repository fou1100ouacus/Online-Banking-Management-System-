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
    public partial class frmListUsers : Form
    {
        public frmListUsers()
        {
            InitializeComponent();
        }
        private void _RefreshList()
        {
            dgvallusers.DataSource = clsUser.ListUsers();
        }
        private void frmListUsers_Load(object sender, EventArgs e)
        {
            _RefreshList();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmAddUser frm = new frmAddUser(-1);
            //frm.Show();






        }

        //private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    int currentid = (int)dgvallusers.CurrentRow.Cells[0].Value;

        //    frmAddUser frm = new frmAddUser(currentid);
        //   ////// frm.Show();
        //}

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUser frm= new frmAddUser(-1);
            frm.Show();
        }

        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int currentid = (int)dgvallusers.CurrentRow.Cells[0].Value;

            frmAddUser frm = new frmAddUser(currentid);
            frm.Show();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this Client  " + dgvallusers.CurrentRow.Cells[0].Value, "Confirm Delete"

               , MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (clsUser.DeleteUser((int)dgvallusers.CurrentRow.Cells[0].Value))
                {
                    _RefreshList();

                }
                //else
                //{
                //    MessageBox.Show("Client is not deleted");
                //}

            }
            MessageBox.Show("Client Deleted Successfully");






        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int currentid = (int)dgvallusers.CurrentRow.Cells[0].Value;
            frmUserCard frm = new frmUserCard(currentid); frm.Show();
        }
    }
}
