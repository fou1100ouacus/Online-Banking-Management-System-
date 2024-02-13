namespace bank
{
    partial class frmClients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2BorderlessForm2 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnclientcard = new Guna.UI2.WinForms.Guna2Button();
            this.btnfindclient = new Guna.UI2.WinForms.Guna2Button();
            this.btnclientsList = new Guna.UI2.WinForms.Guna2Button();
            this.btndeleteclient = new Guna.UI2.WinForms.Guna2Button();
            this.btnupdateclient = new Guna.UI2.WinForms.Guna2Button();
            this.btnaddclient = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(265, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Clients";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 40;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.HasFormShadow = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2BorderlessForm2
            // 
            this.guna2BorderlessForm2.BorderRadius = 40;
            this.guna2BorderlessForm2.ContainerControl = this;
            this.guna2BorderlessForm2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm2.HasFormShadow = false;
            this.guna2BorderlessForm2.ShadowColor = System.Drawing.Color.White;
            this.guna2BorderlessForm2.TransparentWhileDrag = true;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::bank.Properties.Resources.icons8_edit_calendar_48;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(222, 24);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(37, 34);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 9;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderRadius = 19;
            this.guna2PictureBox1.Image = global::bank.Properties.Resources.Free_Vector___Illustrated_business_person_meditating;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(444, 61);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(351, 380);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 8;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // btnclientcard
            // 
            this.btnclientcard.Animated = true;
            this.btnclientcard.AutoRoundedCorners = true;
            this.btnclientcard.BorderRadius = 47;
            this.btnclientcard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnclientcard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnclientcard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnclientcard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnclientcard.FillColor = System.Drawing.Color.SteelBlue;
            this.btnclientcard.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnclientcard.ForeColor = System.Drawing.Color.White;
            this.btnclientcard.Image = global::bank.Properties.Resources.icons8_contacts_641;
            this.btnclientcard.Location = new System.Drawing.Point(235, 337);
            this.btnclientcard.Name = "btnclientcard";
            this.btnclientcard.Size = new System.Drawing.Size(203, 97);
            this.btnclientcard.TabIndex = 7;
            this.btnclientcard.Text = "Client Card";
            this.btnclientcard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnclientcard_MouseClick);
            // 
            // btnfindclient
            // 
            this.btnfindclient.Animated = true;
            this.btnfindclient.AutoRoundedCorners = true;
            this.btnfindclient.BorderRadius = 44;
            this.btnfindclient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnfindclient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnfindclient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnfindclient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnfindclient.FillColor = System.Drawing.Color.SteelBlue;
            this.btnfindclient.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnfindclient.ForeColor = System.Drawing.Color.White;
            this.btnfindclient.Image = global::bank.Properties.Resources._5094671_find_glass_search_zoom_icon;
            this.btnfindclient.Location = new System.Drawing.Point(238, 231);
            this.btnfindclient.Name = "btnfindclient";
            this.btnfindclient.Size = new System.Drawing.Size(200, 91);
            this.btnfindclient.TabIndex = 6;
            this.btnfindclient.Text = "Find Client";
            this.btnfindclient.Click += new System.EventHandler(this.btnfindclient_Click);
            this.btnfindclient.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnfindclient_MouseClick);
            // 
            // btnclientsList
            // 
            this.btnclientsList.Animated = true;
            this.btnclientsList.AutoRoundedCorners = true;
            this.btnclientsList.BorderRadius = 48;
            this.btnclientsList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnclientsList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnclientsList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnclientsList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnclientsList.FillColor = System.Drawing.Color.SteelBlue;
            this.btnclientsList.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnclientsList.ForeColor = System.Drawing.Color.White;
            this.btnclientsList.Image = global::bank.Properties.Resources.icons8_admin_100;
            this.btnclientsList.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnclientsList.Location = new System.Drawing.Point(235, 103);
            this.btnclientsList.Name = "btnclientsList";
            this.btnclientsList.Size = new System.Drawing.Size(203, 99);
            this.btnclientsList.TabIndex = 5;
            this.btnclientsList.Text = "List Clients";
            this.btnclientsList.Click += new System.EventHandler(this.btnclientsList_Click);
            this.btnclientsList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnclientsList_MouseClick);
            // 
            // btndeleteclient
            // 
            this.btndeleteclient.Animated = true;
            this.btndeleteclient.AutoRoundedCorners = true;
            this.btndeleteclient.BorderRadius = 47;
            this.btndeleteclient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndeleteclient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndeleteclient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndeleteclient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndeleteclient.FillColor = System.Drawing.Color.SteelBlue;
            this.btndeleteclient.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btndeleteclient.ForeColor = System.Drawing.Color.White;
            this.btndeleteclient.Image = global::bank.Properties.Resources._5011352_bin_delete_recycle_trash_icon;
            this.btndeleteclient.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btndeleteclient.Location = new System.Drawing.Point(12, 337);
            this.btndeleteclient.Name = "btndeleteclient";
            this.btndeleteclient.Size = new System.Drawing.Size(200, 97);
            this.btndeleteclient.TabIndex = 4;
            this.btndeleteclient.Text = "Delete Client";
            this.btndeleteclient.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btndeleteclient_MouseClick);
            // 
            // btnupdateclient
            // 
            this.btnupdateclient.Animated = true;
            this.btnupdateclient.AutoRoundedCorners = true;
            this.btnupdateclient.BackgroundImage = global::bank.Properties.Resources._728933_document_edit_file_page_paper_icon;
            this.btnupdateclient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnupdateclient.BorderRadius = 49;
            this.btnupdateclient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnupdateclient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnupdateclient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnupdateclient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnupdateclient.FillColor = System.Drawing.Color.SteelBlue;
            this.btnupdateclient.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnupdateclient.ForeColor = System.Drawing.Color.White;
            this.btnupdateclient.Image = global::bank.Properties.Resources._728933_document_edit_file_page_paper_icon1;
            this.btnupdateclient.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnupdateclient.Location = new System.Drawing.Point(12, 221);
            this.btnupdateclient.Name = "btnupdateclient";
            this.btnupdateclient.Size = new System.Drawing.Size(200, 101);
            this.btnupdateclient.TabIndex = 3;
            this.btnupdateclient.Text = "Update Client";
            this.btnupdateclient.Click += new System.EventHandler(this.btnfindclient_Click);
            this.btnupdateclient.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnupdateclient_MouseClick);
            // 
            // btnaddclient
            // 
            this.btnaddclient.Animated = true;
            this.btnaddclient.AutoRoundedCorners = true;
            this.btnaddclient.BorderRadius = 48;
            this.btnaddclient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnaddclient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnaddclient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnaddclient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnaddclient.FillColor = System.Drawing.Color.SteelBlue;
            this.btnaddclient.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnaddclient.ForeColor = System.Drawing.Color.White;
            this.btnaddclient.Image = global::bank.Properties.Resources.icons8_add_48;
            this.btnaddclient.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnaddclient.Location = new System.Drawing.Point(12, 103);
            this.btnaddclient.Name = "btnaddclient";
            this.btnaddclient.Size = new System.Drawing.Size(200, 99);
            this.btnaddclient.TabIndex = 2;
            this.btnaddclient.Text = "Add new Client";
            this.btnaddclient.Click += new System.EventHandler(this.btnaddclient_Click);
            this.btnaddclient.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnaddclient_MouseClick);
            // 
            // frmClients
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.btnclientcard);
            this.Controls.Add(this.btnfindclient);
            this.Controls.Add(this.btnclientsList);
            this.Controls.Add(this.btndeleteclient);
            this.Controls.Add(this.btnupdateclient);
            this.Controls.Add(this.btnaddclient);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "frmClients";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "frmClients";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.frmClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btnaddclient;
        private Guna.UI2.WinForms.Guna2Button btnupdateclient;
        private Guna.UI2.WinForms.Guna2Button btnclientsList;
        private Guna.UI2.WinForms.Guna2Button btndeleteclient;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnclientcard;
        private Guna.UI2.WinForms.Guna2Button btnfindclient;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm2;
    }
}