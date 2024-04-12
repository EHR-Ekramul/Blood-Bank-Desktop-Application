
namespace VoidBloodBank.TonmoyUserControl
{
    partial class TUC_Employee
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Gbtn_RemoveEmp = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.G_dgvEmployeeShow = new Guna.UI2.WinForms.Guna2DataGridView();
            this.empID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empjoiningdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.G_dgvEmployeeShow)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(332, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Employee";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.panel1.Controls.Add(this.Gbtn_RemoveEmp);
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 78);
            this.panel1.TabIndex = 5;
            // 
            // Gbtn_RemoveEmp
            // 
            this.Gbtn_RemoveEmp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Gbtn_RemoveEmp.BackColor = System.Drawing.Color.Transparent;
            this.Gbtn_RemoveEmp.BorderRadius = 22;
            this.Gbtn_RemoveEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gbtn_RemoveEmp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gbtn_RemoveEmp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gbtn_RemoveEmp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gbtn_RemoveEmp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gbtn_RemoveEmp.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Bold);
            this.Gbtn_RemoveEmp.ForeColor = System.Drawing.Color.White;
            this.Gbtn_RemoveEmp.Location = new System.Drawing.Point(762, 16);
            this.Gbtn_RemoveEmp.Name = "Gbtn_RemoveEmp";
            this.Gbtn_RemoveEmp.Size = new System.Drawing.Size(157, 45);
            this.Gbtn_RemoveEmp.TabIndex = 6;
            this.Gbtn_RemoveEmp.Text = "Remove";
            this.Gbtn_RemoveEmp.UseTransparentBackground = true;
            this.Gbtn_RemoveEmp.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 22;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(584, 17);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(157, 45);
            this.guna2Button1.TabIndex = 5;
            this.guna2Button1.Text = "Add";
            this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // G_dgvEmployeeShow
            // 
            this.G_dgvEmployeeShow.AllowUserToAddRows = false;
            this.G_dgvEmployeeShow.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.G_dgvEmployeeShow.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.G_dgvEmployeeShow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.G_dgvEmployeeShow.ColumnHeadersHeight = 19;
            this.G_dgvEmployeeShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.G_dgvEmployeeShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empID,
            this.userName,
            this.UserGender,
            this.userEmail,
            this.userPhone,
            this.empjoiningdate,
            this.empSalary});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.G_dgvEmployeeShow.DefaultCellStyle = dataGridViewCellStyle3;
            this.G_dgvEmployeeShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.G_dgvEmployeeShow.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.G_dgvEmployeeShow.Location = new System.Drawing.Point(0, 78);
            this.G_dgvEmployeeShow.Name = "G_dgvEmployeeShow";
            this.G_dgvEmployeeShow.ReadOnly = true;
            this.G_dgvEmployeeShow.RowHeadersVisible = false;
            this.G_dgvEmployeeShow.RowHeadersWidth = 51;
            this.G_dgvEmployeeShow.RowTemplate.Height = 24;
            this.G_dgvEmployeeShow.Size = new System.Drawing.Size(1005, 595);
            this.G_dgvEmployeeShow.TabIndex = 6;
            this.G_dgvEmployeeShow.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.G_dgvEmployeeShow.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.G_dgvEmployeeShow.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.G_dgvEmployeeShow.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.G_dgvEmployeeShow.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.G_dgvEmployeeShow.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.G_dgvEmployeeShow.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.G_dgvEmployeeShow.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.G_dgvEmployeeShow.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.G_dgvEmployeeShow.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G_dgvEmployeeShow.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.G_dgvEmployeeShow.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.G_dgvEmployeeShow.ThemeStyle.HeaderStyle.Height = 19;
            this.G_dgvEmployeeShow.ThemeStyle.ReadOnly = true;
            this.G_dgvEmployeeShow.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.G_dgvEmployeeShow.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.G_dgvEmployeeShow.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G_dgvEmployeeShow.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.G_dgvEmployeeShow.ThemeStyle.RowsStyle.Height = 24;
            this.G_dgvEmployeeShow.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.G_dgvEmployeeShow.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // empID
            // 
            this.empID.DataPropertyName = "empID";
            this.empID.HeaderText = "ID";
            this.empID.MinimumWidth = 6;
            this.empID.Name = "empID";
            this.empID.ReadOnly = true;
            // 
            // userName
            // 
            this.userName.DataPropertyName = "userFullName";
            this.userName.HeaderText = "Name";
            this.userName.MinimumWidth = 6;
            this.userName.Name = "userName";
            this.userName.ReadOnly = true;
            // 
            // UserGender
            // 
            this.UserGender.DataPropertyName = "userGender";
            this.UserGender.HeaderText = "Gender";
            this.UserGender.MinimumWidth = 6;
            this.UserGender.Name = "UserGender";
            this.UserGender.ReadOnly = true;
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
            // empjoiningdate
            // 
            this.empjoiningdate.DataPropertyName = "empJoiningDate";
            this.empjoiningdate.HeaderText = "Joining Date";
            this.empjoiningdate.MinimumWidth = 6;
            this.empjoiningdate.Name = "empjoiningdate";
            this.empjoiningdate.ReadOnly = true;
            // 
            // empSalary
            // 
            this.empSalary.DataPropertyName = "empSalary";
            this.empSalary.HeaderText = "Salary";
            this.empSalary.MinimumWidth = 6;
            this.empSalary.Name = "empSalary";
            this.empSalary.ReadOnly = true;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.G_dgvEmployeeShow);
            this.Controls.Add(this.panel1);
            this.Name = "Employee";
            this.Size = new System.Drawing.Size(1005, 673);
            this.Load += new System.EventHandler(this.Employee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.G_dgvEmployeeShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button Gbtn_RemoveEmp;
        private Guna.UI2.WinForms.Guna2DataGridView G_dgvEmployeeShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn empID;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn userEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn empjoiningdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn empSalary;
    }
}
