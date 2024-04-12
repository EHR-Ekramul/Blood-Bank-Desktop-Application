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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            new RoundCornerForm(this);
        }

//Form Closing Confirmation
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

//Hover Action
        private void LBL_Login_MouseHover(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            lbl.Cursor = Cursors.Hand;
            lbl.ForeColor = Color.FromArgb(255, 94, 148, 255);
            lbl.Font = new Font(lbl.Font, FontStyle.Bold);
        }
        private void LBL_Login_MouseLeave(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            lbl.ForeColor = Color.Red;
            lbl.Font = new Font(lbl.Font, FontStyle.Regular);
        }
        
        //Click Action
        private void LBL_Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void Controls_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Gbtn_SignUp.PerformClick();
            }
        }

        private void Gbtn_SignUp_Click(object sender, EventArgs e)
        {
//Fetching data from controls
            string firstName = Gtxt_FirstName.Text.Trim();
            string name = (firstName +" "+ Gtxt_LastName.Text.Trim()).Trim();
            string email = Gtxt_Email.Text.Trim();
            string phone = Gtxt_Phone.Text.Trim();
            string username = Gtxt_Username.Text.Trim();
            string password = Gtxt_Password.Text.Trim();
            string gender = (Rb_Male.Checked) ? "Male" : (Rb_Female.Checked)?"Female":"";
            string bloodGroup = (Gcb_BloodGroup.SelectedIndex == 0) ? "" : Gcb_BloodGroup.SelectedItem.ToString().Trim();
            string dob = Gdtp_DOB.Value.ToString().Split(' ')[0].Trim();
            string country = (Gcb_Country.SelectedIndex == 0) ? "" : Gcb_Country.SelectedItem.ToString().Trim();
            string city = (Gcb_City.SelectedIndex == 0) ? "" : Gcb_City.SelectedItem.ToString().Trim();
            string street = Gtxt_Street.Text.Trim();
            string donorAvailability = (Gbtn_ToggleOn.Visible) ? "1" : "0";
            
//Checking Invalid Inputs
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(bloodGroup) || string.IsNullOrEmpty(country) || string.IsNullOrEmpty(city) || string.IsNullOrEmpty(street)) //check if any field is empty
            {
                MultiTask.ShowError("Enter all the Valid Information", "Empty Field");
                return;
            }
            
            //Invalid Email
            if (!MultiTask.EmailValidation(email)) { MessageBox.Show("Enter a valid Email Address", "Invalid Email"); return; }

            //Check and fix name
            if (!MultiTask.NameValidation(name)) { MessageBox.Show("Enter a valid Name", "Invalid Name"); return; }

            //Invalid Username
            if (username.Length<7 || username.Length > 15) { MessageBox.Show("Username length should be 7-15", "Invalid Username"); return; }
            for(int i=0; i<username.Length; i++) //check if username doesn't contains a-z
            {
                if(username[i]<'a' || username[i] > 'z')
                {
                    MessageBox.Show("Username contains a-z only", "Invalid Username", MessageBoxButtons.OK);
                    return;
                }
            }
            
            //Invalid Password
            if (password.Length < 5) { MessageBox.Show("Password length should be minimum 5", "Invalid Password"); return; }
            
            //Invalid Age //check user age >7
            if (Int32.Parse(dob.Split('-')[2]) >= Int32.Parse(DateTime.Now.ToString().Split(' ')[0].Split('-')[2]) - 7) { MessageBox.Show("Age should be at least 8 years", "Invalid Age"); return; }
            
            //Invalid Street address
            if (street.Length < 4) { MessageBox.Show("Street address length should be minimum 4", "Invalid Street"); return; }
            
            //Invalid phone number
            if (!MultiTask.MobileNumberValidation(phone)) { MessageBox.Show("Enter Valid Phone Number", "Invalid Number"); return; }

           //Checking if username already taken or not
            if (!MultiTask.CheckUsernameAvailability(username))
            {
                MessageBox.Show("Account exist for this username", "Username not Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
           //Checking if eamil already taken or not
            if (!MultiTask.CheckEmailAvailability(email))
            {
                MessageBox.Show("Email already getting used by another user", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            //Everything is OK Now insert data into DB
            /*MessageBox.Show("First Name : "+firstName+
                "\nLast Nmae : "+Gtxt_LastName.Text+
                "\nFull Name :"+name+"\n" +
                "\nEmail : "+email+
                "\nPhone : "+phone+
                "\nUsername : "+username+
                "\nPassword : "+password+
                "\nGender : "+gender+
                "\nBlood Group : "+bloodGroup+
                "\nDate of Birth : "+dob+
                "\nCountry : "+country+
                "\nCity : "+city+
                "\nStreet : "+street+
                "\nDonor Availability : "+donorAvailability);*/

            //Insert in User info table
            DataTable data = DataAccess.GetDataTable("INSERT INTO User_Info(userName, userPassword, userFullName, userGender, userEmail, userPhone, userType) OUTPUT inserted.userID VALUES('" + username + "', '" + password + "', '" + name + "', '" + gender + "', '" + email + "','" + phone + "','general');", out string error);
            if (!string.IsNullOrEmpty(error)) { MultiTask.ShowError(error,"User info insert error");return; } //error in db
            string userID = data.Rows[0]["userID"].ToString();

            //Insert in user address table
            DataAccess.ExecuteQuery("INSERT INTO user_Address(uID, uCity, uCountry, uStreet) VALUES("+userID+", '"+city+"', '"+country+"','"+street+"');", out error);
            if (!string.IsNullOrEmpty(error)) { MultiTask.ShowError(error,"User Address insert error"); return; } //error in db

            //Insert in donor info table
            DataAccess.ExecuteQuery("INSERT INTO Donor_Info(dnrID, dnrBloodGrp, dnrDOB, dnrTotalDonation, dnrAvailability) VALUES("+userID+",'"+bloodGroup+"', '"+dob+"', 0, "+ donorAvailability + ");", out error);
            if (!string.IsNullOrEmpty(error)) { MultiTask.ShowError(error,"Donor info insert error"); return; } //error in db

            //Update Universal Image
            DataAccess.ExecuteQuery("UPDATE User_Info SET userImage = (SELECT Drafting.image FROM Drafting WHERE Drafting.ID=1) WHERE User_Info.userID = "+ userID + ";", out error);
            if (!string.IsNullOrEmpty(error)) { MultiTask.ShowError(error, "Donor info insert error"); return; } //error in db

            //Show Success Message
            MessageBox.Show("Congratulation! Account Created Successfully","Account Created",MessageBoxButtons.OK);
            this.Hide();
            new Login().Show();
        }

        private void Gbtn_ToggleOn_Click(object sender, EventArgs e)
        {
            Gbtn_ToggleOn.Visible = false;
            Gbtn_ToggleOff.Visible = true;
        }
        private void Gbtn_ToggleOff_Click(object sender, EventArgs e)
        {
            Gbtn_ToggleOn.Visible = true;
            Gbtn_ToggleOff.Visible = false;
        }
        private void Gtxt_Username_TextChanged(object sender, EventArgs e)
        {
            string username = Gtxt_Username.Text;

            if (!MultiTask.CheckUsernameAvailability(username))
            {
                Lbl_UsernameTaken.Visible = true;
            }
            else
            {
                Lbl_UsernameTaken.Visible = false;
            }
        }
    }
}
