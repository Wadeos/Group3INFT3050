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

        public void registerAccount(int userID, string email, string userPassword, string firstName, string lastName, int phoneNumber, string userAddress)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO UserAccount Values (@userId, @email, @userPassword, @firstName, @lastName, @phone, @userAddress)", con);
            cmd.Parameters.AddWithValue("@userID", userID);
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
    }
}