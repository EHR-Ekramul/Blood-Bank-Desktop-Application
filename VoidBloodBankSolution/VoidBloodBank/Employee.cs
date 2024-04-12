using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoidBloodBank.ZahidUserControl;
using System.Windows.Forms;

namespace VoidBloodBank
{
    public partial class Employee : Form
    {
        [Obsolete]
        public Employee()
        {
            InitializeComponent();
        }



        /*private void moveImageBox(object sender)
        {
            *//*Guna2Button b = (Guna2Button)sender;
            ImgSlider_Dashboard.Location = new Point(b.Location.X + 171, b.Location.Y - 18);
            ImgSlider_Dashboard.SendToBack();*//*
        }*/


        private void Gbtn_Account_Click(object sender, EventArgs e)
        {
            AccountTimer.Start();
        }

        bool EmployeeExpand = false;
        private void AccountTimer_Tick(object sender, EventArgs e)
        {
            if (EmployeeExpand)
            {
                AccountPanel.Height -= 5;
                if (AccountPanel.Height == AccountPanel.MinimumSize.Height)
                {
                    EmployeeExpand = false;
                    AccountTimer.Stop();
                }
            }
            else
            {
                AccountPanel.Height += 5;
                if (AccountPanel.Height == AccountPanel.MaximumSize.Height)
                {
                    EmployeeExpand = true;
                    AccountTimer.Stop();
                }
            }
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            Gbtn_Dashboard.PerformClick();

            /*Uc_DashBoard.Visible = true;
            Uc_DonorInfo.Visible = false;
            Panel_ManagePost.Visible = false;
            Uc_MyProfile.Visible = false;
            Uc_Settings.Visible = false;*/


            ImgSlider_ManagePost.Visible = false;
            ImgSlider_Dashboard.Visible = true;
            ImgSlider_DonorInfo.Visible = false;

            string error;


            //DataGridView.AutoGenerateColumns = false;


            DataTable data = DataAccess.GetDataTable("Select * from Active_User", out error);

            if (!string.IsNullOrEmpty(error)) { MessageBox.Show(error); return; }//Error in db
            //MessageBox.Show("" + data.Rows.Count);

            string activeuser = data.Rows[0]["auID"].ToString();


            //Set image for employee panel picture box
            data = DataAccess.GetDataTable("SELECT userImage FROM User_Info WHERE userID=" + activeuser + ";", out error);
            if (!string.IsNullOrEmpty(error)) { MessageBox.Show(error); return; }//Error in db

            PictureBox_Employoee.Image = Image.FromStream(new MemoryStream((byte[])data.Rows[0]["userImage"]));


            //set full name for employee panel Label full name Display
            data = DataAccess.GetDataTable("SELECT userFullName FROM User_Info WHERE userID=" + activeuser + ";", out error);
            if (!string.IsNullOrEmpty(error)) { MessageBox.Show(error); return; }//Error in db

            Label_EmployeePanelEmpName.Text = data.Rows[0]["userFullName"].ToString();

        }




        private void Gbtn_Dashboard_Click(object sender, EventArgs e)
        {
            Panel_ManagePost.Visible = false;
            Panel_Mother.Visible = true;

            Panel_Mother.Controls.Clear();
            var userControl = new Uc_Dashboard();
            Panel_Mother.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;

            ImgSlider_DonorInfo.Visible = false;
            ImgSlider_ManagePost.Visible = false;
            ImgSlider_Dashboard.Visible = true;

            /* Uc_DashBoard.Visible = true;
             Uc_DonorInfo.Visible = false;
             Uc_Settings.Visible = false;
             Uc_MyProfile.Visible = false;
             Panel_ManagePost.Visible = false;
             Panel_ManagePost.Visible = false;*/


        }



        private void Gbtn_DonorInfo_Click(object sender, EventArgs e)
        {
            Panel_ManagePost.Visible = false;
            Panel_Mother.Visible = true;

            Panel_Mother.Controls.Clear();
            var userControl = new Uc_DonorInfo();
            Panel_Mother.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;

            ImgSlider_DonorInfo.Visible = true;
            ImgSlider_Dashboard.Visible = false;
            ImgSlider_ManagePost.Visible = false;



            /*Uc_DashBoard.Visible = false;
            Uc_DonorInfo.Visible = true;
            Uc_Settings.Visible = false;
            Uc_MyProfile.Visible = false;
            Panel_ManagePost.Visible = false;
            Panel_ManagePost.Visible = false;*/




        }

        [Obsolete]
        private void Gbtn_Setting_Click(object sender, EventArgs e)
        {
            Panel_ManagePost.Visible = false;
            Panel_Mother.Visible = true;


            Panel_Mother.Controls.Clear();
            var userControl = new Uc_Settings();
            Panel_Mother.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;

            Uc_Settings.initializeImage(PictureBox_Employoee, Label_EmployeePanelEmpName);

            ImgSlider_DonorInfo.Visible = false;
            ImgSlider_Dashboard.Visible = false;
            ImgSlider_ManagePost.Visible = false;

            /* Uc_DashBoard.Visible = false;
             Uc_DonorInfo.Visible = false;
             Uc_Settings.Visible = true;
             Uc_MyProfile.Visible = false;
             Panel_ManagePost.Visible = false;
             Panel_ManagePost.Visible = false;*/


        }

        private void Gbtn_MyProfile_Click(object sender, EventArgs e)
        {
            Panel_ManagePost.Visible = false;
            Panel_Mother.Visible = true;

            Panel_Mother.Controls.Clear();
            var userControl = new Uc_MyProfile();
            Panel_Mother.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;

            ImgSlider_DonorInfo.Visible = false;
            ImgSlider_Dashboard.Visible = false;
            ImgSlider_ManagePost.Visible = false;

            /*Uc_DashBoard.Visible = false;
            Uc_DonorInfo.Visible = false;
            Uc_Settings.Visible = false;
            Uc_MyProfile.Visible = true;
            Panel_ManagePost.Visible = false;*/


        }

        private void GBtn_ManagePost_Click(object sender, EventArgs e)
        {
            Panel_Mother.Controls.Clear();
            Panel_Mother.Visible = false;
            Panel_ManagePost.Visible = true;



            /*var userControl = new Uc_ManagePost();
            Panel_ManagePost.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;*/


            ImgSlider_DonorInfo.Visible = false;
            ImgSlider_Dashboard.Visible = false;
            ImgSlider_ManagePost.Visible = true;


            /*Uc_DashBoard.Visible = false;
            Uc_DonorInfo.Visible = false;
            Uc_Settings.Visible = false;
            Uc_MyProfile.Visible = false;
            Panel_ManagePost.Visible = true;
*/
            ShowAllRequest("SELECT Blood_Request.brReqID as reqID, User_Info.userFullName as userName, Blood_Request.brRequestDate as reqDate, Blood_Request.brDonationDate as donationDate, Blood_Request.brPatientIssue as patientIssue, Blood_Request.brQuantity as quantity, Blood_Request.brBloodType as blood, CONCAT(Donation_Place.dpPlace,', ',Donation_Place.dpCIty,', ',Donation_Place.dpCountry) as place, User_Info.userImage as userImage, Blood_Request.brReqStatus  FROM Blood_Request inner join Donation_Place on Blood_Request.brReqID=Donation_Place.dpReqID inner join User_Info on User_Info.userID=Blood_Request.brUserID;");
        }
        private void ShowAllRequest(string query)
        {
            //Getting Donor Information
            DataTable data = DataAccess.GetDataTable(query, out string error);
            if (!string.IsNullOrEmpty(error)) { MessageBox.Show(error, "Show All Request Error"); return; } //Error from db
            int requestQuantity = data.Rows.Count;

            bool postShown = false;
            if (requestQuantity == 0)
            {
                FlowLayoutPanel_PendingPost.Controls.Clear(); return;
            }
            for (int i = 0; i < requestQuantity; i++)
            {
                if (postShown == false)
                {
                    postShown = true;
                    FlowLayoutPanel_PendingPost.Controls.Clear();
                }
                var userControl = new Uc_ManagePost();

                Image userImage = Image.FromStream(new MemoryStream((byte[])data.Rows[i]["userImage"]));
                string name = data.Rows[i]["userName"].ToString();
                string reqID = data.Rows[i]["reqID"].ToString();
                string bloodGroup = data.Rows[i]["blood"].ToString();
                string patientIssue = data.Rows[i]["patientIssue"].ToString();
                string reqDate = data.Rows[i]["reqDate"].ToString();
                string donationDate = data.Rows[i]["donationDate"].ToString();
                string place = data.Rows[i]["place"].ToString();
                string quantity = data.Rows[i]["quantity"].ToString();

                userControl.Margin = new Padding(0, 2, 0, 8);
                userControl.Width = FlowLayoutPanel_PendingPost.Width;

                //Set user controls value
                userControl.SetData(userImage, name, reqID, bloodGroup, patientIssue, reqDate, donationDate, place, quantity);

                FlowLayoutPanel_PendingPost.Controls.Add(userControl);
            }
        }

        private bool confirmationShown = false;
        private void Employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!confirmationShown)
            {
                DialogResult result = MessageBox.Show("Do you want to close the Application?", "Close Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    confirmationShown = true;
                    DataAccess.CleanActiveUser();
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void Panel__Paint(object sender, PaintEventArgs e)
        {

        }

        private void GBtn_ManagePostClear_Click(object sender, EventArgs e)
        {
            ComboBox_ManagePost.SelectedIndex = 0;
            GBtn_ManagePostApply.PerformClick();
        }

        private void ComboBox_ManagePost_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GBtn_ManagePostApply_Click(object sender, EventArgs e)
        {
            string extendedCondition = ";";

            if (ComboBox_ManagePost.SelectedIndex == 1)
            {
                extendedCondition = " where Blood_Request.brReqStatus =4;";
            }
            else if (ComboBox_ManagePost.SelectedIndex == 2)
            {
                extendedCondition = " where Blood_Request.brReqStatus =1;";

            }
            else if (ComboBox_ManagePost.SelectedIndex == 3)
            {
                extendedCondition = " where Blood_Request.brReqStatus =0;";

            }
            ShowAllRequest("SELECT Blood_Request.brReqID as reqID, User_Info.userFullName as userName, Blood_Request.brRequestDate as reqDate, Blood_Request.brDonationDate as donationDate, Blood_Request.brPatientIssue as patientIssue, Blood_Request.brQuantity as quantity, Blood_Request.brBloodType as blood, CONCAT(Donation_Place.dpPlace,', ',Donation_Place.dpCIty,', ',Donation_Place.dpCountry) as place, User_Info.userImage as userImage, Blood_Request.brReqStatus  FROM Blood_Request inner join Donation_Place on Blood_Request.brReqID=Donation_Place.dpReqID inner join User_Info on User_Info.userID=Blood_Request.brUserID" + extendedCondition);

        }

        private void GBtn_Logout_Click(object sender, EventArgs e)
        {
            GBtn_Logout.Checked = false;
            DialogResult result = MessageBox.Show("Do you want to Logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DataAccess.CleanActiveUser();
                this.Hide();
                new Login().Show();
            }
        }
    }
}
