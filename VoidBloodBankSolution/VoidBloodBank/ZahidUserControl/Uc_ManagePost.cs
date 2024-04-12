using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoidBloodBank.ZahidUserControl
{
    public partial class Uc_ManagePost : UserControl
    {
        public Uc_ManagePost()
        {
            InitializeComponent();
        }

        public void SetData(Image userImage, string name, string reqID, string bloodGroup, string patientIssue, string reqDate, string donationDate, string place, string quantity)
        {
            Gcpicture_UserImage.Image = userImage;
            Label_UserName.Text = name;
            Label_UserBlood.Text = bloodGroup;
            Label_ReqID.Text = reqID;
            Label_RequestDate.Text = reqDate.Split(' ')[0];
            Label_DonationDate.Text = donationDate.Split(' ')[0];
            Label_PatientIssue.Text = patientIssue;
            label_DonationPlace.Text = place;
            Label_Quantity.Text = quantity + " Bag";
        }

        private void Uc_ManagePost_Load(object sender, EventArgs e)
        {
            DataTable data = DataAccess.GetDataTable("SELECT * FROM Blood_Request WHERE brReqID=" + Label_ReqID.Text.Trim() + ";", out string error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error, "select"); return;
            }
            if (data.Rows[0]["brReqStatus"].ToString().Trim() == "1")
            {
                Gbtn_Accept.Text = "Accepted";
                Gbtn_Accept.Enabled = false;
                Gbtn_Accept.DisabledState.FillColor = Color.Green;
                Gbtn_Reject.Visible = false;
            }
            else if (data.Rows[0]["brReqStatus"].ToString().Trim() == "0")
            {
                Gbtn_Accept.Text = "Rejected";
                Gbtn_Accept.Enabled = false;
                Gbtn_Accept.DisabledState.FillColor = Color.Red;
                Gbtn_Reject.Visible = false;
            }
        }

        private void Gbtn_Accept_Click(object sender, EventArgs e)
        {
            DataAccess.ExecuteQuery("UPDATE Blood_Request SET brReqStatus = 1 WHERE brReqID=" + Label_ReqID.Text.Trim() + ";", out string error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error, "update 1"); return;
            }
            Gbtn_Accept.Text = "Accepted";
            Gbtn_Accept.Enabled = false;
            Gbtn_Accept.DisabledState.FillColor = Color.Green;
            Gbtn_Reject.Visible = false;
        }

        private void Gbtn_Reject_Click(object sender, EventArgs e)
        {
            DataAccess.ExecuteQuery("UPDATE Blood_Request SET brReqStatus=0 WHERE brReqID=" + Label_ReqID.Text.Trim() + ";", out string error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error, "update 0"); return;
            }
            Gbtn_Accept.Text = "Rejected";
            Gbtn_Accept.Enabled = false;
            Gbtn_Accept.DisabledState.FillColor = Color.Red;
            Gbtn_Reject.Visible = false;
        }
    }
}
