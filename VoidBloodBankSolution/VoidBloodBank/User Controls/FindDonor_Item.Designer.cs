
namespace VoidBloodBank.User_Controls
{
    partial class FindDonor_Item
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindDonor_Item));
            this.Gcpicture_DonorImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Label_DonorName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Label_DonorBlood = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label_DonorAddress = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Gbtn_ContactDonor = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Label_DonorID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Label_DonorGender = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Gcpicture_DonorImage)).BeginInit();
            this.SuspendLayout();
            // 
            // Gcpicture_DonorImage
            // 
            this.Gcpicture_DonorImage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Gcpicture_DonorImage.Image = ((System.Drawing.Image)(resources.GetObject("Gcpicture_DonorImage.Image")));
            this.Gcpicture_DonorImage.ImageRotate = 0F;
            this.Gcpicture_DonorImage.Location = new System.Drawing.Point(12, 9);
            this.Gcpicture_DonorImage.Name = "Gcpicture_DonorImage";
            this.Gcpicture_DonorImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Gcpicture_DonorImage.Size = new System.Drawing.Size(100, 93);
            this.Gcpicture_DonorImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Gcpicture_DonorImage.TabIndex = 32;
            this.Gcpicture_DonorImage.TabStop = false;
            // 
            // Label_DonorName
            // 
            this.Label_DonorName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label_DonorName.BackColor = System.Drawing.Color.Transparent;
            this.Label_DonorName.Font = new System.Drawing.Font("Inter", 16F, System.Drawing.FontStyle.Bold);
            this.Label_DonorName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Label_DonorName.Location = new System.Drawing.Point(146, 9);
            this.Label_DonorName.Name = "Label_DonorName";
            this.Label_DonorName.Size = new System.Drawing.Size(204, 35);
            this.Label_DonorName.TabIndex = 31;
            this.Label_DonorName.Text = "Ekramul Haque";
            // 
            // Label_DonorBlood
            // 
            this.Label_DonorBlood.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label_DonorBlood.BackColor = System.Drawing.Color.Transparent;
            this.Label_DonorBlood.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.Label_DonorBlood.ForeColor = System.Drawing.Color.Red;
            this.Label_DonorBlood.Location = new System.Drawing.Point(146, 50);
            this.Label_DonorBlood.Name = "Label_DonorBlood";
            this.Label_DonorBlood.Size = new System.Drawing.Size(125, 26);
            this.Label_DonorBlood.TabIndex = 33;
            this.Label_DonorBlood.Text = "AB Negative";
            // 
            // label_DonorAddress
            // 
            this.label_DonorAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_DonorAddress.AutoSize = false;
            this.label_DonorAddress.BackColor = System.Drawing.Color.Transparent;
            this.label_DonorAddress.Font = new System.Drawing.Font("Inter", 10F);
            this.label_DonorAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_DonorAddress.Location = new System.Drawing.Point(650, 23);
            this.label_DonorAddress.Name = "label_DonorAddress";
            this.label_DonorAddress.Size = new System.Drawing.Size(391, 21);
            this.label_DonorAddress.TabIndex = 35;
            this.label_DonorAddress.Text = "Biswash Betka, Tangail, Bangladesh";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(482, 23);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(138, 21);
            this.guna2HtmlLabel3.TabIndex = 34;
            this.guna2HtmlLabel3.Text = "Donor Address :";
            // 
            // Gbtn_ContactDonor
            // 
            this.Gbtn_ContactDonor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Gbtn_ContactDonor.AutoRoundedCorners = true;
            this.Gbtn_ContactDonor.BorderRadius = 21;
            this.Gbtn_ContactDonor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gbtn_ContactDonor.DisabledState.BorderColor = System.Drawing.Color.Gray;
            this.Gbtn_ContactDonor.DisabledState.CustomBorderColor = System.Drawing.Color.Gray;
            this.Gbtn_ContactDonor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Gbtn_ContactDonor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Gbtn_ContactDonor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.Gbtn_ContactDonor.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Bold);
            this.Gbtn_ContactDonor.ForeColor = System.Drawing.Color.White;
            this.Gbtn_ContactDonor.Location = new System.Drawing.Point(1047, 37);
            this.Gbtn_ContactDonor.Name = "Gbtn_ContactDonor";
            this.Gbtn_ContactDonor.Size = new System.Drawing.Size(180, 45);
            this.Gbtn_ContactDonor.TabIndex = 38;
            this.Gbtn_ContactDonor.Text = "Contact Donor";
            this.Gbtn_ContactDonor.Click += new System.EventHandler(this.Gbtn_ContactDonor_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(146, 83);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(29, 22);
            this.guna2HtmlLabel1.TabIndex = 40;
            this.guna2HtmlLabel1.Text = "ID :";
            // 
            // Label_DonorID
            // 
            this.Label_DonorID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label_DonorID.AutoSize = false;
            this.Label_DonorID.BackColor = System.Drawing.Color.Transparent;
            this.Label_DonorID.Font = new System.Drawing.Font("Inter", 10F);
            this.Label_DonorID.Location = new System.Drawing.Point(181, 83);
            this.Label_DonorID.Name = "Label_DonorID";
            this.Label_DonorID.Size = new System.Drawing.Size(156, 22);
            this.Label_DonorID.TabIndex = 39;
            this.Label_DonorID.Text = "3131004";
            // 
            // Label_DonorGender
            // 
            this.Label_DonorGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_DonorGender.AutoSize = false;
            this.Label_DonorGender.BackColor = System.Drawing.Color.Transparent;
            this.Label_DonorGender.Font = new System.Drawing.Font("Inter", 10F);
            this.Label_DonorGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label_DonorGender.Location = new System.Drawing.Point(650, 55);
            this.Label_DonorGender.Name = "Label_DonorGender";
            this.Label_DonorGender.Size = new System.Drawing.Size(154, 21);
            this.Label_DonorGender.TabIndex = 42;
            this.Label_DonorGender.Text = "Female";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel5.AutoSize = false;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(546, 55);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(74, 21);
            this.guna2HtmlLabel5.TabIndex = 41;
            this.guna2HtmlLabel5.Text = "Gender :";
            // 
            // FindDonor_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.Label_DonorGender);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.Label_DonorID);
            this.Controls.Add(this.Gbtn_ContactDonor);
            this.Controls.Add(this.label_DonorAddress);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.Label_DonorBlood);
            this.Controls.Add(this.Gcpicture_DonorImage);
            this.Controls.Add(this.Label_DonorName);
            this.Name = "FindDonor_Item";
            this.Size = new System.Drawing.Size(1281, 126);
            ((System.ComponentModel.ISupportInitialize)(this.Gcpicture_DonorImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox Gcpicture_DonorImage;
        private Guna.UI2.WinForms.Guna2HtmlLabel Label_DonorName;
        private Guna.UI2.WinForms.Guna2HtmlLabel Label_DonorBlood;
        private Guna.UI2.WinForms.Guna2HtmlLabel label_DonorAddress;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2Button Gbtn_ContactDonor;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel Label_DonorID;
        private Guna.UI2.WinForms.Guna2HtmlLabel Label_DonorGender;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
    }
}
