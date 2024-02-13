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
using static Bank_Bussiness_Layer.clsPerson;
using static Bank_Bussiness_Layer.clsUser;

namespace bank
{
    public partial class frmAddUser : Form
    {
        enum enMode { AddNew = 0, Update = 1 };
        enMode _Mode;

        int _UserID;
        clsUser user;
        public frmAddUser(int id)
        {
            InitializeComponent();
            this._UserID = id;

            if (_UserID == -1)
            {
                this._Mode = enMode.AddNew;
                user = new clsUser();
            }
            else
            {
                this._Mode = enMode.Update;
                this._Mode = enMode.Update;
                lblUserMode.Text = "Udpdate Client ";
                lblUserMode.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblUserMode.ForeColor = System.Drawing.Color.Navy;
                _LoadData(_UserID);
            }
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {









        }
        private void _LoadData(int ID)
        {

            user = clsUser.Find(ID);
            txtfirstname.Text = user.FirstName;
            txtlastname.Text = user.LastName;
            txtpassword.Text = user.Password;
            txtpermission.Text = user.Permission.ToString ();
            txtphone.Text=user.Phone;
            //   txtpincode.Text=user.
            txtemail.Text = user.Email;
            txtcity.Text= user.City;
            txtcountry.Text= user.Country;
            txtusername.Text = user.User_Name;
            lblmodeID.Text=user.User_ID.ToString();
            txtstreet.Text=user.Street;


        }
        private void guna2Button1_MouseClick(object sender, MouseEventArgs e)
        {
          
            user.FirstName =txtfirstname.Text;
            user.LastName =txtlastname.Text;
            user.Email =txtemail.Text;
            user.Phone =txtphone.Text;
            user.Permission =Convert.ToInt32( txtpermission.Text);
            user.Email = txtemail.Text;
            user.Street = txtpassword.Text;
            user.City = txtcity.Text;
            user.Country = txtcountry.Text;
            user.Password = txtpassword.Text;
            user.User_Name = txtusername.Text;
           
            if(user.Save())
            {
                MessageBox.Show("Added successfuly");


            }
            else
            {
                MessageBox.Show("error can't add ");

            }
            _Mode = enMode.Update;
            lblmodeID.Text = Convert.ToString(user.User_ID);




        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_MouseClick(object sender, MouseEventArgs e)
        {

            //clsUser user=new clsUser();
            enPermissions perm = new enPermissions();
            for(int i =0; i < cbpermission.CheckedIndices.Count; i++)
            {
                if (cbpermission.CheckedIndices[i] ==0)
                {
                     perm =  enPermissions.eAll;
                     
                }
                else if (cbpermission.CheckedIndices[i]==1 )
                {
                    perm = enPermissions.pAddNewClient;

                }
                else if (cbpermission.CheckedIndices[i] == 1)
                {
                    perm = enPermissions.pDeleteClient;

                }
                else if (cbpermission.CheckedIndices[i] == 1)
                {
                    perm = enPermissions.pDeleteClient;

                }
                else if (cbpermission.CheckedIndices[i] == 1)
                {
                    perm = enPermissions.pListClients;

                }
                else if (cbpermission.CheckedIndices[i] == 1)
                {
                    perm = enPermissions.pTranactions;

                }
                else if (cbpermission.CheckedIndices[i] == 1)
                {
                    perm = enPermissions.pManageUsers;

                }





                //user.Permission=

            }
            //foreach (string access in cbpermission.CheckedItems)
            //{
            //    if(cbpermission.Items.IndexOf(access) == -1)

            //    clsUser.enPermissions.eAll;
            //   // CheckAccessPermission();
            //}



            // if(cbpermission.)









        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {







        }
    }
}
