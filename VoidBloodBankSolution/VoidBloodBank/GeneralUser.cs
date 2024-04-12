using System;
using System.Data;
using System.Drawing;
using Guna.UI2.WinForms;
using System.Windows.Forms;
using VoidBloodBank.User_Controls;
using System.IO;
using System.Diagnostics;

namespace VoidBloodBank
{
    public partial class GeneralUser : Form
    {
        string activeUser; // Point the Active User
        public GeneralUser()
        {
            InitializeComponent();
        }

//Form Actions
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
                    e.Cancel=true;
                }
            }
        }
        private void Gbtn_Logout_Click(object sender, EventArgs e)
        {
            Gbtn_Logout.Checked = false;

            DialogResult result = MessageBox.Show("Do you want to Logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DataAccess.CleanActiveUser();
                this.Hide();
                new Login().Show();
            }
        }

        //Form Load
        private void GeneralUser_Load(object sender, EventArgs e)
        {
            //Getting Active User ID
            DataTable data = DataAccess.GetDataTable("SELECT auID FROM Active_User;", out string error);
            if (!string.IsNullOrEmpty(error)) { MultiTask.ShowError(error); return; } //Error from db
            activeUser = data.Rows[0]["auID"].ToString();

            Gbtn_Home.PerformClick();
        }

        //Form Resize
        private void GeneralUser_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                if (Gbtn_Account.Checked == true && Gbtn_MyDonation.Checked == true)
                {
                    RefreashFlowPanel(FlowPanel_MyDonation);
                }
                else if (Gbtn_Account.Checked == true && Gbtn_MyRequest.Checked == true)
                {
                    RefreashFlowPanel(FlowPanel_PostGrid);
                }
                else if (Gbtn_FindDonor.Checked == true)
                {
                    RefreashFlowPanel(FlowPanel_AllDonorGrid);
                }
                else if (Gbtn_DonateBlood.Checked == true)
                {
                    RefreashFlowPanel(FlowPanel_AllRequest);
                }
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                if (Gbtn_Account.Checked == true && Gbtn_MyDonation.Checked == true)
                {
                    RefreashFlowPanel(FlowPanel_MyDonation);
                }
                else if (Gbtn_Account.Checked == true && Gbtn_MyRequest.Checked == true)
                {
                    RefreashFlowPanel(FlowPanel_PostGrid);
                }
                else if (Gbtn_FindDonor.Checked == true)
                {
                    RefreashFlowPanel(FlowPanel_AllDonorGrid);
                }
                else if (Gbtn_DonateBlood.Checked == true)
                {
                    RefreashFlowPanel(FlowPanel_AllRequest);
                }
            }
            /*else if (this.WindowState == FormWindowState.Minimized)
            {
                if (Gbtn_Account.Checked == true && Gbtn_MyDonation.Checked == true)
                {
                    RefreashFlowPanel(FlowPanel_MyDonation);
                }
                else if (Gbtn_Account.Checked == true && Gbtn_MyRequest.Checked == true)
                {
                    RefreashFlowPanel(FlowPanel_PostGrid);
                }
                else if (Gbtn_FindDonor.Checked == true)
                {
                    RefreashFlowPanel(FlowPanel_AllDonorGrid);
                }
            }*/
        }

//Timer Actions
        private bool sidebarExpand;
        private void Timer_Sidebar_Tick(object sender, EventArgs e) //Side Bar Timer
        {
            if (!sidebarExpand)
            {
                FlowPanel_Sidebar.Width += 10;
                if (FlowPanel_Sidebar.Width >= FlowPanel_Sidebar.MaximumSize.Width)
                {
                    Timer_Sidebar.Stop();
                    sidebarExpand = true;
                    if (Gbtn_Account.Checked == true && Gbtn_MyDonation.Checked == true)
                    {
                        RefreashFlowPanel(FlowPanel_MyDonation);
                    }
                    else if (Gbtn_Account.Checked == true && Gbtn_MyRequest.Checked == true)
                    {
                        RefreashFlowPanel(FlowPanel_PostGrid);
                    }
                    else if (Gbtn_FindDonor.Checked == true)
                    {
                        RefreashFlowPanel(FlowPanel_AllDonorGrid);
                    }
                    else if (Gbtn_DonateBlood.Checked == true)
                    {
                        RefreashFlowPanel(FlowPanel_AllRequest);
                    }
                }
            }
            else
            {
                FlowPanel_Sidebar.Width -= 10;
                if (FlowPanel_Sidebar.Width <= FlowPanel_Sidebar.MinimumSize.Width)
                {
                    Timer_Sidebar.Stop();
                    sidebarExpand = false;
                    if (Gbtn_Account.Checked == true && Gbtn_MyDonation.Checked == true)
                    {
                        RefreashFlowPanel(FlowPanel_MyDonation);
                    }
                    else if (Gbtn_Account.Checked == true && Gbtn_MyRequest.Checked == true)
                    {
                        RefreashFlowPanel(FlowPanel_PostGrid);
                    }
                    else if (Gbtn_FindDonor.Checked == true)
                    {
                        RefreashFlowPanel(FlowPanel_AllDonorGrid);
                    }
                    else if (Gbtn_DonateBlood.Checked == true)
                    {
                        RefreashFlowPanel(FlowPanel_AllRequest);
                    }
                    if (accountExpand) { Timer_Account.Start(); }
                    if (findBloodExpand) { Timer_FindBlood.Start(); }
                }
            }
        }
        
        private bool accountExpand;
        private void Timer_Account_Tick(object sender, EventArgs e) //Account Button Timer
        {
            if (!accountExpand)
            {
                Panel_Account.Height += 5;
                if (Panel_Account.Height >= Panel_Account.MaximumSize.Height)
                {
                    Timer_Account.Stop();
                    accountExpand = true;
                }
            }
            else
            {
                Panel_Account.Height -= 5;
                if (Panel_Account.Height <= Panel_Account.MinimumSize.Height)
                {
                    Timer_Account.Stop();
                    accountExpand = false;
                }
            }
        }

        private bool findBloodExpand;
        private void Timer_FindBlood_Tick(object sender, EventArgs e) //Find Blood Button Timer
        {
            if (!findBloodExpand)
            {
                Panel_FindBlood.Height += 5;
                if (Panel_FindBlood.Height >= Panel_FindBlood.MaximumSize.Height)
                {
                    Timer_FindBlood.Stop();
                    findBloodExpand = true;
                }
            }
            else
            {
                Panel_FindBlood.Height -= 5;
                if (Panel_FindBlood.Height <= Panel_FindBlood.MinimumSize.Height)
                {
                    Timer_FindBlood.Stop();
                    findBloodExpand = false;
                }
            }
        }
        
// Main Buttons Click Actions
        //Menu
        private void Gbtn_Menu_Click(object sender, EventArgs e)
        {
            Timer_Sidebar.Start();
            Gbtn_Menu.Checked = false;
        }

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Home
        private void Gbtn_Home_Click(object sender, EventArgs e)
        {
            //Checked Status Change
            Gbtn_Home.Checked = true;
            Gbtn_DonateBlood.Checked = false;
            Gibtn_FindBloodArrow.Checked = false;
            Gbtn_FindBlood.Checked = false;
            Gbtn_RequestBlood.Checked = false;
            Gbtn_FindDonor.Checked = false;
            Gibtn_AccountArrow.Checked = false;
            Gbtn_Account.Checked = false;
            Gbtn_EditProfile.Checked = false;
            Gbtn_ChangePassword.Checked = false;
            Gbtn_About.Checked = false;
            Gbtn_Contact.Checked = false;
            Gbtn_Logout.Checked = false;

            //Visibility Actions
            GraPanel_Home.Show();
            GraPanel_DonateBlood.Hide();
            GraPanel_RequestBlood.Hide();
            GraPanel_FindDonor.Hide();
            GraPanel_MyAccount.Hide();
            GraPanel_EditProfile.Hide();
            GraPanel_ContactUs.Hide();
            GraPanel_About.Hide();
        }

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Donate Blood
        private void Gbtn_DonateBlood_Click(object sender, EventArgs e)
        {
            //Checked Status Change
            Gbtn_Home.Checked = false;
            Gbtn_DonateBlood.Checked = true;
            Gibtn_FindBloodArrow.Checked = false;
            Gbtn_FindBlood.Checked = false;
            Gbtn_RequestBlood.Checked = false;
            Gbtn_FindDonor.Checked = false;
            Gibtn_AccountArrow.Checked = false;
            Gbtn_Account.Checked = false;
            Gbtn_EditProfile.Checked = false;
            Gbtn_ChangePassword.Checked = false;
            Gbtn_About.Checked = false;
            Gbtn_Contact.Checked = false;
            Gbtn_Logout.Checked = false;

            /*//Docking Actions
            GraPanel_Home.Dock = DockStyle.None;
            GraPanel_DonateBlood.Dock = DockStyle.Fill;
            GraPanel_RequestBlood.Dock = DockStyle.None;
            GraPanel_FindDonor.Dock = DockStyle.None;
            GraPanel_MyAccount.Dock = DockStyle.None;
            GraPanel_EditProfile.Dock = DockStyle.None;
            GraPanel_ContactUs.Dock = DockStyle.None;
            GraPanel_About.Dock = DockStyle.None;*/

            //Visibility Actions
            GraPanel_Home.Hide();
            GraPanel_DonateBlood.Show();
            GraPanel_RequestBlood.Hide();
            GraPanel_FindDonor.Hide();
            GraPanel_MyAccount.Hide();
            GraPanel_EditProfile.Hide();
            GraPanel_ContactUs.Hide();
            GraPanel_About.Hide();
            DonateBlood_Item.InitializeFlowPanel(FlowPanel_AllRequest);
            //FlowPanel_AllRequest
            ShowAllRequest("SELECT Blood_Request.brReqID as reqID, User_Info.userFullName as userName, Blood_Request.brRequestDate as reqDate, Blood_Request.brDonationDate as donationDate, Blood_Request.brPatientIssue as patientIssue, Blood_Request.brQuantity as quantity, Blood_Request.brBloodType as blood, CONCAT(Donation_Place.dpPlace,', ',Donation_Place.dpCIty,', ',Donation_Place.dpCountry) as place, User_Info.userImage as userImage  FROM Blood_Request inner join Donation_Place on Blood_Request.brReqID=Donation_Place.dpReqID inner join User_Info on User_Info.userID=Blood_Request.brUserID WHERE (brReqStatus=1 and Blood_Request.brUserID <> " + activeUser+");");
        }
        private void ShowAllRequest(string query)
        {
            //Getting Donor Information
            DataTable data = DataAccess.GetDataTable(query, out string error);
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
        private void Gbtn_AllRequestApply_Click(object sender, EventArgs e)
        {
            string extendedCondition = ";";
            if (Gcb_AllReqCity.SelectedIndex == 0 && Gcb_AllReqBlood.SelectedIndex != 0)
            {
                extendedCondition = " and Blood_Request.brBloodType='" + Gcb_AllReqBlood.SelectedItem.ToString().Trim() + "';";
            }
            else if (Gcb_AllReqCity.SelectedIndex != 0 && Gcb_AllReqBlood.SelectedIndex == 0)
            {
                extendedCondition = " and Donation_Place.dpCIty='" + Gcb_AllReqCity.SelectedItem.ToString().Trim() + "';";
            }
            else if (Gcb_AllReqCity.SelectedIndex != 0 && Gcb_AllReqBlood.SelectedIndex != 0)
            {
                extendedCondition = " and Donation_Place.dpCIty='"+ Gcb_AllReqCity.SelectedItem.ToString().Trim() + "' and Blood_Request.brBloodType='"+ Gcb_AllReqBlood.SelectedItem.ToString().Trim() + "';";
            }

            ShowAllRequest("SELECT Blood_Request.brReqID as reqID, User_Info.userFullName as userName, Blood_Request.brRequestDate as reqDate, Blood_Request.brDonationDate as donationDate, Blood_Request.brPatientIssue as patientIssue, Blood_Request.brQuantity as quantity, Blood_Request.brBloodType as blood, CONCAT(Donation_Place.dpPlace,', ',Donation_Place.dpCIty,', ',Donation_Place.dpCountry) as place, User_Info.userImage as userImage  FROM Blood_Request inner join Donation_Place on Blood_Request.brReqID=Donation_Place.dpReqID inner join User_Info on User_Info.userID=Blood_Request.brUserID WHERE (brReqStatus=1 and Blood_Request.brUserID <> " + activeUser + ")" + extendedCondition);
        }
        private void Gbtn_ClearAllRequestSelection_Click(object sender, EventArgs e)
        {
            Gcb_AllReqCountry.SelectedIndex = 0;
            Gcb_AllReqCity.SelectedIndex = 0;
            Gcb_AllReqBlood.SelectedIndex = 0;
            Gbtn_AllRequestApply.PerformClick();
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Find Blood
        private void Gibtn_FindBloodArrow_Click(object sender, EventArgs e)
        {
            Gbtn_FindBlood.PerformClick();
        }
        private void Gbtn_FindBlood_Click(object sender, EventArgs e)
        {
            if (sidebarExpand == false)
            {
                Timer_Sidebar.Start();
                Timer_FindBlood.Start();
            }
            if (!sidebarExpand) { return; }
            Timer_FindBlood.Start();

            //Button Checked Status
            if(Gbtn_RequestBlood.Checked || Gbtn_FindDonor.Checked)
            {
                Gibtn_FindBloodArrow.Checked = true;
                Gbtn_FindBlood.Checked = true;
            }
            else
            {
                Gibtn_FindBloodArrow.Checked = false;
                Gbtn_FindBlood.Checked = false;
            }
        }
            //Find Blood --> Request Blood
        private void Gbtn_RequestBlood_Click(object sender, EventArgs e)
        {
            //Checked Status Change
            Gbtn_Home.Checked = false;
            Gbtn_DonateBlood.Checked = false;
            Gibtn_FindBloodArrow.Checked = true;
            Gbtn_FindBlood.Checked = true;
            Gbtn_RequestBlood.Checked = true;
            Gbtn_FindDonor.Checked = false;
            Gibtn_AccountArrow.Checked = false;
            Gbtn_Account.Checked = false;
            Gbtn_EditProfile.Checked = false;
            Gbtn_ChangePassword.Checked = false;
            Gbtn_About.Checked = false;
            Gbtn_Contact.Checked = false;
            Gbtn_Logout.Checked = false;

            /*//Docking Actions
            GraPanel_Home.Dock = DockStyle.None;
            GraPanel_DonateBlood.Dock = DockStyle.None;
            GraPanel_RequestBlood.Dock = DockStyle.Fill;
            GraPanel_FindDonor.Dock = DockStyle.None;
            GraPanel_MyAccount.Dock = DockStyle.None;
            GraPanel_EditProfile.Dock = DockStyle.None;
            GraPanel_ContactUs.Dock = DockStyle.None;
            GraPanel_About.Dock = DockStyle.None;*/
            //Visibility Actions
            GraPanel_Home.Hide();
            GraPanel_DonateBlood.Hide();
            GraPanel_RequestBlood.Show();
            GraPanel_FindDonor.Hide();
            GraPanel_MyAccount.Hide();
            GraPanel_EditProfile.Hide();
            GraPanel_ContactUs.Hide();
            GraPanel_About.Hide();

            GDateTimePicker_DonationDate.MinDate = DateTime.Now;
        }
        private void Gbtn_Post_Click(object sender, EventArgs e)
        {
            string bloodType = (Gbtn_AP.Checked) ? "A Positive" : (Gbtn_AN.Checked) ? "A Negative" : (Gbtn_BP.Checked) ? "B Positive" : (Gbtn_BN.Checked) ? "B Negative" : (Gbtn_ABN.Checked) ? "AB Negative" : (Gbtn_ABP.Checked) ? "AB Positive" : (Gbtn_OP.Checked) ? "O Positive" : "O Negative";
            string pIssue = Gtxt_PatientIssue.Text.Trim();
            string quantity = Gtxt_Quantity.Text.Trim();
            string donationDate = GDateTimePicker_DonationDate.Value.ToString().Trim();
            string country = GComboB_Country.SelectedItem.ToString().Trim();
            string city = GComboB_City.SelectedItem.ToString().Trim();
            string place = Gtxt_DonationPlace.Text.Trim();

            //Validation
            if(string.IsNullOrEmpty(pIssue) || string.IsNullOrEmpty(place))
            {
                MessageBox.Show("Enter all information", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (GComboB_Country.SelectedIndex == 0)
            {
                MessageBox.Show("Enter Valid Country", "Invalid Country", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (GComboB_City.SelectedIndex == 0)
            {
                MessageBox.Show("Enter Valid City", "Invalid City", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //insert in blood request
            DataTable data = DataAccess.GetDataTable("INSERT INTO Blood_Request(brUserID,brBloodType,brPatientIssue,brQuantity,brDonationDate) OUTPUT inserted.brReqID VALUES(" + activeUser+", '"+ bloodType + "','"+ pIssue + "',"+ quantity + ",'"+ donationDate + "');", out string error);
            if (!string.IsNullOrEmpty(error)) { MultiTask.ShowError(error, "Insert Blood Request Error"); }
            string reqID = data.Rows[0]["brReqID"].ToString();

            //insert in donation place
            DataAccess.ExecuteQuery("INSERT INTO Donation_Place(dpReqID,dpCity,dpCountry,dpPlace) VALUES("+reqID+",'"+city+"','"+country+"','"+ place + "');", out error);
            if (!string.IsNullOrEmpty(error)) { MultiTask.ShowError(error, "Insert Donation Place Error"); }

            MessageBox.Show("Successfuly Requested! Request Pending to be reviewed", "Request Pending", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Gbtn_Account.PerformClick();
        }
            //Find Blood --> Find Donor
        private void Gbtn_FindDonor_Click(object sender, EventArgs e)
        {
            //Checked Status Change
            Gbtn_Home.Checked = false;
            Gbtn_DonateBlood.Checked = false;
            Gibtn_FindBloodArrow.Checked = true;
            Gbtn_FindBlood.Checked = true;
            Gbtn_RequestBlood.Checked = false;
            Gbtn_FindDonor.Checked = true;
            Gibtn_AccountArrow.Checked = false;
            Gbtn_Account.Checked = false;
            Gbtn_EditProfile.Checked = false;
            Gbtn_ChangePassword.Checked = false;
            Gbtn_About.Checked = false;
            Gbtn_Contact.Checked = false;
            Gbtn_Logout.Checked = false;

            /*//Docking Actions
            GraPanel_Home.Dock = DockStyle.None;
            GraPanel_DonateBlood.Dock = DockStyle.None;
            GraPanel_RequestBlood.Dock = DockStyle.None;
            GraPanel_FindDonor.Dock = DockStyle.Fill;
            GraPanel_MyAccount.Dock = DockStyle.None;
            GraPanel_EditProfile.Dock = DockStyle.None;
            GraPanel_ContactUs.Dock = DockStyle.None;
            GraPanel_About.Dock = DockStyle.None;*/
            //Visibility Actions
            GraPanel_Home.Hide();
            GraPanel_DonateBlood.Hide();
            GraPanel_RequestBlood.Hide();
            GraPanel_FindDonor.Show();
            GraPanel_MyAccount.Hide();
            GraPanel_EditProfile.Hide();
            GraPanel_ContactUs.Hide();
            GraPanel_About.Hide();

            ShowAllDonor("SELECT User_Info.userID as donorID, User_Info.userFullName as donorName, User_Info.userGender as gender, Donor_Info.dnrBloodGrp as donorBlood, User_Info.userImage as donorImage, CONCAT(user_Address.uStreet,', ',user_Address.uCity,', ',user_Address.uCountry) as donorAddress  FROM User_Info inner join user_Address on User_Info.userID=user_Address.uID inner join Donor_Info on User_Info.userID=Donor_Info.dnrID WHERE (Donor_Info.dnrAvailability=1 and User_Info.userID <> " + activeUser + ");");

        }
        private void Gbtn_ClearSelection_Click(object sender, EventArgs e)
        {
            Gcb_Blood.SelectedIndex = 0;
            Gcb_City.SelectedIndex = 0;
            Gcb_Country.SelectedIndex = 0;
            Gbtn_Apply.PerformClick();
        }
        private void Gbtn_Apply_Click(object sender, EventArgs e)
        {
            string extendedCondition = ";";
            if(Gcb_City.SelectedIndex==0 && Gcb_Blood.SelectedIndex != 0)
            {
                extendedCondition = " and Donor_Info.dnrBloodGrp='" + Gcb_Blood.SelectedItem.ToString().Trim() + "';";
            }
            else if (Gcb_City.SelectedIndex != 0 && Gcb_Blood.SelectedIndex == 0)
            {
                extendedCondition = " and user_Address.uCity='" + Gcb_City.SelectedItem.ToString().Trim() + "';";
            }
            else if(Gcb_City.SelectedIndex != 0 && Gcb_Blood.SelectedIndex != 0)
            {
                extendedCondition = " and user_Address.uCity='" + Gcb_City.SelectedItem.ToString().Trim() + "' and Donor_Info.dnrBloodGrp='" + Gcb_Blood.SelectedItem.ToString().Trim() + "';";
            }

            ShowAllDonor("SELECT User_Info.userID as donorID, User_Info.userFullName as donorName, User_Info.userGender as gender, Donor_Info.dnrBloodGrp as donorBlood, User_Info.userImage as donorImage, CONCAT(user_Address.uStreet,', ',user_Address.uCity,', ',user_Address.uCountry) as donorAddress  FROM User_Info inner join user_Address on User_Info.userID=user_Address.uID inner join Donor_Info on User_Info.userID=Donor_Info.dnrID WHERE (Donor_Info.dnrAvailability=1 and User_Info.userID <> " + activeUser + ")"+ extendedCondition);
        }
        private void ShowAllDonor(string query)
        {
            //Getting Donor Information
            DataTable data = DataAccess.GetDataTable(query, out string error);
            if (!string.IsNullOrEmpty(error)) { MultiTask.ShowError(error, "Show All Donor Error"); return; } //Error from db
            int donorQuantity = data.Rows.Count;

            bool postShown = false;
            if (donorQuantity == 0)
            {
                FlowPanel_AllDonorGrid.Controls.Clear(); return;
            }
            for (int i = 0; i < donorQuantity; i++)
            {
                if (postShown == false)
                {
                    postShown = true;
                    FlowPanel_AllDonorGrid.Controls.Clear();
                }
                var userControl = new FindDonor_Item();

                string ID = data.Rows[i]["donorID"].ToString();
                string name = data.Rows[i]["donorName"].ToString();
                string gender = data.Rows[i]["gender"].ToString();
                string blood = data.Rows[i]["donorBlood"].ToString();
                string address = data.Rows[i]["donorAddress"].ToString();
                Image image = Image.FromStream(new MemoryStream((byte[])data.Rows[i]["donorImage"]));

                userControl.Margin = new Padding(0, 2, 0, 8);
                userControl.Width = FlowPanel_AllDonorGrid.Width;

                //Set user controls value
                userControl.SetData(ID, image, name, gender, blood, address);

                FlowPanel_AllDonorGrid.Controls.Add(userControl);
            }
        }

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //My Account
        private void Gibtn_AccountArrow_Click(object sender, EventArgs e)
        {
            if (Gibtn_AccountArrow.Checked == true) { Gibtn_AccountArrow.Checked = true; }
            else { Gibtn_AccountArrow.Checked = false; }
            if (!sidebarExpand) { return; }
            Timer_Account.Start();
        }
        private void Gbtn_Account_Click(object sender, EventArgs e)
        {
            //Checked Status Change
            Gbtn_Home.Checked = false;
            Gbtn_DonateBlood.Checked = false;
            Gibtn_FindBloodArrow.Checked = false;
            Gbtn_FindBlood.Checked = false;
            Gbtn_RequestBlood.Checked = false;
            Gbtn_FindDonor.Checked = false;
            Gibtn_AccountArrow.Checked = true;
            Gbtn_Account.Checked = true;
            Gbtn_EditProfile.Checked = false;
            Gbtn_ChangePassword.Checked = false;
            Gbtn_About.Checked = false;
            Gbtn_Contact.Checked = false;
            Gbtn_Logout.Checked = false;

            /*//Docking Actions
            GraPanel_Home.Dock = DockStyle.None;
            GraPanel_DonateBlood.Dock = DockStyle.None;
            GraPanel_RequestBlood.Dock = DockStyle.None;
            GraPanel_FindDonor.Dock = DockStyle.None;
            GraPanel_MyAccount.Dock = DockStyle.Fill;
            GraPanel_EditProfile.Dock = DockStyle.None;
            GraPanel_ContactUs.Dock = DockStyle.None;
            GraPanel_About.Dock = DockStyle.None;*/
            //Visibility Actions
            GraPanel_Home.Hide();
            GraPanel_DonateBlood.Hide();
            GraPanel_RequestBlood.Hide();
            GraPanel_FindDonor.Hide();
            GraPanel_MyAccount.Show();
            GraPanel_EditProfile.Hide();
            GraPanel_ContactUs.Hide();
            GraPanel_About.Hide();

            //Show Post Grids
            Gbtn_MyRequest.PerformClick();

            //Show Page Info
            Glabel_Greetings.Text = MultiTask.GetGreetings();//Greetings User


            //Get active user All info
            DataTable data = DataAccess.GetDataTable("SELECT * FROM User_Info WHERE (userID=" + activeUser + ");", out string error);
            if (!string.IsNullOrEmpty(error)) { MultiTask.ShowError(error); return; } //Error from db
            Glabel_FullName.Text = data.Rows[0]["userFullName"].ToString(); //Show First Name

            //Showing Image
            Image userImage = Image.FromStream(new MemoryStream((byte[])data.Rows[0]["userImage"]));
            Gpbx_ImageProfile.Image = userImage;

            //Showing Total Donation
            data = DataAccess.GetDataTable("SELECT * FROM Donor_Info WHERE dnrID=" + activeUser + ";", out error);
            if (!string.IsNullOrEmpty(error)) { MultiTask.ShowError(error, "Total Donation show Error"); return; } //Error from db
            Gbtn_TotalDonation.Text = "Total Donation :   " + data.Rows[0]["dnrTotalDonation"].ToString().Trim();

            //Showing UserID
            Gtxt_UserID.Text = "User ID :  " + activeUser;

            //Showing Blood Group
            Label_Blood.Text = data.Rows[0]["dnrBloodGrp"].ToString().Trim();

            data = DataAccess.GetDataTable("select * from Donor_Info where dnrID="+activeUser+";", out error);
            if (!string.IsNullOrEmpty(error))
            {
                MultiTask.ShowError(error, "Donor Status Update Error");
                return;
            }
            if (data.Rows[0]["dnrAvailability"].ToString()=="0")
            {
                Gbtn_ToggleOn.Visible = false;
                Gbtn_ToggleOff.Visible = true;
            }
            else
            {
                Gbtn_ToggleOn.Visible = true;
                Gbtn_ToggleOff.Visible = false;
            }
        }
        //private readonly bool reqShown2;
        private void Gbtn_MyRequest_Click(object sender, EventArgs e)
        {
            FlowPanel_PostGrid.Visible = true;
            FlowPanel_MyDonation.Visible = false;

            bool reqShown = false;
            //Getting Request Information
            DataTable data = DataAccess.GetDataTable("SELECT brReqID,brBloodType,brPatientIssue,brQuantity,brRequestDate,brDonationDate,brReqStatus FROM Blood_Request WHERE brUserID=" + activeUser + " ORDER BY brReqID DESC;", out string error);
            if (!string.IsNullOrEmpty(error)) { MultiTask.ShowError(error,"General"); return; } //Error from db
            int postQuantity = data.Rows.Count;

            for (int i=0; i<postQuantity; i++)
            {
                if (reqShown == false)
                {
                    FlowPanel_PostGrid.Controls.Clear();
                    reqShown = true;
                }
                var userControl = new MyRequest_Item();
                
                string reqID = data.Rows[i]["brReqID"].ToString();
                string bloodType = data.Rows[i]["brBloodType"].ToString();
                string patientIssue = data.Rows[i]["brPatientIssue"].ToString();
                string quantity = data.Rows[i]["brQuantity"].ToString()+" Bag";
                string reqDate = data.Rows[i]["brRequestDate"].ToString();
                string donationDate = data.Rows[i]["brDonationDate"].ToString();
                string reqStatus = data.Rows[i]["brReqStatus"].ToString();
                userControl.Margin = new Padding(0, 10, 0, 0);
                userControl.Width = FlowPanel_PostGrid.Width;


                //Set user controls value
                userControl.SetData(reqID, bloodType, patientIssue, quantity, reqDate, donationDate, reqStatus);
                
                FlowPanel_PostGrid.Controls.Add(userControl);
            }
        }
        //private bool donationShown2;
        private void Gbtn_MyDonation_Click(object sender, EventArgs e)
        {
            FlowPanel_PostGrid.Visible = false;
            FlowPanel_MyDonation.Visible = true;

            bool donationShown = false;
            //Getting Request Information
            DataTable data = DataAccess.GetDataTable("SELECT dhReqID as reqID, User_Info.userFullName as receiever, User_Info.userImage as userImage, Blood_Request.brRequestDate as reqDate, dhDonationDate as donationDate, Blood_Request.brPatientIssue as patientIssue, Blood_Request.brBloodType as bloodType, Donation_Place.dpPlace as place FROM Donation_History inner join Blood_Request on Donation_History.dhReqID=Blood_Request.brReqID inner join User_Info on User_Info.userID=Blood_Request.brUserID inner join Donation_Place on Blood_Request.brReqID=Donation_Place.dpReqID WHERE (dhDnrID="+activeUser+ " and dhDonationStatus=1) ORDER BY reqID DESC;", out string error);
            if (!string.IsNullOrEmpty(error)) { MultiTask.ShowError(error, "My Donation Error"); return; } //Error from db
            int donation = data.Rows.Count;

            for (int i = 0; i < donation; i++)
            {
                if (donationShown == false)
                {
                    FlowPanel_MyDonation.Controls.Clear();
                    donationShown = true;
                }
                var userControl = new My_Donation();

                Image userImage = Image.FromStream(new MemoryStream((byte[])data.Rows[i]["userImage"]));
                string reqID = data.Rows[i]["reqID"].ToString();
                string receiever = data.Rows[i]["receiever"].ToString();
                string reqDate = data.Rows[i]["reqDate"].ToString();
                string donationDate = data.Rows[i]["donationDate"].ToString();
                string patientIssue = data.Rows[i]["patientIssue"].ToString();
                string bloodType = data.Rows[i]["bloodType"].ToString();
                string donationPlace = data.Rows[i]["place"].ToString();

                userControl.Margin = new Padding(0, 10, 0, 0);
                userControl.Width = FlowPanel_MyDonation.Width;


                //Set user controls value
                userControl.SetData(userImage, receiever, reqID, bloodType, patientIssue, reqDate, donationDate, donationPlace);

                FlowPanel_MyDonation.Controls.Add(userControl);
            }
        }
        private void Gbtn_TotalDonation_Click(object sender, EventArgs e)
        {
            Gbtn_MyDonation.PerformClick();
        }
            //Account --> Edit Profile
        private void Gbtn_EditProfile_Click(object sender, EventArgs e)
        {
            //Checked Status Change
            Gbtn_Home.Checked = false;
            Gbtn_DonateBlood.Checked = false;
            Gibtn_FindBloodArrow.Checked = false;
            Gbtn_FindBlood.Checked = false;
            Gbtn_RequestBlood.Checked = false;
            Gbtn_FindDonor.Checked = false;
            Gibtn_AccountArrow.Checked = true;
            Gbtn_Account.Checked = true;
            Gbtn_EditProfile.Checked = true;
            Gbtn_ChangePassword.Checked = false;
            Gbtn_About.Checked = false;
            Gbtn_Contact.Checked = false;
            Gbtn_Logout.Checked = false;

            /*//Docking Actions
            GraPanel_Home.Dock = DockStyle.None;
            GraPanel_DonateBlood.Dock = DockStyle.None;
            GraPanel_RequestBlood.Dock = DockStyle.None;
            GraPanel_FindDonor.Dock = DockStyle.None;
            GraPanel_MyAccount.Dock = DockStyle.None;
            GraPanel_EditProfile.Dock = DockStyle.Fill;
            GraPanel_ContactUs.Dock = DockStyle.None;
            GraPanel_About.Dock = DockStyle.None;*/

            //Visibility Actions
            GraPanel_Home.Hide();
            GraPanel_DonateBlood.Hide();
            GraPanel_RequestBlood.Hide();
            GraPanel_FindDonor.Hide();
            GraPanel_MyAccount.Hide();
            GraPanel_EditProfile.Show();
            GraPanel_ContactUs.Hide();
            GraPanel_About.Hide();
            Panel_ChangePassword.Hide();
            if (Gbtn_ChangePassword.Checked) { return; }

            //Set all value of controls
            DataTable data = DataAccess.GetDataTable("SELECT User_Info.userFullName, User_Info.userImage, User_Info.userEmail, User_Info.userPhone, user_Address.uCity, user_Address.uStreet FROM User_Info inner join user_Address on User_Info.userID = user_Address.uID WHERE userID="+activeUser+";", out string error);
            if (!string.IsNullOrEmpty(error)) { MultiTask.ShowError(error, "Edit Profile Data Fetch Error"); return; }//Error in db

            EditProfile_ProfileImage.Image= Image.FromStream(new MemoryStream((byte[])data.Rows[0]["userImage"]));
            EditProfile_FirstName.Text = data.Rows[0]["userFullName"].ToString().Split(' ')[0];
            EditProfile_LastName.Text = data.Rows[0]["userFullName"].ToString().Split(' ')[1];
            EditProfile_Email.Text = data.Rows[0]["userEmail"].ToString();
            EditProfile_PhoneNumber.Text = data.Rows[0]["userPhone"].ToString();
            EditProfile_StreetAddress.Text = data.Rows[0]["uStreet"].ToString();
            EditProfile_City.SelectedItem = data.Rows[0]["uCity"].ToString();
            EditProfile_FirstName.Focus();
            EditProfile_FirstName.SelectionStart = EditProfile_FirstName.Text.Length;
            EditProfile_FirstName.ScrollToCaret();
        }
        private void Gpicture_EditImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif)|*.png;*.jpg;*.jpeg;*.gif"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;
                EditProfile_ProfileImage.Image = Image.FromFile(selectedImagePath);
            }
        }
        private void Gbtn_EditProfile_SaveChanges_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to save the changes?", "Save changes confiramtion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            string userName = (EditProfile_FirstName.Text.Trim() + " " + EditProfile_LastName.Text.Trim()).Trim();
            string userEmail = EditProfile_Email.Text.Trim();
            string userPhone = EditProfile_PhoneNumber.Text.Trim();
            string userStreet = EditProfile_StreetAddress.Text.Trim();
            string userCity = EditProfile_City.SelectedItem.ToString().Trim();

            //Validating Info
            if(string.IsNullOrEmpty(EditProfile_FirstName.Text.Trim()) || string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(userEmail) || string.IsNullOrEmpty(userPhone) || string.IsNullOrEmpty(userStreet))
            {
                MultiTask.ShowError("Enter Valid Info", "Empty Field");return;
            }

            //Check and fix name
            if(!MultiTask.NameValidation(userName)) { MultiTask.ShowError("Enter Valid Name", "Invalid Name"); return; }
            if(!MultiTask.EmailValidation(userEmail)) { MultiTask.ShowError("Enter Valid Email", "Invalid Email"); return; }
            if(!MultiTask.MobileNumberValidation(userPhone)) { MultiTask.ShowError("Enter Valid Phone Number", "Invalid Phone"); return; }
            
            //Checking email available or not
            DataTable data = DataAccess.GetDataTable("SELECT * FROM User_Info WHERE (userEmail='"+userEmail+"' and userID <> "+activeUser+");", out string error1);
            if (!string.IsNullOrEmpty(error1)) { MultiTask.ShowError(error1); }// error in db side
            if (data.Rows.Count != 0) 
            {
                MultiTask.ShowError("Email used by another account", "Email not Available"); return;
            }
            
            if (EditProfile_ProfileImage.Image == null)
            {
                MultiTask.ShowError("Select an Image", "No Image Found"); return;
            }


            //Updating in Database
            //Image update
            DataAccess.UpdateImage(EditProfile_ProfileImage.Image, activeUser, out string error);
            if (!string.IsNullOrEmpty(error)) { MultiTask.ShowError(error, "Image update error in Edit Profile"); return; }

            //Update User_Info data
            DataAccess.ExecuteQuery("UPDATE User_Info SET userFullName = '"+ userName + "', userEmail = '"+ userEmail + "', userPhone = '"+ userPhone + "' WHERE (userID = "+activeUser+");", out error);
            if (!string.IsNullOrEmpty(error)) { MultiTask.ShowError(error, "Data update error in Edit Profile"); return; }
            
            //Update User_Address data
            DataAccess.ExecuteQuery("UPDATE user_Address SET uCity = '"+ userCity + "', uStreet = '"+ userStreet + "' WHERE ([uID] = 3131004);", out error);
            if (!string.IsNullOrEmpty(error)) { MultiTask.ShowError(error, "Data update error in Edit Profile"); return; }

            MessageBox.Show("Changes Saved Successfuly", "Changes Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Gbtn_EditProfile.PerformClick();
        }
            //Account --> Change Password
        private void Gbtn_ChangePassword_Click(object sender, EventArgs e)
        {
            //Checked Status Change
            Gbtn_Home.Checked = false;
            Gbtn_DonateBlood.Checked = false;
            Gibtn_FindBloodArrow.Checked = false;
            Gbtn_FindBlood.Checked = false;
            Gbtn_RequestBlood.Checked = false;
            Gbtn_FindDonor.Checked = false;
            Gibtn_AccountArrow.Checked = true;
            Gbtn_Account.Checked = true;
            Gbtn_EditProfile.Checked = false;
            Gbtn_ChangePassword.Checked = true;
            Gbtn_About.Checked = false;
            Gbtn_Contact.Checked = false;
            Gbtn_Logout.Checked = false;

            /*//Docking Actions
            GraPanel_Home.Dock = DockStyle.None;
            GraPanel_DonateBlood.Dock = DockStyle.None;
            GraPanel_RequestBlood.Dock = DockStyle.None;
            GraPanel_FindDonor.Dock = DockStyle.None;
            GraPanel_MyAccount.Dock = DockStyle.None;
            GraPanel_EditProfile.Dock = DockStyle.Fill;
            GraPanel_ContactUs.Dock = DockStyle.None;
            GraPanel_About.Dock = DockStyle.None;*/
            //Visibility Actions
            GraPanel_Home.Hide();
            GraPanel_DonateBlood.Hide();
            GraPanel_RequestBlood.Hide();
            GraPanel_FindDonor.Hide();
            GraPanel_MyAccount.Hide();
            GraPanel_EditProfile.Show();
            GraPanel_ContactUs.Hide();
            GraPanel_About.Hide();
            Panel_ChangePassword.Visible = true;
        }
        private void Gbtn_Change_New_Password_Click(object sender, EventArgs e)
        {
            string currentPass = Gtxt_CurrentPass.Text;
            string newPass = Gtxt_NewPass.Text;
            string confirmPass = Gtxt_ConfirmPass.Text;

            //Get current pass from db
            DataTable data = DataAccess.GetDataTable("SELECT userPassword FROM User_Info WHERE userID = "+activeUser+";", out string error);
            if (!string.IsNullOrEmpty(error)) { MultiTask.ShowError(error, "Change password get pass error");return; }

            //Validation
            string pass = data.Rows[0]["userPassword"].ToString();
            if (currentPass != pass)
            {
                MultiTask.ShowError("Enter Valid Current Password", "Wrong Current Password"); return;
            }
            if (newPass.Length < 5)
            {
                MessageBox.Show("Password Length should be minimum 5", "Invalid Password Length", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
            }
            if (newPass != confirmPass)
            {
                MultiTask.ShowError("Enter Correct Confirm Password", "Confirm password didn't matched"); return;
            }

            //Update Password
            DataAccess.ExecuteQuery("UPDATE User_Info SET userPassword = '"+newPass+"' FROM User_Info WHERE (userID = "+activeUser+");", out error);
            if (!string.IsNullOrEmpty(error)) { MultiTask.ShowError(error, "Change password insert error"); return; }

            MessageBox.Show("Password Successfuly Updated", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Gbtn_Home.PerformClick();
        }

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //About Us
        private void Gbtn_About_Click(object sender, EventArgs e)
        {
            //Checked Status Change
            Gbtn_Home.Checked = false;
            Gbtn_DonateBlood.Checked = false;
            Gibtn_FindBloodArrow.Checked = false;
            Gbtn_FindBlood.Checked = false;
            Gbtn_RequestBlood.Checked = false;
            Gbtn_FindDonor.Checked = false;
            Gibtn_AccountArrow.Checked = false;
            Gbtn_Account.Checked = false;
            Gbtn_EditProfile.Checked = false;
            Gbtn_ChangePassword.Checked = false;
            Gbtn_About.Checked = true;
            Gbtn_Contact.Checked = false;
            Gbtn_Logout.Checked = false;

            /*//Docking Actions
            GraPanel_Home.Dock = DockStyle.None;
            GraPanel_DonateBlood.Dock = DockStyle.None;
            GraPanel_RequestBlood.Dock = DockStyle.None;
            GraPanel_FindDonor.Dock = DockStyle.None;
            GraPanel_MyAccount.Dock = DockStyle.None;
            GraPanel_EditProfile.Dock = DockStyle.None;
            GraPanel_ContactUs.Dock = DockStyle.None;
            GraPanel_About.Dock = DockStyle.Fill;*/
            //Visibility Actions
            GraPanel_Home.Hide();
            GraPanel_DonateBlood.Hide();
            GraPanel_RequestBlood.Hide();
            GraPanel_FindDonor.Hide();
            GraPanel_MyAccount.Hide();
            GraPanel_EditProfile.Hide();
            GraPanel_ContactUs.Hide();
            GraPanel_About.Show();
        }

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Contact Us
        private void Gbtn_Contact_Click(object sender, EventArgs e)
        {
            //Checked Status Change
            Gbtn_Home.Checked = false;
            Gbtn_DonateBlood.Checked = false;
            Gibtn_FindBloodArrow.Checked = false;
            Gbtn_FindBlood.Checked = false;
            Gbtn_RequestBlood.Checked = false;
            Gbtn_FindDonor.Checked = false;
            Gibtn_AccountArrow.Checked = false;
            Gbtn_Account.Checked = false;
            Gbtn_EditProfile.Checked = false;
            Gbtn_ChangePassword.Checked = false;
            Gbtn_About.Checked = false;
            Gbtn_Contact.Checked = true;
            Gbtn_Logout.Checked = false;

            /*//Docking Actions
            GraPanel_Home.Dock = DockStyle.None;
            GraPanel_DonateBlood.Dock = DockStyle.None;
            GraPanel_RequestBlood.Dock = DockStyle.None;
            GraPanel_FindDonor.Dock = DockStyle.None;
            GraPanel_MyAccount.Dock = DockStyle.None;
            GraPanel_EditProfile.Dock = DockStyle.None;
            GraPanel_ContactUs.Dock = DockStyle.Fill;
            GraPanel_About.Dock = DockStyle.None;*/
            //Visibility Actions
            GraPanel_Home.Hide();
            GraPanel_DonateBlood.Hide();
            GraPanel_RequestBlood.Hide();
            GraPanel_FindDonor.Hide();
            GraPanel_MyAccount.Hide();
            GraPanel_EditProfile.Hide();
            GraPanel_ContactUs.Show();
            GraPanel_About.Hide();
        }

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Other Actions
        private void RefreashFlowPanel(FlowLayoutPanel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is MyRequest_Item userControl && FlowPanel_PostGrid.Visible==true)
                {
                    userControl.Width = panel.Width;
                }
                else if (control is My_Donation UserControl && FlowPanel_MyDonation.Visible==true)
                {
                    UserControl.Width = panel.Width;
                }
                else if(control is FindDonor_Item USERControl)
                {
                    USERControl.Width = panel.Width;
                }
                else if(control is DonateBlood_Item userCONTROL)
                {
                    userCONTROL.Width = panel.Width;
                }
            }
        }
        private void Gbtn_Decrease_Click(object sender, EventArgs e)
        {
            int quantity = Int32.Parse(Gtxt_Quantity.Text);
            if (quantity > 1) { quantity--; Gtxt_Quantity.Text = quantity.ToString(); }
        }
        private void Gbtn_Increase_Click(object sender, EventArgs e)
        {
            int quantity = Int32.Parse(Gtxt_Quantity.Text);
            quantity++;
            Gtxt_Quantity.Text = quantity.ToString();
        }
        
        //Redirecting Buttons Click
        private void Gbtn_GetStarted_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/BeVoid313");
        }
        private void SocialButton_Click(object sender, EventArgs e)
        {
            Guna2CircleButton btn = sender as Guna2CircleButton;
            if (btn == social_Facebook || btn==social2_Facebook) { Process.Start("https://www.facebook.com/BeVoid313"); }
            else if (btn == social_linkdin || btn==social2_Linkdin) { Process.Start("https://www.linkedin.com/in/ehrekramul/"); }
            else if (btn == social_twitter || btn==social2_Twitter) { Process.Start("https://twitter.com/EkramulHaqueEHR"); }
            else if (btn == social_youtube || btn==social2_Youtube) { Process.Start("https://www.youtube.com/@Ekramul-Haque"); }
        }

        private void GraPanel_RequestBlood_Click(object sender, EventArgs e)
        {
            if (sidebarExpand == true)
            {
                Timer_Sidebar.Start();
            }
        }

        private void Gbtn_ToggleOn_Click(object sender, EventArgs e)
        {
            DataAccess.ExecuteQuery("UPDATE Donor_Info SET dnrAvailability=0 WHERE dnrID=" + activeUser + ";", out string error);
            if (!string.IsNullOrEmpty(error))
            {
                MultiTask.ShowError(error, "Donor Status Update Error");
                return;
            }
            Gbtn_ToggleOn.Visible = false;
            Gbtn_ToggleOff.Visible = true;
        }

        private void Gbtn_ToggleOff_Click(object sender, EventArgs e)
        {
            DataAccess.ExecuteQuery("UPDATE Donor_Info SET dnrAvailability=1 WHERE dnrID=" + activeUser + ";", out string error);
            if (!string.IsNullOrEmpty(error))
            {
                MultiTask.ShowError(error, "Donor Status Update Error");
                return;
            }
            Gbtn_ToggleOn.Visible = true;
            Gbtn_ToggleOff.Visible = false;
        }
    }
}
