
namespace VoidBloodBank
{
    partial class Employee
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
        [System.Obsolete]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.AccountTimer = new System.Windows.Forms.Timer(this.components);
            this.Gbtn_Dashboard = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Gbtn_DonorInfo = new Guna.UI2.WinForms.Guna2Button();
            this.ImgSlider_Dashboard = new System.Windows.Forms.PictureBox();
            this.AccountFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AccountPanel = new System.Windows.Forms.Panel();
            this.Gbtn_MyProfile = new Guna.UI2.WinForms.Guna2Button();
            this.Gbtn_Setting = new Guna.UI2.WinForms.Guna2Button();
            this.Gbtn_Account = new Guna.UI2.WinForms.Guna2Button();
            this.GBtn_Logout = new Guna.UI2.WinForms.Guna2Button();
            this.GBtn_ManagePost = new Guna.UI2.WinForms.Guna2Button();
            this.Panel_Employee = new System.Windows.Forms.Panel();
            this.ImgSlider_ManagePost = new System.Windows.Forms.PictureBox();
            this.ImgSlider_DonorInfo = new System.Windows.Forms.PictureBox();
            this.Label_EmployeePanelEmpName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PictureBox_Employoee = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Panel_Mother = new System.Windows.Forms.Panel();
            this.Panel_ManagePost = new System.Windows.Forms.Panel();
            this.FlowLayoutPanel_PendingPost = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GBtn_ManagePostClear = new Guna.UI2.WinForms.Guna2Button();
            this.GBtn_ManagePostApply = new Guna.UI2.WinForms.Guna2Button();
            this.ComboBox_ManagePost = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgSlider_Dashboard)).BeginInit();
            this.AccountFlowPanel.SuspendLayout();
            this.AccountPanel.SuspendLayout();
            this.Panel_Employee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgSlider_ManagePost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgSlider_DonorInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Employoee)).BeginInit();
            this.Panel_ManagePost.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AccountTimer
            // 
            this.AccountTimer.Interval = 5;
            this.AccountTimer.Tick += new System.EventHandler(this.AccountTimer_Tick);
            // 
            // Gbtn_Dashboard
            // 
            this.Gbtn_Dashboard.BackColor = System.Drawing.Color.Transparent;
            this.Gbtn_Dashboard.BorderRadius = 22;
            this.Gbtn_Dashboard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Gbtn_Dashboard.CheckedState.FillColor = System.Drawing.Color.White;
            this.Gbtn_Dashboard.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Gbtn_Dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gbtn_Dashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gbtn_Dashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gbtn_Dashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gbtn_Dashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gbtn_Dashboard.FillColor = System.Drawing.Color.White;
            this.Gbtn_Dashboard.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.Gbtn_Dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Gbtn_Dashboard.Image = ((System.Drawing.Image)(resources.GetObject("Gbtn_Dashboard.Image")));
            this.Gbtn_Dashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gbtn_Dashboard.ImageOffset = new System.Drawing.Point(5, 0);
            this.Gbtn_Dashboard.ImageSize = new System.Drawing.Size(30, 30);
            this.Gbtn_Dashboard.Location = new System.Drawing.Point(11, 139);
            this.Gbtn_Dashboard.Name = "Gbtn_Dashboard";
            this.Gbtn_Dashboard.Size = new System.Drawing.Size(200, 41);
            this.Gbtn_Dashboard.TabIndex = 1;
            this.Gbtn_Dashboard.Text = "DashBoard";
            this.Gbtn_Dashboard.TextOffset = new System.Drawing.Point(10, 0);
            this.Gbtn_Dashboard.UseTransparentBackground = true;
            this.Gbtn_Dashboard.Click += new System.EventHandler(this.Gbtn_Dashboard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 619);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Gbtn_DonorInfo
            // 
            this.Gbtn_DonorInfo.BackColor = System.Drawing.Color.Transparent;
            this.Gbtn_DonorInfo.BorderRadius = 22;
            this.Gbtn_DonorInfo.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Gbtn_DonorInfo.CheckedState.FillColor = System.Drawing.Color.White;
            this.Gbtn_DonorInfo.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Gbtn_DonorInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gbtn_DonorInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gbtn_DonorInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gbtn_DonorInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gbtn_DonorInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gbtn_DonorInfo.FillColor = System.Drawing.Color.White;
            this.Gbtn_DonorInfo.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.Gbtn_DonorInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Gbtn_DonorInfo.Image = ((System.Drawing.Image)(resources.GetObject("Gbtn_DonorInfo.Image")));
            this.Gbtn_DonorInfo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gbtn_DonorInfo.ImageOffset = new System.Drawing.Point(5, 0);
            this.Gbtn_DonorInfo.ImageSize = new System.Drawing.Size(30, 30);
            this.Gbtn_DonorInfo.Location = new System.Drawing.Point(14, 201);
            this.Gbtn_DonorInfo.Name = "Gbtn_DonorInfo";
            this.Gbtn_DonorInfo.Size = new System.Drawing.Size(200, 41);
            this.Gbtn_DonorInfo.TabIndex = 3;
            this.Gbtn_DonorInfo.Text = "Donor Info";
            this.Gbtn_DonorInfo.TextOffset = new System.Drawing.Point(10, 0);
            this.Gbtn_DonorInfo.UseTransparentBackground = true;
            this.Gbtn_DonorInfo.Click += new System.EventHandler(this.Gbtn_DonorInfo_Click);
            // 
            // ImgSlider_Dashboard
            // 
            this.ImgSlider_Dashboard.Image = ((System.Drawing.Image)(resources.GetObject("ImgSlider_Dashboard.Image")));
            this.ImgSlider_Dashboard.Location = new System.Drawing.Point(191, 121);
            this.ImgSlider_Dashboard.Name = "ImgSlider_Dashboard";
            this.ImgSlider_Dashboard.Size = new System.Drawing.Size(50, 75);
            this.ImgSlider_Dashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ImgSlider_Dashboard.TabIndex = 1;
            this.ImgSlider_Dashboard.TabStop = false;
            // 
            // AccountFlowPanel
            // 
            this.AccountFlowPanel.Controls.Add(this.AccountPanel);
            this.AccountFlowPanel.Controls.Add(this.GBtn_Logout);
            this.AccountFlowPanel.Location = new System.Drawing.Point(10, 319);
            this.AccountFlowPanel.Name = "AccountFlowPanel";
            this.AccountFlowPanel.Size = new System.Drawing.Size(212, 251);
            this.AccountFlowPanel.TabIndex = 6;
            // 
            // AccountPanel
            // 
            this.AccountPanel.Controls.Add(this.Gbtn_MyProfile);
            this.AccountPanel.Controls.Add(this.Gbtn_Setting);
            this.AccountPanel.Controls.Add(this.Gbtn_Account);
            this.AccountPanel.Location = new System.Drawing.Point(3, 3);
            this.AccountPanel.MaximumSize = new System.Drawing.Size(210, 178);
            this.AccountPanel.MinimumSize = new System.Drawing.Size(210, 55);
            this.AccountPanel.Name = "AccountPanel";
            this.AccountPanel.Size = new System.Drawing.Size(210, 55);
            this.AccountPanel.TabIndex = 5;
            // 
            // Gbtn_MyProfile
            // 
            this.Gbtn_MyProfile.BackColor = System.Drawing.Color.Transparent;
            this.Gbtn_MyProfile.BorderRadius = 22;
            this.Gbtn_MyProfile.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Gbtn_MyProfile.CheckedState.FillColor = System.Drawing.Color.White;
            this.Gbtn_MyProfile.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Gbtn_MyProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gbtn_MyProfile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gbtn_MyProfile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gbtn_MyProfile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gbtn_MyProfile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gbtn_MyProfile.FillColor = System.Drawing.Color.White;
            this.Gbtn_MyProfile.Font = new System.Drawing.Font("Inter", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gbtn_MyProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Gbtn_MyProfile.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Gbtn_MyProfile.Image = ((System.Drawing.Image)(resources.GetObject("Gbtn_MyProfile.Image")));
            this.Gbtn_MyProfile.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gbtn_MyProfile.ImageOffset = new System.Drawing.Point(2, 0);
            this.Gbtn_MyProfile.ImageSize = new System.Drawing.Size(30, 30);
            this.Gbtn_MyProfile.Location = new System.Drawing.Point(24, 65);
            this.Gbtn_MyProfile.Name = "Gbtn_MyProfile";
            this.Gbtn_MyProfile.Size = new System.Drawing.Size(173, 41);
            this.Gbtn_MyProfile.TabIndex = 4;
            this.Gbtn_MyProfile.Text = "  My Profile";
            this.Gbtn_MyProfile.UseTransparentBackground = true;
            this.Gbtn_MyProfile.Click += new System.EventHandler(this.Gbtn_MyProfile_Click);
            // 
            // Gbtn_Setting
            // 
            this.Gbtn_Setting.BackColor = System.Drawing.Color.Transparent;
            this.Gbtn_Setting.BorderRadius = 22;
            this.Gbtn_Setting.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Gbtn_Setting.CheckedState.FillColor = System.Drawing.Color.White;
            this.Gbtn_Setting.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Gbtn_Setting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gbtn_Setting.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gbtn_Setting.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gbtn_Setting.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gbtn_Setting.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gbtn_Setting.FillColor = System.Drawing.Color.White;
            this.Gbtn_Setting.Font = new System.Drawing.Font("Inter", 10.8F);
            this.Gbtn_Setting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Gbtn_Setting.Image = ((System.Drawing.Image)(resources.GetObject("Gbtn_Setting.Image")));
            this.Gbtn_Setting.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gbtn_Setting.ImageOffset = new System.Drawing.Point(2, 0);
            this.Gbtn_Setting.ImageSize = new System.Drawing.Size(30, 30);
            this.Gbtn_Setting.Location = new System.Drawing.Point(24, 124);
            this.Gbtn_Setting.Name = "Gbtn_Setting";
            this.Gbtn_Setting.Size = new System.Drawing.Size(173, 41);
            this.Gbtn_Setting.TabIndex = 4;
            this.Gbtn_Setting.Text = "Settings";
            this.Gbtn_Setting.UseTransparentBackground = true;
            this.Gbtn_Setting.Click += new System.EventHandler(this.Gbtn_Setting_Click);
            // 
            // Gbtn_Account
            // 
            this.Gbtn_Account.BackColor = System.Drawing.Color.Transparent;
            this.Gbtn_Account.BorderRadius = 22;
            this.Gbtn_Account.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Gbtn_Account.CheckedState.FillColor = System.Drawing.Color.White;
            this.Gbtn_Account.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Gbtn_Account.Cursor = System.Windows.Forms.Cursors.Default;
            this.Gbtn_Account.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gbtn_Account.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gbtn_Account.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gbtn_Account.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gbtn_Account.FillColor = System.Drawing.Color.White;
            this.Gbtn_Account.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.Gbtn_Account.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Gbtn_Account.Image = ((System.Drawing.Image)(resources.GetObject("Gbtn_Account.Image")));
            this.Gbtn_Account.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gbtn_Account.ImageOffset = new System.Drawing.Point(5, 0);
            this.Gbtn_Account.ImageSize = new System.Drawing.Size(30, 30);
            this.Gbtn_Account.Location = new System.Drawing.Point(1, 3);
            this.Gbtn_Account.Name = "Gbtn_Account";
            this.Gbtn_Account.Size = new System.Drawing.Size(200, 41);
            this.Gbtn_Account.TabIndex = 2;
            this.Gbtn_Account.Text = "Account";
            this.Gbtn_Account.UseTransparentBackground = true;
            this.Gbtn_Account.Click += new System.EventHandler(this.Gbtn_Account_Click);
            // 
            // GBtn_Logout
            // 
            this.GBtn_Logout.BackColor = System.Drawing.Color.Transparent;
            this.GBtn_Logout.BorderRadius = 22;
            this.GBtn_Logout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.GBtn_Logout.CheckedState.FillColor = System.Drawing.Color.White;
            this.GBtn_Logout.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.GBtn_Logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GBtn_Logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GBtn_Logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GBtn_Logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GBtn_Logout.FillColor = System.Drawing.Color.White;
            this.GBtn_Logout.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.GBtn_Logout.ForeColor = System.Drawing.Color.Red;
            this.GBtn_Logout.Image = ((System.Drawing.Image)(resources.GetObject("GBtn_Logout.Image")));
            this.GBtn_Logout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GBtn_Logout.ImageOffset = new System.Drawing.Point(5, 0);
            this.GBtn_Logout.ImageSize = new System.Drawing.Size(30, 30);
            this.GBtn_Logout.Location = new System.Drawing.Point(3, 64);
            this.GBtn_Logout.Name = "GBtn_Logout";
            this.GBtn_Logout.Size = new System.Drawing.Size(200, 41);
            this.GBtn_Logout.TabIndex = 5;
            this.GBtn_Logout.Text = "Logout";
            this.GBtn_Logout.UseTransparentBackground = true;
            this.GBtn_Logout.Click += new System.EventHandler(this.GBtn_Logout_Click);
            // 
            // GBtn_ManagePost
            // 
            this.GBtn_ManagePost.BackColor = System.Drawing.Color.Transparent;
            this.GBtn_ManagePost.BorderRadius = 22;
            this.GBtn_ManagePost.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.GBtn_ManagePost.CheckedState.FillColor = System.Drawing.Color.White;
            this.GBtn_ManagePost.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GBtn_ManagePost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GBtn_ManagePost.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GBtn_ManagePost.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GBtn_ManagePost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GBtn_ManagePost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GBtn_ManagePost.FillColor = System.Drawing.Color.White;
            this.GBtn_ManagePost.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.GBtn_ManagePost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GBtn_ManagePost.Image = ((System.Drawing.Image)(resources.GetObject("GBtn_ManagePost.Image")));
            this.GBtn_ManagePost.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GBtn_ManagePost.ImageOffset = new System.Drawing.Point(2, 0);
            this.GBtn_ManagePost.ImageSize = new System.Drawing.Size(30, 30);
            this.GBtn_ManagePost.Location = new System.Drawing.Point(14, 263);
            this.GBtn_ManagePost.Name = "GBtn_ManagePost";
            this.GBtn_ManagePost.Size = new System.Drawing.Size(200, 41);
            this.GBtn_ManagePost.TabIndex = 7;
            this.GBtn_ManagePost.Text = "  Manage Post";
            this.GBtn_ManagePost.TextOffset = new System.Drawing.Point(10, 0);
            this.GBtn_ManagePost.UseTransparentBackground = true;
            this.GBtn_ManagePost.Click += new System.EventHandler(this.GBtn_ManagePost_Click);
            // 
            // Panel_Employee
            // 
            this.Panel_Employee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.Panel_Employee.Controls.Add(this.ImgSlider_ManagePost);
            this.Panel_Employee.Controls.Add(this.ImgSlider_DonorInfo);
            this.Panel_Employee.Controls.Add(this.Label_EmployeePanelEmpName);
            this.Panel_Employee.Controls.Add(this.PictureBox_Employoee);
            this.Panel_Employee.Controls.Add(this.GBtn_ManagePost);
            this.Panel_Employee.Controls.Add(this.AccountFlowPanel);
            this.Panel_Employee.Controls.Add(this.ImgSlider_Dashboard);
            this.Panel_Employee.Controls.Add(this.Gbtn_DonorInfo);
            this.Panel_Employee.Controls.Add(this.pictureBox1);
            this.Panel_Employee.Controls.Add(this.Gbtn_Dashboard);
            this.Panel_Employee.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Employee.Location = new System.Drawing.Point(0, 0);
            this.Panel_Employee.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Employee.Name = "Panel_Employee";
            this.Panel_Employee.Size = new System.Drawing.Size(237, 673);
            this.Panel_Employee.TabIndex = 0;
            // 
            // ImgSlider_ManagePost
            // 
            this.ImgSlider_ManagePost.Image = ((System.Drawing.Image)(resources.GetObject("ImgSlider_ManagePost.Image")));
            this.ImgSlider_ManagePost.Location = new System.Drawing.Point(193, 247);
            this.ImgSlider_ManagePost.Name = "ImgSlider_ManagePost";
            this.ImgSlider_ManagePost.Size = new System.Drawing.Size(49, 72);
            this.ImgSlider_ManagePost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ImgSlider_ManagePost.TabIndex = 8;
            this.ImgSlider_ManagePost.TabStop = false;
            // 
            // ImgSlider_DonorInfo
            // 
            this.ImgSlider_DonorInfo.Image = ((System.Drawing.Image)(resources.GetObject("ImgSlider_DonorInfo.Image")));
            this.ImgSlider_DonorInfo.Location = new System.Drawing.Point(192, 183);
            this.ImgSlider_DonorInfo.Name = "ImgSlider_DonorInfo";
            this.ImgSlider_DonorInfo.Size = new System.Drawing.Size(49, 76);
            this.ImgSlider_DonorInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ImgSlider_DonorInfo.TabIndex = 7;
            this.ImgSlider_DonorInfo.TabStop = false;
            // 
            // Label_EmployeePanelEmpName
            // 
            this.Label_EmployeePanelEmpName.BackColor = System.Drawing.Color.Transparent;
            this.Label_EmployeePanelEmpName.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_EmployeePanelEmpName.ForeColor = System.Drawing.Color.Black;
            this.Label_EmployeePanelEmpName.Location = new System.Drawing.Point(19, 92);
            this.Label_EmployeePanelEmpName.Name = "Label_EmployeePanelEmpName";
            this.Label_EmployeePanelEmpName.Size = new System.Drawing.Size(114, 26);
            this.Label_EmployeePanelEmpName.TabIndex = 12;
            this.Label_EmployeePanelEmpName.Text = "Emp Name";
            // 
            // PictureBox_Employoee
            // 
            this.PictureBox_Employoee.ImageRotate = 0F;
            this.PictureBox_Employoee.Location = new System.Drawing.Point(37, 2);
            this.PictureBox_Employoee.Name = "PictureBox_Employoee";
            this.PictureBox_Employoee.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PictureBox_Employoee.Size = new System.Drawing.Size(130, 84);
            this.PictureBox_Employoee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_Employoee.TabIndex = 8;
            this.PictureBox_Employoee.TabStop = false;
            // 
            // Panel_Mother
            // 
            this.Panel_Mother.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Mother.Location = new System.Drawing.Point(237, 0);
            this.Panel_Mother.Name = "Panel_Mother";
            this.Panel_Mother.Size = new System.Drawing.Size(1045, 673);
            this.Panel_Mother.TabIndex = 8;
            // 
            // Panel_ManagePost
            // 
            this.Panel_ManagePost.Controls.Add(this.FlowLayoutPanel_PendingPost);
            this.Panel_ManagePost.Controls.Add(this.panel1);
            this.Panel_ManagePost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_ManagePost.Location = new System.Drawing.Point(237, 0);
            this.Panel_ManagePost.Name = "Panel_ManagePost";
            this.Panel_ManagePost.Size = new System.Drawing.Size(1045, 673);
            this.Panel_ManagePost.TabIndex = 9;
            this.Panel_ManagePost.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel__Paint);
            // 
            // FlowLayoutPanel_PendingPost
            // 
            this.FlowLayoutPanel_PendingPost.AutoScroll = true;
            this.FlowLayoutPanel_PendingPost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowLayoutPanel_PendingPost.Location = new System.Drawing.Point(0, 98);
            this.FlowLayoutPanel_PendingPost.Margin = new System.Windows.Forms.Padding(0);
            this.FlowLayoutPanel_PendingPost.Name = "FlowLayoutPanel_PendingPost";
            this.FlowLayoutPanel_PendingPost.Size = new System.Drawing.Size(1045, 575);
            this.FlowLayoutPanel_PendingPost.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.GBtn_ManagePostClear);
            this.panel1.Controls.Add(this.GBtn_ManagePostApply);
            this.panel1.Controls.Add(this.ComboBox_ManagePost);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1045, 98);
            this.panel1.TabIndex = 17;
            // 
            // GBtn_ManagePostClear
            // 
            this.GBtn_ManagePostClear.AutoRoundedCorners = true;
            this.GBtn_ManagePostClear.BackColor = System.Drawing.Color.Transparent;
            this.GBtn_ManagePostClear.BorderRadius = 12;
            this.GBtn_ManagePostClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GBtn_ManagePostClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GBtn_ManagePostClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GBtn_ManagePostClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GBtn_ManagePostClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GBtn_ManagePostClear.FillColor = System.Drawing.Color.White;
            this.GBtn_ManagePostClear.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Bold);
            this.GBtn_ManagePostClear.ForeColor = System.Drawing.Color.Red;
            this.GBtn_ManagePostClear.Location = new System.Drawing.Point(274, 25);
            this.GBtn_ManagePostClear.Name = "GBtn_ManagePostClear";
            this.GBtn_ManagePostClear.Size = new System.Drawing.Size(101, 27);
            this.GBtn_ManagePostClear.TabIndex = 17;
            this.GBtn_ManagePostClear.Text = "Clear";
            this.GBtn_ManagePostClear.UseTransparentBackground = true;
            this.GBtn_ManagePostClear.Click += new System.EventHandler(this.GBtn_ManagePostClear_Click);
            // 
            // GBtn_ManagePostApply
            // 
            this.GBtn_ManagePostApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GBtn_ManagePostApply.AutoRoundedCorners = true;
            this.GBtn_ManagePostApply.BackColor = System.Drawing.Color.Transparent;
            this.GBtn_ManagePostApply.BorderColor = System.Drawing.Color.Transparent;
            this.GBtn_ManagePostApply.BorderRadius = 12;
            this.GBtn_ManagePostApply.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.GBtn_ManagePostApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GBtn_ManagePostApply.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GBtn_ManagePostApply.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GBtn_ManagePostApply.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GBtn_ManagePostApply.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GBtn_ManagePostApply.FillColor = System.Drawing.Color.White;
            this.GBtn_ManagePostApply.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold);
            this.GBtn_ManagePostApply.ForeColor = System.Drawing.Color.Black;
            this.GBtn_ManagePostApply.Location = new System.Drawing.Point(654, 25);
            this.GBtn_ManagePostApply.Name = "GBtn_ManagePostApply";
            this.GBtn_ManagePostApply.Size = new System.Drawing.Size(101, 27);
            this.GBtn_ManagePostApply.TabIndex = 16;
            this.GBtn_ManagePostApply.Text = "Apply";
            this.GBtn_ManagePostApply.UseTransparentBackground = true;
            this.GBtn_ManagePostApply.Click += new System.EventHandler(this.GBtn_ManagePostApply_Click);
            // 
            // ComboBox_ManagePost
            // 
            this.ComboBox_ManagePost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_ManagePost.AutoRoundedCorners = true;
            this.ComboBox_ManagePost.BackColor = System.Drawing.Color.Transparent;
            this.ComboBox_ManagePost.BorderColor = System.Drawing.Color.Gray;
            this.ComboBox_ManagePost.BorderRadius = 17;
            this.ComboBox_ManagePost.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_ManagePost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_ManagePost.DropDownWidth = 210;
            this.ComboBox_ManagePost.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox_ManagePost.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox_ManagePost.Font = new System.Drawing.Font("Inter", 12F);
            this.ComboBox_ManagePost.ForeColor = System.Drawing.Color.Gray;
            this.ComboBox_ManagePost.ItemHeight = 30;
            this.ComboBox_ManagePost.Items.AddRange(new object[] {
            "All",
            "Pending Post",
            "Accepted Post",
            "Rejected Post"});
            this.ComboBox_ManagePost.Location = new System.Drawing.Point(381, 22);
            this.ComboBox_ManagePost.Name = "ComboBox_ManagePost";
            this.ComboBox_ManagePost.Size = new System.Drawing.Size(267, 36);
            this.ComboBox_ManagePost.StartIndex = 0;
            this.ComboBox_ManagePost.TabIndex = 12;
            this.ComboBox_ManagePost.SelectedIndexChanged += new System.EventHandler(this.ComboBox_ManagePost_SelectedIndexChanged);
            // 
            // Employee
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1282, 673);
            this.Controls.Add(this.Panel_ManagePost);
            this.Controls.Add(this.Panel_Mother);
            this.Controls.Add(this.Panel_Employee);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(475, 185);
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VOID Blood Bank";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Employee_FormClosing);
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgSlider_Dashboard)).EndInit();
            this.AccountFlowPanel.ResumeLayout(false);
            this.AccountPanel.ResumeLayout(false);
            this.Panel_Employee.ResumeLayout(false);
            this.Panel_Employee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgSlider_ManagePost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgSlider_DonorInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Employoee)).EndInit();
            this.Panel_ManagePost.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer AccountTimer;
        private Guna.UI2.WinForms.Guna2Button Gbtn_Dashboard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button Gbtn_DonorInfo;
        private System.Windows.Forms.PictureBox ImgSlider_Dashboard;
        private System.Windows.Forms.FlowLayoutPanel AccountFlowPanel;
        private System.Windows.Forms.Panel AccountPanel;
        private Guna.UI2.WinForms.Guna2Button Gbtn_MyProfile;
        private Guna.UI2.WinForms.Guna2Button Gbtn_Setting;
        private Guna.UI2.WinForms.Guna2Button Gbtn_Account;
        private Guna.UI2.WinForms.Guna2Button GBtn_Logout;
        private Guna.UI2.WinForms.Guna2Button GBtn_ManagePost;
        private System.Windows.Forms.Panel Panel_Employee;
        private Guna.UI2.WinForms.Guna2CirclePictureBox PictureBox_Employoee;
        private Guna.UI2.WinForms.Guna2HtmlLabel Label_EmployeePanelEmpName;
        private System.Windows.Forms.PictureBox ImgSlider_DonorInfo;
        private System.Windows.Forms.PictureBox ImgSlider_ManagePost;
        private System.Windows.Forms.Panel Panel_Mother;
        private System.Windows.Forms.Panel Panel_ManagePost;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox_ManagePost;
        private Guna.UI2.WinForms.Guna2Button GBtn_ManagePostClear;
        private Guna.UI2.WinForms.Guna2Button GBtn_ManagePostApply;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel_PendingPost;
    }
}