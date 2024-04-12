using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;


namespace VoidBloodBank
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
            new RoundCornerForm(this);
        }

//Form Closing
        private bool confirmationShown = false;
        private void Gbtn_FormClose_Click(object sender, EventArgs e)
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
            }
        }

        private void Gbtn_FormClose_MouseLeave(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;
            btn.FillColor = Color.White;
            btn.ForeColor = Color.Black;
        }
        private void Gbtn_FormClose_MouseHover(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;
            btn.FillColor = Color.Red;
            btn.BackColor = Color.Red;
            btn.ForeColor = Color.White;
        }

//Dragable Form
        private bool mouseDown; private Point offset;
        private void Panel_MoveForm_MouseDown(object sender, MouseEventArgs e) { offset.X = e.X; offset.Y = e.Y; mouseDown = true; }
        private void Panel_MoveForm_MouseUp(object sender, MouseEventArgs e) { mouseDown = false; }
        private void Panel_MoveForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }
        //OTP Panel Expand
        bool panelExpand;
        private void Timer_OtpPanel_Tick(object sender, EventArgs e)
        {
            if (panelExpand)
            {
                Panel_Username.Height -= 5;
                if (Panel_Username.Height == Panel_Username.MinimumSize.Height)
                {
                    panelExpand = false;
                    Timer_OtpPanel.Stop();
                }
            }
            else
            {
                Panel_Username.Height += 5;
                if (Panel_Username.Height == Panel_Username.MaximumSize.Height)
                {
                    panelExpand = true;
                    Timer_OtpPanel.Stop();
                }
            }
        }
//Click Actions
        private void Gbtn_GetOtp_Click(object sender, EventArgs e)
        {
//Sending OTP
            if (Gtxt_Username.ReadOnly==false)
            {
//Checking if user available in db or not
                string inputUser = Gtxt_Username.Text;

                DataTable data = DataAccess.GetDataTable("SELECT userID,userEmail FROM User_Info WHERE (userName='" + inputUser + "');", out string error);

                if (!string.IsNullOrEmpty(error)) //if got error in db side
                {
                    MultiTask.ShowError(error);
                    return;
                }
                
                if (data.Rows.Count == 0)
                {
                    MultiTask.ShowError("Enter Valid Username","User Not Found");
                    Gtxt_Username.BorderColor = Color.Red;
                    Gtxt_Username.Focus();
                    return;
                }
                string userID = data.Rows[0]["userID"].ToString(); //userID from db
                string userEmail= data.Rows[0]["userEmail"].ToString(); //userEmail from db

                //Sending OTP to email address
                Mail.SendOTP(userEmail, out string otp, out error);

                if (!string.IsNullOrEmpty(error)) //if got error in sendimg email
                {
                    MultiTask.ShowError(error);
                    return;
                }

//Storing active user id in db
                DataAccess.ExecuteQuery("INSERT INTO Active_User(auID) VALUES ("+userID+");", out error);
                if (!string.IsNullOrEmpty(error)) //if got error in db side
                {
                    MultiTask.ShowError(error);
                    return;
                }

//Storing OTP in db
                DataAccess.ExecuteQuery("INSERT INTO OTP_Message(otp) VALUES ("+otp+");", out error);
                if (!string.IsNullOrEmpty(error)) //if got error in db side
                {
                    MultiTask.ShowError(error);
                    return;
                }


                //Showing success
                Panel_OtpSentMessage.Visible = true;
//Make username txt field readonly
                Timer_OtpPanel.Start();
                Gtxt_Username.ReadOnly = true;
                Gtxt_Username.Enabled = false;
                Gtxt_Username.TabStop = false;
                Gtxt_OTP.Focus();
                Gbtn_GetOtp.Text = "Verify";
                return;
            }

//Checking OTP
            string inputOTP = Gtxt_OTP.Text;

            DataTable dt = DataAccess.GetDataTable("SELECT * FROM OTP_Message;", out string error1);

            if (!string.IsNullOrEmpty(error1)) //if got error in db side
            {
                MultiTask.ShowError(error1);
                return;
            }
            string OTP = dt.Rows[0]["otp"].ToString(); //otp from db

            if (inputOTP != OTP)
            {
                MultiTask.ShowError("Enter a Valid OTP", "Invalid OTP");
                Gtxt_OTP.BorderColor = Color.Red;
                Gtxt_OTP.Focus();
                return;
            }

            Panel_NewPass.Visible = true;
            Timer_NewPass.Start();
            FLP_OtpPanel.Visible = false;
            Gtxt_NewPass.Focus();
        }
        private void Gbtn_Cancel_Click(object sender, EventArgs e)
        {
            DataAccess.CleanActiveUser();
            this.Hide();
            new Login().Show();
        }
        private void OtpButtons_TextChanges(object sender, EventArgs e)
        {
            Guna2TextBox txt = sender as Guna2TextBox;
            txt.BorderColor = Color.DarkGray;
        }
        
        bool passPanelExpand;
        private void Timer_NewPass_Tick(object sender, EventArgs e)
        {
            if (passPanelExpand)
            {
                Panel_NewPass.Height -= 5;
                if (Panel_NewPass.Height <= Panel_NewPass.MinimumSize.Height)
                {
                    passPanelExpand = false;
                    Timer_NewPass.Stop();
                }
            }
            else
            {
                Panel_NewPass.Height += 5;
                if (Panel_NewPass.Height >= Panel_NewPass.MaximumSize.Height)
                {
                    passPanelExpand = true;
                    Timer_NewPass.Stop();
                }
            }
        }
        private void OtpButtons_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Gbtn_GetOtp.PerformClick();
            }
        }
        private void Cb_ShowPass_Click(object sender, EventArgs e)
        {
            if (Cb_ShowPass.Checked == true)
            {
                Gtxt_ConfirmPass.UseSystemPasswordChar = false;
                Gtxt_ConfirmPass.PasswordChar = Gtxt_OTP.PasswordChar;
                Gtxt_NewPass.UseSystemPasswordChar = false;
                Gtxt_NewPass.PasswordChar = Gtxt_OTP.PasswordChar;
            }
            else
            {
                Gtxt_ConfirmPass.UseSystemPasswordChar = true;
                Gtxt_NewPass.UseSystemPasswordChar = true;
            }
        }
        private void Gbtn_ChangePass_Click(object sender, EventArgs e)
        {
            string newPass = Gtxt_NewPass.Text;
            string confirmPass = Gtxt_ConfirmPass.Text;

            if (string.IsNullOrEmpty(newPass) || string.IsNullOrEmpty(confirmPass))
            {
                MultiTask.ShowError("Enter Valid Password", "Empty Field");
                return;
            }
            if (newPass.Length < 5) //Check password length
            {
                MessageBox.Show("Password length should be minimum 5", "Invalid Password", MessageBoxButtons.OK);
                return;
            }
            if (newPass != confirmPass)
            {
                MultiTask.ShowError("Password doesn't matched", "Wrong Password");
                return;
            }
            DataTable data = DataAccess.GetDataTable("SELECT * FROM Active_User;", out string error);

            if (!string.IsNullOrEmpty(error)) //if got error in db side
            {
                MultiTask.ShowError(error);
                return;
            }

            string activeUser = data.Rows[0]["auID"].ToString(); //userID from db
            DataAccess.ExecuteQuery("UPDATE User_Info SET userPassword='" + newPass + "' WHERE (userID = " + activeUser + ");", out error);
            if (!string.IsNullOrEmpty(error)) //if got error in db side
            {
                MultiTask.ShowError(error);
                return;
            }

            MessageBox.Show("Password Successfully Changed", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DataAccess.CleanActiveUser();
            this.Hide();
            new Login().Show();
        }
        private void Gtxt_ConfirmPass_TextChanged(object sender, EventArgs e)
        {
            string newPass = Gtxt_NewPass.Text;
            string confirmPass = Gtxt_ConfirmPass.Text;

            if (newPass != confirmPass)
            {
                Lbl_Matching.Visible = true;
            }
            else
            {
                Lbl_Matching.Visible = false;
            }
        }
        private void Gtxt_ConfirmPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Gbtn_ChangePass.PerformClick();
            }
        }
    }
}
