
namespace VoidBloodBank.ZahidUserControl
{
    partial class Uc_Settings
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
        [System.Obsolete]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uc_Settings));
            this.ChangeNameTimer = new System.Windows.Forms.Timer(this.components);
            this.ChangePassTimer = new System.Windows.Forms.Timer(this.components);
            this.ChangeEmailTimer = new System.Windows.Forms.Timer(this.components);
            this.ChangeNumberTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GBtn_SettingsSaveImage = new Guna.UI2.WinForms.Guna2Button();
            this.FlowPanel_Settings2 = new System.Windows.Forms.FlowLayoutPanel();
            this.ChangeNumberPanel = new System.Windows.Forms.Panel();
            this.GBtn_NewNumber = new Guna.UI2.WinForms.Guna2Button();
            this.TxtBox_PhoneNumber = new MetroFramework.Controls.MetroTextBox();
            this.TxtBox_NewNumber = new MetroFramework.Controls.MetroTextBox();
            this.GBtn_SaveNumber = new Guna.UI2.WinForms.Guna2Button();
            this.Panel_ChangeEmail = new System.Windows.Forms.Panel();
            this.GBtn_ChangeEmail = new Guna.UI2.WinForms.Guna2Button();
            this.TxtBox_Email = new MetroFramework.Controls.MetroTextBox();
            this.GBtn_SaveEmail = new Guna.UI2.WinForms.Guna2Button();
            this.TxtBox_NewEmail = new MetroFramework.Controls.MetroTextBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.GBtn_ChangePic = new Guna.UI2.WinForms.Guna2CircleButton();
            this.PictureBox_Settings = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.FlowPanel_Settings1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ChangeNamePanel = new System.Windows.Forms.Panel();
            this.GBtn_ChangeName = new Guna.UI2.WinForms.Guna2Button();
            this.TxtBox_FullName = new MetroFramework.Controls.MetroTextBox();
            this.GBtn_SaveName = new Guna.UI2.WinForms.Guna2Button();
            this.TxtBox_LastName = new MetroFramework.Controls.MetroTextBox();
            this.TxtBox_FirstName = new MetroFramework.Controls.MetroTextBox();
            this.ChangePassPanel = new System.Windows.Forms.Panel();
            this.GBtn_ChangePass = new Guna.UI2.WinForms.Guna2Button();
            this.TxtBox_CurrentPass = new MetroFramework.Controls.MetroTextBox();
            this.GBtn_SavePass = new Guna.UI2.WinForms.Guna2Button();
            this.TxtBox_NewPassword = new MetroFramework.Controls.MetroTextBox();
            this.TxtBox_ConfirmPassword = new MetroFramework.Controls.MetroTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.FlowPanel_Settings2.SuspendLayout();
            this.ChangeNumberPanel.SuspendLayout();
            this.Panel_ChangeEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Settings)).BeginInit();
            this.FlowPanel_Settings1.SuspendLayout();
            this.ChangeNamePanel.SuspendLayout();
            this.ChangePassPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChangeNameTimer
            // 
            this.ChangeNameTimer.Interval = 5;
            this.ChangeNameTimer.Tick += new System.EventHandler(this.ChangeNameTimer_Tick);
            // 
            // ChangePassTimer
            // 
            this.ChangePassTimer.Interval = 5;
            this.ChangePassTimer.Tick += new System.EventHandler(this.ChangePassTimer_Tick);
            // 
            // ChangeEmailTimer
            // 
            this.ChangeEmailTimer.Interval = 5;
            this.ChangeEmailTimer.Tick += new System.EventHandler(this.ChangeEmailTimer_Tick);
            // 
            // ChangeNumberTimer
            // 
            this.ChangeNumberTimer.Interval = 5;
            this.ChangeNumberTimer.Tick += new System.EventHandler(this.ChangeNumberTimer_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(454, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Settings";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 98);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.GBtn_SettingsSaveImage);
            this.panel2.Controls.Add(this.FlowPanel_Settings2);
            this.panel2.Controls.Add(this.guna2PictureBox2);
            this.panel2.Controls.Add(this.GBtn_ChangePic);
            this.panel2.Controls.Add(this.PictureBox_Settings);
            this.panel2.Controls.Add(this.FlowPanel_Settings1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1038, 575);
            this.panel2.TabIndex = 17;
            // 
            // GBtn_SettingsSaveImage
            // 
            this.GBtn_SettingsSaveImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GBtn_SettingsSaveImage.AutoRoundedCorners = true;
            this.GBtn_SettingsSaveImage.BackColor = System.Drawing.Color.Transparent;
            this.GBtn_SettingsSaveImage.BorderColor = System.Drawing.Color.Lime;
            this.GBtn_SettingsSaveImage.BorderRadius = 15;
            this.GBtn_SettingsSaveImage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GBtn_SettingsSaveImage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GBtn_SettingsSaveImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GBtn_SettingsSaveImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GBtn_SettingsSaveImage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.GBtn_SettingsSaveImage.Font = new System.Drawing.Font("Inter", 10.2F);
            this.GBtn_SettingsSaveImage.ForeColor = System.Drawing.Color.White;
            this.GBtn_SettingsSaveImage.Location = new System.Drawing.Point(35, 201);
            this.GBtn_SettingsSaveImage.Name = "GBtn_SettingsSaveImage";
            this.GBtn_SettingsSaveImage.Size = new System.Drawing.Size(127, 33);
            this.GBtn_SettingsSaveImage.TabIndex = 41;
            this.GBtn_SettingsSaveImage.Text = "Save Image";
            this.GBtn_SettingsSaveImage.Click += new System.EventHandler(this.GBtn_SettingsSaveImage_Click);
            // 
            // FlowPanel_Settings2
            // 
            this.FlowPanel_Settings2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FlowPanel_Settings2.Controls.Add(this.ChangeNumberPanel);
            this.FlowPanel_Settings2.Controls.Add(this.Panel_ChangeEmail);
            this.FlowPanel_Settings2.Location = new System.Drawing.Point(617, 4);
            this.FlowPanel_Settings2.Name = "FlowPanel_Settings2";
            this.FlowPanel_Settings2.Size = new System.Drawing.Size(417, 402);
            this.FlowPanel_Settings2.TabIndex = 40;
            // 
            // ChangeNumberPanel
            // 
            this.ChangeNumberPanel.Controls.Add(this.GBtn_NewNumber);
            this.ChangeNumberPanel.Controls.Add(this.TxtBox_PhoneNumber);
            this.ChangeNumberPanel.Controls.Add(this.TxtBox_NewNumber);
            this.ChangeNumberPanel.Controls.Add(this.GBtn_SaveNumber);
            this.ChangeNumberPanel.Location = new System.Drawing.Point(3, 3);
            this.ChangeNumberPanel.MaximumSize = new System.Drawing.Size(417, 142);
            this.ChangeNumberPanel.MinimumSize = new System.Drawing.Size(417, 57);
            this.ChangeNumberPanel.Name = "ChangeNumberPanel";
            this.ChangeNumberPanel.Size = new System.Drawing.Size(417, 57);
            this.ChangeNumberPanel.TabIndex = 16;
            // 
            // GBtn_NewNumber
            // 
            this.GBtn_NewNumber.BackColor = System.Drawing.Color.Transparent;
            this.GBtn_NewNumber.BorderRadius = 22;
            this.GBtn_NewNumber.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GBtn_NewNumber.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GBtn_NewNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GBtn_NewNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GBtn_NewNumber.FillColor = System.Drawing.Color.White;
            this.GBtn_NewNumber.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.GBtn_NewNumber.ForeColor = System.Drawing.Color.Black;
            this.GBtn_NewNumber.Image = ((System.Drawing.Image)(resources.GetObject("GBtn_NewNumber.Image")));
            this.GBtn_NewNumber.Location = new System.Drawing.Point(362, 8);
            this.GBtn_NewNumber.Name = "GBtn_NewNumber";
            this.GBtn_NewNumber.Size = new System.Drawing.Size(49, 45);
            this.GBtn_NewNumber.TabIndex = 21;
            this.GBtn_NewNumber.UseTransparentBackground = true;
            this.GBtn_NewNumber.Click += new System.EventHandler(this.GBtn_ChangeNumber_Click);
            // 
            // TxtBox_PhoneNumber
            // 
            // 
            // 
            // 
            this.TxtBox_PhoneNumber.CustomButton.Image = null;
            this.TxtBox_PhoneNumber.CustomButton.Location = new System.Drawing.Point(363, 2);
            this.TxtBox_PhoneNumber.CustomButton.Name = "";
            this.TxtBox_PhoneNumber.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.TxtBox_PhoneNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBox_PhoneNumber.CustomButton.TabIndex = 1;
            this.TxtBox_PhoneNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBox_PhoneNumber.CustomButton.UseSelectable = true;
            this.TxtBox_PhoneNumber.CustomButton.Visible = false;
            this.TxtBox_PhoneNumber.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtBox_PhoneNumber.Lines = new string[0];
            this.TxtBox_PhoneNumber.Location = new System.Drawing.Point(3, 4);
            this.TxtBox_PhoneNumber.MaxLength = 32767;
            this.TxtBox_PhoneNumber.Name = "TxtBox_PhoneNumber";
            this.TxtBox_PhoneNumber.PasswordChar = '\0';
            this.TxtBox_PhoneNumber.ReadOnly = true;
            this.TxtBox_PhoneNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBox_PhoneNumber.SelectedText = "";
            this.TxtBox_PhoneNumber.SelectionLength = 0;
            this.TxtBox_PhoneNumber.SelectionStart = 0;
            this.TxtBox_PhoneNumber.ShortcutsEnabled = true;
            this.TxtBox_PhoneNumber.Size = new System.Drawing.Size(411, 50);
            this.TxtBox_PhoneNumber.TabIndex = 20;
            this.TxtBox_PhoneNumber.UseSelectable = true;
            this.TxtBox_PhoneNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBox_PhoneNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // TxtBox_NewNumber
            // 
            // 
            // 
            // 
            this.TxtBox_NewNumber.CustomButton.Image = null;
            this.TxtBox_NewNumber.CustomButton.Location = new System.Drawing.Point(363, 2);
            this.TxtBox_NewNumber.CustomButton.Name = "";
            this.TxtBox_NewNumber.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.TxtBox_NewNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBox_NewNumber.CustomButton.TabIndex = 1;
            this.TxtBox_NewNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBox_NewNumber.CustomButton.UseSelectable = true;
            this.TxtBox_NewNumber.CustomButton.Visible = false;
            this.TxtBox_NewNumber.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtBox_NewNumber.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.TxtBox_NewNumber.Lines = new string[0];
            this.TxtBox_NewNumber.Location = new System.Drawing.Point(3, 60);
            this.TxtBox_NewNumber.MaxLength = 32767;
            this.TxtBox_NewNumber.Name = "TxtBox_NewNumber";
            this.TxtBox_NewNumber.PasswordChar = '\0';
            this.TxtBox_NewNumber.PromptText = "New Number";
            this.TxtBox_NewNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBox_NewNumber.SelectedText = "";
            this.TxtBox_NewNumber.SelectionLength = 0;
            this.TxtBox_NewNumber.SelectionStart = 0;
            this.TxtBox_NewNumber.ShortcutsEnabled = true;
            this.TxtBox_NewNumber.Size = new System.Drawing.Size(411, 50);
            this.TxtBox_NewNumber.TabIndex = 20;
            this.TxtBox_NewNumber.UseSelectable = true;
            this.TxtBox_NewNumber.WaterMark = "New Number";
            this.TxtBox_NewNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBox_NewNumber.WaterMarkFont = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // GBtn_SaveNumber
            // 
            this.GBtn_SaveNumber.BackColor = System.Drawing.Color.Transparent;
            this.GBtn_SaveNumber.BorderRadius = 10;
            this.GBtn_SaveNumber.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GBtn_SaveNumber.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GBtn_SaveNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GBtn_SaveNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GBtn_SaveNumber.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.GBtn_SaveNumber.Font = new System.Drawing.Font("Inter", 10.2F);
            this.GBtn_SaveNumber.ForeColor = System.Drawing.Color.White;
            this.GBtn_SaveNumber.Location = new System.Drawing.Point(340, 115);
            this.GBtn_SaveNumber.Name = "GBtn_SaveNumber";
            this.GBtn_SaveNumber.Size = new System.Drawing.Size(71, 23);
            this.GBtn_SaveNumber.TabIndex = 16;
            this.GBtn_SaveNumber.Text = "Save";
            this.GBtn_SaveNumber.UseTransparentBackground = true;
            this.GBtn_SaveNumber.Click += new System.EventHandler(this.GBtn_SaveNumber_Click);
            // 
            // Panel_ChangeEmail
            // 
            this.Panel_ChangeEmail.Controls.Add(this.GBtn_ChangeEmail);
            this.Panel_ChangeEmail.Controls.Add(this.TxtBox_Email);
            this.Panel_ChangeEmail.Controls.Add(this.GBtn_SaveEmail);
            this.Panel_ChangeEmail.Controls.Add(this.TxtBox_NewEmail);
            this.Panel_ChangeEmail.Location = new System.Drawing.Point(3, 66);
            this.Panel_ChangeEmail.MaximumSize = new System.Drawing.Size(417, 140);
            this.Panel_ChangeEmail.MinimumSize = new System.Drawing.Size(417, 57);
            this.Panel_ChangeEmail.Name = "Panel_ChangeEmail";
            this.Panel_ChangeEmail.Size = new System.Drawing.Size(417, 57);
            this.Panel_ChangeEmail.TabIndex = 10;
            // 
            // GBtn_ChangeEmail
            // 
            this.GBtn_ChangeEmail.BackColor = System.Drawing.Color.Transparent;
            this.GBtn_ChangeEmail.BorderRadius = 22;
            this.GBtn_ChangeEmail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GBtn_ChangeEmail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GBtn_ChangeEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GBtn_ChangeEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GBtn_ChangeEmail.FillColor = System.Drawing.Color.White;
            this.GBtn_ChangeEmail.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.GBtn_ChangeEmail.ForeColor = System.Drawing.Color.Black;
            this.GBtn_ChangeEmail.Image = ((System.Drawing.Image)(resources.GetObject("GBtn_ChangeEmail.Image")));
            this.GBtn_ChangeEmail.Location = new System.Drawing.Point(361, 4);
            this.GBtn_ChangeEmail.Name = "GBtn_ChangeEmail";
            this.GBtn_ChangeEmail.Size = new System.Drawing.Size(49, 45);
            this.GBtn_ChangeEmail.TabIndex = 19;
            this.GBtn_ChangeEmail.UseTransparentBackground = true;
            this.GBtn_ChangeEmail.Click += new System.EventHandler(this.GBtn_ChangeEmail_Click);
            // 
            // TxtBox_Email
            // 
            // 
            // 
            // 
            this.TxtBox_Email.CustomButton.Image = null;
            this.TxtBox_Email.CustomButton.Location = new System.Drawing.Point(363, 2);
            this.TxtBox_Email.CustomButton.Name = "";
            this.TxtBox_Email.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.TxtBox_Email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBox_Email.CustomButton.TabIndex = 1;
            this.TxtBox_Email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBox_Email.CustomButton.UseSelectable = true;
            this.TxtBox_Email.CustomButton.Visible = false;
            this.TxtBox_Email.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtBox_Email.Lines = new string[0];
            this.TxtBox_Email.Location = new System.Drawing.Point(1, 3);
            this.TxtBox_Email.MaxLength = 32767;
            this.TxtBox_Email.Name = "TxtBox_Email";
            this.TxtBox_Email.PasswordChar = '\0';
            this.TxtBox_Email.ReadOnly = true;
            this.TxtBox_Email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBox_Email.SelectedText = "";
            this.TxtBox_Email.SelectionLength = 0;
            this.TxtBox_Email.SelectionStart = 0;
            this.TxtBox_Email.ShortcutsEnabled = true;
            this.TxtBox_Email.Size = new System.Drawing.Size(411, 50);
            this.TxtBox_Email.TabIndex = 18;
            this.TxtBox_Email.UseSelectable = true;
            this.TxtBox_Email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBox_Email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // GBtn_SaveEmail
            // 
            this.GBtn_SaveEmail.BackColor = System.Drawing.Color.Transparent;
            this.GBtn_SaveEmail.BorderRadius = 10;
            this.GBtn_SaveEmail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GBtn_SaveEmail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GBtn_SaveEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GBtn_SaveEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GBtn_SaveEmail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.GBtn_SaveEmail.Font = new System.Drawing.Font("Inter", 10.2F);
            this.GBtn_SaveEmail.ForeColor = System.Drawing.Color.White;
            this.GBtn_SaveEmail.Location = new System.Drawing.Point(340, 112);
            this.GBtn_SaveEmail.Name = "GBtn_SaveEmail";
            this.GBtn_SaveEmail.Size = new System.Drawing.Size(71, 23);
            this.GBtn_SaveEmail.TabIndex = 17;
            this.GBtn_SaveEmail.Text = "Save";
            this.GBtn_SaveEmail.UseTransparentBackground = true;
            this.GBtn_SaveEmail.Click += new System.EventHandler(this.GBtn_SaveEmail_Click);
            // 
            // TxtBox_NewEmail
            // 
            // 
            // 
            // 
            this.TxtBox_NewEmail.CustomButton.Image = null;
            this.TxtBox_NewEmail.CustomButton.Location = new System.Drawing.Point(363, 2);
            this.TxtBox_NewEmail.CustomButton.Name = "";
            this.TxtBox_NewEmail.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.TxtBox_NewEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBox_NewEmail.CustomButton.TabIndex = 1;
            this.TxtBox_NewEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBox_NewEmail.CustomButton.UseSelectable = true;
            this.TxtBox_NewEmail.CustomButton.Visible = false;
            this.TxtBox_NewEmail.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtBox_NewEmail.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.TxtBox_NewEmail.Lines = new string[0];
            this.TxtBox_NewEmail.Location = new System.Drawing.Point(2, 56);
            this.TxtBox_NewEmail.MaxLength = 32767;
            this.TxtBox_NewEmail.Name = "TxtBox_NewEmail";
            this.TxtBox_NewEmail.PasswordChar = '\0';
            this.TxtBox_NewEmail.PromptText = "New Email";
            this.TxtBox_NewEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBox_NewEmail.SelectedText = "";
            this.TxtBox_NewEmail.SelectionLength = 0;
            this.TxtBox_NewEmail.SelectionStart = 0;
            this.TxtBox_NewEmail.ShortcutsEnabled = true;
            this.TxtBox_NewEmail.Size = new System.Drawing.Size(411, 50);
            this.TxtBox_NewEmail.TabIndex = 20;
            this.TxtBox_NewEmail.UseSelectable = true;
            this.TxtBox_NewEmail.WaterMark = "New Email";
            this.TxtBox_NewEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBox_NewEmail.WaterMarkFont = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(789, 445);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(248, 125);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 39;
            this.guna2PictureBox2.TabStop = false;
            // 
            // GBtn_ChangePic
            // 
            this.GBtn_ChangePic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GBtn_ChangePic.BackColor = System.Drawing.Color.Transparent;
            this.GBtn_ChangePic.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GBtn_ChangePic.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GBtn_ChangePic.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GBtn_ChangePic.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GBtn_ChangePic.FillColor = System.Drawing.Color.White;
            this.GBtn_ChangePic.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GBtn_ChangePic.ForeColor = System.Drawing.Color.White;
            this.GBtn_ChangePic.Image = ((System.Drawing.Image)(resources.GetObject("GBtn_ChangePic.Image")));
            this.GBtn_ChangePic.IndicateFocus = true;
            this.GBtn_ChangePic.Location = new System.Drawing.Point(145, 147);
            this.GBtn_ChangePic.Name = "GBtn_ChangePic";
            this.GBtn_ChangePic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.GBtn_ChangePic.Size = new System.Drawing.Size(36, 37);
            this.GBtn_ChangePic.TabIndex = 38;
            this.GBtn_ChangePic.UseTransparentBackground = true;
            this.GBtn_ChangePic.Click += new System.EventHandler(this.GBtn_ChangePic_Click);
            // 
            // PictureBox_Settings
            // 
            this.PictureBox_Settings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureBox_Settings.ImageRotate = 0F;
            this.PictureBox_Settings.Location = new System.Drawing.Point(2, 6);
            this.PictureBox_Settings.Name = "PictureBox_Settings";
            this.PictureBox_Settings.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PictureBox_Settings.Size = new System.Drawing.Size(190, 189);
            this.PictureBox_Settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_Settings.TabIndex = 37;
            this.PictureBox_Settings.TabStop = false;
            // 
            // FlowPanel_Settings1
            // 
            this.FlowPanel_Settings1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FlowPanel_Settings1.Controls.Add(this.ChangeNamePanel);
            this.FlowPanel_Settings1.Controls.Add(this.ChangePassPanel);
            this.FlowPanel_Settings1.Location = new System.Drawing.Point(198, 5);
            this.FlowPanel_Settings1.Name = "FlowPanel_Settings1";
            this.FlowPanel_Settings1.Size = new System.Drawing.Size(417, 401);
            this.FlowPanel_Settings1.TabIndex = 36;
            // 
            // ChangeNamePanel
            // 
            this.ChangeNamePanel.Controls.Add(this.GBtn_ChangeName);
            this.ChangeNamePanel.Controls.Add(this.TxtBox_FullName);
            this.ChangeNamePanel.Controls.Add(this.GBtn_SaveName);
            this.ChangeNamePanel.Controls.Add(this.TxtBox_LastName);
            this.ChangeNamePanel.Controls.Add(this.TxtBox_FirstName);
            this.ChangeNamePanel.Location = new System.Drawing.Point(3, 3);
            this.ChangeNamePanel.MaximumSize = new System.Drawing.Size(417, 196);
            this.ChangeNamePanel.MinimumSize = new System.Drawing.Size(417, 57);
            this.ChangeNamePanel.Name = "ChangeNamePanel";
            this.ChangeNamePanel.Size = new System.Drawing.Size(417, 57);
            this.ChangeNamePanel.TabIndex = 0;
            // 
            // GBtn_ChangeName
            // 
            this.GBtn_ChangeName.BackColor = System.Drawing.Color.Transparent;
            this.GBtn_ChangeName.BorderRadius = 22;
            this.GBtn_ChangeName.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GBtn_ChangeName.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GBtn_ChangeName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GBtn_ChangeName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GBtn_ChangeName.FillColor = System.Drawing.Color.White;
            this.GBtn_ChangeName.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.GBtn_ChangeName.ForeColor = System.Drawing.Color.Black;
            this.GBtn_ChangeName.Image = ((System.Drawing.Image)(resources.GetObject("GBtn_ChangeName.Image")));
            this.GBtn_ChangeName.Location = new System.Drawing.Point(373, 5);
            this.GBtn_ChangeName.Name = "GBtn_ChangeName";
            this.GBtn_ChangeName.Size = new System.Drawing.Size(39, 45);
            this.GBtn_ChangeName.TabIndex = 34;
            this.GBtn_ChangeName.UseTransparentBackground = true;
            this.GBtn_ChangeName.Click += new System.EventHandler(this.GBtn_ChangeName_Click);
            // 
            // TxtBox_FullName
            // 
            // 
            // 
            // 
            this.TxtBox_FullName.CustomButton.Image = null;
            this.TxtBox_FullName.CustomButton.Location = new System.Drawing.Point(363, 2);
            this.TxtBox_FullName.CustomButton.Name = "";
            this.TxtBox_FullName.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.TxtBox_FullName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBox_FullName.CustomButton.TabIndex = 1;
            this.TxtBox_FullName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBox_FullName.CustomButton.UseSelectable = true;
            this.TxtBox_FullName.CustomButton.Visible = false;
            this.TxtBox_FullName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtBox_FullName.Lines = new string[0];
            this.TxtBox_FullName.Location = new System.Drawing.Point(3, 3);
            this.TxtBox_FullName.MaxLength = 32767;
            this.TxtBox_FullName.Name = "TxtBox_FullName";
            this.TxtBox_FullName.PasswordChar = '\0';
            this.TxtBox_FullName.ReadOnly = true;
            this.TxtBox_FullName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBox_FullName.SelectedText = "";
            this.TxtBox_FullName.SelectionLength = 0;
            this.TxtBox_FullName.SelectionStart = 0;
            this.TxtBox_FullName.ShortcutsEnabled = true;
            this.TxtBox_FullName.Size = new System.Drawing.Size(411, 50);
            this.TxtBox_FullName.TabIndex = 18;
            this.TxtBox_FullName.UseSelectable = true;
            this.TxtBox_FullName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBox_FullName.WaterMarkFont = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // GBtn_SaveName
            // 
            this.GBtn_SaveName.BackColor = System.Drawing.Color.Transparent;
            this.GBtn_SaveName.BorderRadius = 10;
            this.GBtn_SaveName.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GBtn_SaveName.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GBtn_SaveName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GBtn_SaveName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GBtn_SaveName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.GBtn_SaveName.Font = new System.Drawing.Font("Inter", 10.2F);
            this.GBtn_SaveName.ForeColor = System.Drawing.Color.White;
            this.GBtn_SaveName.Location = new System.Drawing.Point(340, 168);
            this.GBtn_SaveName.Name = "GBtn_SaveName";
            this.GBtn_SaveName.Size = new System.Drawing.Size(71, 23);
            this.GBtn_SaveName.TabIndex = 17;
            this.GBtn_SaveName.Text = "Save";
            this.GBtn_SaveName.UseTransparentBackground = true;
            this.GBtn_SaveName.Click += new System.EventHandler(this.GBtn_SaveName_Click);
            // 
            // TxtBox_LastName
            // 
            // 
            // 
            // 
            this.TxtBox_LastName.CustomButton.Image = null;
            this.TxtBox_LastName.CustomButton.Location = new System.Drawing.Point(363, 2);
            this.TxtBox_LastName.CustomButton.Name = "";
            this.TxtBox_LastName.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.TxtBox_LastName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBox_LastName.CustomButton.TabIndex = 1;
            this.TxtBox_LastName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBox_LastName.CustomButton.UseSelectable = true;
            this.TxtBox_LastName.CustomButton.Visible = false;
            this.TxtBox_LastName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtBox_LastName.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.TxtBox_LastName.Lines = new string[0];
            this.TxtBox_LastName.Location = new System.Drawing.Point(3, 114);
            this.TxtBox_LastName.MaxLength = 32767;
            this.TxtBox_LastName.Name = "TxtBox_LastName";
            this.TxtBox_LastName.PasswordChar = '\0';
            this.TxtBox_LastName.PromptText = "Last Name";
            this.TxtBox_LastName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBox_LastName.SelectedText = "";
            this.TxtBox_LastName.SelectionLength = 0;
            this.TxtBox_LastName.SelectionStart = 0;
            this.TxtBox_LastName.ShortcutsEnabled = true;
            this.TxtBox_LastName.Size = new System.Drawing.Size(411, 50);
            this.TxtBox_LastName.TabIndex = 2;
            this.TxtBox_LastName.UseSelectable = true;
            this.TxtBox_LastName.WaterMark = "Last Name";
            this.TxtBox_LastName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBox_LastName.WaterMarkFont = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // TxtBox_FirstName
            // 
            // 
            // 
            // 
            this.TxtBox_FirstName.CustomButton.Image = null;
            this.TxtBox_FirstName.CustomButton.Location = new System.Drawing.Point(363, 2);
            this.TxtBox_FirstName.CustomButton.Name = "";
            this.TxtBox_FirstName.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.TxtBox_FirstName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBox_FirstName.CustomButton.TabIndex = 1;
            this.TxtBox_FirstName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBox_FirstName.CustomButton.UseSelectable = true;
            this.TxtBox_FirstName.CustomButton.Visible = false;
            this.TxtBox_FirstName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtBox_FirstName.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.TxtBox_FirstName.Lines = new string[0];
            this.TxtBox_FirstName.Location = new System.Drawing.Point(3, 59);
            this.TxtBox_FirstName.MaxLength = 32767;
            this.TxtBox_FirstName.Name = "TxtBox_FirstName";
            this.TxtBox_FirstName.PasswordChar = '\0';
            this.TxtBox_FirstName.PromptText = "First Name";
            this.TxtBox_FirstName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBox_FirstName.SelectedText = "";
            this.TxtBox_FirstName.SelectionLength = 0;
            this.TxtBox_FirstName.SelectionStart = 0;
            this.TxtBox_FirstName.ShortcutsEnabled = true;
            this.TxtBox_FirstName.Size = new System.Drawing.Size(411, 50);
            this.TxtBox_FirstName.TabIndex = 1;
            this.TxtBox_FirstName.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBox_FirstName.UseSelectable = true;
            this.TxtBox_FirstName.WaterMark = "First Name";
            this.TxtBox_FirstName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBox_FirstName.WaterMarkFont = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // ChangePassPanel
            // 
            this.ChangePassPanel.Controls.Add(this.GBtn_ChangePass);
            this.ChangePassPanel.Controls.Add(this.TxtBox_CurrentPass);
            this.ChangePassPanel.Controls.Add(this.GBtn_SavePass);
            this.ChangePassPanel.Controls.Add(this.TxtBox_NewPassword);
            this.ChangePassPanel.Controls.Add(this.TxtBox_ConfirmPassword);
            this.ChangePassPanel.Location = new System.Drawing.Point(3, 66);
            this.ChangePassPanel.MaximumSize = new System.Drawing.Size(417, 196);
            this.ChangePassPanel.MinimumSize = new System.Drawing.Size(417, 57);
            this.ChangePassPanel.Name = "ChangePassPanel";
            this.ChangePassPanel.Size = new System.Drawing.Size(417, 57);
            this.ChangePassPanel.TabIndex = 6;
            // 
            // GBtn_ChangePass
            // 
            this.GBtn_ChangePass.BackColor = System.Drawing.Color.Transparent;
            this.GBtn_ChangePass.BorderRadius = 22;
            this.GBtn_ChangePass.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GBtn_ChangePass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GBtn_ChangePass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GBtn_ChangePass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GBtn_ChangePass.FillColor = System.Drawing.Color.White;
            this.GBtn_ChangePass.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.GBtn_ChangePass.ForeColor = System.Drawing.Color.Black;
            this.GBtn_ChangePass.Image = ((System.Drawing.Image)(resources.GetObject("GBtn_ChangePass.Image")));
            this.GBtn_ChangePass.Location = new System.Drawing.Point(373, 3);
            this.GBtn_ChangePass.Name = "GBtn_ChangePass";
            this.GBtn_ChangePass.Size = new System.Drawing.Size(38, 45);
            this.GBtn_ChangePass.TabIndex = 19;
            this.GBtn_ChangePass.UseTransparentBackground = true;
            this.GBtn_ChangePass.Click += new System.EventHandler(this.GBtn_ChangePass_Click);
            // 
            // TxtBox_CurrentPass
            // 
            // 
            // 
            // 
            this.TxtBox_CurrentPass.CustomButton.Image = null;
            this.TxtBox_CurrentPass.CustomButton.Location = new System.Drawing.Point(363, 2);
            this.TxtBox_CurrentPass.CustomButton.Name = "";
            this.TxtBox_CurrentPass.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.TxtBox_CurrentPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBox_CurrentPass.CustomButton.TabIndex = 1;
            this.TxtBox_CurrentPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBox_CurrentPass.CustomButton.UseSelectable = true;
            this.TxtBox_CurrentPass.CustomButton.Visible = false;
            this.TxtBox_CurrentPass.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtBox_CurrentPass.Lines = new string[0];
            this.TxtBox_CurrentPass.Location = new System.Drawing.Point(3, 0);
            this.TxtBox_CurrentPass.MaxLength = 32767;
            this.TxtBox_CurrentPass.Name = "TxtBox_CurrentPass";
            this.TxtBox_CurrentPass.PasswordChar = '\0';
            this.TxtBox_CurrentPass.PromptText = "Current Password";
            this.TxtBox_CurrentPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBox_CurrentPass.SelectedText = "";
            this.TxtBox_CurrentPass.SelectionLength = 0;
            this.TxtBox_CurrentPass.SelectionStart = 0;
            this.TxtBox_CurrentPass.ShortcutsEnabled = true;
            this.TxtBox_CurrentPass.Size = new System.Drawing.Size(411, 50);
            this.TxtBox_CurrentPass.TabIndex = 18;
            this.TxtBox_CurrentPass.UseSelectable = true;
            this.TxtBox_CurrentPass.WaterMark = "Current Password";
            this.TxtBox_CurrentPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBox_CurrentPass.WaterMarkFont = new System.Drawing.Font("Inter SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // GBtn_SavePass
            // 
            this.GBtn_SavePass.AutoRoundedCorners = true;
            this.GBtn_SavePass.BackColor = System.Drawing.Color.Transparent;
            this.GBtn_SavePass.BorderColor = System.Drawing.Color.Lime;
            this.GBtn_SavePass.BorderRadius = 10;
            this.GBtn_SavePass.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GBtn_SavePass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GBtn_SavePass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GBtn_SavePass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GBtn_SavePass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.GBtn_SavePass.Font = new System.Drawing.Font("Inter", 10.2F);
            this.GBtn_SavePass.ForeColor = System.Drawing.Color.White;
            this.GBtn_SavePass.Location = new System.Drawing.Point(340, 166);
            this.GBtn_SavePass.Name = "GBtn_SavePass";
            this.GBtn_SavePass.Size = new System.Drawing.Size(71, 23);
            this.GBtn_SavePass.TabIndex = 17;
            this.GBtn_SavePass.Text = "Save";
            this.GBtn_SavePass.Click += new System.EventHandler(this.GBtn_SavePass_Click);
            // 
            // TxtBox_NewPassword
            // 
            // 
            // 
            // 
            this.TxtBox_NewPassword.CustomButton.Image = null;
            this.TxtBox_NewPassword.CustomButton.Location = new System.Drawing.Point(363, 2);
            this.TxtBox_NewPassword.CustomButton.Name = "";
            this.TxtBox_NewPassword.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.TxtBox_NewPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBox_NewPassword.CustomButton.TabIndex = 1;
            this.TxtBox_NewPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBox_NewPassword.CustomButton.UseSelectable = true;
            this.TxtBox_NewPassword.CustomButton.Visible = false;
            this.TxtBox_NewPassword.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtBox_NewPassword.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.TxtBox_NewPassword.Lines = new string[0];
            this.TxtBox_NewPassword.Location = new System.Drawing.Point(3, 56);
            this.TxtBox_NewPassword.MaxLength = 32767;
            this.TxtBox_NewPassword.Name = "TxtBox_NewPassword";
            this.TxtBox_NewPassword.PasswordChar = '\0';
            this.TxtBox_NewPassword.PromptText = "New Password";
            this.TxtBox_NewPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBox_NewPassword.SelectedText = "";
            this.TxtBox_NewPassword.SelectionLength = 0;
            this.TxtBox_NewPassword.SelectionStart = 0;
            this.TxtBox_NewPassword.ShortcutsEnabled = true;
            this.TxtBox_NewPassword.Size = new System.Drawing.Size(411, 50);
            this.TxtBox_NewPassword.TabIndex = 1;
            this.TxtBox_NewPassword.UseSelectable = true;
            this.TxtBox_NewPassword.WaterMark = "New Password";
            this.TxtBox_NewPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBox_NewPassword.WaterMarkFont = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // TxtBox_ConfirmPassword
            // 
            // 
            // 
            // 
            this.TxtBox_ConfirmPassword.CustomButton.Image = null;
            this.TxtBox_ConfirmPassword.CustomButton.Location = new System.Drawing.Point(363, 2);
            this.TxtBox_ConfirmPassword.CustomButton.Name = "";
            this.TxtBox_ConfirmPassword.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.TxtBox_ConfirmPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBox_ConfirmPassword.CustomButton.TabIndex = 1;
            this.TxtBox_ConfirmPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBox_ConfirmPassword.CustomButton.UseSelectable = true;
            this.TxtBox_ConfirmPassword.CustomButton.Visible = false;
            this.TxtBox_ConfirmPassword.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtBox_ConfirmPassword.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.TxtBox_ConfirmPassword.Lines = new string[0];
            this.TxtBox_ConfirmPassword.Location = new System.Drawing.Point(3, 112);
            this.TxtBox_ConfirmPassword.MaxLength = 32767;
            this.TxtBox_ConfirmPassword.Name = "TxtBox_ConfirmPassword";
            this.TxtBox_ConfirmPassword.PasswordChar = '\0';
            this.TxtBox_ConfirmPassword.PromptText = "Confirm Password";
            this.TxtBox_ConfirmPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBox_ConfirmPassword.SelectedText = "";
            this.TxtBox_ConfirmPassword.SelectionLength = 0;
            this.TxtBox_ConfirmPassword.SelectionStart = 0;
            this.TxtBox_ConfirmPassword.ShortcutsEnabled = true;
            this.TxtBox_ConfirmPassword.Size = new System.Drawing.Size(411, 50);
            this.TxtBox_ConfirmPassword.TabIndex = 2;
            this.TxtBox_ConfirmPassword.UseSelectable = true;
            this.TxtBox_ConfirmPassword.WaterMark = "Confirm Password";
            this.TxtBox_ConfirmPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBox_ConfirmPassword.WaterMarkFont = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Uc_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(475, 185);
            this.Name = "Uc_Settings";
            this.Size = new System.Drawing.Size(1038, 673);
            this.Load += new System.EventHandler(this.Uc_Settings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.FlowPanel_Settings2.ResumeLayout(false);
            this.ChangeNumberPanel.ResumeLayout(false);
            this.Panel_ChangeEmail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Settings)).EndInit();
            this.FlowPanel_Settings1.ResumeLayout(false);
            this.ChangeNamePanel.ResumeLayout(false);
            this.ChangePassPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer ChangeNameTimer;
        private System.Windows.Forms.Timer ChangePassTimer;
        private System.Windows.Forms.Timer ChangeEmailTimer;
        private System.Windows.Forms.Timer ChangeNumberTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button GBtn_SettingsSaveImage;
        private System.Windows.Forms.FlowLayoutPanel FlowPanel_Settings2;
        private System.Windows.Forms.Panel ChangeNumberPanel;
        private Guna.UI2.WinForms.Guna2Button GBtn_NewNumber;
        private MetroFramework.Controls.MetroTextBox TxtBox_PhoneNumber;
        private MetroFramework.Controls.MetroTextBox TxtBox_NewNumber;
        private Guna.UI2.WinForms.Guna2Button GBtn_SaveNumber;
        private System.Windows.Forms.Panel Panel_ChangeEmail;
        private Guna.UI2.WinForms.Guna2Button GBtn_ChangeEmail;
        private MetroFramework.Controls.MetroTextBox TxtBox_Email;
        private Guna.UI2.WinForms.Guna2Button GBtn_SaveEmail;
        private MetroFramework.Controls.MetroTextBox TxtBox_NewEmail;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2CircleButton GBtn_ChangePic;
        private Guna.UI2.WinForms.Guna2CirclePictureBox PictureBox_Settings;
        private System.Windows.Forms.FlowLayoutPanel FlowPanel_Settings1;
        private System.Windows.Forms.Panel ChangeNamePanel;
        private Guna.UI2.WinForms.Guna2Button GBtn_ChangeName;
        private MetroFramework.Controls.MetroTextBox TxtBox_FullName;
        private Guna.UI2.WinForms.Guna2Button GBtn_SaveName;
        private MetroFramework.Controls.MetroTextBox TxtBox_LastName;
        private MetroFramework.Controls.MetroTextBox TxtBox_FirstName;
        private System.Windows.Forms.Panel ChangePassPanel;
        private Guna.UI2.WinForms.Guna2Button GBtn_ChangePass;
        private MetroFramework.Controls.MetroTextBox TxtBox_CurrentPass;
        private Guna.UI2.WinForms.Guna2Button GBtn_SavePass;
        private MetroFramework.Controls.MetroTextBox TxtBox_NewPassword;
        private MetroFramework.Controls.MetroTextBox TxtBox_ConfirmPassword;
    }
}
