using Bank_Bussiness_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bank
{
    public partial class SignUp : Form
    {
        //        frm_MainBaseForm Main = null;
        clsClient Sender = null, Receiver = null;
        clsTransaction Transaction = null;
        string VerificationKey;

        public SignUp()
        {
            InitializeComponent();
        }
       
        static private SignUp
           _Screen = null;
        static public SignUp Screen
        {

            get
            {
                if (_Screen == null)
                {
                    _Screen = new SignUp ();
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
        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login1 = new Login();
              login1.Show();
            this.Close();
        }
        //   int vcode = 1000;
        private void guna2Button1_MouseClick(object sender, MouseEventArgs e)
        {


            if (txtemail.Text == "" || txtfirst.Text == "" || txtlastname.Text == "" || txtpassword.Text=="")
            {
                MessageBox.Show("Empty Field");
            }
            else
            {
                // email verfication ==>calll frm

                VerificationKey = clsutilverify.GenerateVerificationKey(6);

                string Subject = "Subject: Your Verification Key for sign up ";
                string Body = $"Dear {txtfirst.Text} {txtlastname.Text},\r\n\r\nYour recent transaction (Trasfer money to other acount) with Houdaifa Bamk requires a final step to ensure its security. Please find your unique verification key below:\r\n\r\nVerification Key: {VerificationKey}\r\n\r\nTo complete your transaction, simply copy this verification key and paste it in the designated field on our secure website. This step confirms your authorization and safeguards your financial activity.\r\n\r\nIf you did not initiate this transaction or have any concerns regarding your account's security, please contact our customer support immediately at bank.houdaifa@gmail.com.\r\n\r\nThank you for choosing Houdaifa Bank. We value your trust in us and are committed to keeping your financial information safe.\r\n\r\nSincerely,\r\n\r\nSent by : Verification Bot\r\nBank Name : Houdaifa Bank\r\nContact Information : bank.houdaifa@gmail.com\r\n";

               



                //////////
                clsUser user= new clsUser();
                clsGlobal.CurrentUser = user;
                user.Email = txtemail.Text;
                user.FirstName = txtfirst.Text;
                user.Password=txtpassword.Text;
                user.LastName = txtlastname.Text;
                user.SendEmail(Subject, Body);
             frmVerficationCode frm=new frmVerficationCode(VerificationKey,txtfirst.Text);
                frm.Show();
                if (user.Save()) // add user
                {
                    MessageBox.Show("Sign Up successfully");
                }
           //     Sender.SendEmail(Subject, Body);
                //pnl_CheckSpam.Visible = true;

                //btn_SendEmail.Text = "Resend Email";
        //        tb_VerificationKey.Select();

            }






            //enLoginStatus LoginResult = _TryLoginEmail(txtemail.Text.Trim(), txtpassword.Text.Trim());
            

            //if (LoginResult == enLoginStatus.eSuccess)
            //{
            //    // Login Code
            //    clsVerificationCode.Send("", "", "  Because you haven't do the 2 step mobile verification.\" +\r\n        //        \" Please check your account has been verify by\" +\r\n        //        \" 2 step verification. Get google help to 2 step verification\";");
            //    frmVerficationCode frm = new frmVerficationCode();
            //    frm.Show();
            //}


            ////frmVerficationCode frmVerficationCode = new frmVerficationCode();
            ////frmVerficationCode.Show();

            ////timvcode.Stop();



            ////frmVerficationCode frm= new frmVerficationCode();
            ////frm.Show();
            //this.Close();



        }

        private void timvcode_Tick(object sender, EventArgs e)
        {










        }

        private void btnSignup_Click(object sender, EventArgs e)
        {







        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
        ErrorProvider errorProvider1 { get { return errorProvider1; } }

        private void txtfirst_Validating(object sender, CancelEventArgs e)
        {

            //if (string.IsNullOrEmpty(txtfirst.Text))
            //{
            //// e.Cancel = true;
            //    txtfirst.Focus();
            //    errorProvider1.SetError(txtfirst, "Please Enter your First Name !");
            //}
            //else
            //{
            //    e.Cancel = false;
            //    errorProvider1.SetError(txtfirst, "");
            //}


        }
    }
}
