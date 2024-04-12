using VoidBloodBank.TonmoyUserControl;
namespace VoidBloodBank
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.SidePanel = new System.Windows.Forms.Panel();
            this.ImgSlide = new System.Windows.Forms.PictureBox();
            this.F_PanelMyAccount = new System.Windows.Forms.FlowLayoutPanel();
            this.panelT = new System.Windows.Forms.Panel();
            this.GunaMyAccountbtn = new Guna.UI2.WinForms.Guna2Button();
            this.GunaSettingBtn = new Guna.UI2.WinForms.Guna2Button();
            this.GunaMyProfileBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GunaLogOutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.LblAName = new System.Windows.Forms.Label();
            this.GunaPicBox = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.GunaEmployeeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.GunaBloodRequestBtn = new Guna.UI2.WinForms.Guna2Button();
            this.GunaDonorListBtn = new Guna.UI2.WinForms.Guna2Button();
            this.GunaDashboardBtn = new Guna.UI2.WinForms.Guna2Button();
            this.LblTypeName = new System.Windows.Forms.Label();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.SubTransition = new System.Windows.Forms.Timer(this.components);
            this.MotherPanel = new System.Windows.Forms.Panel();
            this.SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgSlide)).BeginInit();
            this.F_PanelMyAccount.SuspendLayout();
            this.panelT.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GunaPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(212)))));
            this.SidePanel.Controls.Add(this.ImgSlide);
            this.SidePanel.Controls.Add(this.F_PanelMyAccount);
            this.SidePanel.Controls.Add(this.LblAName);
            this.SidePanel.Controls.Add(this.GunaPicBox);
            this.SidePanel.Controls.Add(this.GunaEmployeeBtn);
            this.SidePanel.Controls.Add(this.GunaBloodRequestBtn);
            this.SidePanel.Controls.Add(this.GunaDonorListBtn);
            this.SidePanel.Controls.Add(this.GunaDashboardBtn);
            this.SidePanel.Controls.Add(this.LblTypeName);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(277, 673);
            this.SidePanel.TabIndex = 0;
            // 
            // ImgSlide
            // 
            this.ImgSlide.Image = ((System.Drawing.Image)(resources.GetObject("ImgSlide.Image")));
            this.ImgSlide.Location = new System.Drawing.Point(215, 156);
            this.ImgSlide.Name = "ImgSlide";
            this.ImgSlide.Size = new System.Drawing.Size(67, 86);
            this.ImgSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ImgSlide.TabIndex = 2;
            this.ImgSlide.TabStop = false;
            // 
            // F_PanelMyAccount
            // 
            this.F_PanelMyAccount.Controls.Add(this.panelT);
            this.F_PanelMyAccount.Controls.Add(this.panel1);
            this.F_PanelMyAccount.Location = new System.Drawing.Point(2, 422);
            this.F_PanelMyAccount.Name = "F_PanelMyAccount";
            this.F_PanelMyAccount.Size = new System.Drawing.Size(271, 217);
            this.F_PanelMyAccount.TabIndex = 2;
            // 
            // panelT
            // 
            this.panelT.Controls.Add(this.GunaMyAccountbtn);
            this.panelT.Controls.Add(this.GunaSettingBtn);
            this.panelT.Controls.Add(this.GunaMyProfileBtn);
            this.panelT.Location = new System.Drawing.Point(3, 3);
            this.panelT.MaximumSize = new System.Drawing.Size(268, 148);
            this.panelT.MinimumSize = new System.Drawing.Size(268, 50);
            this.panelT.Name = "panelT";
            this.panelT.Size = new System.Drawing.Size(268, 50);
            this.panelT.TabIndex = 3;
            // 
            // GunaMyAccountbtn
            // 
            this.GunaMyAccountbtn.BackColor = System.Drawing.Color.Transparent;
            this.GunaMyAccountbtn.BorderRadius = 22;
            this.GunaMyAccountbtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.GunaMyAccountbtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.GunaMyAccountbtn.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.GunaMyAccountbtn.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.GunaMyAccountbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GunaMyAccountbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GunaMyAccountbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GunaMyAccountbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GunaMyAccountbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GunaMyAccountbtn.FillColor = System.Drawing.Color.White;
            this.GunaMyAccountbtn.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.GunaMyAccountbtn.ForeColor = System.Drawing.Color.Black;
            this.GunaMyAccountbtn.Image = ((System.Drawing.Image)(resources.GetObject("GunaMyAccountbtn.Image")));
            this.GunaMyAccountbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GunaMyAccountbtn.ImageOffset = new System.Drawing.Point(6, 0);
            this.GunaMyAccountbtn.Location = new System.Drawing.Point(24, 3);
            this.GunaMyAccountbtn.Name = "GunaMyAccountbtn";
            this.GunaMyAccountbtn.Size = new System.Drawing.Size(220, 44);
            this.GunaMyAccountbtn.TabIndex = 10;
            this.GunaMyAccountbtn.Text = "My Account";
            this.GunaMyAccountbtn.TextOffset = new System.Drawing.Point(3, 0);
            this.GunaMyAccountbtn.UseTransparentBackground = true;
            this.GunaMyAccountbtn.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // GunaSettingBtn
            // 
            this.GunaSettingBtn.BackColor = System.Drawing.Color.Transparent;
            this.GunaSettingBtn.BorderRadius = 22;
            this.GunaSettingBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.GunaSettingBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.GunaSettingBtn.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.GunaSettingBtn.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.GunaSettingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GunaSettingBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GunaSettingBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GunaSettingBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GunaSettingBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GunaSettingBtn.FillColor = System.Drawing.Color.White;
            this.GunaSettingBtn.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.GunaSettingBtn.ForeColor = System.Drawing.Color.Black;
            this.GunaSettingBtn.Image = ((System.Drawing.Image)(resources.GetObject("GunaSettingBtn.Image")));
            this.GunaSettingBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GunaSettingBtn.ImageOffset = new System.Drawing.Point(6, 0);
            this.GunaSettingBtn.Location = new System.Drawing.Point(54, 97);
            this.GunaSettingBtn.Name = "GunaSettingBtn";
            this.GunaSettingBtn.Size = new System.Drawing.Size(175, 41);
            this.GunaSettingBtn.TabIndex = 11;
            this.GunaSettingBtn.Text = "Setting";
            this.GunaSettingBtn.TextOffset = new System.Drawing.Point(-9, 0);
            this.GunaSettingBtn.UseTransparentBackground = true;
            this.GunaSettingBtn.Click += new System.EventHandler(this.GunaSettingBtn_Click);
            // 
            // GunaMyProfileBtn
            // 
            this.GunaMyProfileBtn.BackColor = System.Drawing.Color.Transparent;
            this.GunaMyProfileBtn.BorderRadius = 22;
            this.GunaMyProfileBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.GunaMyProfileBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.GunaMyProfileBtn.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.GunaMyProfileBtn.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.GunaMyProfileBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GunaMyProfileBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GunaMyProfileBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GunaMyProfileBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GunaMyProfileBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GunaMyProfileBtn.FillColor = System.Drawing.Color.White;
            this.GunaMyProfileBtn.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.GunaMyProfileBtn.ForeColor = System.Drawing.Color.Black;
            this.GunaMyProfileBtn.Image = ((System.Drawing.Image)(resources.GetObject("GunaMyProfileBtn.Image")));
            this.GunaMyProfileBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GunaMyProfileBtn.ImageOffset = new System.Drawing.Point(6, 0);
            this.GunaMyProfileBtn.IndicateFocus = true;
            this.GunaMyProfileBtn.Location = new System.Drawing.Point(54, 50);
            this.GunaMyProfileBtn.Name = "GunaMyProfileBtn";
            this.GunaMyProfileBtn.Size = new System.Drawing.Size(175, 41);
            this.GunaMyProfileBtn.TabIndex = 9;
            this.GunaMyProfileBtn.Text = "My profile";
            this.GunaMyProfileBtn.TextOffset = new System.Drawing.Point(3, 0);
            this.GunaMyProfileBtn.UseTransparentBackground = true;
            this.GunaMyProfileBtn.Click += new System.EventHandler(this.GunaMyProfileBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GunaLogOutBtn);
            this.panel1.Location = new System.Drawing.Point(3, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 51);
            this.panel1.TabIndex = 10;
            // 
            // GunaLogOutBtn
            // 
            this.GunaLogOutBtn.BackColor = System.Drawing.Color.Transparent;
            this.GunaLogOutBtn.BorderRadius = 22;
            this.GunaLogOutBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.GunaLogOutBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.GunaLogOutBtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GunaLogOutBtn.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.GunaLogOutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GunaLogOutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GunaLogOutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GunaLogOutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GunaLogOutBtn.FillColor = System.Drawing.Color.White;
            this.GunaLogOutBtn.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.GunaLogOutBtn.ForeColor = System.Drawing.Color.Red;
            this.GunaLogOutBtn.Image = ((System.Drawing.Image)(resources.GetObject("GunaLogOutBtn.Image")));
            this.GunaLogOutBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GunaLogOutBtn.ImageOffset = new System.Drawing.Point(6, 0);
            this.GunaLogOutBtn.Location = new System.Drawing.Point(27, 7);
            this.GunaLogOutBtn.Name = "GunaLogOutBtn";
            this.GunaLogOutBtn.Size = new System.Drawing.Size(220, 41);
            this.GunaLogOutBtn.TabIndex = 8;
            this.GunaLogOutBtn.Text = "Log out";
            this.GunaLogOutBtn.TextOffset = new System.Drawing.Point(-21, 0);
            this.GunaLogOutBtn.UseTransparentBackground = true;
            this.GunaLogOutBtn.CheckedChanged += new System.EventHandler(this.DashboardBtn_CheckedChanged);
            this.GunaLogOutBtn.Click += new System.EventHandler(this.GunaLogOutBtn_Click);
            // 
            // LblAName
            // 
            this.LblAName.AutoSize = true;
            this.LblAName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LblAName.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Bold);
            this.LblAName.ForeColor = System.Drawing.Color.White;
            this.LblAName.Location = new System.Drawing.Point(103, 25);
            this.LblAName.Name = "LblAName";
            this.LblAName.Size = new System.Drawing.Size(135, 17);
            this.LblAName.TabIndex = 2;
            this.LblAName.Text = "Tonmoy sutradhar";
            // 
            // GunaPicBox
            // 
            this.GunaPicBox.BackColor = System.Drawing.Color.Transparent;
            this.GunaPicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GunaPicBox.Image = ((System.Drawing.Image)(resources.GetObject("GunaPicBox.Image")));
            this.GunaPicBox.ImageRotate = 0F;
            this.GunaPicBox.Location = new System.Drawing.Point(3, 22);
            this.GunaPicBox.Name = "GunaPicBox";
            this.GunaPicBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.GunaPicBox.Size = new System.Drawing.Size(112, 108);
            this.GunaPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GunaPicBox.TabIndex = 0;
            this.GunaPicBox.TabStop = false;
            this.GunaPicBox.UseTransparentBackground = true;
            // 
            // GunaEmployeeBtn
            // 
            this.GunaEmployeeBtn.BackColor = System.Drawing.Color.Transparent;
            this.GunaEmployeeBtn.BorderRadius = 22;
            this.GunaEmployeeBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.GunaEmployeeBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.GunaEmployeeBtn.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.GunaEmployeeBtn.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.GunaEmployeeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GunaEmployeeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GunaEmployeeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GunaEmployeeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GunaEmployeeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GunaEmployeeBtn.FillColor = System.Drawing.Color.White;
            this.GunaEmployeeBtn.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.GunaEmployeeBtn.ForeColor = System.Drawing.Color.Black;
            this.GunaEmployeeBtn.Image = ((System.Drawing.Image)(resources.GetObject("GunaEmployeeBtn.Image")));
            this.GunaEmployeeBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GunaEmployeeBtn.ImageOffset = new System.Drawing.Point(6, 0);
            this.GunaEmployeeBtn.Location = new System.Drawing.Point(28, 364);
            this.GunaEmployeeBtn.Name = "GunaEmployeeBtn";
            this.GunaEmployeeBtn.Size = new System.Drawing.Size(220, 41);
            this.GunaEmployeeBtn.TabIndex = 5;
            this.GunaEmployeeBtn.Text = "Employee";
            this.GunaEmployeeBtn.TextOffset = new System.Drawing.Point(-9, 0);
            this.GunaEmployeeBtn.UseTransparentBackground = true;
            this.GunaEmployeeBtn.CheckedChanged += new System.EventHandler(this.DashboardBtn_CheckedChanged);
            this.GunaEmployeeBtn.Click += new System.EventHandler(this.GunaEmployeeBtn_Click);
            // 
            // GunaBloodRequestBtn
            // 
            this.GunaBloodRequestBtn.BackColor = System.Drawing.Color.Transparent;
            this.GunaBloodRequestBtn.BorderRadius = 22;
            this.GunaBloodRequestBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.GunaBloodRequestBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.GunaBloodRequestBtn.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.GunaBloodRequestBtn.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.GunaBloodRequestBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GunaBloodRequestBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GunaBloodRequestBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GunaBloodRequestBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GunaBloodRequestBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GunaBloodRequestBtn.FillColor = System.Drawing.Color.White;
            this.GunaBloodRequestBtn.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.GunaBloodRequestBtn.ForeColor = System.Drawing.Color.Black;
            this.GunaBloodRequestBtn.Image = ((System.Drawing.Image)(resources.GetObject("GunaBloodRequestBtn.Image")));
            this.GunaBloodRequestBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GunaBloodRequestBtn.ImageOffset = new System.Drawing.Point(5, 0);
            this.GunaBloodRequestBtn.Location = new System.Drawing.Point(28, 304);
            this.GunaBloodRequestBtn.Name = "GunaBloodRequestBtn";
            this.GunaBloodRequestBtn.Size = new System.Drawing.Size(220, 41);
            this.GunaBloodRequestBtn.TabIndex = 4;
            this.GunaBloodRequestBtn.Text = "Blood Request";
            this.GunaBloodRequestBtn.TextOffset = new System.Drawing.Point(15, 0);
            this.GunaBloodRequestBtn.UseTransparentBackground = true;
            this.GunaBloodRequestBtn.CheckedChanged += new System.EventHandler(this.DashboardBtn_CheckedChanged);
            this.GunaBloodRequestBtn.Click += new System.EventHandler(this.GunaBloodRequestBtn_Click);
            // 
            // GunaDonorListBtn
            // 
            this.GunaDonorListBtn.BackColor = System.Drawing.Color.Transparent;
            this.GunaDonorListBtn.BorderRadius = 22;
            this.GunaDonorListBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.GunaDonorListBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.GunaDonorListBtn.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.GunaDonorListBtn.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image6")));
            this.GunaDonorListBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GunaDonorListBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GunaDonorListBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GunaDonorListBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GunaDonorListBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GunaDonorListBtn.FillColor = System.Drawing.Color.White;
            this.GunaDonorListBtn.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.GunaDonorListBtn.ForeColor = System.Drawing.Color.Black;
            this.GunaDonorListBtn.Image = ((System.Drawing.Image)(resources.GetObject("GunaDonorListBtn.Image")));
            this.GunaDonorListBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GunaDonorListBtn.ImageOffset = new System.Drawing.Point(6, 0);
            this.GunaDonorListBtn.Location = new System.Drawing.Point(28, 247);
            this.GunaDonorListBtn.Name = "GunaDonorListBtn";
            this.GunaDonorListBtn.Size = new System.Drawing.Size(220, 41);
            this.GunaDonorListBtn.TabIndex = 3;
            this.GunaDonorListBtn.Text = "Donor info";
            this.GunaDonorListBtn.TextOffset = new System.Drawing.Point(-9, 0);
            this.GunaDonorListBtn.UseTransparentBackground = true;
            this.GunaDonorListBtn.CheckedChanged += new System.EventHandler(this.DashboardBtn_CheckedChanged);
            this.GunaDonorListBtn.Click += new System.EventHandler(this.GunaDonorListBtn_Click);
            // 
            // GunaDashboardBtn
            // 
            this.GunaDashboardBtn.BackColor = System.Drawing.Color.Transparent;
            this.GunaDashboardBtn.BorderRadius = 22;
            this.GunaDashboardBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.GunaDashboardBtn.Checked = true;
            this.GunaDashboardBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.GunaDashboardBtn.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.GunaDashboardBtn.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image7")));
            this.GunaDashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GunaDashboardBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GunaDashboardBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GunaDashboardBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GunaDashboardBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GunaDashboardBtn.FillColor = System.Drawing.Color.White;
            this.GunaDashboardBtn.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.GunaDashboardBtn.ForeColor = System.Drawing.Color.Black;
            this.GunaDashboardBtn.Image = ((System.Drawing.Image)(resources.GetObject("GunaDashboardBtn.Image")));
            this.GunaDashboardBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GunaDashboardBtn.ImageOffset = new System.Drawing.Point(10, 0);
            this.GunaDashboardBtn.Location = new System.Drawing.Point(28, 178);
            this.GunaDashboardBtn.Name = "GunaDashboardBtn";
            this.GunaDashboardBtn.Size = new System.Drawing.Size(220, 41);
            this.GunaDashboardBtn.TabIndex = 1;
            this.GunaDashboardBtn.Text = "Dashboard";
            this.GunaDashboardBtn.UseTransparentBackground = true;
            this.GunaDashboardBtn.CheckedChanged += new System.EventHandler(this.DashboardBtn_CheckedChanged);
            this.GunaDashboardBtn.Click += new System.EventHandler(this.GunaDashboardBtn_Click);
            // 
            // LblTypeName
            // 
            this.LblTypeName.AutoSize = true;
            this.LblTypeName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LblTypeName.Font = new System.Drawing.Font("Inter", 8F, System.Drawing.FontStyle.Bold);
            this.LblTypeName.ForeColor = System.Drawing.Color.Aqua;
            this.LblTypeName.Location = new System.Drawing.Point(157, 53);
            this.LblTypeName.Name = "LblTypeName";
            this.LblTypeName.Size = new System.Drawing.Size(42, 14);
            this.LblTypeName.TabIndex = 2;
            this.LblTypeName.Text = "Admin";
            // 
            // SubTransition
            // 
            this.SubTransition.Interval = 10;
            this.SubTransition.Tick += new System.EventHandler(this.SubTransition_Tick);
            // 
            // MotherPanel
            // 
            this.MotherPanel.BackColor = System.Drawing.Color.White;
            this.MotherPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MotherPanel.Location = new System.Drawing.Point(277, 0);
            this.MotherPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MotherPanel.Name = "MotherPanel";
            this.MotherPanel.Size = new System.Drawing.Size(1005, 673);
            this.MotherPanel.TabIndex = 1;
            // 
            // AdminPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1282, 673);
            this.Controls.Add(this.MotherPanel);
            this.Controls.Add(this.SidePanel);
            this.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Void Blood Bank";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GeneralUser_FormClosing);
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.SidePanel.ResumeLayout(false);
            this.SidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgSlide)).EndInit();
            this.F_PanelMyAccount.ResumeLayout(false);
            this.panelT.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GunaPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Label LblTypeName;
        private Guna.UI2.WinForms.Guna2Button GunaDashboardBtn;
        private Guna.UI2.WinForms.Guna2Button GunaLogOutBtn;
        private Guna.UI2.WinForms.Guna2Button GunaEmployeeBtn;
        private Guna.UI2.WinForms.Guna2Button GunaBloodRequestBtn;
        private Guna.UI2.WinForms.Guna2Button GunaDonorListBtn;
        private Guna.UI2.WinForms.Guna2CirclePictureBox GunaPicBox;
        private System.Windows.Forms.Label LblAName;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.FlowLayoutPanel F_PanelMyAccount;
        private Guna.UI2.WinForms.Guna2Button GunaMyProfileBtn;
        private Guna.UI2.WinForms.Guna2Button GunaMyAccountbtn;
        private Guna.UI2.WinForms.Guna2Button GunaSettingBtn;
        private System.Windows.Forms.Timer SubTransition;
        private System.Windows.Forms.Panel panelT;
        private System.Windows.Forms.Panel MotherPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ImgSlide;
    }
}