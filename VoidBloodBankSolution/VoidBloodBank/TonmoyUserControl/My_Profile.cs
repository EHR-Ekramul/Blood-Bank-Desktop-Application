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
    public partial class My_Profile : UserControl
    {
        public My_Profile()
        {
            InitializeComponent();
        }

        private void My_Profile_Load(object sender, EventArgs e)
        {
            //////My Profile Picture set...

            DataTable data = DataAccess.GetDataTable("SELECT * FROM Active_User", out string error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }

            string activeuser = data.Rows[0]["auID"].ToString();

            data = DataAccess.GetDataTable("SELECT userImage FROM User_Info WHERE userID =" + activeuser + ";", out error);
            if (!String.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }

            G_PicBoxMyPrfil.Image = Image.FromStream(new MemoryStream((byte[])data.Rows[0]["userImage"]));


            //////////////My Profile Name,ID,Gender etc....


            //My Profile Lable Name display Under ImgBox...
            data = DataAccess.GetDataTable("SELECT userFullName FROM User_Info WHERE userID = " + activeuser + ";", out error);
            if (!String.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            LblNmeMyPrfil.Text = data.Rows[0]["userFullName"].ToString();


            //My Profile Lable Name display...
            data = DataAccess.GetDataTable("SELECT userFullName FROM User_Info WHERE userID = " + activeuser + ";", out error);
            if (!String.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            G_lblNameSMyPrfil.Text = data.Rows[0]["userFullName"].ToString();


            //My Profile Lable ID display...
            data = DataAccess.GetDataTable("SELECT userID FROM User_Info WHERE userID=" + activeuser + ";", out error);
            if (!String.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            G_lblIDSMyPrfil.Text = data.Rows[0]["userID"].ToString();


            //MyProfile State Address Display...
            data = DataAccess.GetDataTable("SELECT uStreet from user_Address where uID =" + activeuser + ";", out error);
            if (!String.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            G_lblStreetAddress.Text = data.Rows[0]["uStreet"].ToString();



            //MyProfile Address Display
            data = DataAccess.GetDataTable("Select CONCAT(uCity, ', ', uCountry) as State from user_Address where uID =" + activeuser + ";", out error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            LblStateMyPrfil.Text = data.Rows[0]["State"].ToString();


            //My Profile Email display under imgBox...
            data = DataAccess.GetDataTable("SELECT userEmail from User_Info where userID =" + activeuser + ";", out error);
            if (!String.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            LblEmailMyPrfil.Text = data.Rows[0]["userEmail"].ToString();


            //My Profile Email display ...
            data = DataAccess.GetDataTable("SELECT userEmail from User_Info where userID =" + activeuser + ";", out error);
            if (!String.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            G_lblEmailSMyPrfil.Text = data.Rows[0]["userEmail"].ToString();


            //My Profile Phone display ...
            data = DataAccess.GetDataTable("SELECT userPhone from User_Info where userID=" + activeuser + ";", out error);
            if (!String.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            G_lblPhoneSMyPrfil.Text = data.Rows[0]["userPhone"].ToString();


            //My Profile Phone display ...
            data = DataAccess.GetDataTable("SELECT userPhone from User_Info where userID=" + activeuser + ";", out error);
            if (!String.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            G_lblPhoneSMyPrfil.Text = data.Rows[0]["userPhone"].ToString();


            //My Profile Gender display ...
            data = DataAccess.GetDataTable("SELECT userGender from User_Info where userID=" + activeuser + ";", out error);
            if (!String.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            G_lblGndrSMyPrfil.Text = data.Rows[0]["userGender"].ToString();
        }




    }
}
