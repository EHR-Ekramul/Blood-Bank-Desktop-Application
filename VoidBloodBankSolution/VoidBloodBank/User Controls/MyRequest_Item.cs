using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoidBloodBank.User_Controls
{
    public partial class MyRequest_Item : UserControl
    {
        public MyRequest_Item()
        {
            InitializeComponent();
        }

        public void SetData(string reqID, string bloodGroup, string patientIssue, string quantity, string reqDate, string donationDate, string reqStatus)
        {
            Label_BloodGroup.Text = bloodGroup;
            Label_ReqID.Text = reqID;
            Label_PatientIssue.Text = patientIssue;
            Label_Quantity.Text = quantity;
            Label_RequestDate.Text = reqDate.Split(' ')[0];
            Label_DonationDate.Text = donationDate.Split(' ')[0];

            
            //Set Request Status
            if (reqStatus == "1")
            {
                Gbtn_ReqStatus.Text = "Accepted";
                Gbtn_ReqStatus.FillColor = Color.Green;
            }
            else if (reqStatus == "0")
            {
                Gbtn_ReqStatus.Text = "Rejected";
                Gbtn_ReqStatus.FillColor = Color.Red;
            }
            else if (reqStatus == "4")
            {
                Gbtn_ReqStatus.Text = "Pending";
                Gbtn_ReqStatus.FillColor = Color.Chocolate;
            }
        }

        private void MyRequest_Item_Load(object sender, EventArgs e)
        {
            DataTable data = DataAccess.GetDataTable("SELECT (Blood_Request.brQuantity-Blood_Request.brManageQuantity) as remain FROM Blood_Request WHERE Blood_Request.brReqID=" + Label_ReqID.Text + ";", out string error);
            if (!string.IsNullOrEmpty(error)) { MultiTask.ShowError(error, "Donate Item Load Error"); return; }
            string remain = data.Rows[0]["remain"].ToString().Trim();

            if (remain == "0")
            {
                Gbtn_ReqStatus.FillColor= Color.FromArgb(91, 109, 255);
                Gbtn_ReqStatus.Text = "Managed";
            }
        }
    }
}
