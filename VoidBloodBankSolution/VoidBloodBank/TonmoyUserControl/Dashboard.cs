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
    public partial class Dashboard : UserControl
    {

        //private string text;
        // private int len = 0;
        public Dashboard()
        {
            InitializeComponent();
        }



        /*private void LblTextSlideTimer_Tick(object sender, EventArgs e)
        {
            if(len < text.Length)
            {
                lblTextSlide.Text = lblTextSlide.Text + text.ElementAt(len);
                len++;
            }

            else
            {
                LblTextSlideTimer.Stop(); 
            }
        }*/

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //string text = lblTextSlide.Text;
            //lblTextSlide.Text = "";
            // LblTextSlideTimer.Start();

            string error;



            //Dashboard Total Blood Donors number count
            string query = "select * from User_Info where userType = 'general';";


            DataTable dt = DataAccess.GetDataTable(query, out error);

            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK);
                return;
            }
            LblTotalDonors.Text = dt.Rows.Count.ToString();



            //Dashboard Total Available Blood Donors number count
            string query2 = "select * from Donor_Info where dnrAvailability = 1;";

            DataTable dt2 = DataAccess.GetDataTable(query2, out error);

            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK);
                return;
            }
            LblAvailableDonors.Text = dt2.Rows.Count.ToString();



            //Dashboard Post Approved number count
            string query4 = "select * from Employee_Info";

            DataTable dt4 = DataAccess.GetDataTable(query4, out error);

            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK);
                return;
            }
            LblTotalEmp.Text = dt4.Rows.Count.ToString();
        }
    }
}
