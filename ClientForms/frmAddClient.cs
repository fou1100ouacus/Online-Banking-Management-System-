using Bank_Bussiness_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace bank
{
    public partial class frmAddClient : Form
    {
        enum enMode { AddNew = 0, Update = 1 };
        enMode _Mode;

        int _ClientID;
        clsClient client;



        public frmAddClient(int id)
        {
            InitializeComponent();
            this._ClientID = id;


            if (_ClientID == -1)
            {
                this._Mode = enMode.AddNew;
            //    lblclientmodee.Text = "Add new Client ";
                client = new clsClient();
             
                return;

            }
            else
            {
                this._Mode= enMode.Update;
                lblclientmodee.Text = "Udpdate Client ";
                lblclientmodee.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblclientmodee.ForeColor = System.Drawing.Color.Navy;
                _loadClientData(_ClientID);

            }
            // else the updated mode is active
            // lblmodeid.Text=_ClientID.ToString();


            //     lblclientmodee.
        }


        //private void _LoadData()
        //{
        //    if(_Mode == enMode.AddNew)
        //    {
        //        client = new clsClient();
        //        return;
        //    }
        //    else if(_Mode == enMode.Update)
        //    {

        //        _loadClientData(_ClientID);
        //    }


        //}

  
            private void _loadClientData(int ID)
            {

           client = clsClient.Find(ID);
            //  DataTable dt= clsClient.ListClient();

            //  DataRow[] ResultRows = dt.Select("Client_ID=ClietnID");

            //foreach (DataRow row in ResultRows)
            //{

            //    lblmodeid.Text = row[0].ToString();
            //    txtaccountnum.Text = row[1].ToString();
            //    txtemail.Text = row[2].ToString();
            //    txtpincode.Text = row[3].ToString();
            //    txtbalance.Text = row[4].ToString();
            //    txtphone.Text = row[5].ToString();
            //   // txtstreet.Text = row[6].ToString();person id
            //    txtfirstname.Text = row[7].ToString();
            //    txtLastName.Text = row[8].ToString();
            //    txtcountry.Text = row[9].ToString();
            //    txtcity.Text = row[10].ToString();
            //    txtstreet.Text = row[11].ToString();
            //    txtaccountnum.Enabled = false;

            ////   dt.Rows.
            //}
           //
            txtaccount.Text=client.Street;
            txtFirstname.Text = client.AccountNumber;
            txtLastName.Text = client.FirstName;
            txtCountru.Text = client.LastName;
            txtCIty.Text = client.Country;
            txtStreet.Text = client.City;
            //
            txtbalance.Text = client.Balance.ToString();
            txtemail.Text = client.Email;
       //     txtaccount.Text = client.AccountNumber;
            txtpincode.Text = client.PinCode;
            lblmodeid.Text = client.Client_ID.ToString();
            txtphone.Text = client.Phone;
            //
            //txtStreet.Text = client.Street;
            //txtFirstname.Text = client.FirstName;
            //txtLastName.Text = client.LastName;
            //txtCountru.Text = client.Country;
           
            //txtCIty.Text = client.City;
          
            // street --- last name
            // frist -- account
            // country -- fristname
            // account -- city

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmAddClient_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
        private void llOpenFileDialog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           

        }
        // Button save changes
          private void guna2Button1_MouseClick(object sender, MouseEventArgs e)
          {
           

 
           client.FirstName =txtFirstname.Text;
           client.LastName= txtLastName.Text;
           client.Country  =txtCountru.Text;
           client.City = txtCIty.Text;
           client.Balance =Convert.ToDouble( txtbalance.Text);
           client.Email = txtemail.Text;
           client.Phone = txtphone.Text;
           client.PinCode = txtpincode.Text;
           client.Street = txtStreet.Text;
           client.AccountNumber = txtaccount.Text;
            //if(_Mode==enMode.AddNew)
            //{

            //}
            //if (pictureBox1.ImageLocation != null)
            //{

            //    _Client.ImagePath = pictureBox1.ImageLocation;
            //}
            //else
            //{
            //    _Contact.ImagePath = "";
            //}

            if (client.Save() )
            {
               
                MessageBox.Show("Data Saved Successfully.");
            }
            else
            {
                MessageBox.Show("Error: Data Didn't Save Successfully.");
            }

            _Mode = enMode.Update;

              lblmodeid.Text = client.Client_ID.ToString();






        }

        private void llupload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string selectedFilePath = openFileDialog1.FileName;
                pictureBox1.Load(selectedFilePath);
                llremove.Visible = true;
            }


           

        }

        private void llremove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.ImageLocation = null;
            llremove.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
