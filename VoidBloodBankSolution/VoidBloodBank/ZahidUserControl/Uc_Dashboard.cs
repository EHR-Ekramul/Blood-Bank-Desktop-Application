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
    public partial class Uc_Dashboard : UserControl
    {
        public Uc_Dashboard()
        {
            InitializeComponent();
        }

        private bool chartEdited;

        private void Uc_Dashboard_Load(object sender, EventArgs e)
        {




            string error;

            //Chart Blood Groups Available
            string querychart1 = "select dnrBloodGrp from Donor_Info";
            DataTable dtc = DataAccess.GetDataTable(querychart1, out error);

            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK);
                return;
            }







            //Dashboard Total Blood Donors number count
            string query = "select * from User_Info where userType = 'general';";


            DataTable dt = DataAccess.GetDataTable(query, out error);

            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK);
                return;
            }
            Label_TotalBloodDonors.Text = dt.Rows.Count.ToString();



            //Dashboard Total Available Blood Donors number count
            string query2 = "select * from Donor_Info where dnrAvailability = 1;";

            DataTable dt2 = DataAccess.GetDataTable(query2, out error);

            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK);
                return;
            }
            Lable_AvailableDonors.Text = dt2.Rows.Count.ToString();


            //Dashboard Post Pending number count
            string query3 = "select * from Blood_Request where brReqStatus =4;";

            DataTable dt3 = DataAccess.GetDataTable(query3, out error);

            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK);
                return;
            }
            Label_PostPending.Text = dt3.Rows.Count.ToString();


            //Dashboard Post Approved number count
            string query4 = "select * from Blood_Request where brReqStatus =1;";

            DataTable dt4 = DataAccess.GetDataTable(query4, out error);

            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK);
                return;
            }
            Label_ApprovedPost.Text = dt4.Rows.Count.ToString();



            if (chartEdited)
            {
                return;
            }
            DataTable data = DataAccess.GetDataTable("SELECT * FROM Donor_Info;", out error);
            if (!string.IsNullOrEmpty(error)) { MessageBox.Show(error, "Total donor get error"); return; }
            double totalDonor = data.Rows.Count;


            double aPositive = GetSpecificDonor("SELECT * FROM Donor_Info WHERE dnrBloodGrp = 'A Positive';", totalDonor);
            double aNegative = GetSpecificDonor("SELECT * FROM Donor_Info WHERE dnrBloodGrp = 'A Negative';", totalDonor);
            double bPositive = GetSpecificDonor("SELECT * FROM Donor_Info WHERE dnrBloodGrp = 'B Positive';", totalDonor);
            double bNegative = GetSpecificDonor("SELECT * FROM Donor_Info WHERE dnrBloodGrp = 'B Negative';", totalDonor);
            double oPositive = GetSpecificDonor("SELECT * FROM Donor_Info WHERE dnrBloodGrp = 'O Positive';", totalDonor);
            double oNegative = GetSpecificDonor("SELECT * FROM Donor_Info WHERE dnrBloodGrp = 'O Negative';", totalDonor);
            double abPositive = GetSpecificDonor("SELECT * FROM Donor_Info WHERE dnrBloodGrp = 'AB Positive';", totalDonor);
            double abNegative = GetSpecificDonor("SELECT * FROM Donor_Info WHERE dnrBloodGrp = 'AB Negative';", totalDonor);

            chartEdited = true;
            if (aPositive != 0)
            {
                chart1.Series[0].Points.AddXY("A+", aPositive);
            }
            if (aNegative != 0)
            {
                chart1.Series[0].Points.AddXY("A-", aNegative);
            }
            if (bPositive != 0)
            {
                chart1.Series[0].Points.AddXY("B+", bPositive);
            }
            if (bNegative != 0)
            {
                chart1.Series[0].Points.AddXY("B-", bNegative);
            }
            if (oPositive != 0)
            {
                chart1.Series[0].Points.AddXY("O+", oPositive);
            }
            if (oNegative != 0)
            {
                chart1.Series[0].Points.AddXY("O-", oNegative);
            }
            if (abPositive != 0)
            {
                chart1.Series[0].Points.AddXY("AB+", abPositive);
            }
            if (abNegative != 0)
            {
                chart1.Series[0].Points.AddXY("AB-", abNegative);
            }


        }
        ////PieChart 
        private double GetSpecificDonor(string query, double totalDonor)
        {
            DataTable data = DataAccess.GetDataTable(query, out string error);
            if (!string.IsNullOrEmpty(error)) { MessageBox.Show(error, "Specific donor get error"); return -313; }
            return (data.Rows.Count / totalDonor) * 100;
        }
        /////////////////////////////////////////////////////////////////
    }
}
