using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace VoidBloodBank
{
    internal static class MultiTask
    {
        public static void ShowError(string error, string title="Something Went Wrong")
        {
            MessageBox.Show(error, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static bool CheckEmailAvailability(string userEmail)
        {
            DataTable data = DataAccess.GetDataTable("SELECT * FROM User_Info WHERE userEmail='" + userEmail + "';", out string error);
            if (!string.IsNullOrEmpty(error)) { MultiTask.ShowError(error); }// error in db side

            if (data.Rows.Count == 0) { return true; }
            else { return false; }
        }
        public static bool CheckUsernameAvailability(string username)
        {
            DataTable data = DataAccess.GetDataTable("SELECT * FROM User_Info WHERE userName='" + username + "';", out string error);
            if (!string.IsNullOrEmpty(error)) { MultiTask.ShowError(error); return false; }// error in db side

            if (data.Rows.Count == 0) { return true; }
            else { return false; }
        }
        public static string GetGreetings()
        {
            int hour = DateTime.Now.Hour;

            if (hour >= 6 && hour < 12)
            {
                return "Good Morning";
            }
            else if (hour >= 12 && hour < 17)
            {
                return "Good Afternoon";
            }
            else
            {
                return "Good Evening";
            }
        }
        public static bool MobileNumberValidation(string mobile)
        {
            for(int i=0; i < mobile.Length; i++)
            {
                if(mobile[i]<'0' || mobile[i] > '9')
                {
                    return false;
                }
            }

            string mobileCode = mobile.Substring(0, 3);
            if (mobile.Length != 11 || mobileCode == "010" || mobileCode == "011" || mobileCode == "012") //Wrong phone number
            {
                return false;
            }

            return true;
        }
        public static bool EmailValidation(string email)
        {
            string[] arrEmail = email.Split('@');

            if (arrEmail.Length != 2)
            {
                return false;
            }

            //Useless Maybe
            int countAt = 0;
            for(int i=0; i<email.Length; i++)
            {
                if (email[i] == '@') { countAt++; }
                if (countAt > 1) { return false; }
            }
            if (countAt < 1) { return false; }

            return true;
        }
        public static bool NameValidation(string NAME)
        {
            string name = NAME.ToLower();
            for (int i = 0; i < name.Length; i++)
            {
                if(name[i]<'a' || name[i] > 'z')
                {
                    if (name[i] != ' ')
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
