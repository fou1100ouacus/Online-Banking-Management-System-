using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using Bank_Bussiness_Layer;
namespace bank
{
    public partial class frmVerficationCode : Form
    { private string _vcode;
        private string _name;
        public frmVerficationCode(string vcode,string username)
        {
            this._vcode = vcode;
            this._name = username;
            InitializeComponent();
        }

        private void frmVerficationCode_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {



          

        }
    
        private void guna2Button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtvcode.Text == "")
            {
                MessageBox.Show("You must enter verification key", "Requered field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (txtvcode.Text != _vcode)
            {
                MessageBox.Show("Verification Key is wrong", "Wrong Key", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (_vcode == txtvcode.Text)
            {
                BankMain bankMain = new BankMain(_name);
                bankMain.Show();

            }
            else
            {
                MessageBox.Show("wrong verfiy");

            }
            //this.Sender.Refresh();

            //if (Sender.Balance < Transaction.Amount)
            //{
            //    MessageBox.Show($"You can not perform this transaction, your balance [{Sender.Balance}] is Less than ammount [{Transaction.Amount}]", "Balance Not Enough", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //clsTransaction transaction = Sender.Transfer(Receiver, Transaction.Amount);

            //if (transaction == null)
            //{
            //    MessageBox.Show("Somthing Went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}


            //      Main.controler.open_page("Third");







        }
        //    string to, from, codepassword, mail;
        //    SignUp frm=new SignUp();

        //    to = txtgmail.Text;
        //    from = "sdeveloper140@gmail.com\r\n";

        //    mail = vcode.ToString();
        //    codepassword = "pincode2pincode2";//////
        //    MailMessage Message = new MailMessage();

        //    Message.To.Add(to);
        //    Message.From = new MailAddress(from);
        //    Message.Body = "Because you haven't do the 2 step mobile verification." +
        //        " Please check your account has been verify by" +
        //        " 2 step verification. Get google help to 2 step verification";
        //    Message.Subject = "Verify your email  please ";//
        //    SmtpClient smtpClient = new SmtpClient();

        //    smtpClient.EnableSsl = true;
        //    smtpClient.Port = 587;
        //    smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
        //    smtpClient.Credentials = new NetworkCredential(from, codepassword);


        //    try
        //    {
        //        smtpClient.Send(Message);
        //        MessageBox.Show("Verfication Code sent Successfuly ! go to gmail and got it",
        //         "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);




        //    }

        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);

        //    }













        //      }

        private void timvcode_Tick(object sender, EventArgs e)
        {


            //vcode += 10;
            //if (vcode == 9999)

            //{
            //    vcode = 1000;
            //}





        }
    }
}
