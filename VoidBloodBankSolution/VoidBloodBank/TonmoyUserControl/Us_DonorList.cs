using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoidBloodBank.TonmoyUserControl
{
    public partial class Us_DonorList : UserControl
    {
        public Us_DonorList()
        {
            InitializeComponent();
            G_dgvDonorListShowList.ClearSelection();
        }

        private void Us_DonorList_Load(object sender, EventArgs e)
        {
            string query = "Select User_Info.userID, User_Info.userFullName, Donor_Info.dnrBloodGrp, Donor_Info.dnrDOB, User_Info.userGender, User_Info.userEmail, User_Info.userPhone, user_Address.uCity, user_Address.uCountry, user_Address.uStreet, Donor_Info.dnrTotalDonation, CASE WHEN Donor_Info.dnrAvailability = 1 THEN 'Available' ELSE 'Not Available' END as dnrAvailability from User_Info inner join Donor_Info on User_Info.userID = Donor_Info.dnrID inner join user_Address on User_Info.userID = user_Address.uID";

            string error;
            DataTable dt = DataAccess.GetDataTable(query, out error);

            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK);
                return;
            }

            G_dgvDonorListShowList.DataSource = dt;
            G_dgvDonorListShowList.Refresh();
            G_dgvDonorListShowList.ClearSelection();
            AdminPanel.GeidViewInitialize3(G_dgvDonorListShowList);
        }




        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        private void ReloadDataGridViewDonorInfo(string query)
        {

            string error;

            DataTable dt = DataAccess.GetDataTable(query, out error);

            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK);
                return;
            }


            G_dgvDonorListShowList.DataSource = dt;
            G_dgvDonorListShowList.Refresh();
            G_dgvDonorListShowList.ClearSelection();
        }

        private void G_BtnApply_Click(object sender, EventArgs e)
        {
            string extendedCondition = ";";

            if (G_CMBCity.SelectedIndex == 0 && G_CMBBloodGroup.SelectedIndex != 0)
            {
                extendedCondition = " where Donor_Info.dnrBloodGrp='" + G_CMBBloodGroup.SelectedItem.ToString().Trim() + "';";
            }
            else if (G_CMBCity.SelectedIndex != 0 && G_CMBBloodGroup.SelectedIndex == 0)
            {
                extendedCondition = " where user_Address.uCity='" + G_CMBCity.SelectedItem.ToString().Trim() + "';";
            }
            else if (G_CMBCity.SelectedIndex != 0 && G_CMBBloodGroup.SelectedIndex != 0)
            {
                extendedCondition = " where user_Address.uCity='" + G_CMBCity.SelectedItem.ToString().Trim() + "' and Donor_Info.dnrBloodGrp='" + G_CMBBloodGroup.SelectedItem.ToString().Trim() + "';";
            }




            ReloadDataGridViewDonorInfo("Select User_Info.userID, User_Info.userFullName, Donor_Info.dnrBloodGrp, Donor_Info.dnrDOB, User_Info.userGender, User_Info.userEmail, User_Info.userPhone, user_Address.uCity, user_Address.uCountry, user_Address.uStreet, Donor_Info.dnrTotalDonation, CASE WHEN Donor_Info.dnrAvailability = 1 THEN 'Available' ELSE 'Not Available' END as dnrAvailability from User_Info inner join Donor_Info on User_Info.userID = Donor_Info.dnrID inner join user_Address on User_Info.userID = user_Address.uID " + extendedCondition);
        }

        private void G_Btnclear_Click(object sender, EventArgs e)
        {
            G_CMBCity.SelectedIndex = 0;
            G_CMBCountry.SelectedIndex = 0;
            G_CMBBloodGroup.SelectedIndex = 0;
            G_BtnApply.PerformClick();
        }
    }
}
