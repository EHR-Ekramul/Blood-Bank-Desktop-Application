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

namespace VoidBloodBank.TonmoyUserControl
{
    public partial class Setting : UserControl
    {
        string activeuser;
        public Setting()
        {
            InitializeComponent();
        }


        bool ChangeNameExpand = false;
        private void TimerForName_Tick(object sender, EventArgs e)
        {
            if (ChangeNameExpand)
            {
                NameCngPanel.Height -= 5;
                if (NameCngPanel.Height == NameCngPanel.MinimumSize.Height)
                {
                    ChangeNameExpand = false;
                    TimerForName.Stop();
                }
            }
            else
            {
                NameCngPanel.Height += 5;
                if (NameCngPanel.Height == NameCngPanel.MaximumSize.Height)
                {
                    ChangeNameExpand = true;
                    TimerForName.Stop();
                }
            }
        }

        private void G_BTnChgNme_Click_1(object sender, EventArgs e)
        {
            TimerForName.Start();
        }



        bool ChangePassExpand = false;
        private void TimerForPass_Tick(object sender, EventArgs e)
        {
            if (ChangePassExpand)
            {
                PassCngPanel.Height -= 5;
                if (PassCngPanel.Height == PassCngPanel.MinimumSize.Height)
                {
                    ChangePassExpand = false;
                    TimerForPass.Stop();
                }
            }
            else
            {
                PassCngPanel.Height += 5;
                if (PassCngPanel.Height == PassCngPanel.MaximumSize.Height)
                {
                    ChangePassExpand = true;
                    TimerForPass.Stop();
                }
            }
        }

        private void G_BtnPasscng_Click(object sender, EventArgs e)
        {
            TimerForPass.Start();
        }


        bool ChangeEmailExpand = false;

        private void TimerforEmail_Tick(object sender, EventArgs e)
        {
            if (ChangeEmailExpand)
            {
                EmilCngPanel.Height -= 5;
                if (EmilCngPanel.Height == EmilCngPanel.MinimumSize.Height)
                {
                    ChangeEmailExpand = false;
                    TimerforEmail.Stop();
                }
            }
            else
            {
                EmilCngPanel.Height += 5;
                if (EmilCngPanel.Height == EmilCngPanel.MaximumSize.Height)
                {
                    ChangeEmailExpand = true;
                    TimerforEmail.Stop();
                }
            }
        }

        private void G_BtnEmailcng_Click(object sender, EventArgs e)
        {
            TimerforEmail.Start();
        }


        bool ChangeNumberExpand = false;

        private void TimerForPhone_Tick(object sender, EventArgs e)
        {
            if (ChangeNumberExpand)
            {
                PhoneNmbrCngPanel.Height -= 5;
                if (PhoneNmbrCngPanel.Height == PhoneNmbrCngPanel.MinimumSize.Height)
                {
                    ChangeNumberExpand = false;
                    TimerForPhone.Stop();
                }
            }
            else
            {
                PhoneNmbrCngPanel.Height += 5;
                if (PhoneNmbrCngPanel.Height == PhoneNmbrCngPanel.MaximumSize.Height)
                {
                    ChangeNumberExpand = true;
                    TimerForPhone.Stop();
                }
            }
        }

        private void G_BtnCngPhone_Click(object sender, EventArgs e)
        {
            TimerForPhone.Start();
        }



        private void Setting_Load(object sender, EventArgs e)
        {

            ////Show query
            DataTable data = DataAccess.GetDataTable("Select * From Active_User", out string error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            activeuser = data.Rows[0]["auID"].ToString();


            /////Img
            data = DataAccess.GetDataTable("SELECT userImage FROM User_Info WHERE userID=" + activeuser + ";", out error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            G_PicBoxOfSetting.Image = Image.FromStream(new MemoryStream((byte[])data.Rows[0]["userImage"]));


            ////Show initial name in textBox
            data = DataAccess.GetDataTable("SELECT userFullName FROM User_Info WHERE userID=" + activeuser + ";", out error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            G_TxtNmeChng.Text = data.Rows[0]["userFullName"].ToString();



            data = DataAccess.GetDataTable("SELECT userPassword FROM User_Info WHERE userID=" + activeuser + ";", out error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }



            data = DataAccess.GetDataTable("SELECT userPhone from User_Info where userID=" + activeuser + ";", out error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            G_TxtPhoneNumChng.Text = data.Rows[0]["userPhone"].ToString();



            data = DataAccess.GetDataTable("Select userEmail from User_Info where userID=" + activeuser + ";", out error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            G_TxtEmailchng.Text = data.Rows[0]["userEmail"].ToString();

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        private void G_NameSave_Click(object sender, EventArgs e)
        {
            string userName = (G_TxtFirstName.Text.Trim() + " " + G_TxtConfirmName.Text.Trim()).Trim();

            /*string userFirstName = G_TxtFirstName.Text;
            string userLastName = G_TxtConfirmName.Text;*/

            //Checking Textbox is empty or not
            if (string.IsNullOrEmpty(G_TxtFirstName.Text.Trim()))
            {
                MessageBox.Show("First Name Can't be Empty", "Empty");
                return;
            }




            //Checking if user used same name already given
            DataTable data = DataAccess.GetDataTable("SELECT userFullName FROM User_Info WHERE userFullName='" + userName + "';", out string error);
            if (!string.IsNullOrEmpty(error)) { MessageBox.Show(error, "Error in User Full Name db"); return; }// error in db side

            // if (data.Rows.Count != 0) { MessageBox.Show("Current Name and New Name is Same", "User other Name"); return; }



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

            data = DataAccess.GetDataTable("SELECT * FROM User_Info WHERE userID=" + activeuser + ";", out error);
            if (!string.IsNullOrEmpty(error)) { MessageBox.Show(error, "Error in User Full Name db"); }// error in db side
            LblAName.Text = data.Rows[0]["userFullName"].ToString().Trim();

            G_TxtFirstName.Clear();
            G_TxtConfirmName.Clear();
            G_BTnChgNme.PerformClick();
        }

        private void G_PassSave_Click(object sender, EventArgs e)
        {
            string currentPass = G_TxtPassChng.Text;
            string newPass = G_TxtNewPass.Text;
            string confirmPass = G_TxtConfirmPass.Text;

            //Get current pass from db
            DataTable data = DataAccess.GetDataTable("SELECT userPassword FROM User_Info WHERE userID = " + activeuser + ";", out string error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error, "Error in current password fetch");
                return;
            }

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

            G_TxtNewPass.Clear();
            G_TxtConfirmPass.Clear();
            G_TxtPassChng.Clear();
            G_PassSave.PerformClick();
        }

        private void G_EmailSave_Click(object sender, EventArgs e)
        {
            string userEmail = G_txtNewEmail.Text;

            //Checking Email used by Others or not
            DataTable data = DataAccess.GetDataTable("SELECT * FROM User_Info WHERE userEmail='" + userEmail + "';", out string error);
            if (!string.IsNullOrEmpty(error)) { MessageBox.Show(error, "Error in Email db"); }// error in db side

            if (data.Rows.Count != 0) { MessageBox.Show("Email used by another account", "Email not Available"); return; }


            /* DialogResult result = MessageBox.Show("Do you want to save new Email?", "Save changes confiramtion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             if (result == DialogResult.No)
             {
                 return;
             }*/


            //Validating Email

            //Email Box Empty Checking
            if (string.IsNullOrEmpty(userEmail))
            {
                //MessageBox.Show("Email can't be empty", "Empty");
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

            /*if (data.Rows.Count != 0) 
            {
                MessageBox.Show("Email used by another account", "Email not Available"); return;
            }*/

            DataAccess.ExecuteQuery("UPDATE User_Info SET userEmail = '" + userEmail + "' where (userID = " + activeuser + ");", out error1);
            if (!string.IsNullOrEmpty(error1))
            { MessageBox.Show(error1, "Data update error in Edit Email"); return; }

            MessageBox.Show("Email Changed Successfully", "Changes Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            G_txtNewEmail.Clear();
            G_EmailSave.PerformClick();
        }

        private void G_PhoneSave_Click(object sender, EventArgs e)
        {
            string userPhone = G_TxtNewNumbr.Text;


            //Checking Number used by Others or not
            DataTable data = DataAccess.GetDataTable("SELECT * FROM User_Info WHERE userPhone='" + userPhone + "';", out string error);
            if (!string.IsNullOrEmpty(error)) { MessageBox.Show(error, "Error in Phone db"); }// error in db side

            // if (data.Rows.Count != 0) { MessageBox.Show("Phone Number used by another account", "Phone Number not Available"); return; }


            //Validatiog Number
            if (string.IsNullOrEmpty(userPhone))
            {
                // MessageBox.Show("Enter a valid Number", "Empty");
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

            G_TxtNewNumbr.Clear();
            G_TxtPhoneNumChng.Clear();
            G_PhoneSave.PerformClick();
        }

        private void G_BtnEditPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif)|*.png;*.jpg;*.jpeg;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;
                G_PicBoxOfSetting.Image = Image.FromFile(selectedImagePath);
            }
        }




        private static Guna2CirclePictureBox GunaPicBox;
        private static Label LblAName;

        public static void InitializeImages(Guna2CirclePictureBox a, Label b)
        {
            GunaPicBox = a;
            LblAName = b;
        }
        private void G_BtnSavePicture_Click(object sender, EventArgs e)
        {
            /* DialogResult result = MessageBox.Show("Do you want to save the changes?", "Save changes confiramtion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             if (result == DialogResult.No)
             {
                 return;
             }

             if (G_BtnEditPic.Image == null)
             {
                 MessageBox.Show("Select an Image", "No Image Found"); return;
             }


             DataAccess.UpdateImage(G_BtnEditPic.Image, activeuser, out string error);
             if (!string.IsNullOrEmpty(error))
             {
                 MessageBox.Show(error, "Image update error in Settings change picture");
                 return;
             }

             MessageBox.Show("Image Saved Successfuly", "Changes Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);*/

            //Set all value of controls
            DialogResult result = MessageBox.Show("Do you want to save the changes?", "Save changes confiramtion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            if (G_PicBoxOfSetting.Image == null)
            {
                MessageBox.Show("Select an Image", "No Image Found"); return;
            }



            //Updating Image in DB
            DataAccess.UpdateImage(G_PicBoxOfSetting.Image, activeuser, out string error);
            if (!string.IsNullOrEmpty(error)) { MessageBox.Show(error, "Image update error in Settings change picture"); return; }


            MessageBox.Show("Image Saved Successfully", "Changes Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DataTable data = DataAccess.GetDataTable("SELECT userImage FROM User_Info WHERE userID=" + activeuser + ";", out error);
            if (!string.IsNullOrEmpty(error)) { MessageBox.Show(error); return; }//Error in db

            GunaPicBox.Image = Image.FromStream(new MemoryStream((byte[])data.Rows[0]["userImage"]));
        }
    }
}
