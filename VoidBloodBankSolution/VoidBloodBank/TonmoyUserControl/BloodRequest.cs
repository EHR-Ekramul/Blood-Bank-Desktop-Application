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
    public partial class BloodRequest : UserControl
    {
        public BloodRequest()
        {
            InitializeComponent();
            dgv_BloodReqShow.ClearSelection();
        }

        private void BloodRequest_Load(object sender, EventArgs e)
        {
            string query = "Select Blood_Request.brReqID, User_Info.userFullName, Blood_Request.brBloodType, Blood_Request.brPatientIssue, Blood_Request.brQuantity, Blood_Request.brManageQuantity, Blood_Request.brRequestDate, Blood_Request.brDonationDate, User_Info.userPhone, CASE WHEN Blood_Request.brReqStatus = 0 THEN 'Rejected' WHEN Blood_Request.brReqStatus = 1 THEN 'Accepted' ELSE 'Pending' END as reqStatus from User_Info inner join Blood_Request on User_Info.userID = Blood_Request.brUserID";

            string error;
            DataTable dt = DataAccess.GetDataTable(query, out error);

            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK);
                return;
            }

            dgv_BloodReqShow.DataSource = dt;
            dgv_BloodReqShow.Refresh();
            dgv_BloodReqShow.ClearSelection();
            AdminPanel.GeidViewInitialize2(dgv_BloodReqShow);
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


            dgv_BloodReqShow.DataSource = dt;
            dgv_BloodReqShow.Refresh();
            dgv_BloodReqShow.ClearSelection();
        }

        private void G_ApplybtnBr_Click(object sender, EventArgs e)
        {
            string extendedCondition = ";";

            if (G_CMBBloodStatus.SelectedIndex == 1)
            {
                extendedCondition = " where Blood_Request.brReqStatus =1;";
            }
            else if (G_CMBBloodStatus.SelectedIndex == 2)
            {
                extendedCondition = " where Blood_Request.brReqStatus =0;";
            }
            else if (G_CMBBloodStatus.SelectedIndex == 3)
            {
                extendedCondition = " where Blood_Request.brReqStatus =4;";
            }




            ReloadDataGridViewDonorInfo("Select Blood_Request.brReqID, User_Info.userFullName, Blood_Request.brBloodType, Blood_Request.brPatientIssue, Blood_Request.brQuantity, Blood_Request.brManageQuantity, Blood_Request.brRequestDate, Blood_Request.brDonationDate, User_Info.userPhone, CASE WHEN Blood_Request.brReqStatus = 0 THEN 'Rejected' WHEN Blood_Request.brReqStatus = 1 THEN 'Accepted' ELSE 'Pending' END as reqStatus from User_Info inner join Blood_Request on User_Info.userID = Blood_Request.brUserID" + extendedCondition);

        }

        private void G_ClearBtnBr_Click(object sender, EventArgs e)
        {
            G_CMBBloodStatus.SelectedIndex = 0;
            G_ApplybtnBr.PerformClick();
        }
    }
}
