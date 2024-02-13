using Bank_Bussiness_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace bank
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        static private Login
           _Screen = null;
        static public Login Screen
        {
        
            get
            {
                if (_Screen == null)
                {
                    _Screen = new Login();
                }

                return _Screen;
            }
        }

       

        private enLoginStatus _TryLoginEmail(string Email, string Password)
        {
            if (string.IsNullOrEmpty(Email))
            {
                return enLoginStatus.eEmailEmpty;
            }

            if (Password == "")
            {
                return enLoginStatus.ePasswordEmpty;
            }

            if (!isValidEmail(Email))
            {
                return enLoginStatus.eEmailNonValid;
            }

            if (Password.Length < 8)
            {
                return enLoginStatus.ePasswordSmallerThanMinLength;
            }

            clsUser user = clsUser.Find(Email);

            if (user == null)
            {
                return enLoginStatus.eFailedEmailNotFound;
            }

            if (user.Password != Password)
            {
                return enLoginStatus.eFailedPasswordWrong;
            }

            clsGlobal.CurrentUser = user;

            return enLoginStatus.eSuccess;
        }

        #region Validation


        private bool isValidEmail(string Email)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(Email);
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }


        #endregion



        private enum enLoginStatus
        {
            eSuccess, eFailedEmailNotFound, eFailedPasswordWrong, eEmailEmpty,
            eEmailNonValid, ePasswordEmpty, ePasswordSmallerThanMinLength
        };
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           SignUp sign=new SignUp();
            sign.Show();
            this.Hide();
        }

        private void guna2Button1_MouseClick(object sender, MouseEventArgs e)
        {

            enLoginStatus LoginResult = _TryLoginEmail(txtemail.Text.Trim(), txtpassword.Text.Trim());

            if (LoginResult == enLoginStatus.eSuccess)
            {
                // Login Code

                clsUser user = clsUser.Find(txtemail.Text);
                if (user != null)
                {
                    if (user.Password == txtpassword.Text)
                    {
                        BankMain screen = new BankMain(user);
                        screen.Show();
                        this.Close();
                    }
                }

            }

     
        }
        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
