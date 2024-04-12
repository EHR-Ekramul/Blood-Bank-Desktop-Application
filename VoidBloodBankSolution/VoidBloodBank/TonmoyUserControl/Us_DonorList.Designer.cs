
namespace VoidBloodBank.TonmoyUserControl
{
    partial class Us_DonorList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.D__L_Toppanel = new System.Windows.Forms.Panel();
            this.G_CMBCountry = new Guna.UI2.WinForms.Guna2ComboBox();
            this.G_CMBCity = new Guna.UI2.WinForms.Guna2ComboBox();
            this.G_CMBBloodGroup = new Guna.UI2.WinForms.Guna2ComboBox();
            this.G_Btnclear = new Guna.UI2.WinForms.Guna2Button();
            this.G_BtnApply = new Guna.UI2.WinForms.Guna2Button();
            this.G_dgvDonorListShowList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.userID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dnrBloodGrp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dnrDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uStreet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dnrTotalDonation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dnrAvailability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D__L_Toppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.G_dgvDonorListShowList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "Donor list";
            // 
            // D__L_Toppanel
            // 
            this.D__L_Toppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.D__L_Toppanel.Controls.Add(this.G_CMBCountry);
            this.D__L_Toppanel.Controls.Add(this.G_CMBCity);
            this.D__L_Toppanel.Controls.Add(this.G_CMBBloodGroup);
            this.D__L_Toppanel.Controls.Add(this.G_Btnclear);
            this.D__L_Toppanel.Controls.Add(this.G_BtnApply);
            this.D__L_Toppanel.Controls.Add(this.label1);
            this.D__L_Toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.D__L_Toppanel.Location = new System.Drawing.Point(0, 0);
            this.D__L_Toppanel.Name = "D__L_Toppanel";
            this.D__L_Toppanel.Size = new System.Drawing.Size(1005, 78);
            this.D__L_Toppanel.TabIndex = 9;
            // 
            // G_CMBCountry
            // 
            this.G_CMBCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.G_CMBCountry.AutoRoundedCorners = true;
            this.G_CMBCountry.BackColor = System.Drawing.Color.Transparent;
            this.G_CMBCountry.BorderColor = System.Drawing.Color.Gray;
            this.G_CMBCountry.BorderRadius = 17;
            this.G_CMBCountry.Cursor = System.Windows.Forms.Cursors.Default;
            this.G_CMBCountry.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.G_CMBCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.G_CMBCountry.DropDownWidth = 210;
            this.G_CMBCountry.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.G_CMBCountry.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.G_CMBCountry.Font = new System.Drawing.Font("Inter", 9.5F);
            this.G_CMBCountry.ForeColor = System.Drawing.Color.Gray;
            this.G_CMBCountry.ItemHeight = 30;
            this.G_CMBCountry.Items.AddRange(new object[] {
            "Country",
            "Bangladesh"});
            this.G_CMBCountry.Location = new System.Drawing.Point(466, 20);
            this.G_CMBCountry.Name = "G_CMBCountry";
            this.G_CMBCountry.Size = new System.Drawing.Size(173, 36);
            this.G_CMBCountry.StartIndex = 0;
            this.G_CMBCountry.TabIndex = 21;
            // 
            // G_CMBCity
            // 
            this.G_CMBCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.G_CMBCity.AutoRoundedCorners = true;
            this.G_CMBCity.BackColor = System.Drawing.Color.Transparent;
            this.G_CMBCity.BorderColor = System.Drawing.Color.Gray;
            this.G_CMBCity.BorderRadius = 17;
            this.G_CMBCity.Cursor = System.Windows.Forms.Cursors.Default;
            this.G_CMBCity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.G_CMBCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.G_CMBCity.DropDownWidth = 210;
            this.G_CMBCity.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.G_CMBCity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.G_CMBCity.Font = new System.Drawing.Font("Inter", 9.5F);
            this.G_CMBCity.ForeColor = System.Drawing.Color.Gray;
            this.G_CMBCity.ItemHeight = 30;
            this.G_CMBCity.Items.AddRange(new object[] {
            "City",
            "Bagerhat",
            "Bandarban",
            "Barguna",
            "Barisal",
            "Bhola",
            "Bogra",
            "Brahmanbaria",
            "Chandpur",
            "Chittagong",
            "Chuadanga",
            "Comilla",
            "Cox\'s Bazar",
            "Dhaka",
            "Dinajpur",
            "Faridpur",
            "Feni",
            "Gaibandha",
            "Gazipur",
            "Gopalganj",
            "Habiganj",
            "Jamalpur",
            "Jessore",
            "Jhalokati",
            "Jhenaidah",
            "Joypurhat",
            "Khagrachari",
            "Khulna",
            "Kishoreganj",
            "Kurigram",
            "Kushtia",
            "Lakshmipur",
            "Lalmonirhat",
            "Madaripur",
            "Magura",
            "Manikganj",
            "Maulvibazar",
            "Meherpur",
            "Munshiganj",
            "Mymensingh",
            "Naogaon",
            "Narail",
            "Narayanganj",
            "Narsingdi",
            "Natore",
            "Nawabganj",
            "Netrokona",
            "Nilphamari",
            "Noakhali",
            "Pabna",
            "Panchagarh",
            "Patuakhali",
            "Pirojpur",
            "Rajbari",
            "Rajshahi",
            "Rangamati",
            "Rangpur",
            "Satkhira",
            "Shariatpur",
            "Sherpur",
            "Sirajgonj",
            "Sunamganj",
            "Sylhet",
            "Tangail",
            "Thakurgaon"});
            this.G_CMBCity.Location = new System.Drawing.Point(647, 20);
            this.G_CMBCity.Name = "G_CMBCity";
            this.G_CMBCity.Size = new System.Drawing.Size(173, 36);
            this.G_CMBCity.StartIndex = 0;
            this.G_CMBCity.TabIndex = 20;
            // 
            // G_CMBBloodGroup
            // 
            this.G_CMBBloodGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.G_CMBBloodGroup.AutoRoundedCorners = true;
            this.G_CMBBloodGroup.BackColor = System.Drawing.Color.Transparent;
            this.G_CMBBloodGroup.BorderColor = System.Drawing.Color.Gray;
            this.G_CMBBloodGroup.BorderRadius = 17;
            this.G_CMBBloodGroup.Cursor = System.Windows.Forms.Cursors.Default;
            this.G_CMBBloodGroup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.G_CMBBloodGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.G_CMBBloodGroup.DropDownWidth = 210;
            this.G_CMBBloodGroup.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.G_CMBBloodGroup.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.G_CMBBloodGroup.Font = new System.Drawing.Font("Inter", 9.5F);
            this.G_CMBBloodGroup.ForeColor = System.Drawing.Color.Gray;
            this.G_CMBBloodGroup.ItemHeight = 30;
            this.G_CMBBloodGroup.Items.AddRange(new object[] {
            "Blood Group",
            "A Negative",
            "A Positive",
            "AB Negative",
            "AB Positive",
            "B Negative",
            "B Positive",
            "O Negative",
            "O Positive"});
            this.G_CMBBloodGroup.Location = new System.Drawing.Point(827, 21);
            this.G_CMBBloodGroup.Name = "G_CMBBloodGroup";
            this.G_CMBBloodGroup.Size = new System.Drawing.Size(173, 36);
            this.G_CMBBloodGroup.StartIndex = 0;
            this.G_CMBBloodGroup.TabIndex = 19;
            // 
            // G_Btnclear
            // 
            this.G_Btnclear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.G_Btnclear.BorderRadius = 22;
            this.G_Btnclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.G_Btnclear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.G_Btnclear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.G_Btnclear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.G_Btnclear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.G_Btnclear.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G_Btnclear.ForeColor = System.Drawing.Color.White;
            this.G_Btnclear.Location = new System.Drawing.Point(188, 17);
            this.G_Btnclear.Name = "G_Btnclear";
            this.G_Btnclear.Size = new System.Drawing.Size(132, 42);
            this.G_Btnclear.TabIndex = 11;
            this.G_Btnclear.Text = "Clear";
            this.G_Btnclear.Click += new System.EventHandler(this.G_Btnclear_Click);
            // 
            // G_BtnApply
            // 
            this.G_BtnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.G_BtnApply.BorderRadius = 22;
            this.G_BtnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.G_BtnApply.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.G_BtnApply.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.G_BtnApply.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.G_BtnApply.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.G_BtnApply.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G_BtnApply.ForeColor = System.Drawing.Color.White;
            this.G_BtnApply.Location = new System.Drawing.Point(328, 17);
            this.G_BtnApply.Name = "G_BtnApply";
            this.G_BtnApply.Size = new System.Drawing.Size(132, 42);
            this.G_BtnApply.TabIndex = 12;
            this.G_BtnApply.Text = "Apply";
            this.G_BtnApply.Click += new System.EventHandler(this.G_BtnApply_Click);
            // 
            // G_dgvDonorListShowList
            // 
            this.G_dgvDonorListShowList.AllowUserToAddRows = false;
            this.G_dgvDonorListShowList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.G_dgvDonorListShowList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.G_dgvDonorListShowList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.G_dgvDonorListShowList.ColumnHeadersHeight = 22;
            this.G_dgvDonorListShowList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.G_dgvDonorListShowList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userID,
            this.userFullName,
            this.dnrBloodGrp,
            this.dnrDOB,
            this.userGender,
            this.userEmail,
            this.userPhone,
            this.uStreet,
            this.uCity,
            this.uCountry,
            this.dnrTotalDonation,
            this.dnrAvailability});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.G_dgvDonorListShowList.DefaultCellStyle = dataGridViewCellStyle3;
            this.G_dgvDonorListShowList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.G_dgvDonorListShowList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.G_dgvDonorListShowList.Location = new System.Drawing.Point(0, 78);
            this.G_dgvDonorListShowList.Name = "G_dgvDonorListShowList";
            this.G_dgvDonorListShowList.ReadOnly = true;
            this.G_dgvDonorListShowList.RowHeadersVisible = false;
            this.G_dgvDonorListShowList.RowHeadersWidth = 51;
            this.G_dgvDonorListShowList.RowTemplate.Height = 24;
            this.G_dgvDonorListShowList.Size = new System.Drawing.Size(1005, 595);
            this.G_dgvDonorListShowList.TabIndex = 10;
            this.G_dgvDonorListShowList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.G_dgvDonorListShowList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.G_dgvDonorListShowList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.G_dgvDonorListShowList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.G_dgvDonorListShowList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.G_dgvDonorListShowList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.G_dgvDonorListShowList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.G_dgvDonorListShowList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.G_dgvDonorListShowList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.G_dgvDonorListShowList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G_dgvDonorListShowList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.G_dgvDonorListShowList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.G_dgvDonorListShowList.ThemeStyle.HeaderStyle.Height = 22;
            this.G_dgvDonorListShowList.ThemeStyle.ReadOnly = true;
            this.G_dgvDonorListShowList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.G_dgvDonorListShowList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.G_dgvDonorListShowList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G_dgvDonorListShowList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.G_dgvDonorListShowList.ThemeStyle.RowsStyle.Height = 24;
            this.G_dgvDonorListShowList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.G_dgvDonorListShowList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // userID
            // 
            this.userID.DataPropertyName = "userID";
            this.userID.FillWeight = 90F;
            this.userID.HeaderText = "ID";
            this.userID.MinimumWidth = 7;
            this.userID.Name = "userID";
            this.userID.ReadOnly = true;
            // 
            // userFullName
            // 
            this.userFullName.DataPropertyName = "userFullName";
            this.userFullName.HeaderText = "Name";
            this.userFullName.MinimumWidth = 6;
            this.userFullName.Name = "userFullName";
            this.userFullName.ReadOnly = true;
            // 
            // dnrBloodGrp
            // 
            this.dnrBloodGrp.DataPropertyName = "dnrBloodGrp";
            this.dnrBloodGrp.FillWeight = 105F;
            this.dnrBloodGrp.HeaderText = "Blood-Group";
            this.dnrBloodGrp.MinimumWidth = 6;
            this.dnrBloodGrp.Name = "dnrBloodGrp";
            this.dnrBloodGrp.ReadOnly = true;
            // 
            // dnrDOB
            // 
            this.dnrDOB.DataPropertyName = "dnrDOB";
            this.dnrDOB.HeaderText = "DOB";
            this.dnrDOB.MinimumWidth = 6;
            this.dnrDOB.Name = "dnrDOB";
            this.dnrDOB.ReadOnly = true;
            // 
            // userGender
            // 
            this.userGender.DataPropertyName = "userGender";
            this.userGender.FillWeight = 70F;
            this.userGender.HeaderText = "Gender";
            this.userGender.MinimumWidth = 6;
            this.userGender.Name = "userGender";
            this.userGender.ReadOnly = true;
            // 
            // userEmail
            // 
            this.userEmail.DataPropertyName = "userEmail";
            this.userEmail.HeaderText = "Email";
            this.userEmail.MinimumWidth = 6;
            this.userEmail.Name = "userEmail";
            this.userEmail.ReadOnly = true;
            // 
            // userPhone
            // 
            this.userPhone.DataPropertyName = "userPhone";
            this.userPhone.HeaderText = "Phone";
            this.userPhone.MinimumWidth = 6;
            this.userPhone.Name = "userPhone";
            this.userPhone.ReadOnly = true;
            // 
            // uStreet
            // 
            this.uStreet.DataPropertyName = "uStreet";
            this.uStreet.HeaderText = "Street";
            this.uStreet.MinimumWidth = 6;
            this.uStreet.Name = "uStreet";
            this.uStreet.ReadOnly = true;
            // 
            // uCity
            // 
            this.uCity.DataPropertyName = "uCity";
            this.uCity.HeaderText = "City";
            this.uCity.MinimumWidth = 6;
            this.uCity.Name = "uCity";
            this.uCity.ReadOnly = true;
            // 
            // uCountry
            // 
            this.uCountry.DataPropertyName = "uCountry";
            this.uCountry.HeaderText = "Country";
            this.uCountry.MinimumWidth = 6;
            this.uCountry.Name = "uCountry";
            this.uCountry.ReadOnly = true;
            // 
            // dnrTotalDonation
            // 
            this.dnrTotalDonation.DataPropertyName = "dnrTotalDonation";
            this.dnrTotalDonation.HeaderText = "Total-Donation";
            this.dnrTotalDonation.MinimumWidth = 6;
            this.dnrTotalDonation.Name = "dnrTotalDonation";
            this.dnrTotalDonation.ReadOnly = true;
            // 
            // dnrAvailability
            // 
            this.dnrAvailability.DataPropertyName = "dnrAvailability";
            this.dnrAvailability.HeaderText = "Availability";
            this.dnrAvailability.MinimumWidth = 6;
            this.dnrAvailability.Name = "dnrAvailability";
            this.dnrAvailability.ReadOnly = true;
            // 
            // Us_DonorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.G_dgvDonorListShowList);
            this.Controls.Add(this.D__L_Toppanel);
            this.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Us_DonorList";
            this.Size = new System.Drawing.Size(1005, 673);
            this.Load += new System.EventHandler(this.Us_DonorList_Load);
            this.D__L_Toppanel.ResumeLayout(false);
            this.D__L_Toppanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.G_dgvDonorListShowList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel D__L_Toppanel;
        private Guna.UI2.WinForms.Guna2DataGridView G_dgvDonorListShowList;
        private System.Windows.Forms.DataGridViewTextBoxColumn userID;
        private System.Windows.Forms.DataGridViewTextBoxColumn userFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dnrBloodGrp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dnrDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn userGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn userEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn uStreet;
        private System.Windows.Forms.DataGridViewTextBoxColumn uCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn uCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn dnrTotalDonation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dnrAvailability;
        private Guna.UI2.WinForms.Guna2ComboBox G_CMBCountry;
        private Guna.UI2.WinForms.Guna2ComboBox G_CMBCity;
        private Guna.UI2.WinForms.Guna2ComboBox G_CMBBloodGroup;
        private Guna.UI2.WinForms.Guna2Button G_Btnclear;
        private Guna.UI2.WinForms.Guna2Button G_BtnApply;
    }
}
