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
        List<Classes.UserAccount> List = new List<Classes.UserAccount>();
        public List<UserAccount> getAllUsersDetails()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM UserAccount", con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                UserAccount user = new UserAccount();
                user.userId = (int)reader["userId"];
                user.email = (string)reader["Email"];
                user.userPassword = (string)reader["UserPassword"];
                user.firstName = (string)reader["FirstName"];
                user.lastName = (string)reader["LastName"];
                user.phoneNumber = (int)reader["PhoneNumber"];
                user.userAddress = (string)reader["userAddress"];
                List.Add(user);
            }
            con.Close();
            return List;

        }

        public void userAccountUpdate(int userId, string Email, string userPassword, string FirstName, string LastName, int PhoneNumber, string userAddress)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                string sql = "UPDATE UserAccount SET Email = @Email, "
                    + "userPassword = @userPassword, "
                    + "FirstName = @FirstName, "
                    + "LastName = @LastName, "
                    + "PhoneNumber = @PhoneNumber, "
                    + "userAddress = @userAddress "
                    + "WHERE userId = @userId";

                SqlCommand cmd = new SqlCommand(sql, con);

                SqlParameter paramID = new SqlParameter("@userId", userId);
                cmd.Parameters.Add(paramID);
                SqlParameter paramEmail = new SqlParameter("@Email", Email);
                cmd.Parameters.Add(paramEmail);
                SqlParameter paramPassword = new SqlParameter("@userPassword", userPassword);
                cmd.Parameters.Add(paramPassword);
                SqlParameter paramFirst = new SqlParameter("@FirstName", FirstName);
                cmd.Parameters.Add(paramFirst);
                SqlParameter paramLast = new SqlParameter("@LastName", LastName);
                cmd.Parameters.Add(paramLast);
                SqlParameter paramPhone = new SqlParameter("@PhoneNumber", PhoneNumber);
                cmd.Parameters.Add(paramPhone);
                SqlParameter paramAddress = new SqlParameter("@userAddress", userAddress);
                cmd.Parameters.Add(paramAddress);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void userAccountDelete(int userId)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM UserAccount WHERE userId = " + userId + "", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void userAccountInsert(string Email, string userPassword, string FirstName, string LastName, int PhoneNumber, string userAddress)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO UserAccount (Email, userPassword, FirstName, LastName, PhoneNumber, userAddress) VALUES ( @Email, @userPassword, @FirstName, @LastName, @PhoneNumber, @userAddress)", con);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@userPassword", userPassword);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
            cmd.Parameters.AddWithValue("@userAddress", userAddress);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}