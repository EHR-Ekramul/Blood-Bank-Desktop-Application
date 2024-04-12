
namespace VoidBloodBank.ZahidUserControl
{
    partial class Uc_Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uc_Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel_DashBoard = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Panel_AvailableDonors = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ImageButton6 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Lable_AvailableDonors = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Panel_TotalBloodDonors = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ImageButton5 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Label_TotalBloodDonors = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Panel_PostsPending = new Guna.UI2.WinForms.Guna2Panel();
            this.Label_PostPending = new System.Windows.Forms.Label();
            this.guna2ImageButton8 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label14 = new System.Windows.Forms.Label();
            this.Panel_ApprovedPost = new Guna.UI2.WinForms.Guna2Panel();
            this.Label_ApprovedPost = new System.Windows.Forms.Label();
            this.guna2ImageButton7 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.Panel_DashBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.Panel_AvailableDonors.SuspendLayout();
            this.Panel_TotalBloodDonors.SuspendLayout();
            this.Panel_PostsPending.SuspendLayout();
            this.Panel_ApprovedPost.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 95);
            this.panel1.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(392, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "DashBoard";
            // 
            // Panel_DashBoard
            // 
            this.Panel_DashBoard.BackColor = System.Drawing.Color.White;
            this.Panel_DashBoard.Controls.Add(this.chart1);
            this.Panel_DashBoard.Controls.Add(this.Panel_AvailableDonors);
            this.Panel_DashBoard.Controls.Add(this.Panel_TotalBloodDonors);
            this.Panel_DashBoard.Controls.Add(this.Panel_PostsPending);
            this.Panel_DashBoard.Controls.Add(this.Panel_ApprovedPost);
            this.Panel_DashBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_DashBoard.Location = new System.Drawing.Point(0, 95);
            this.Panel_DashBoard.Name = "Panel_DashBoard";
            this.Panel_DashBoard.Size = new System.Drawing.Size(1038, 578);
            this.Panel_DashBoard.TabIndex = 43;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(101, 249);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(830, 326);
            this.chart1.TabIndex = 46;
            this.chart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("Inter Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Blood Groups Collection";
            this.chart1.Titles.Add(title1);
            // 
            // Panel_AvailableDonors
            // 
            this.Panel_AvailableDonors.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Panel_AvailableDonors.BackColor = System.Drawing.Color.Transparent;
            this.Panel_AvailableDonors.BorderRadius = 25;
            this.Panel_AvailableDonors.Controls.Add(this.guna2ImageButton6);
            this.Panel_AvailableDonors.Controls.Add(this.Lable_AvailableDonors);
            this.Panel_AvailableDonors.Controls.Add(this.label10);
            this.Panel_AvailableDonors.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(194)))), ((int)(((byte)(65)))));
            this.Panel_AvailableDonors.Location = new System.Drawing.Point(279, 14);
            this.Panel_AvailableDonors.Name = "Panel_AvailableDonors";
            this.Panel_AvailableDonors.Size = new System.Drawing.Size(223, 139);
            this.Panel_AvailableDonors.TabIndex = 43;
            // 
            // guna2ImageButton6
            // 
            this.guna2ImageButton6.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton6.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton6.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton6.Image")));
            this.guna2ImageButton6.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton6.ImageRotate = 0F;
            this.guna2ImageButton6.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2ImageButton6.Location = new System.Drawing.Point(156, 33);
            this.guna2ImageButton6.Name = "guna2ImageButton6";
            this.guna2ImageButton6.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton6.Size = new System.Drawing.Size(64, 54);
            this.guna2ImageButton6.TabIndex = 33;
            // 
            // Lable_AvailableDonors
            // 
            this.Lable_AvailableDonors.AutoSize = true;
            this.Lable_AvailableDonors.BackColor = System.Drawing.Color.Transparent;
            this.Lable_AvailableDonors.Font = new System.Drawing.Font("Inter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lable_AvailableDonors.ForeColor = System.Drawing.Color.White;
            this.Lable_AvailableDonors.Location = new System.Drawing.Point(42, 40);
            this.Lable_AvailableDonors.Name = "Lable_AvailableDonors";
            this.Lable_AvailableDonors.Size = new System.Drawing.Size(55, 36);
            this.Lable_AvailableDonors.TabIndex = 26;
            this.Lable_AvailableDonors.Text = "33";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(194)))), ((int)(((byte)(65)))));
            this.label10.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(35, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 24);
            this.label10.TabIndex = 23;
            this.label10.Text = "Available Donors";
            // 
            // Panel_TotalBloodDonors
            // 
            this.Panel_TotalBloodDonors.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Panel_TotalBloodDonors.BackColor = System.Drawing.Color.Transparent;
            this.Panel_TotalBloodDonors.BorderRadius = 25;
            this.Panel_TotalBloodDonors.Controls.Add(this.guna2ImageButton5);
            this.Panel_TotalBloodDonors.Controls.Add(this.Label_TotalBloodDonors);
            this.Panel_TotalBloodDonors.Controls.Add(this.label8);
            this.Panel_TotalBloodDonors.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.Panel_TotalBloodDonors.Location = new System.Drawing.Point(21, 14);
            this.Panel_TotalBloodDonors.Name = "Panel_TotalBloodDonors";
            this.Panel_TotalBloodDonors.Size = new System.Drawing.Size(223, 139);
            this.Panel_TotalBloodDonors.TabIndex = 42;
            // 
            // guna2ImageButton5
            // 
            this.guna2ImageButton5.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton5.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton5.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton5.Image")));
            this.guna2ImageButton5.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton5.ImageRotate = 0F;
            this.guna2ImageButton5.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2ImageButton5.Location = new System.Drawing.Point(148, 26);
            this.guna2ImageButton5.Name = "guna2ImageButton5";
            this.guna2ImageButton5.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton5.Size = new System.Drawing.Size(56, 61);
            this.guna2ImageButton5.TabIndex = 33;
            // 
            // Label_TotalBloodDonors
            // 
            this.Label_TotalBloodDonors.AutoSize = true;
            this.Label_TotalBloodDonors.BackColor = System.Drawing.Color.Transparent;
            this.Label_TotalBloodDonors.Font = new System.Drawing.Font("Inter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TotalBloodDonors.ForeColor = System.Drawing.Color.White;
            this.Label_TotalBloodDonors.Location = new System.Drawing.Point(28, 40);
            this.Label_TotalBloodDonors.Name = "Label_TotalBloodDonors";
            this.Label_TotalBloodDonors.Size = new System.Drawing.Size(64, 36);
            this.Label_TotalBloodDonors.TabIndex = 25;
            this.Label_TotalBloodDonors.Text = "121";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.label8.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = "Total Blood Donors";
            // 
            // Panel_PostsPending
            // 
            this.Panel_PostsPending.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Panel_PostsPending.BackColor = System.Drawing.Color.Transparent;
            this.Panel_PostsPending.BorderRadius = 25;
            this.Panel_PostsPending.Controls.Add(this.Label_PostPending);
            this.Panel_PostsPending.Controls.Add(this.guna2ImageButton8);
            this.Panel_PostsPending.Controls.Add(this.label14);
            this.Panel_PostsPending.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(46)))), ((int)(((byte)(255)))));
            this.Panel_PostsPending.Location = new System.Drawing.Point(537, 14);
            this.Panel_PostsPending.Name = "Panel_PostsPending";
            this.Panel_PostsPending.Size = new System.Drawing.Size(223, 139);
            this.Panel_PostsPending.TabIndex = 45;
            // 
            // Label_PostPending
            // 
            this.Label_PostPending.AutoSize = true;
            this.Label_PostPending.BackColor = System.Drawing.Color.Transparent;
            this.Label_PostPending.Font = new System.Drawing.Font("Inter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_PostPending.ForeColor = System.Drawing.Color.White;
            this.Label_PostPending.Location = new System.Drawing.Point(52, 40);
            this.Label_PostPending.Name = "Label_PostPending";
            this.Label_PostPending.Size = new System.Drawing.Size(55, 36);
            this.Label_PostPending.TabIndex = 41;
            this.Label_PostPending.Text = "33";
            // 
            // guna2ImageButton8
            // 
            this.guna2ImageButton8.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton8.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton8.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton8.Image")));
            this.guna2ImageButton8.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton8.ImageRotate = 0F;
            this.guna2ImageButton8.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2ImageButton8.Location = new System.Drawing.Point(161, 33);
            this.guna2ImageButton8.Name = "guna2ImageButton8";
            this.guna2ImageButton8.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton8.Size = new System.Drawing.Size(64, 54);
            this.guna2ImageButton8.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(46)))), ((int)(((byte)(255)))));
            this.label14.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(38, 104);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 24);
            this.label14.TabIndex = 18;
            this.label14.Text = "Post Pending";
            // 
            // Panel_ApprovedPost
            // 
            this.Panel_ApprovedPost.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Panel_ApprovedPost.BackColor = System.Drawing.Color.Transparent;
            this.Panel_ApprovedPost.BorderRadius = 25;
            this.Panel_ApprovedPost.Controls.Add(this.Label_ApprovedPost);
            this.Panel_ApprovedPost.Controls.Add(this.guna2ImageButton7);
            this.Panel_ApprovedPost.Controls.Add(this.label12);
            this.Panel_ApprovedPost.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(159)))), ((int)(((byte)(224)))));
            this.Panel_ApprovedPost.Location = new System.Drawing.Point(795, 14);
            this.Panel_ApprovedPost.Name = "Panel_ApprovedPost";
            this.Panel_ApprovedPost.Size = new System.Drawing.Size(223, 139);
            this.Panel_ApprovedPost.TabIndex = 44;
            // 
            // Label_ApprovedPost
            // 
            this.Label_ApprovedPost.AutoSize = true;
            this.Label_ApprovedPost.BackColor = System.Drawing.Color.Transparent;
            this.Label_ApprovedPost.Font = new System.Drawing.Font("Inter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ApprovedPost.ForeColor = System.Drawing.Color.White;
            this.Label_ApprovedPost.Location = new System.Drawing.Point(53, 40);
            this.Label_ApprovedPost.Name = "Label_ApprovedPost";
            this.Label_ApprovedPost.Size = new System.Drawing.Size(55, 36);
            this.Label_ApprovedPost.TabIndex = 42;
            this.Label_ApprovedPost.Text = "33";
            // 
            // guna2ImageButton7
            // 
            this.guna2ImageButton7.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton7.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton7.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton7.Image")));
            this.guna2ImageButton7.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton7.ImageRotate = 0F;
            this.guna2ImageButton7.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2ImageButton7.Location = new System.Drawing.Point(159, 33);
            this.guna2ImageButton7.Name = "guna2ImageButton7";
            this.guna2ImageButton7.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton7.Size = new System.Drawing.Size(64, 54);
            this.guna2ImageButton7.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(159)))), ((int)(((byte)(224)))));
            this.label12.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(34, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 24);
            this.label12.TabIndex = 21;
            this.label12.Text = "Approved Post";
            // 
            // Uc_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel_DashBoard);
            this.Controls.Add(this.panel1);
            this.Name = "Uc_Dashboard";
            this.Size = new System.Drawing.Size(1038, 673);
            this.Load += new System.EventHandler(this.Uc_Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Panel_DashBoard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.Panel_AvailableDonors.ResumeLayout(false);
            this.Panel_AvailableDonors.PerformLayout();
            this.Panel_TotalBloodDonors.ResumeLayout(false);
            this.Panel_TotalBloodDonors.PerformLayout();
            this.Panel_PostsPending.ResumeLayout(false);
            this.Panel_PostsPending.PerformLayout();
            this.Panel_ApprovedPost.ResumeLayout(false);
            this.Panel_ApprovedPost.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Panel_DashBoard;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Guna.UI2.WinForms.Guna2Panel Panel_AvailableDonors;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton6;
        private System.Windows.Forms.Label Lable_AvailableDonors;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Panel Panel_TotalBloodDonors;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton5;
        private System.Windows.Forms.Label Label_TotalBloodDonors;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Panel Panel_PostsPending;
        private System.Windows.Forms.Label Label_PostPending;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton8;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2Panel Panel_ApprovedPost;
        private System.Windows.Forms.Label Label_ApprovedPost;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton7;
        private System.Windows.Forms.Label label12;
    }
}
