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
    public partial class My_Donation : UserControl
    {
        public My_Donation()
        {
            InitializeComponent();
        }

        public void SetData(Image userImage, string receiver, string reqID, string bloodGroup, string patientIssue, string reqDate, string donationDate, string place)
        {
            Gcpicture_userProfile.Image = userImage;
            Label_userName.Text = receiver;
            Label_ReqID.Text = reqID;
            Label_DonationDate.Text = donationDate.Split(' ')[0];
            Label_RequestDate.Text = reqDate.Split(' ')[0];
            Label_PatientIssue.Text = patientIssue;
            Label_BloodType.Text = bloodGroup;
            label_Place.Text = place;
        }
    }
}
