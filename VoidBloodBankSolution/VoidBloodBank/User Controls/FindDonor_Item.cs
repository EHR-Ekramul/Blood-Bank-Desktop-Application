using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoidBloodBank.User_Controls
{
    public partial class FindDonor_Item : UserControl
    {
        public FindDonor_Item()
        {
            InitializeComponent();
        }

        public void SetData(string ID, Image image, string name, string gender, string blood, string address)
        {
            Label_DonorID.Text = ID;
            Label_DonorGender.Text = gender;
            Gcpicture_DonorImage.Image = image;
            Label_DonorName.Text = name;
            Label_DonorBlood.Text = blood;
            label_DonorAddress.Text = address;
        }

        private void Gbtn_ContactDonor_Click(object sender, EventArgs e)
        {
            DataTable data = DataAccess.GetDataTable("SELECT * FROM User_Info WHERE userID=" + Label_DonorID.Text + ";", out string error);
            if (!string.IsNullOrEmpty(error)) { MultiTask.ShowError(error, "Contact Donor DB error"); return; }

            //Copy Text and show tooltip
            string textToCopy = "Donor ID : " + Label_DonorID.Text + "\n" + "Donor Name : " + Label_DonorName.Text + "\n" + "Blood Group : " + Label_DonorBlood.Text + "\n" + "Mobile : " + data.Rows[0]["userPhone"].ToString() + "\n" + "Email : " + data.Rows[0]["userEmail"].ToString() + "\n" + "Address : " + label_DonorAddress.Text;
            Clipboard.SetText(textToCopy);
            new ToolTip().Show("Contact Information copied to clipboard!", Gbtn_ContactDonor, 2, Gbtn_ContactDonor.Height, 2000); // Show tooltip for 2 seconds
        }
    }
}
