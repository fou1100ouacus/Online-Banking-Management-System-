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
    public partial class BankMain : Form
    {
        private clsUser _user;
        private string _name;
        public BankMain(clsUser user)
        {
            InitializeComponent();
            this._user = user;
        }
        public BankMain(string username)
        {
            InitializeComponent();
            this._name = username;
        }

        private void BankMain_Load(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void guna2Button2_MouseClick(object sender, MouseEventArgs e)
        {
            MainPanel.Show();
          //  loadform(new frmdashboard());
            // guna2Button2.BackColor = Color.BlueViolet;             //SystemColors.Control;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
          loadform (new frmATM());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            loadform(new frmClients());
           
            // guna2Button4.ForeColor = Color.Chocolate;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            MainPanel.Show();

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2CustomGradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void loadform(object Form)
        {

            if(this.MainPanel.Controls.Count>0)
            {
                this.MainPanel.Controls.RemoveAt(0);
                Form f = Form as Form;
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                this.MainPanel.Controls.Add(f);
                this.MainPanel.Tag= f;
                f.Show();

            }

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            loadform(new frmUsers ());
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            loadform (new frmTransactions(_user));
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            loadform(new frmOperations() ) ;
        }

        private void btnClients_MouseClick(object sender, MouseEventArgs e)
        {
            loadform(new frmClients());
        }

        private void btnUsers_MouseClick(object sender, MouseEventArgs e)
        {
            loadform(new frmUsers());
        }

        private void btnTransactions_MouseClick(object sender, MouseEventArgs e)
        {
            loadform(new frmTransactions(_user));
        }

        private void btnoperation_MouseClick(object sender, MouseEventArgs e)
        {
            loadform(new frmOperations());
        }

        private void btnAtm_MouseClick(object sender, MouseEventArgs e)
        {
            loadform(new frmATM());
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbluser_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint_1(object sender, PaintEventArgs e)
        {
            lbluser.Text = "Hi "+ _user.User_Name.ToString();
            clsGlobal.CurrentUser= _user;
        }

        private void guna2Button1_MouseClick(object sender, MouseEventArgs e)
        {
            MainPanel.Show();

        }
    }
}
