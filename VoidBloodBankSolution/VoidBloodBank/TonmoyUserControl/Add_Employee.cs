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
    public partial class Add_Employee : UserControl
    {
        public Add_Employee()
        {
            InitializeComponent();
        }

        private void Gbtn_AddnewEmp_SaveChanges_Click(object sender, EventArgs e)
        {
            //Fetching data from controls
            string firstName = Gtxt_firstName.Text.Trim();
            string name = (firstName + " " + Gtxt_LastName.Text).Trim();
            string email = Gtxt_Email.Text.Trim();
            string phone = Gtxt_PhoneNum.Text.Trim();
            string username = Gtxt_UserName.Text.Trim();
            string password = Gtxt_Pass.Text.Trim();
            string gender = (rbtn_Male.Checked) ? "Male" : (rbtn_Female.Checked) ? "Female" : "";
            string country = (CmbCountry.SelectedIndex == 0) ? "" : CmbCountry.SelectedItem.ToString().Trim(); ;
            string city = (CmbCity.SelectedIndex == 0) ? "" : CmbCity.SelectedItem.ToString().Trim();
            string street = Gtxt_StreetAddress.Text.Trim();
            string salary = guna2TextBox1.Text.Trim();

            //Checking Invalid Inputs
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(country) || string.IsNullOrEmpty(city) || string.IsNullOrEmpty(street)) //check if any field is empty
            {
                MultiTask.ShowError("Enter all the Valid Information", "Empty Field");
                return;
            }
            //Invalid Email
            if (!MultiTask.EmailValidation(email))
            {
                MessageBox.Show("Enter a valid Email Address", "Invalid Email", MessageBoxButtons.OK);
                return;
            }
            //Invalid Username
            if (username.Length < 7 || username.Length > 15) //check username lenght
            {
                MessageBox.Show("Username length should be 7-15", "Invalid Username", MessageBoxButtons.OK);
                return;
            }
            for (int i = 0; i < username.Length; i++) //check if username doesn't contains a-z
            {
                if (username[i] < 'a' || username[i] > 'z')
                {
                    MessageBox.Show("Username contains a-z only", "Invalid Username", MessageBoxButtons.OK);
                    return;
                }
            }
            //Check salary
            for (int i = 0; i < salary.Length; i++) //check if username doesn't contains a-z
            {
                if (salary[i] < '0' || salary[i] > '9')
                {
                    MessageBox.Show("Enter Valid Salary", "Invalid Salary", MessageBoxButtons.OK);
                    return;
                }
            }
            //Invalid Password
            if (password.Length < 5) //Check password length
            {
                MessageBox.Show("Password length should be minimum 5", "Invalid Password", MessageBoxButtons.OK);
                return;
            }

            //Invalid Street
            if (street.Length < 4) //Wrong street address length <4
            {
                MessageBox.Show("Street address length should be minimum 4", "Invalid Street", MessageBoxButtons.OK);
                return;
            }
            //Invalid Phone
            if (!MultiTask.MobileNumberValidation(phone)) //Wrong phone number
            {
                MessageBox.Show("Enter Valid Phone Number", "Invalid Number", MessageBoxButtons.OK);
                return;
            }


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

            //Insert in User info table
            DataTable data = DataAccess.GetDataTable("INSERT INTO User_Info(userName, userPassword, userFullName, userGender, userEmail, userPhone, userType) OUTPUT inserted.userID VALUES('" + username + "', '" + password + "', '" + name + "', '" + gender + "', '" + email + "','" + phone + "','emp');", out string error);
            if (!string.IsNullOrEmpty(error)) { MultiTask.ShowError(error, "User info insert error"); return; } //error in db
            string userID = data.Rows[0]["userID"].ToString();

            //Insert in user address table
            DataAccess.ExecuteQuery("INSERT INTO user_Address(uID, uCity, uCountry, uStreet) VALUES(" + userID + ", '" + city + "', '" + country + "','" + street + "');", out error);
            if (!string.IsNullOrEmpty(error)) { MultiTask.ShowError(error, "User Address insert error"); return; } //error in db

            //Insert in donor info table
            DataAccess.ExecuteQuery("INSERT INTO Employee_Info(empID,empSalary) VALUES(" + userID + "," + salary + ");", out error);
            if (!string.IsNullOrEmpty(error)) { MultiTask.ShowError(error, "Employee info insert error"); return; } //error in db



            //Show Success Message
            MessageBox.Show("Congratulation! Employee Added", "Account Created", MessageBoxButtons.OK);
        }





    }
}
