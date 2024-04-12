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
    public partial class Uc_DonorInfo : UserControl
    {
        //string activeuser;
        public Uc_DonorInfo()
        {
            InitializeComponent();
        }

        private void Uc_DonorInfo_Load(object sender, EventArgs e)
        {
            /*string query = "Select User_Info.userID, User_Info.userFullName, Donor_Info.dnrBloodGrp, Donor_Info.dnrDOB, User_Info.userGender, User_Info.userEmail, User_Info.userPhone, user_Address.uCity, user_Address.uCountry, user_Address.uStreet, Donor_Info.dnrTotalDonation, CASE WHEN Donor_Info.dnrAvailability = 1 THEN 'Available' ELSE 'Not Available' END as dnrAvailability from User_Info inner join Donor_Info on User_Info.userID = Donor_Info.dnrID inner join user_Address on User_Info.userID = user_Address.uID";
            string error;

            DataTable dt = DataAccess.GetData(query, out error);

            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK);
                return;
            }

            
            DataGridView_DonorInfo.DataSource = dt;
            DataGridView_DonorInfo.Refresh();
            DataGridView_DonorInfo.ClearSelection();*/
            ReloadDataGridViewDonorInfo("Select User_Info.userID, User_Info.userFullName, Donor_Info.dnrBloodGrp, Donor_Info.dnrDOB, User_Info.userGender, User_Info.userEmail, User_Info.userPhone, user_Address.uCity, user_Address.uCountry, user_Address.uStreet, Donor_Info.dnrTotalDonation, CASE WHEN Donor_Info.dnrAvailability = 1 THEN 'Available' ELSE 'Not Available' END as dnrAvailability from User_Info inner join Donor_Info on User_Info.userID = Donor_Info.dnrID inner join user_Address on User_Info.userID = user_Address.uID");



        }

        private void ReloadDataGridViewDonorInfo(string query)
        {

            string error;

            DataTable dt = DataAccess.GetDataTable(query, out error);

            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK);
                return;
            }


            DataGridView_DonorInfo.DataSource = dt;
            DataGridView_DonorInfo.Refresh();
            DataGridView_DonorInfo.ClearSelection();
        }

        private void GBtn_DonorInfoApply_Click(object sender, EventArgs e)
        {
            string extendedCondition = ";";

            if (ComboBox_City.SelectedIndex == 0 && ComboBox_BloodGroup.SelectedIndex != 0)
            {
                extendedCondition = " where Donor_Info.dnrBloodGrp='" + ComboBox_BloodGroup.SelectedItem.ToString().Trim() + "';";
            }
            else if (ComboBox_City.SelectedIndex != 0 && ComboBox_BloodGroup.SelectedIndex == 0)
            {
                extendedCondition = " where user_Address.uCity='" + ComboBox_City.SelectedItem.ToString().Trim() + "';";
            }
            else if (ComboBox_City.SelectedIndex != 0 && ComboBox_BloodGroup.SelectedIndex != 0)
            {
                extendedCondition = " where user_Address.uCity='" + ComboBox_City.SelectedItem.ToString().Trim() + "' and Donor_Info.dnrBloodGrp='" + ComboBox_BloodGroup.SelectedItem.ToString().Trim() + "';";
            }




            ReloadDataGridViewDonorInfo("Select User_Info.userID, User_Info.userFullName, Donor_Info.dnrBloodGrp, Donor_Info.dnrDOB, User_Info.userGender, User_Info.userEmail, User_Info.userPhone, user_Address.uCity, user_Address.uCountry, user_Address.uStreet, Donor_Info.dnrTotalDonation, CASE WHEN Donor_Info.dnrAvailability = 1 THEN 'Available' ELSE 'Not Available' END as dnrAvailability from User_Info inner join Donor_Info on User_Info.userID = Donor_Info.dnrID inner join user_Address on User_Info.userID = user_Address.uID " + extendedCondition);

        }

        private void GBtn_Clear_Click(object sender, EventArgs e)
        {
            ComboBox_City.SelectedIndex = 0;
            ComboBox_Country.SelectedIndex = 0;
            ComboBox_BloodGroup.SelectedIndex = 0;
            GBtn_DonorInfoApply.PerformClick();

        }
    }
}
