using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoidBloodBank.TonmoyUserControl;
using System.Windows.Forms;

namespace VoidBloodBank
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }
        //Window Close Confirmation
        private bool confirmationShown = false;
        private void GeneralUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!confirmationShown)
            {
                DialogResult result = MessageBox.Show("Do you want to close the Application?", "Close Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    confirmationShown = true;
                    DataAccess.CleanActiveUser();
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
        private static Guna2DataGridView grid;
        public static void GeidViewInitialize(Guna2DataGridView G_dgvEmployeeShow)
        {
            grid = G_dgvEmployeeShow;
        }

        private static Guna2DataGridView grid2;
        public static void GeidViewInitialize2(Guna2DataGridView G_dgvEmployeeShow)
        {
            grid2 = G_dgvEmployeeShow;
        }


        private static Guna2DataGridView grid3;
        public static void GeidViewInitialize3(Guna2DataGridView G_dgvEmployeeShow)
        {
            grid3 = G_dgvEmployeeShow;
        }


        private void moveImageBox(object sender)
        {
            Guna2Button b = (Guna2Button)sender;
            ImgSlide.Location = new Point(b.Location.X + 185, b.Location.Y - 23);
            ImgSlide.SendToBack();
            //ImgSlide.Visible = false;
        }

        private void DashboardBtn_CheckedChanged(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }

        bool EmployeeExpand = false;
        private void SubTransition_Tick(object sender, EventArgs e)
        {
            if (EmployeeExpand)
            {
                panelT.Height -= 5;
                if (panelT.Height == panelT.MinimumSize.Height)
                {
                    EmployeeExpand = false;
                    SubTransition.Stop();
                }
            }
            else
            {
                panelT.Height += 5;
                if (panelT.Height == panelT.MaximumSize.Height)
                {
                    EmployeeExpand = true;
                    SubTransition.Stop();
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            // panelT.BackColor = Color.White;
            SubTransition.Start();
            //////////////////////////////////////visible check......
            // dashboard1.Visible = false;
            //us_DonorList.Visible = false;
            //  us_bloodRequest.Visible = false;
            // us_employee.Visible = false;
            //myAccount1.Visible = true;
            //my_Profile1.Visible = false;
            // setting1.Visible = false;

        }


        private void GunaDonorListBtn_Click(object sender, EventArgs e)
        {
            ImgSlide.Visible = true; 
            MotherPanel.Controls.Clear();
            var userControl = new Us_DonorList();
            MotherPanel.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;




            /* dashboard1.Visible = false;
            us_DonorList.Visible = true;
            us_bloodRequest.Visible = false;
            us_employee.Visible = false;
            myAccount1.Visible = false;
            my_Profile1.Visible = false;
            setting1.Visible = false;*/

            grid3.ClearSelection();
        }

        private void GunaBloodRequestBtn_Click(object sender, EventArgs e)
        {
            ImgSlide.Visible = true;
            MotherPanel.Controls.Clear();
            var userControl = new BloodRequest();
            MotherPanel.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;




            /* dashboard1.Visible = false;
            us_DonorList.Visible = false;
            us_bloodRequest.Visible = true;
            us_employee.Visible = false;
            myAccount1.Visible = false;
            my_Profile1.Visible = false;
            setting1.Visible = false;*/
            grid2.ClearSelection();

        }


        private void GunaDashboardBtn_Click(object sender, EventArgs e)
        {
            ImgSlide.Visible = true;
            MotherPanel.Controls.Clear();
            var userControl = new Dashboard();
            MotherPanel.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;


            /*dashboard1.Visible = true;
            us_DonorList.Visible = false;
            us_bloodRequest.Visible = false;
            us_employee.Visible = false;
            myAccount1.Visible = false;
            my_Profile1.Visible = false;
            setting1.Visible = false;*/
        }

        private void GunaEmployeeBtn_Click(object sender, EventArgs e)
        {
            ImgSlide.Visible = true; 
            TUC_Employee.initializePanel(MotherPanel);
            MotherPanel.Controls.Clear();
            var userControl = new TUC_Employee();
            MotherPanel.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;



            // ImgSlide.Visible = false;

            /*dashboard1.Visible = false;
            us_DonorList.Visible = false;
            us_bloodRequest.Visible = false;
            us_employee.Visible = true;
            myAccount1.Visible = false;
            my_Profile1.Visible = false;
            setting1.Visible = false;*/
            grid.ClearSelection();


        }

        private void GunaMyProfileBtn_Click(object sender, EventArgs e)
        {
            ImgSlide.Visible = false; 
            MotherPanel.Controls.Clear();
            var userControl = new My_Profile();
            MotherPanel.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;




            /*dashboard1.Visible = false;
            us_DonorList.Visible = false;
            us_bloodRequest.Visible = false;
            us_employee.Visible = false;
            myAccount1.Visible = false;
            my_Profile2.Visible = true;
            setting1.Visible = false;*/
        }

        private void GunaSettingBtn_Click(object sender, EventArgs e)
        {
            ImgSlide.Visible = false;
            Setting.InitializeImages(GunaPicBox, LblAName);
            MotherPanel.Controls.Clear();
            var userControl = new Setting();
            MotherPanel.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;





            /*dashboard1.Visible = false;
            us_DonorList.Visible = false;
            us_bloodRequest.Visible = false;
            us_employee.Visible = false;
            myAccount1.Visible = false;
            my_Profile1.Visible = false;
            setting1.Visible = true;*/
        }

        private void GunaLogOutBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Logout?","Logout Confirmaion",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }
            DataAccess.CleanActiveUser();
            this.Hide();
            new Login().Show();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            GunaDashboardBtn.PerformClick();

            /* Uc_DashBoard.Visible = true;
             Uc_DonorInfo.Visible = false;
             Panel_ManagePost.Visible = false;
             Uc_MyProfile.Visible = false;
             Uc_Settings.Visible = false;


             ImgSlider_ManagePost.Visible = false;
             ImgSlider_Dashboard.Visible = true;
             ImgSlider_DonorInfo.Visible = false;*/

            string error;

            DataTable data = DataAccess.GetDataTable("Select * from Active_User", out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }

            string activeuser = data.Rows[0]["auID"].ToString();


            //Set all value of controls
            data = DataAccess.GetDataTable("SELECT * FROM User_Info WHERE userID=" + activeuser + ";", out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }

            GunaPicBox.Image = Image.FromStream(new MemoryStream((byte[])data.Rows[0]["userImage"]));
            LblAName.Text = data.Rows[0]["userFullName"].ToString();
        }

    }
}
