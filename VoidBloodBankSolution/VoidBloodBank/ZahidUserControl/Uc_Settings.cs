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
using System.Windows.Forms;

namespace VoidBloodBank.ZahidUserControl
{
    public partial class Uc_Settings : UserControl
    {
        string activeuser;

        [Obsolete]
        public Uc_Settings()
        {
            InitializeComponent();
        }

        bool ChangeNameExpand = false;

        private void ChangeNameTimer_Tick(object sender, EventArgs e)
        {
            if (ChangeNameExpand)
            {
                ChangeNamePanel.Height -= 5;
                if (ChangeNamePanel.Height == ChangeNamePanel.MinimumSize.Height)
                {
                    ChangeNameExpand = false;
                    ChangeNameTimer.Stop();
                }
            }
            else
            {
                ChangeNamePanel.Height += 5;
                if (ChangeNamePanel.Height == ChangeNamePanel.MaximumSize.Height)
                {
                    ChangeNameExpand = true;
                    ChangeNameTimer.Stop();
                }
            }

        }

        private void GBtn_ChangeName_Click(object sender, EventArgs e)
        {
            ChangeNameTimer.Start();

            if (ChangeNameExpand == true)
            {
                TxtBox_FirstName.WaterMark = "Full Name";
            }
            else
            {
                TxtBox_FirstName.WaterMark = "First Name";
            }


        }


        bool ChangePassExpand = false;
        private void ChangePassTimer_Tick(object sender, EventArgs e)
        {
            if (ChangePassExpand)
            {
                ChangePassPanel.Height -= 5;
                if (ChangePassPanel.Height == ChangePassPanel.MinimumSize.Height)
                {
                    ChangePassExpand = false;
                    ChangePassTimer.Stop();
                }
            }
            else
            {
                ChangePassPanel.Height += 5;
                if (ChangePassPanel.Height == ChangePassPanel.MaximumSize.Height)
                {
                    ChangePassExpand = true;
                    ChangePassTimer.Stop();
                }
            }
        }

        private void GBtn_ChangePass_Click(object sender, EventArgs e)
        {
            ChangePassTimer.Start();
        }


        bool ChangeEmailExpand = false;

        private void ChangeEmailTimer_Tick(object sender, EventArgs e)
        {
            if (ChangeEmailExpand)
            {
                Panel_ChangeEmail.Height -= 5;
                if (Panel_ChangeEmail.Height == Panel_ChangeEmail.MinimumSize.Height)
                {
                    ChangeEmailExpand = false;
                    ChangeEmailTimer.Stop();
                }
            }
            else
            {
                Panel_ChangeEmail.Height += 5;
                if (Panel_ChangeEmail.Height == Panel_ChangeEmail.MaximumSize.Height)
                {
                    ChangeEmailExpand = true;
                    ChangeEmailTimer.Stop();
                }
            }
        }
        private void GBtn_ChangeEmail_Click(object sender, EventArgs e)
        {
            ChangeEmailTimer.Start();
        }



        bool ChangeNumberExpand = false;

        private void ChangeNumberTimer_Tick(object sender, EventArgs e)
        {
            if (ChangeNumberExpand)
            {
                ChangeNumberPanel.Height -= 5;
                if (ChangeNumberPanel.Height == ChangeNumberPanel.MinimumSize.Height)
                {
                    ChangeNumberExpand = false;
                    ChangeNumberTimer.Stop();
                }
            }
            else
            {
                ChangeNumberPanel.Height += 5;
                if (ChangeNumberPanel.Height == ChangeNumberPanel.MaximumSize.Height)
                {
                    ChangeNumberExpand = true;
                    ChangeNumberTimer.Stop();
                }
            }
        }

        private void GBtn_ChangeNumber_Click(object sender, EventArgs e)
        {
            ChangeNumberTimer.Start();
        }

        private void Uc_Settings_Load(object sender, EventArgs e)
        {

            DataTable data = DataAccess.GetDataTable("Select * from Active_User", out string error);

            if (!string.IsNullOrEmpty(error)) { MessageBox.Show(error); return; }//Error in db
            //MessageBox.Show("" + data.Rows.Count);

            activeuser = data.Rows[0]["auID"].ToString();


            //Set all value of controls
            data = DataAccess.GetDataTable("SELECT userImage FROM User_Info WHERE userID=" + activeuser + ";", out error);
            if (!string.IsNullOrEmpty(error)) { MessageBox.Show(error); return; }//Error in db

            PictureBox_Settings.Image = Image.FromStream(new MemoryStream((byte[])data.Rows[0]["userImage"]));


            //Settings UserControl

            //Settings TextBox full name Display
            data = DataAccess.GetDataTable("SELECT userFullName FROM User_Info WHERE userID=" + activeuser + ";", out error);
            if (!string.IsNullOrEmpty(error)) { MessageBox.Show(error); return; }//Error in db

            TxtBox_FullName.Text = data.Rows[0]["userFullName"].ToString();


            //Settings TextBox CurrentPassword Display
            data = DataAccess.GetDataTable("SELECT userPassword FROM User_Info WHERE userID=" + activeuser + ";", out error);
            if (!string.IsNullOrEmpty(error)) { MessageBox.Show(error); return; }//Error in db

            // TxtBox_CurrentPass.Text = data.Rows[0]["userPassword"].ToString();


            //Settings TextBox Phone Number Display
            data = DataAccess.GetDataTable("SELECT userPhone from User_Info where userID=" + activeuser + ";", out error);
            if (!string.IsNullOrEmpty(error)) { MessageBox.Show(error); return; }//Error in db

            TxtBox_PhoneNumber.Text = data.Rows[0]["userPhone"].ToString();

            //Settings TextBox Email Number Display
            data = DataAccess.GetDataTable("Select userEmail from User_Info where userID=" + activeuser + ";", out error);
            if (!string.IsNullOrEmpty(error)) { MessageBox.Show(error); return; }

            TxtBox_Email.Text = data.Rows[0]["userEmail"].ToString();


        }

        private void GBtn_ChangePic_Click(object sender, EventArgs e)
        {
            //Image Updating

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif)|*.png;*.jpg;*.jpeg;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;
                PictureBox_Settings.Image = Image.FromFile(selectedImagePath);
            }



        }

        private void GBtn_SavePass_Click(object sender, EventArgs e)
        {

            string currentPass = TxtBox_CurrentPass.Text;
            string newPass = TxtBox_NewPassword.Text;
            string confirmPass = TxtBox_ConfirmPassword.Text;

            //Get current pass from db

            DataTable data = DataAccess.GetDataTable("SELECT userPassword FROM User_Info WHERE userID = " + activeuser + ";", out string error);
            if (!string.IsNullOrEmpty(error)) { MessageBox.Show(error, "Error in current password fetch"); return; }//Error in db


            //Checking NewPassword box is empty or not
            if (string.IsNullOrEmpty(newPass))
            {
                MessageBox.Show("New password can't be Null", "Empty");
                return;
            }
            //Checking Confirm box is empty or not
            if (string.IsNullOrEmpty(confirmPass))
            {
                MessageBox.Show("Confirm Password can't be Null", "Empty");
                return;
            }


            //Validation
            string pass = data.Rows[0]["userPassword"].ToString();
            if (currentPass != pass)
            {
                MessageBox.Show("Enter Valid Current Password", "Wrong Current Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (newPass.Length < 5)
            {
                MessageBox.Show("Password Length should be minimum 5", "Invalid Password Length", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (newPass != confirmPass)
            {
                MessageBox.Show("Enter Correct Confirm Password", "Confirm Password didn't matched");
                return;
            }
            if (currentPass == newPass)
            {
                MessageBox.Show("Current Password and New Password is Same", "Enter different Password");
                return;
            }



            DialogResult result = MessageBox.Show("Do you want to save the Password?", "Save changes confiramtion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }


            //Update Password
            DataAccess.ExecuteQuery("UPDATE User_Info SET userPassword = '" + newPass + "' FROM User_Info WHERE (userID = " + activeuser + ");", out error);
            if (!string.IsNullOrEmpty(error)) { MessageBox.Show(error, "Change password insert error"); return; }

            MessageBox.Show("Password Successfuly Updated", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            TxtBox_NewPassword.Clear();
            TxtBox_ConfirmPassword.Clear();
            TxtBox_CurrentPass.Clear();
            GBtn_ChangePass.PerformClick();

        }

        private void GBtn_Hide_Click(object sender, EventArgs e)
        {

        }


        private bool NameValidation(ref string name)
        {
            name = name.ToLower();
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] < 'a' || name[i] > 'z')
                {
                    if(name[i]!=' ')
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private void GBtn_SaveName_Click(object sender, EventArgs e)
        {

            string userName = (TxtBox_FirstName.Text.Trim() + " " + TxtBox_LastName.Text.Trim()).Trim();


            //Checking Textbox is empty or not
            if (string.IsNullOrEmpty(TxtBox_FirstName.Text.Trim()))
            {
                MessageBox.Show("First Name Can't be Empty", "Empty");
                return;
            }






            //Checking if user used same name already given
            DataTable data = DataAccess.GetDataTable("SELECT userFullName FROM User_Info WHERE userFullName='" + userName + "';", out string error);
            if (!string.IsNullOrEmpty(error)) { MessageBox.Show(error, "Error in User Full Name db"); }// error in db side

            if (data.Rows.Count != 0) { MessageBox.Show("Current Name and New Name is Same", "User other Name"); return; }






            DialogResult result = MessageBox.Show("Do you want to save the New Name?", "Save changes confiramtion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }



            //Updating Name in DB
            DataAccess.ExecuteQuery("UPDATE User_Info SET userFullName = '" + userName + "'WHERE (userID = " + activeuser + ");", out error);
            if (!string.IsNullOrEmpty(error))
            { MessageBox.Show(error, "Data update error in Edit Name"); return; }

            MessageBox.Show("Name Changed Successfully", "Changes Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            TxtBox_FirstName.Clear();
            TxtBox_LastName.Clear();

            data = DataAccess.GetDataTable("SELECT * FROM User_Info WHERE userID=" + activeuser + ";", out error);
            if (!string.IsNullOrEmpty(error)) { MessageBox.Show(error); return; }//Error in db
            name.Text = data.Rows[0]["userFullName"].ToString();
            GBtn_ChangeName.PerformClick();

        }

        private void GBtn_SaveNumber_Click(object sender, EventArgs e)
        {
            string userPhone = TxtBox_NewNumber.Text;


            //Checking Number used by Others or not
            DataTable data = DataAccess.GetDataTable("SELECT * FROM User_Info WHERE userPhone='" + userPhone + "';", out string error);
            if (!string.IsNullOrEmpty(error)) { MessageBox.Show(error, "Error in Phone db"); }// error in db side

            if (data.Rows.Count != 0) { MessageBox.Show("Phone Number used by another account", "Phone Number not Available"); return; }


            //Validatiog Number
            if (string.IsNullOrEmpty(userPhone))
            {
                MessageBox.Show("Enter a valid Number", "Empty");
                return;
            }

            //Number Length check

            //Invalid Phone
            string ValidPhone = userPhone.Substring(0, 3);
            if (ValidPhone == "010" || ValidPhone == "011" || ValidPhone == "012") //Wrong phone number
            {
                MessageBox.Show("Enter Valid Phone Number", "Invalid Number", MessageBoxButtons.OK);
                return;
            }

            //Phone 
            if (userPhone.Length < 0 || userPhone.Length > 11) //check Phone Number lenght
            {
                MessageBox.Show("Phone Number length should be 11 Digit", "Invalid Phone Number", MessageBoxButtons.OK);
                return;
            }
            for (int i = 0; i < userPhone.Length; i++) //check Phone Number doesn't contain 0-9
            {
                if (userPhone[i] < '0' || userPhone[i] > '9')
                {
                    MessageBox.Show("Phone Number contains 0-9 only", "Invalid User Phone", MessageBoxButtons.OK);
                    return;
                }
            }

            //Updating Phone Number
            DataAccess.ExecuteQuery("Update User_Info SET userPhone = '" + userPhone + "' WHERE (userID= " + activeuser + ");", out error);
            if (!string.IsNullOrEmpty(error))
            { MessageBox.Show(error, "Data update error in Edit Phone"); return; }


            DialogResult result = MessageBox.Show("Do you want to save the New Phone Number?", "Save changes confiramtion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            MessageBox.Show("Phone Number Changed Successfully", "Changes Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            TxtBox_NewNumber.Clear();
            TxtBox_PhoneNumber.Clear();
            GBtn_NewNumber.PerformClick();

        }

        private void GBtn_SaveEmail_Click(object sender, EventArgs e)
        {
            string userEmail = TxtBox_NewEmail.Text;

            //Checking Email used by Others or not
            DataTable data = DataAccess.GetDataTable("SELECT * FROM User_Info WHERE userEmail='" + userEmail + "';", out string error);
            if (!string.IsNullOrEmpty(error)) { MessageBox.Show(error, "Error in Email db"); }// error in db side

            if (data.Rows.Count != 0) { MessageBox.Show("Email used by another account", "Email not Available"); return; }


            DialogResult result = MessageBox.Show("Do you want to save new Email?", "Save changes confiramtion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }


            //Validating Email

            //Email Box Empty Checking
            if (string.IsNullOrEmpty(userEmail))
            {
                MessageBox.Show("Email can't be empty", "Empty");
                return;
            }

            //Invalid Email
            string[] arrEmail = userEmail.Split('@').ToArray();
            if (arrEmail.Length != 2)
            {
                MessageBox.Show("Enter a valid Email Address", "Invalid Email", MessageBoxButtons.OK);
                return;
            }


            //Updating Email
            data = DataAccess.GetDataTable("SELECT * FROM User_Info WHERE (userEmail='" + userEmail + "' and userID <> " + activeuser + ");", out string error1);
            if (!string.IsNullOrEmpty(error1))
            { MessageBox.Show(error1, "Data update error in Edit Email"); return; }// error in db side



            DataAccess.ExecuteQuery("UPDATE User_Info SET userEmail = '" + userEmail + "' where (userID = " + activeuser + ");", out error1);
            if (!string.IsNullOrEmpty(error1))
            { MessageBox.Show(error1, "Data update error in Edit Email"); return; }

            MessageBox.Show("Email Changed Successfully", "Changes Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            TxtBox_NewEmail.Clear();
            GBtn_ChangeEmail.PerformClick();
        }

        private static Guna2CirclePictureBox image;
        private static Guna2HtmlLabel name;
        public static void initializeImage(Guna2CirclePictureBox userImage, Guna2HtmlLabel userName)
        {
            image = userImage;
            name = userName;
        }
        private void GBtn_SettingsSaveImage_Click(object sender, EventArgs e)
        {
            //Set all value of controls
            DialogResult result = MessageBox.Show("Do you want to save the changes?", "Save changes confiramtion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            if (PictureBox_Settings.Image == null)
            {
                MessageBox.Show("Select an Image", "No Image Found"); return;
            }



            //Updating Image in DB
            DataAccess.UpdateImage(PictureBox_Settings.Image, activeuser, out string error);
            if (!string.IsNullOrEmpty(error)) { MessageBox.Show(error, "Image update error in Settings change picture"); return; }


            MessageBox.Show("Image Saved Successfully", "Changes Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DataTable data = DataAccess.GetDataTable("SELECT * FROM User_Info WHERE userID=" + activeuser + ";", out error);
            if (!string.IsNullOrEmpty(error)) { MessageBox.Show(error); return; }//Error in db

            image.Image = Image.FromStream(new MemoryStream((byte[])data.Rows[0]["userImage"]));
        }
    }
}
