
namespace VoidBloodBank
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.Panel_MoveForm = new System.Windows.Forms.Panel();
            this.Gbtn_FormClose = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Gtxt_Username = new Guna.UI2.WinForms.Guna2TextBox();
            this.FLP_OtpPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Panel_Username = new System.Windows.Forms.Panel();
            this.Gtxt_OTP = new Guna.UI2.WinForms.Guna2TextBox();
            this.Panel_OtpButtons = new System.Windows.Forms.Panel();
            this.Gbtn_Cancel = new Guna.UI2.WinForms.Guna2Button();
            this.Gbtn_GetOtp = new Guna.UI2.WinForms.Guna2Button();
            this.Panel_OtpSentMessage = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel_NewPass = new System.Windows.Forms.Panel();
            this.Lbl_Matching = new System.Windows.Forms.Label();
            this.Cb_ShowPass = new System.Windows.Forms.CheckBox();
            this.Gbtn_ChangePass = new Guna.UI2.WinForms.Guna2Button();
            this.Gtxt_ConfirmPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.Gtxt_NewPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.Timer_OtpPanel = new System.Windows.Forms.Timer(this.components);
            this.Timer_NewPass = new System.Windows.Forms.Timer(this.components);
            this.Panel_MoveForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.FLP_OtpPanel.SuspendLayout();
            this.Panel_Username.SuspendLayout();
            this.Panel_OtpButtons.SuspendLayout();
            this.Panel_OtpSentMessage.SuspendLayout();
            this.Panel_NewPass.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_MoveForm
            // 
            this.Panel_MoveForm.BackColor = System.Drawing.Color.Transparent;
            this.Panel_MoveForm.Controls.Add(this.Gbtn_FormClose);
            this.Panel_MoveForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_MoveForm.ForeColor = System.Drawing.Color.Transparent;
            this.Panel_MoveForm.Location = new System.Drawing.Point(0, 0);
            this.Panel_MoveForm.Name = "Panel_MoveForm";
            this.Panel_MoveForm.Size = new System.Drawing.Size(616, 45);
            this.Panel_MoveForm.TabIndex = 21;
            this.Panel_MoveForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MoveForm_MouseDown);
            this.Panel_MoveForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MoveForm_MouseMove);
            this.Panel_MoveForm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_MoveForm_MouseUp);
            // 
            // Gbtn_FormClose
            // 
            this.Gbtn_FormClose.BackColor = System.Drawing.Color.White;
            this.Gbtn_FormClose.BorderColor = System.Drawing.Color.Transparent;
            this.Gbtn_FormClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gbtn_FormClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gbtn_FormClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gbtn_FormClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gbtn_FormClose.FillColor = System.Drawing.Color.White;
            this.Gbtn_FormClose.Font = new System.Drawing.Font("Roboto", 15F);
            this.Gbtn_FormClose.ForeColor = System.Drawing.Color.Black;
            this.Gbtn_FormClose.Location = new System.Drawing.Point(560, 0);
            this.Gbtn_FormClose.Name = "Gbtn_FormClose";
            this.Gbtn_FormClose.Size = new System.Drawing.Size(56, 39);
            this.Gbtn_FormClose.TabIndex = 22;
            this.Gbtn_FormClose.Text = "×";
            this.Gbtn_FormClose.Click += new System.EventHandler(this.Gbtn_FormClose_Click);
            this.Gbtn_FormClose.MouseLeave += new System.EventHandler(this.Gbtn_FormClose_MouseLeave);
            this.Gbtn_FormClose.MouseHover += new System.EventHandler(this.Gbtn_FormClose_MouseHover);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(42, 51);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(537, 356);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 22;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // Gtxt_Username
            // 
            this.Gtxt_Username.Animated = true;
            this.Gtxt_Username.AutoRoundedCorners = true;
            this.Gtxt_Username.BackColor = System.Drawing.Color.Transparent;
            this.Gtxt_Username.BorderColor = System.Drawing.Color.DarkGray;
            this.Gtxt_Username.BorderRadius = 22;
            this.Gtxt_Username.BorderThickness = 2;
            this.Gtxt_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Gtxt_Username.DefaultText = "";
            this.Gtxt_Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Gtxt_Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Gtxt_Username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Gtxt_Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Gtxt_Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Gtxt_Username.Font = new System.Drawing.Font("Roboto", 10F);
            this.Gtxt_Username.ForeColor = System.Drawing.Color.Black;
            this.Gtxt_Username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Gtxt_Username.IconLeft = ((System.Drawing.Image)(resources.GetObject("Gtxt_Username.IconLeft")));
            this.Gtxt_Username.IconLeftSize = new System.Drawing.Size(22, 22);
            this.Gtxt_Username.Location = new System.Drawing.Point(111, 5);
            this.Gtxt_Username.Margin = new System.Windows.Forms.Padding(5);
            this.Gtxt_Username.Name = "Gtxt_Username";
            this.Gtxt_Username.PasswordChar = '\0';
            this.Gtxt_Username.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.Gtxt_Username.PlaceholderText = "Enter Username";
            this.Gtxt_Username.SelectedText = "";
            this.Gtxt_Username.Size = new System.Drawing.Size(399, 46);
            this.Gtxt_Username.TabIndex = 0;
            this.Gtxt_Username.TextChanged += new System.EventHandler(this.OtpButtons_TextChanges);
            this.Gtxt_Username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OtpButtons_KeyDown);
            // 
            // FLP_OtpPanel
            // 
            this.FLP_OtpPanel.Controls.Add(this.Panel_Username);
            this.FLP_OtpPanel.Controls.Add(this.Panel_OtpButtons);
            this.FLP_OtpPanel.Controls.Add(this.Panel_OtpSentMessage);
            this.FLP_OtpPanel.Location = new System.Drawing.Point(12, 413);
            this.FLP_OtpPanel.Name = "FLP_OtpPanel";
            this.FLP_OtpPanel.Size = new System.Drawing.Size(592, 252);
            this.FLP_OtpPanel.TabIndex = 1;
            // 
            // Panel_Username
            // 
            this.Panel_Username.Controls.Add(this.Gtxt_Username);
            this.Panel_Username.Controls.Add(this.Gtxt_OTP);
            this.Panel_Username.Location = new System.Drawing.Point(3, 3);
            this.Panel_Username.MaximumSize = new System.Drawing.Size(589, 122);
            this.Panel_Username.MinimumSize = new System.Drawing.Size(589, 58);
            this.Panel_Username.Name = "Panel_Username";
            this.Panel_Username.Size = new System.Drawing.Size(589, 58);
            this.Panel_Username.TabIndex = 0;
            // 
            // Gtxt_OTP
            // 
            this.Gtxt_OTP.Animated = true;
            this.Gtxt_OTP.AutoRoundedCorners = true;
            this.Gtxt_OTP.BackColor = System.Drawing.Color.Transparent;
            this.Gtxt_OTP.BorderColor = System.Drawing.Color.DarkGray;
            this.Gtxt_OTP.BorderRadius = 22;
            this.Gtxt_OTP.BorderThickness = 2;
            this.Gtxt_OTP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Gtxt_OTP.DefaultText = "";
            this.Gtxt_OTP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Gtxt_OTP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Gtxt_OTP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Gtxt_OTP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Gtxt_OTP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Gtxt_OTP.Font = new System.Drawing.Font("Roboto", 10F);
            this.Gtxt_OTP.ForeColor = System.Drawing.Color.Black;
            this.Gtxt_OTP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Gtxt_OTP.IconLeft = ((System.Drawing.Image)(resources.GetObject("Gtxt_OTP.IconLeft")));
            this.Gtxt_OTP.IconLeftSize = new System.Drawing.Size(22, 22);
            this.Gtxt_OTP.Location = new System.Drawing.Point(111, 67);
            this.Gtxt_OTP.Margin = new System.Windows.Forms.Padding(5);
            this.Gtxt_OTP.Name = "Gtxt_OTP";
            this.Gtxt_OTP.PasswordChar = '\0';
            this.Gtxt_OTP.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.Gtxt_OTP.PlaceholderText = "Enter 6-Digit Verification Code";
            this.Gtxt_OTP.SelectedText = "";
            this.Gtxt_OTP.Size = new System.Drawing.Size(399, 46);
            this.Gtxt_OTP.TabIndex = 1;
            this.Gtxt_OTP.TextChanged += new System.EventHandler(this.OtpButtons_TextChanges);
            this.Gtxt_OTP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OtpButtons_KeyDown);
            // 
            // Panel_OtpButtons
            // 
            this.Panel_OtpButtons.Controls.Add(this.Gbtn_Cancel);
            this.Panel_OtpButtons.Controls.Add(this.Gbtn_GetOtp);
            this.Panel_OtpButtons.Location = new System.Drawing.Point(3, 67);
            this.Panel_OtpButtons.Name = "Panel_OtpButtons";
            this.Panel_OtpButtons.Size = new System.Drawing.Size(589, 64);
            this.Panel_OtpButtons.TabIndex = 2;
            // 
            // Gbtn_Cancel
            // 
            this.Gbtn_Cancel.Animated = true;
            this.Gbtn_Cancel.AutoRoundedCorners = true;
            this.Gbtn_Cancel.BackColor = System.Drawing.Color.Transparent;
            this.Gbtn_Cancel.BorderRadius = 21;
            this.Gbtn_Cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gbtn_Cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gbtn_Cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gbtn_Cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gbtn_Cancel.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.Gbtn_Cancel.ForeColor = System.Drawing.Color.White;
            this.Gbtn_Cancel.IndicateFocus = true;
            this.Gbtn_Cancel.Location = new System.Drawing.Point(313, 8);
            this.Gbtn_Cancel.Name = "Gbtn_Cancel";
            this.Gbtn_Cancel.Size = new System.Drawing.Size(197, 45);
            this.Gbtn_Cancel.TabIndex = 3;
            this.Gbtn_Cancel.Text = "Cancel";
            this.Gbtn_Cancel.Click += new System.EventHandler(this.Gbtn_Cancel_Click);
            // 
            // Gbtn_GetOtp
            // 
            this.Gbtn_GetOtp.Animated = true;
            this.Gbtn_GetOtp.AutoRoundedCorners = true;
            this.Gbtn_GetOtp.BackColor = System.Drawing.Color.Transparent;
            this.Gbtn_GetOtp.BorderRadius = 21;
            this.Gbtn_GetOtp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gbtn_GetOtp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gbtn_GetOtp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gbtn_GetOtp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gbtn_GetOtp.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.Gbtn_GetOtp.ForeColor = System.Drawing.Color.White;
            this.Gbtn_GetOtp.IndicateFocus = true;
            this.Gbtn_GetOtp.Location = new System.Drawing.Point(111, 8);
            this.Gbtn_GetOtp.Name = "Gbtn_GetOtp";
            this.Gbtn_GetOtp.Size = new System.Drawing.Size(197, 45);
            this.Gbtn_GetOtp.TabIndex = 2;
            this.Gbtn_GetOtp.Text = "Get OTP";
            this.Gbtn_GetOtp.Click += new System.EventHandler(this.Gbtn_GetOtp_Click);
            // 
            // Panel_OtpSentMessage
            // 
            this.Panel_OtpSentMessage.Controls.Add(this.label1);
            this.Panel_OtpSentMessage.Location = new System.Drawing.Point(3, 137);
            this.Panel_OtpSentMessage.Name = "Panel_OtpSentMessage";
            this.Panel_OtpSentMessage.Size = new System.Drawing.Size(589, 36);
            this.Panel_OtpSentMessage.TabIndex = 23;
            this.Panel_OtpSentMessage.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(181, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "An OTP has been sent to you Email";
            // 
            // Panel_NewPass
            // 
            this.Panel_NewPass.Controls.Add(this.Lbl_Matching);
            this.Panel_NewPass.Controls.Add(this.Cb_ShowPass);
            this.Panel_NewPass.Controls.Add(this.Gbtn_ChangePass);
            this.Panel_NewPass.Controls.Add(this.Gtxt_ConfirmPass);
            this.Panel_NewPass.Controls.Add(this.Gtxt_NewPass);
            this.Panel_NewPass.Location = new System.Drawing.Point(12, 403);
            this.Panel_NewPass.MaximumSize = new System.Drawing.Size(592, 259);
            this.Panel_NewPass.MinimumSize = new System.Drawing.Size(592, 10);
            this.Panel_NewPass.Name = "Panel_NewPass";
            this.Panel_NewPass.Size = new System.Drawing.Size(592, 10);
            this.Panel_NewPass.TabIndex = 4;
            this.Panel_NewPass.TabStop = true;
            this.Panel_NewPass.Visible = false;
            // 
            // Lbl_Matching
            // 
            this.Lbl_Matching.AutoSize = true;
            this.Lbl_Matching.Font = new System.Drawing.Font("Inter", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Matching.ForeColor = System.Drawing.Color.Red;
            this.Lbl_Matching.Location = new System.Drawing.Point(479, 100);
            this.Lbl_Matching.Name = "Lbl_Matching";
            this.Lbl_Matching.Size = new System.Drawing.Size(95, 17);
            this.Lbl_Matching.TabIndex = 50;
            this.Lbl_Matching.Text = "Not Matched";
            this.Lbl_Matching.Visible = false;
            // 
            // Cb_ShowPass
            // 
            this.Cb_ShowPass.AutoSize = true;
            this.Cb_ShowPass.Location = new System.Drawing.Point(146, 140);
            this.Cb_ShowPass.Name = "Cb_ShowPass";
            this.Cb_ShowPass.Size = new System.Drawing.Size(129, 21);
            this.Cb_ShowPass.TabIndex = 6;
            this.Cb_ShowPass.TabStop = false;
            this.Cb_ShowPass.Text = "Show Password";
            this.Cb_ShowPass.UseVisualStyleBackColor = true;
            this.Cb_ShowPass.Click += new System.EventHandler(this.Cb_ShowPass_Click);
            // 
            // Gbtn_ChangePass
            // 
            this.Gbtn_ChangePass.Animated = true;
            this.Gbtn_ChangePass.AutoRoundedCorners = true;
            this.Gbtn_ChangePass.BackColor = System.Drawing.Color.Transparent;
            this.Gbtn_ChangePass.BorderRadius = 21;
            this.Gbtn_ChangePass.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gbtn_ChangePass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gbtn_ChangePass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gbtn_ChangePass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gbtn_ChangePass.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.Gbtn_ChangePass.ForeColor = System.Drawing.Color.White;
            this.Gbtn_ChangePass.IndicateFocus = true;
            this.Gbtn_ChangePass.Location = new System.Drawing.Point(127, 175);
            this.Gbtn_ChangePass.Name = "Gbtn_ChangePass";
            this.Gbtn_ChangePass.Size = new System.Drawing.Size(344, 45);
            this.Gbtn_ChangePass.TabIndex = 7;
            this.Gbtn_ChangePass.TabStop = false;
            this.Gbtn_ChangePass.Text = "Change Password";
            this.Gbtn_ChangePass.Click += new System.EventHandler(this.Gbtn_ChangePass_Click);
            // 
            // Gtxt_ConfirmPass
            // 
            this.Gtxt_ConfirmPass.Animated = true;
            this.Gtxt_ConfirmPass.AutoRoundedCorners = true;
            this.Gtxt_ConfirmPass.BackColor = System.Drawing.Color.Transparent;
            this.Gtxt_ConfirmPass.BorderColor = System.Drawing.Color.DarkGray;
            this.Gtxt_ConfirmPass.BorderRadius = 21;
            this.Gtxt_ConfirmPass.BorderThickness = 2;
            this.Gtxt_ConfirmPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Gtxt_ConfirmPass.DefaultText = "";
            this.Gtxt_ConfirmPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Gtxt_ConfirmPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Gtxt_ConfirmPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Gtxt_ConfirmPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Gtxt_ConfirmPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Gtxt_ConfirmPass.Font = new System.Drawing.Font("Roboto", 10F);
            this.Gtxt_ConfirmPass.ForeColor = System.Drawing.Color.Black;
            this.Gtxt_ConfirmPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Gtxt_ConfirmPass.IconLeft = ((System.Drawing.Image)(resources.GetObject("Gtxt_ConfirmPass.IconLeft")));
            this.Gtxt_ConfirmPass.IconLeftSize = new System.Drawing.Size(23, 23);
            this.Gtxt_ConfirmPass.IconRight = ((System.Drawing.Image)(resources.GetObject("Gtxt_ConfirmPass.IconRight")));
            this.Gtxt_ConfirmPass.IconRightOffset = new System.Drawing.Point(5, 0);
            this.Gtxt_ConfirmPass.IconRightSize = new System.Drawing.Size(23, 23);
            this.Gtxt_ConfirmPass.Location = new System.Drawing.Point(127, 86);
            this.Gtxt_ConfirmPass.Margin = new System.Windows.Forms.Padding(5);
            this.Gtxt_ConfirmPass.Name = "Gtxt_ConfirmPass";
            this.Gtxt_ConfirmPass.PasswordChar = '●';
            this.Gtxt_ConfirmPass.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.Gtxt_ConfirmPass.PlaceholderText = "Confirm Password";
            this.Gtxt_ConfirmPass.SelectedText = "";
            this.Gtxt_ConfirmPass.Size = new System.Drawing.Size(344, 45);
            this.Gtxt_ConfirmPass.TabIndex = 5;
            this.Gtxt_ConfirmPass.UseSystemPasswordChar = true;
            this.Gtxt_ConfirmPass.TextChanged += new System.EventHandler(this.Gtxt_ConfirmPass_TextChanged);
            this.Gtxt_ConfirmPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Gtxt_ConfirmPass_KeyDown);
            // 
            // Gtxt_NewPass
            // 
            this.Gtxt_NewPass.Animated = true;
            this.Gtxt_NewPass.AutoRoundedCorners = true;
            this.Gtxt_NewPass.BackColor = System.Drawing.Color.Transparent;
            this.Gtxt_NewPass.BorderColor = System.Drawing.Color.DarkGray;
            this.Gtxt_NewPass.BorderRadius = 21;
            this.Gtxt_NewPass.BorderThickness = 2;
            this.Gtxt_NewPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Gtxt_NewPass.DefaultText = "";
            this.Gtxt_NewPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Gtxt_NewPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Gtxt_NewPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Gtxt_NewPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Gtxt_NewPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Gtxt_NewPass.Font = new System.Drawing.Font("Roboto", 10F);
            this.Gtxt_NewPass.ForeColor = System.Drawing.Color.Black;
            this.Gtxt_NewPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Gtxt_NewPass.IconLeft = ((System.Drawing.Image)(resources.GetObject("Gtxt_NewPass.IconLeft")));
            this.Gtxt_NewPass.IconLeftSize = new System.Drawing.Size(23, 23);
            this.Gtxt_NewPass.IconRight = ((System.Drawing.Image)(resources.GetObject("Gtxt_NewPass.IconRight")));
            this.Gtxt_NewPass.IconRightOffset = new System.Drawing.Point(5, 0);
            this.Gtxt_NewPass.IconRightSize = new System.Drawing.Size(23, 23);
            this.Gtxt_NewPass.Location = new System.Drawing.Point(127, 20);
            this.Gtxt_NewPass.Margin = new System.Windows.Forms.Padding(5);
            this.Gtxt_NewPass.Name = "Gtxt_NewPass";
            this.Gtxt_NewPass.PasswordChar = '●';
            this.Gtxt_NewPass.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.Gtxt_NewPass.PlaceholderText = "New Password";
            this.Gtxt_NewPass.SelectedText = "";
            this.Gtxt_NewPass.Size = new System.Drawing.Size(344, 45);
            this.Gtxt_NewPass.TabIndex = 4;
            this.Gtxt_NewPass.UseSystemPasswordChar = true;
            this.Gtxt_NewPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Gtxt_ConfirmPass_KeyDown);
            // 
            // Timer_OtpPanel
            // 
            this.Timer_OtpPanel.Interval = 15;
            this.Timer_OtpPanel.Tick += new System.EventHandler(this.Timer_OtpPanel_Tick);
            // 
            // Timer_NewPass
            // 
            this.Timer_NewPass.Interval = 15;
            this.Timer_NewPass.Tick += new System.EventHandler(this.Timer_NewPass_Tick);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(616, 704);
            this.Controls.Add(this.Panel_NewPass);
            this.Controls.Add(this.FLP_OtpPanel);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.Panel_MoveForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPassword";
            this.Panel_MoveForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.FLP_OtpPanel.ResumeLayout(false);
            this.Panel_Username.ResumeLayout(false);
            this.Panel_OtpButtons.ResumeLayout(false);
            this.Panel_OtpSentMessage.ResumeLayout(false);
            this.Panel_OtpSentMessage.PerformLayout();
            this.Panel_NewPass.ResumeLayout(false);
            this.Panel_NewPass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_MoveForm;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox Gtxt_Username;
        private System.Windows.Forms.FlowLayoutPanel FLP_OtpPanel;
        private System.Windows.Forms.Panel Panel_Username;
        private Guna.UI2.WinForms.Guna2TextBox Gtxt_OTP;
        private System.Windows.Forms.Panel Panel_OtpButtons;
        private Guna.UI2.WinForms.Guna2Button Gbtn_Cancel;
        private Guna.UI2.WinForms.Guna2Button Gbtn_GetOtp;
        private System.Windows.Forms.Panel Panel_NewPass;
        private Guna.UI2.WinForms.Guna2TextBox Gtxt_ConfirmPass;
        private Guna.UI2.WinForms.Guna2TextBox Gtxt_NewPass;
        private Guna.UI2.WinForms.Guna2Button Gbtn_ChangePass;
        private System.Windows.Forms.Timer Timer_OtpPanel;
        private System.Windows.Forms.Timer Timer_NewPass;
        private System.Windows.Forms.CheckBox Cb_ShowPass;
        private System.Windows.Forms.Panel Panel_OtpSentMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Matching;
        private Guna.UI2.WinForms.Guna2Button Gbtn_FormClose;
    }
}