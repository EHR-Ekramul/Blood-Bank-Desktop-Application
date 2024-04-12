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
    public partial class Uc_MyProfile : UserControl
    {
        public Uc_MyProfile()
        {
            InitializeComponent();
        }

        private void Uc_MyProfile_Load(object sender, EventArgs e)
        {
            //My Profile Picture
            DataTable data = DataAccess.GetDataTable("Select * from Active_User", out string error);

            if (!string.IsNullOrEmpty(error)) { MessageBox.Show(error); return; }//Error in db
            //MessageBox.Show("" + data.Rows.Count);

            string activeuser = data.Rows[0]["auID"].ToString();


            //Set all value of controls             
            data = DataAccess.GetDataTable("SELECT userImage FROM User_Info WHERE userID=" + activeuser + ";", out error);
            if (!string.IsNullOrEmpty(error)) { MessageBox.Show(error); return; }//Error in db

            PictureBox_MyProfile.Image = Image.FromStream(new MemoryStream((byte[])data.Rows[0]["userImage"]));



            //My Profile ID,Name, Gender, Blood Group, Email, Dob, phone, salary, joining dt


            //MyProfile Label ID Display
            data = DataAccess.GetDataTable("SELECT userID FROM User_Info WHERE userID=" + activeuser + ";", out error);
            if (!string.IsNullOrEmpty(error)) { MessageBox.Show(error); return; }//Error in db

            Label_MyProfileId.Text = data.Rows[0]["userID"].ToString();



            //MyProfile Label full name Display
            data = DataAccess.GetDataTable("SELECT userFullName FROM User_Info WHERE userID=" + activeuser + ";", out error);
            if (!string.IsNullOrEmpty(error)) { MessageBox.Show(error); return; }//Error in db

            Label_MyProfileName.Text = data.Rows[0]["userFullName"].ToString();


            //MyProfile Label Gender Display
            data = DataAccess.GetDataTable("SELECT userGender FROM User_Info WHERE userID=" + activeuser + ";", out error);
            if (!string.IsNullOrEmpty(error)) { MessageBox.Show(error); return; }//Error in db

            Label_MyProfileGender.Text = data.Rows[0]["userGender"].ToString();


            //MyProfile Street Address Display
            data = DataAccess.GetDataTable("select uStreet from user_Address where uID=" + activeuser + ";", out error);
            if (!string.IsNullOrEmpty(error)) { MessageBox.Show(error); return; }//Error in db

            Label_MyProfileStreetAddress.Text = data.Rows[0]["uStreet"].ToString();


            //MyProfile State Address Display
            data = DataAccess.GetDataTable("Select CONCAT(uCity, ', ', uCountry) as State from user_Address where uID =" + activeuser + ";", out error);
            if (!string.IsNullOrEmpty(error)) { MessageBox.Show(error); return; }//Error in db

            Label_MyProfileStateAddress.Text = data.Rows[0]["State"].ToString();


            //MyProfile Email Display
            data = DataAccess.GetDataTable("select userEmail from User_Info where userID=" + activeuser + ";", out error);
            if (!string.IsNullOrEmpty(error)) { MessageBox.Show(error); return; }//Error in db

            Label_MyProfileEmail.Text = data.Rows[0]["userEmail"].ToString();


            //MyProfile Phone Display
            data = DataAccess.GetDataTable("select userPhone from User_Info where userID=" + activeuser + ";", out error);
            if (!string.IsNullOrEmpty(error)) { MessageBox.Show(error); return; }//Error in db

            Label_MyProfilePhone.Text = data.Rows[0]["userPhone"].ToString();


            //MyProfile Salary Display
            data = DataAccess.GetDataTable("select empSalary from Employee_Info where empID=" + activeuser + ";", out error);
            if (!string.IsNullOrEmpty(error)) { MessageBox.Show(error); return; }//Error in db

            Label_MyProfileSalary.Text = data.Rows[0]["empSalary"].ToString();


            //MyProfile Joining Date Display
            data = DataAccess.GetDataTable("select empJoiningDate from Employee_Info where empID=" + activeuser + ";", out error);
            if (!string.IsNullOrEmpty(error)) { MessageBox.Show(error); return; }//Error in db

            Label_MyProfileJoiningDt.Text = data.Rows[0]["empJoiningDate"].ToString();

        }
    }
}
