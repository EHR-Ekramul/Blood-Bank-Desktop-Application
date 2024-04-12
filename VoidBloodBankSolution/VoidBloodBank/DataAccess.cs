using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VoidBloodBank
{
    internal static class DataAccess
    {
        //Sql database object with Connection string
        readonly private static SqlConnection dbConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\PROJECT\Sources\Database\VoidDataBase.mdf;Integrated Security=True;Connect Timeout=30");


        //Get 1 DataTable
        public static DataTable GetDataTable(string query, out string error)
        {
            try
            {
                dbConnection.Open(); //Open Database database

                SqlCommand command = new SqlCommand(query, dbConnection);
                SqlDataAdapter adp = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];

                dbConnection.Close(); //Close Database database
                error = "";
                return dt;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null;
            }
        }

        //Execute Select, Update, Delete Query
        public static void ExecuteQuery(string query, out string error)
        {
            try
            {
                dbConnection.Open(); //Open Database database

                SqlCommand command = new SqlCommand(query, dbConnection);
                command.ExecuteNonQuery();

                dbConnection.Close(); //Close Database database
                error = "";
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
        }
    
        //Update user Profile Image
        public static void UpdateImage(Image userImage, string activeUser, out string error)
        {
            try
            {
                byte []byteImage = (byte[])new ImageConverter().ConvertTo(userImage, typeof(byte[]));

                dbConnection.Open(); //Open Database Connection

                SqlCommand cmd = new SqlCommand("UPDATE User_Info SET userImage = @image WHERE userID = "+activeUser+";", dbConnection);
                cmd.Parameters.AddWithValue("@image", byteImage);
                cmd.ExecuteNonQuery();

                dbConnection.Close();//Close Database Connection
                error = "";
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
        }
        public static void CleanActiveUser() //clean adctive user and otp table in db
        {
            //Cleaning OTP db
            DataAccess.ExecuteQuery("DELETE FROM OTP_Message;", out string error);
            if (!string.IsNullOrEmpty(error)) //if got error in db side
            {
                MultiTask.ShowError(error);
                return;
            }

            //Cleaning active user db
            DataAccess.ExecuteQuery("DELETE FROM Active_User;", out error);
            if (!string.IsNullOrEmpty(error)) //if got error in db side
            {
                MultiTask.ShowError(error);
                return;
            }
        }
    }
}
