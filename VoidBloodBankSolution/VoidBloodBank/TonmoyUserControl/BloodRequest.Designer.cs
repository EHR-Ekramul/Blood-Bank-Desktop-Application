
namespace VoidBloodBank.TonmoyUserControl
{
    partial class BloodRequest
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BloodReqPanel = new System.Windows.Forms.Panel();
            this.dgv_BloodReqShow = new Guna.UI2.WinForms.Guna2DataGridView();
            this.brReqID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brBloodType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brPatientIssue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brManageQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brRequestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brDonationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reqStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.G_CMBBloodStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.G_ClearBtnBr = new Guna.UI2.WinForms.Guna2Button();
            this.G_ApplybtnBr = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.BloodReqPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BloodReqShow)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BloodReqPanel
            // 
            this.BloodReqPanel.Controls.Add(this.dgv_BloodReqShow);
            this.BloodReqPanel.Controls.Add(this.panel2);
            this.BloodReqPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BloodReqPanel.Location = new System.Drawing.Point(0, 0);
            this.BloodReqPanel.Name = "BloodReqPanel";
            this.BloodReqPanel.Size = new System.Drawing.Size(1005, 673);
            this.BloodReqPanel.TabIndex = 0;
            // 
            // dgv_BloodReqShow
            // 
            this.dgv_BloodReqShow.AllowUserToAddRows = false;
            this.dgv_BloodReqShow.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgv_BloodReqShow.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_BloodReqShow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_BloodReqShow.ColumnHeadersHeight = 36;
            this.dgv_BloodReqShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_BloodReqShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brReqID,
            this.userFullName,
            this.brBloodType,
            this.brPatientIssue,
            this.brQuantity,
            this.brManageQuantity,
            this.brRequestDate,
            this.brDonationDate,
            this.userPhone,
            this.reqStatus});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_BloodReqShow.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_BloodReqShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_BloodReqShow.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_BloodReqShow.Location = new System.Drawing.Point(0, 78);
            this.dgv_BloodReqShow.Name = "dgv_BloodReqShow";
            this.dgv_BloodReqShow.ReadOnly = true;
            this.dgv_BloodReqShow.RowHeadersVisible = false;
            this.dgv_BloodReqShow.RowHeadersWidth = 51;
            this.dgv_BloodReqShow.RowTemplate.Height = 24;
            this.dgv_BloodReqShow.Size = new System.Drawing.Size(1005, 595);
            this.dgv_BloodReqShow.TabIndex = 1;
            this.dgv_BloodReqShow.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_BloodReqShow.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_BloodReqShow.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_BloodReqShow.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_BloodReqShow.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_BloodReqShow.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_BloodReqShow.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_BloodReqShow.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_BloodReqShow.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_BloodReqShow.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_BloodReqShow.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_BloodReqShow.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_BloodReqShow.ThemeStyle.HeaderStyle.Height = 36;
            this.dgv_BloodReqShow.ThemeStyle.ReadOnly = true;
            this.dgv_BloodReqShow.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_BloodReqShow.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_BloodReqShow.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_BloodReqShow.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_BloodReqShow.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_BloodReqShow.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_BloodReqShow.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // brReqID
            // 
            this.brReqID.DataPropertyName = "brReqID";
            this.brReqID.HeaderText = "ID";
            this.brReqID.MinimumWidth = 6;
            this.brReqID.Name = "brReqID";
            this.brReqID.ReadOnly = true;
            // 
            // userFullName
            // 
            this.userFullName.DataPropertyName = "userFullName";
            this.userFullName.HeaderText = "Name";
            this.userFullName.MinimumWidth = 6;
            this.userFullName.Name = "userFullName";
            this.userFullName.ReadOnly = true;
            // 
            // brBloodType
            // 
            this.brBloodType.DataPropertyName = "brBloodType";
            this.brBloodType.HeaderText = "Blood Type";
            this.brBloodType.MinimumWidth = 6;
            this.brBloodType.Name = "brBloodType";
            this.brBloodType.ReadOnly = true;
            // 
            // brPatientIssue
            // 
            this.brPatientIssue.DataPropertyName = "brPatientIssue";
            this.brPatientIssue.HeaderText = "Patient Issue";
            this.brPatientIssue.MinimumWidth = 6;
            this.brPatientIssue.Name = "brPatientIssue";
            this.brPatientIssue.ReadOnly = true;
            // 
            // brQuantity
            // 
            this.brQuantity.DataPropertyName = "brQuantity";
            this.brQuantity.HeaderText = "Quantity";
            this.brQuantity.MinimumWidth = 6;
            this.brQuantity.Name = "brQuantity";
            this.brQuantity.ReadOnly = true;
            // 
            // brManageQuantity
            // 
            this.brManageQuantity.DataPropertyName = "brManageQuantity";
            this.brManageQuantity.HeaderText = "Manage Blood";
            this.brManageQuantity.MinimumWidth = 6;
            this.brManageQuantity.Name = "brManageQuantity";
            this.brManageQuantity.ReadOnly = true;
            // 
            // brRequestDate
            // 
            this.brRequestDate.DataPropertyName = "brRequestDate";
            this.brRequestDate.HeaderText = "Request Date";
            this.brRequestDate.MinimumWidth = 6;
            this.brRequestDate.Name = "brRequestDate";
            this.brRequestDate.ReadOnly = true;
            // 
            // brDonationDate
            // 
            this.brDonationDate.DataPropertyName = "brDonationDate";
            this.brDonationDate.HeaderText = "Donation Date";
            this.brDonationDate.MinimumWidth = 6;
            this.brDonationDate.Name = "brDonationDate";
            this.brDonationDate.ReadOnly = true;
            // 
            // userPhone
            // 
            this.userPhone.DataPropertyName = "userPhone";
            this.userPhone.HeaderText = "Phone";
            this.userPhone.MinimumWidth = 6;
            this.userPhone.Name = "userPhone";
            this.userPhone.ReadOnly = true;
            // 
            // reqStatus
            // 
            this.reqStatus.DataPropertyName = "reqStatus";
            this.reqStatus.HeaderText = "Status";
            this.reqStatus.MinimumWidth = 6;
            this.reqStatus.Name = "reqStatus";
            this.reqStatus.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.panel2.Controls.Add(this.G_CMBBloodStatus);
            this.panel2.Controls.Add(this.G_ClearBtnBr);
            this.panel2.Controls.Add(this.G_ApplybtnBr);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1005, 78);
            this.panel2.TabIndex = 0;
            // 
            // G_CMBBloodStatus
            // 
            this.G_CMBBloodStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.G_CMBBloodStatus.AutoRoundedCorners = true;
            this.G_CMBBloodStatus.BackColor = System.Drawing.Color.Transparent;
            this.G_CMBBloodStatus.BorderColor = System.Drawing.Color.Gray;
            this.G_CMBBloodStatus.BorderRadius = 17;
            this.G_CMBBloodStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.G_CMBBloodStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.G_CMBBloodStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.G_CMBBloodStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.G_CMBBloodStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.G_CMBBloodStatus.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G_CMBBloodStatus.ForeColor = System.Drawing.Color.Gray;
            this.G_CMBBloodStatus.ItemHeight = 30;
            this.G_CMBBloodStatus.Items.AddRange(new object[] {
            "Blood Status",
            "Accepted",
            "Rejected",
            "Pending"});
            this.G_CMBBloodStatus.Location = new System.Drawing.Point(724, 22);
            this.G_CMBBloodStatus.Name = "G_CMBBloodStatus";
            this.G_CMBBloodStatus.Size = new System.Drawing.Size(173, 36);
            this.G_CMBBloodStatus.StartIndex = 0;
            this.G_CMBBloodStatus.TabIndex = 2;
            this.G_CMBBloodStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // G_ClearBtnBr
            // 
            this.G_ClearBtnBr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.G_ClearBtnBr.BorderRadius = 22;
            this.G_ClearBtnBr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.G_ClearBtnBr.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.G_ClearBtnBr.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.G_ClearBtnBr.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.G_ClearBtnBr.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.G_ClearBtnBr.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G_ClearBtnBr.ForeColor = System.Drawing.Color.White;
            this.G_ClearBtnBr.Location = new System.Drawing.Point(415, 19);
            this.G_ClearBtnBr.Name = "G_ClearBtnBr";
            this.G_ClearBtnBr.Size = new System.Drawing.Size(132, 42);
            this.G_ClearBtnBr.TabIndex = 14;
            this.G_ClearBtnBr.Text = "Clear";
            this.G_ClearBtnBr.Click += new System.EventHandler(this.G_ClearBtnBr_Click);
            // 
            // G_ApplybtnBr
            // 
            this.G_ApplybtnBr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.G_ApplybtnBr.BorderRadius = 22;
            this.G_ApplybtnBr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.G_ApplybtnBr.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.G_ApplybtnBr.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.G_ApplybtnBr.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.G_ApplybtnBr.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.G_ApplybtnBr.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G_ApplybtnBr.ForeColor = System.Drawing.Color.White;
            this.G_ApplybtnBr.Location = new System.Drawing.Point(572, 19);
            this.G_ApplybtnBr.Name = "G_ApplybtnBr";
            this.G_ApplybtnBr.Size = new System.Drawing.Size(132, 42);
            this.G_ApplybtnBr.TabIndex = 13;
            this.G_ApplybtnBr.Text = "Apply";
            this.G_ApplybtnBr.Click += new System.EventHandler(this.G_ApplybtnBr_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Location = new System.Drawing.Point(43, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Blood Request";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // BloodRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BloodReqPanel);
            this.Name = "BloodRequest";
            this.Size = new System.Drawing.Size(1005, 673);
            this.Load += new System.EventHandler(this.BloodRequest_Load);
            this.BloodReqPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BloodReqShow)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BloodReqPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_BloodReqShow;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn brReqID;
        private System.Windows.Forms.DataGridViewTextBoxColumn userFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn brBloodType;
        private System.Windows.Forms.DataGridViewTextBoxColumn brPatientIssue;
        private System.Windows.Forms.DataGridViewTextBoxColumn brQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn brManageQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn brRequestDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn brDonationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn reqStatus;
        private Guna.UI2.WinForms.Guna2Button G_ClearBtnBr;
        private Guna.UI2.WinForms.Guna2Button G_ApplybtnBr;
        private Guna.UI2.WinForms.Guna2ComboBox G_CMBBloodStatus;
    }
}
