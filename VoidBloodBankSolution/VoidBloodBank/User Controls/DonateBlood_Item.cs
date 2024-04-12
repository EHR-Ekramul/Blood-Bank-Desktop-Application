using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoidBloodBank.User_Controls
{
    public partial class DonateBlood_Item : UserControl
    {
        private string activeUser;
        public DonateBlood_Item()
        {
            InitializeComponent();
        }
        //Load
        private void DonateBlood_Item_Load(object sender, EventArgs e)
        {
            DataTable data = DataAccess.GetDataTable("SELECT * FROM Active_User;", out string error);
            if (!string.IsNullOrEmpty(error)) { MultiTask.ShowError(error, "Donate Item Load Error-2"); return; }

            activeUser = data.Rows[0]["auID"].ToString().Trim();

            data = DataAccess.GetDataTable("SELECT (Blood_Request.brQuantity-Blood_Request.brManageQuantity) as remain FROM Blood_Request WHERE Blood_Request.brReqID=" + Label_ReqID.Text + ";", out error);
            if (!string.IsNullOrEmpty(error)) { MultiTask.ShowError(error, "Donate Item Load Error"); return; }
            string remain = data.Rows[0]["remain"].ToString().Trim();

            if (remain == "0")
            {
                Gbtn_Donate.Enabled = false;
                Gbtn_Donate.Text = "Managed";
            }

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
            Label_Quantity.Text = quantity+" Bag";
        }

        private void Gbtn_Donate_Click(object sender, EventArgs e)
        {
            DataTable data = DataAccess.GetDataTable("SELECT * FROM Donor_Info WHERE dnrID="+activeUser+";", out string error);
            if (!string.IsNullOrEmpty(error)) { MultiTask.ShowError(error, "Donate Click Error"); return; }

            string activeUserBlood = data.Rows[0]["dnrBloodGrp"].ToString().Trim();

            if (activeUserBlood != Label_UserBlood.Text)
            {
                MessageBox.Show("Your Blood Group is " + activeUserBlood, "Blood Group Did not match", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("Do You Want to Donate Blood?", "Donation Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.No)   {return;}

            data = DataAccess.GetDataTable("SELECT DATEDIFF(SECOND, Donation_History.dhDonationDate, GETDATE()) AS delayTime FROM Donation_History WHERE dhDnrID=" + activeUser + ";", out error);
            if (!string.IsNullOrEmpty(error)) { MultiTask.ShowError(error, "Donate Click Error-2"); return; }

            if (data.Rows.Count != 0)
            {
                long delayTime = long.Parse(data.Rows[0]["delayTime"].ToString());
                if (delayTime < 10)
                {
                    MessageBox.Show("You Have Donated " + delayTime + " Seconds ago. Please Wait a Few Seconds to Donate Again");
                    return;
                }
            }

            //Insert into Donation History
            DataAccess.ExecuteQuery("INSERT INTO Donation_History(dhReqID,dhDnrID,dhDonationDate,dhDonationStatus) VALUES(" + Label_ReqID.Text + "," + activeUser + ",GETDATE(),1);", out error);
            if (!string.IsNullOrEmpty(error)) { MultiTask.ShowError(error, "Donate Click Error-3"); return; }

            //Update into blood request
                //Get Current managed quantity
            data = DataAccess.GetDataTable("SELECT * FROM Blood_Request WHERE brReqID=" + Label_ReqID.Text + ";", out error);
            if (!string.IsNullOrEmpty(error)) { MultiTask.ShowError(error, "Donate Click Error-4"); return; }

            int managedQuantity = Int32.Parse(data.Rows[0]["brManageQuantity"].ToString().Trim())+1;
            //Update into blood req
            DataAccess.ExecuteQuery("UPDATE Blood_Request SET brManageQuantity=" + managedQuantity + " WHERE brReqID=" + Label_ReqID.Text + ";", out error);
            if (!string.IsNullOrEmpty(error)) { MultiTask.ShowError(error, "Donate Click Error-5"); return; }

            //Update in donor info total donation
                //Get total donation
            data = DataAccess.GetDataTable("SELECT * FROM Donor_Info WHERE dnrID=" + activeUser + ";", out error);
            if (!string.IsNullOrEmpty(error)) { MultiTask.ShowError(error, "Donate Click Error-6"); return; }

            int totalDonation = Int32.Parse(data.Rows[0]["dnrTotalDonation"].ToString().Trim())+1;
                //Update total donation
            DataAccess.ExecuteQuery("UPDATE Donor_Info SET dnrTotalDonation=" + totalDonation + " WHERE dnrID=" + activeUser + ";", out error);
            if (!string.IsNullOrEmpty(error)) { MultiTask.ShowError(error, "Donate Click Error-7"); return; }

            //Copy text and show tooltip
            data = DataAccess.GetDataTable("SELECT * FROM User_Info WHERE userID=(SELECT brUserID FROM Blood_Request WHERE brReqID=" + Label_ReqID.Text + ");", out error);
            if (!string.IsNullOrEmpty(error)) { MultiTask.ShowError(error, "Donate Click Error-8"); return; }

            string textToCopy = "Request ID : " + Label_ReqID.Text + "\nReceiver Name : " + Label_UserName.Text + "\nPhone Number : " + data.Rows[0]["userPhone"].ToString().Trim() + "\nEmail Address : " + data.Rows[0]["userEmail"].ToString().Trim()+"\nAddress : "+ label_DonationPlace.Text;
            Clipboard.SetText(textToCopy);
            new ToolTip().Show("Text copied to clipboard!", Gbtn_Donate, 2, Gbtn_Donate.Height, 2000); // Show tooltip for 2 seconds

            //Confirmation Message
            MessageBox.Show("Thank You for Saving a Life. Please Contact With Receiver to Donate.", "Donation Request Placed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreashList();
        }

        private static FlowLayoutPanel FlowPanel_AllRequest;
        public static void InitializeFlowPanel(FlowLayoutPanel flowPanel)
        {
            FlowPanel_AllRequest = flowPanel;
        }
        private void RefreashList()
        {
            //Getting Donor Information
            DataTable data = DataAccess.GetDataTable("SELECT Blood_Request.brReqID as reqID, User_Info.userFullName as userName, Blood_Request.brRequestDate as reqDate, Blood_Request.brDonationDate as donationDate, Blood_Request.brPatientIssue as patientIssue, Blood_Request.brQuantity as quantity, Blood_Request.brBloodType as blood, CONCAT(Donation_Place.dpPlace,', ',Donation_Place.dpCIty,', ',Donation_Place.dpCountry) as place, User_Info.userImage as userImage  FROM Blood_Request inner join Donation_Place on Blood_Request.brReqID=Donation_Place.dpReqID inner join User_Info on User_Info.userID=Blood_Request.brUserID WHERE (brReqStatus=1 and Blood_Request.brUserID <> " + activeUser + ");", out string error);
            if (!string.IsNullOrEmpty(error)) { MultiTask.ShowError(error, "Show All Request Error"); return; } //Error from db
            int requestQuantity = data.Rows.Count;

            bool postShown = false;
            if (requestQuantity == 0)
            {
                FlowPanel_AllRequest.Controls.Clear(); return;
            }
            for (int i = 0; i < requestQuantity; i++)
            {
                if (postShown == false)
                {
                    postShown = true;
                    FlowPanel_AllRequest.Controls.Clear();
                }
                var userControl = new DonateBlood_Item();

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
                userControl.Width = FlowPanel_AllRequest.Width;

                //Set user controls value
                userControl.SetData(userImage, name, reqID, bloodGroup, patientIssue, reqDate, donationDate, place, quantity);

                FlowPanel_AllRequest.Controls.Add(userControl);
            }
        }

    }
}
