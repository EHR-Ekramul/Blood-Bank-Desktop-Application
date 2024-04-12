
namespace VoidBloodBank.ZahidUserControl
{
    partial class Uc_DonorInfo
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
            this.Panel_DonorInfoUp = new Guna.UI2.WinForms.Guna2Panel();
            this.ComboBox_Country = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ComboBox_City = new Guna.UI2.WinForms.Guna2ComboBox();
            this.GBtn_Clear = new Guna.UI2.WinForms.Guna2Button();
            this.GBtn_DonorInfoApply = new Guna.UI2.WinForms.Guna2Button();
            this.ComboBox_BloodGroup = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DataGridView_DonorInfo = new Guna.UI2.WinForms.Guna2DataGridView();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dnrBloodGrp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dnrDob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uStreet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dnrTotalDonation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dnrAvailability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Panel_DonorInfoUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_DonorInfo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_DonorInfoUp
            // 
            this.Panel_DonorInfoUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Panel_DonorInfoUp.Controls.Add(this.ComboBox_Country);
            this.Panel_DonorInfoUp.Controls.Add(this.ComboBox_City);
            this.Panel_DonorInfoUp.Controls.Add(this.GBtn_Clear);
            this.Panel_DonorInfoUp.Controls.Add(this.GBtn_DonorInfoApply);
            this.Panel_DonorInfoUp.Controls.Add(this.ComboBox_BloodGroup);
            this.Panel_DonorInfoUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_DonorInfoUp.Location = new System.Drawing.Point(0, 0);
            this.Panel_DonorInfoUp.Name = "Panel_DonorInfoUp";
            this.Panel_DonorInfoUp.Size = new System.Drawing.Size(1038, 111);
            this.Panel_DonorInfoUp.TabIndex = 0;
            // 
            // ComboBox_Country
            // 
            this.ComboBox_Country.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ComboBox_Country.AutoRoundedCorners = true;
            this.ComboBox_Country.BackColor = System.Drawing.Color.Transparent;
            this.ComboBox_Country.BorderColor = System.Drawing.Color.Gray;
            this.ComboBox_Country.BorderRadius = 17;
            this.ComboBox_Country.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_Country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Country.DropDownWidth = 210;
            this.ComboBox_Country.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox_Country.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox_Country.Font = new System.Drawing.Font("Inter", 9.5F);
            this.ComboBox_Country.ForeColor = System.Drawing.Color.Gray;
            this.ComboBox_Country.ItemHeight = 30;
            this.ComboBox_Country.Items.AddRange(new object[] {
            "Country",
            "Bangladesh"});
            this.ComboBox_Country.Location = new System.Drawing.Point(248, 32);
            this.ComboBox_Country.Name = "ComboBox_Country";
            this.ComboBox_Country.Size = new System.Drawing.Size(173, 36);
            this.ComboBox_Country.StartIndex = 0;
            this.ComboBox_Country.TabIndex = 14;
            // 
            // ComboBox_City
            // 
            this.ComboBox_City.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ComboBox_City.AutoRoundedCorners = true;
            this.ComboBox_City.BackColor = System.Drawing.Color.Transparent;
            this.ComboBox_City.BorderColor = System.Drawing.Color.Gray;
            this.ComboBox_City.BorderRadius = 17;
            this.ComboBox_City.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_City.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_City.DropDownWidth = 210;
            this.ComboBox_City.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox_City.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox_City.Font = new System.Drawing.Font("Inter", 9.5F);
            this.ComboBox_City.ForeColor = System.Drawing.Color.Gray;
            this.ComboBox_City.ItemHeight = 30;
            this.ComboBox_City.Items.AddRange(new object[] {
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
            this.ComboBox_City.Location = new System.Drawing.Point(443, 32);
            this.ComboBox_City.Name = "ComboBox_City";
            this.ComboBox_City.Size = new System.Drawing.Size(173, 36);
            this.ComboBox_City.StartIndex = 0;
            this.ComboBox_City.TabIndex = 13;
            // 
            // GBtn_Clear
            // 
            this.GBtn_Clear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GBtn_Clear.AutoRoundedCorners = true;
            this.GBtn_Clear.BackColor = System.Drawing.Color.Transparent;
            this.GBtn_Clear.BorderRadius = 12;
            this.GBtn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GBtn_Clear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GBtn_Clear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GBtn_Clear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GBtn_Clear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GBtn_Clear.FillColor = System.Drawing.Color.White;
            this.GBtn_Clear.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Bold);
            this.GBtn_Clear.ForeColor = System.Drawing.Color.Red;
            this.GBtn_Clear.Location = new System.Drawing.Point(118, 37);
            this.GBtn_Clear.Name = "GBtn_Clear";
            this.GBtn_Clear.Size = new System.Drawing.Size(101, 27);
            this.GBtn_Clear.TabIndex = 12;
            this.GBtn_Clear.Text = "Clear";
            this.GBtn_Clear.UseTransparentBackground = true;
            this.GBtn_Clear.Click += new System.EventHandler(this.GBtn_Clear_Click);
            // 
            // GBtn_DonorInfoApply
            // 
            this.GBtn_DonorInfoApply.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GBtn_DonorInfoApply.AutoRoundedCorners = true;
            this.GBtn_DonorInfoApply.BackColor = System.Drawing.Color.Transparent;
            this.GBtn_DonorInfoApply.BorderColor = System.Drawing.Color.Transparent;
            this.GBtn_DonorInfoApply.BorderRadius = 12;
            this.GBtn_DonorInfoApply.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.GBtn_DonorInfoApply.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GBtn_DonorInfoApply.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GBtn_DonorInfoApply.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GBtn_DonorInfoApply.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GBtn_DonorInfoApply.FillColor = System.Drawing.Color.White;
            this.GBtn_DonorInfoApply.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold);
            this.GBtn_DonorInfoApply.ForeColor = System.Drawing.Color.Black;
            this.GBtn_DonorInfoApply.Location = new System.Drawing.Point(843, 37);
            this.GBtn_DonorInfoApply.Name = "GBtn_DonorInfoApply";
            this.GBtn_DonorInfoApply.Size = new System.Drawing.Size(101, 27);
            this.GBtn_DonorInfoApply.TabIndex = 4;
            this.GBtn_DonorInfoApply.Text = "Apply";
            this.GBtn_DonorInfoApply.Click += new System.EventHandler(this.GBtn_DonorInfoApply_Click);
            // 
            // ComboBox_BloodGroup
            // 
            this.ComboBox_BloodGroup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ComboBox_BloodGroup.AutoRoundedCorners = true;
            this.ComboBox_BloodGroup.BackColor = System.Drawing.Color.Transparent;
            this.ComboBox_BloodGroup.BorderColor = System.Drawing.Color.Black;
            this.ComboBox_BloodGroup.BorderRadius = 17;
            this.ComboBox_BloodGroup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_BloodGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_BloodGroup.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox_BloodGroup.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox_BloodGroup.Font = new System.Drawing.Font("Inter", 9.5F);
            this.ComboBox_BloodGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBox_BloodGroup.ItemHeight = 30;
            this.ComboBox_BloodGroup.Items.AddRange(new object[] {
            "Blood Group",
            "A Positive",
            "A Negative",
            "B Positive",
            "B Negative",
            "AB Positive",
            "AB Negative",
            "O Positive",
            "O Negative"});
            this.ComboBox_BloodGroup.Location = new System.Drawing.Point(638, 32);
            this.ComboBox_BloodGroup.Name = "ComboBox_BloodGroup";
            this.ComboBox_BloodGroup.Size = new System.Drawing.Size(173, 36);
            this.ComboBox_BloodGroup.StartIndex = 0;
            this.ComboBox_BloodGroup.TabIndex = 2;
            // 
            // DataGridView_DonorInfo
            // 
            this.DataGridView_DonorInfo.AllowUserToAddRows = false;
            this.DataGridView_DonorInfo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView_DonorInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_DonorInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_DonorInfo.ColumnHeadersHeight = 38;
            this.DataGridView_DonorInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_DonorInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.FullName,
            this.dnrBloodGrp,
            this.dnrDob,
            this.userGender,
            this.userEmail,
            this.userPhone,
            this.uCity,
            this.uCountry,
            this.uStreet,
            this.dnrTotalDonation,
            this.dnrAvailability});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_DonorInfo.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_DonorInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView_DonorInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_DonorInfo.Location = new System.Drawing.Point(0, 0);
            this.DataGridView_DonorInfo.Name = "DataGridView_DonorInfo";
            this.DataGridView_DonorInfo.ReadOnly = true;
            this.DataGridView_DonorInfo.RowHeadersVisible = false;
            this.DataGridView_DonorInfo.RowHeadersWidth = 51;
            this.DataGridView_DonorInfo.RowTemplate.Height = 24;
            this.DataGridView_DonorInfo.Size = new System.Drawing.Size(1038, 562);
            this.DataGridView_DonorInfo.TabIndex = 0;
            this.DataGridView_DonorInfo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_DonorInfo.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_DonorInfo.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_DonorInfo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_DonorInfo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_DonorInfo.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_DonorInfo.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_DonorInfo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DataGridView_DonorInfo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_DonorInfo.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_DonorInfo.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_DonorInfo.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_DonorInfo.ThemeStyle.HeaderStyle.Height = 38;
            this.DataGridView_DonorInfo.ThemeStyle.ReadOnly = true;
            this.DataGridView_DonorInfo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_DonorInfo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_DonorInfo.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Inter Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_DonorInfo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_DonorInfo.ThemeStyle.RowsStyle.Height = 24;
            this.DataGridView_DonorInfo.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_DonorInfo.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // UserID
            // 
            this.UserID.DataPropertyName = "userID";
            this.UserID.HeaderText = "ID";
            this.UserID.MinimumWidth = 6;
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "userFullName";
            this.FullName.HeaderText = "Name";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // dnrBloodGrp
            // 
            this.dnrBloodGrp.DataPropertyName = "dnrBloodGrp";
            this.dnrBloodGrp.HeaderText = "Blood Group";
            this.dnrBloodGrp.MinimumWidth = 6;
            this.dnrBloodGrp.Name = "dnrBloodGrp";
            this.dnrBloodGrp.ReadOnly = true;
            // 
            // dnrDob
            // 
            this.dnrDob.DataPropertyName = "dnrDOB";
            this.dnrDob.HeaderText = "DOB";
            this.dnrDob.MinimumWidth = 6;
            this.dnrDob.Name = "dnrDob";
            this.dnrDob.ReadOnly = true;
            // 
            // userGender
            // 
            this.userGender.DataPropertyName = "userGender";
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
            // uStreet
            // 
            this.uStreet.DataPropertyName = "uStreet";
            this.uStreet.HeaderText = "Street";
            this.uStreet.MinimumWidth = 6;
            this.uStreet.Name = "uStreet";
            this.uStreet.ReadOnly = true;
            // 
            // dnrTotalDonation
            // 
            this.dnrTotalDonation.DataPropertyName = "dnrTotalDonation";
            this.dnrTotalDonation.HeaderText = "Total Donation";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.DataGridView_DonorInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 562);
            this.panel1.TabIndex = 1;
            // 
            // Uc_DonorInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Panel_DonorInfoUp);
            this.MinimumSize = new System.Drawing.Size(475, 185);
            this.Name = "Uc_DonorInfo";
            this.Size = new System.Drawing.Size(1038, 673);
            this.Load += new System.EventHandler(this.Uc_DonorInfo_Load);
            this.Panel_DonorInfoUp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_DonorInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Panel_DonorInfoUp;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_DonorInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dnrBloodGrp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dnrDob;
        private System.Windows.Forms.DataGridViewTextBoxColumn userGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn userEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn uCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn uCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn uStreet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dnrTotalDonation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dnrAvailability;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox_BloodGroup;
        private Guna.UI2.WinForms.Guna2Button GBtn_DonorInfoApply;
        private Guna.UI2.WinForms.Guna2Button GBtn_Clear;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox_Country;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox_City;
        private System.Windows.Forms.Panel panel1;
    }
}
