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
    public partial class frmTransfere : Form
    {
        private clsUser _user;
        public frmTransfere(clsUser user)
        {
            this._user = user;
            InitializeComponent();
        }

        private void frmTransfere_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_MouseClick(object sender, MouseEventArgs e)
        {  
            
            clsClient client1= new clsClient();// sender
            clsClient client2=new clsClient();//reciver
            client1 = clsClient.FindByAccountNumber(txtsender.Text);
            client2= clsClient.FindByAccountNumber(txtreciever.Text) ;
       //     transfer.ReceiverBalanceBefore = client2.Balance;
            //transfer.SenderBalanceBefore = client1.Balance;
            if (client1 != null&& client2 !=null)
            {
                if(client1.Balance>= Convert.ToDouble (txtamount .Text))
                { 
                    client2.Balance += Convert.ToDouble(txtamount.Text);
                    client1.Balance -= Convert.ToDouble(txtamount.Text);
                   
                    if(client1.Save () && client2.Save())
                    {
                        clsTransaction transfer = new clsTransaction(clsTransaction.enTransaction.eTransfer,client1.Client_ID,
                            client2.Client_ID, _user.User_ID,3,Convert.ToDouble (txtamount.Text),DateTime.Now);

                        //transfer.User_ID = _user.User_ID;
                        //transfer.Sender_ID = client1.Client_ID;
                        //transfer.Receiver_ID=client2.Client_ID;
                        //transfer.TransactionType_ID = 3;
                        //transfer.TransactionType = clsTransaction.enTransaction.eTransfer;
                        //transfer.Sender = client1;
                        //transfer.Receiver = client2;
                        //transfer.Amount = Convert.ToDouble (txtamount.Text);
                        //transfer.SenderBalanceAfter = client1.Balance;
                        //transfer.ReceiverBalanceAfter= client2.Balance;
                        if (transfer.Save())
                        {
                            MessageBox.Show("Successful operation ");
                        }
                      
                    }
                    else
                    {
                        MessageBox.Show("failed ");
                    }
                }
                else
                {
                    MessageBox.Show("No enough amount to transfere ");
                }


            }
            else
            {
                MessageBox.Show("Error Invalid fields ");
            }

        }

        private void txtsender_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtreciever_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
