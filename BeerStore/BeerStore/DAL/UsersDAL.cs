using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using BeerStore.Classes;

namespace BeerStore.DAL
{
    public class UsersDAL
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

        public void registerAccount(string email, string userPassword, string firstName, string lastName, int phoneNumber, string userAddress)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO UserAccount (userID, Email, userPassword, firstName, lastName, PhoneNumber, userAddress)" +
                " Values (" + increaseUserID() + ",@email, @userPassword, @firstName, @lastName, @phone, @userAddress)", con);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@userPassword", userPassword);
            cmd.Parameters.AddWithValue("@firstName", firstName);
            cmd.Parameters.AddWithValue("@lastName", lastName);
            cmd.Parameters.AddWithValue("@phone", phoneNumber);
            cmd.Parameters.AddWithValue("@userAddress", userAddress);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public int confirmLogin(string email, string password)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM UserAccount WHERE userPassword = @password AND Email = @email", con);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@email", email);
            int check = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return check;
        }
        public int increaseUserID()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            int maxID = 0;
            SqlCommand cmd = new SqlCommand("SELECT MAX(userID) FROM UserAccount", con);
            if (cmd.ExecuteScalar() is DBNull)
            {
                maxID = 1;
            }
            else {
                maxID = Convert.ToInt32(cmd.ExecuteScalar());
                maxID = maxID + 1;
            }
            return maxID;
        }
        public int getUserID(string email)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT userID FROM UserAccount WHERE Email = @email", con);
            cmd.Parameters.AddWithValue("@email", email);
            int ID = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            con.Close();
            return ID;
        }
        public DataTable displayUserDetails(int userID)
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT u.FirstName, u.LastName, u.Email, i.ShippingAddress FROM UserAccount u, Invoice i WHERE u.userID = i.userID AND u.userID = "+userID+"", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public void updatePassword(string email, string password)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE UserAccount SET userPassword = @password WHERE Email = @email", con);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void makeAdmin(string email)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE UserAccount SET IsAdmin = 'Y' WHERE Email = @email", con);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public string getAdminEmail()
        {
            con.Open();
            string email = "";
            SqlCommand cmd = new SqlCommand("SELECT MAX(userID) FROM UserAccount", con);
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            SqlCommand cmdString = new SqlCommand("SELECT Email FROM UserAccount WHERE userId="+id+"", con);
            SqlDataReader reader = cmdString.ExecuteReader();
            while (reader.Read())
            {
                email = reader[0].ToString();
            }
            con.Close();
            return email;
        }
        public int getAdminStatus(string email)
        {
            int count = 0;
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(IsAdmin) FROM UserAccount WHERE Email = @Email", con);
            cmd.Parameters.AddWithValue("@Email", email);
            if (cmd.ExecuteScalar() is DBNull)
            {
                count = 0;
            }
            else
            {
                count = 1;
            }
            con.Close();
            return count;

        }
    }
}