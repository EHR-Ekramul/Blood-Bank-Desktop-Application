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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            new RoundCornerForm(this);
        }
//Window Close Confirmation
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
        private bool mouseDown;  private Point offset;
        private void Panel_MoveForm_MouseDown(object sender, MouseEventArgs e) {offset.X = e.X; offset.Y = e.Y; mouseDown = true;}
        private void Panel_MoveForm_MouseUp(object sender, MouseEventArgs e) { mouseDown = false; }
        private void Panel_MoveForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }
        
//Hover Action Listeners
        private void ForgotSignup_MouseHover(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            lbl.Cursor = Cursors.Hand;
            lbl.ForeColor = Color.FromArgb(255, 94, 148, 255);
            lbl.Font = new Font(lbl.Font, FontStyle.Bold);
        }
        private void ForgotSignup_MouseLeave(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            lbl.ForeColor = Color.Red;
            lbl.Font = new Font(lbl.Font, FontStyle.Regular);
        }
        private void HideUnhide_MouseHover(object sender, EventArgs e)
        {
            Guna2ImageButton pb = sender as Guna2ImageButton;
            pb.Cursor = Cursors.Hand;
        }
//Click Action Listeners 
        private void GIBTN_Hide_Click(object sender, EventArgs e)
        {
            Gtxt_Password.UseSystemPasswordChar = false;
            Gtxt_Password.PasswordChar = Gtxt_Username.PasswordChar;
            GIBTN_Hide.Visible = false;
            GIBTN_Unhide.Visible = true;
            Gtxt_Password.Focus();
        }
        private void GIBTN_Unhide_Click(object sender, EventArgs e)
        {
            Gtxt_Password.UseSystemPasswordChar = true;
            GIBTN_Unhide.Visible = false;
            GIBTN_Hide.Visible = true;
            Gtxt_Password.Focus();
        }
        private void LBL_SignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SignUp().Show();
        }
        private void LBL_ForgotPass_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ForgotPassword().Show();
        }
        private void EnterButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Gbtn_Login.PerformClick();
            }
        }

        //Login Button Codes
        private void Gbtn_Login_Click(object sender, EventArgs e)
        {
            string inputUser = Gtxt_Username.Text; //input Username
            string inputPass = Gtxt_Password.Text; //input Password

            if(string.IsNullOrEmpty(inputUser) || string.IsNullOrEmpty(inputPass))
            {
                MultiTask.ShowError("Enter Valid Username or Password", "Wrong Username or Password");
                Gtxt_Username.Focus();
                return;
            }

            //Checking User Info
            DataTable data = DataAccess.GetDataTable("SELECT userID,userType FROM User_Info WHERE (userName='" + inputUser + "' and userPassword='" + inputPass + "');", out string error);
            if (!string.IsNullOrEmpty(error))   {MultiTask.ShowError(error);return;} //if error from db

            if (data.Rows.Count == 0) //error if no user found
            { 
                MultiTask.ShowError("Enter Valid Username or Password", "User Not Found");
                Gtxt_Username.Focus();
                return;
            }

            //Redirecting user to his form if found valid
            string userID = data.Rows[0]["userID"].ToString();
            string userType = data.Rows[0]["userType"].ToString();

            DataAccess.ExecuteQuery("INSERT INTO Active_User(auID) VALUES(" + userID + ");", out error);//Writing active user
            if (!string.IsNullOrEmpty(error)) { MultiTask.ShowError(error); return; } //if error from db

            //Opening new form
            this.Hide();
            if (userType == "admin") { new AdminPanel().Show(); }
            else if (userType == "emp") { new Employee().Show(); }
            else { new GeneralUser().Show(); }
        }
    }
}
