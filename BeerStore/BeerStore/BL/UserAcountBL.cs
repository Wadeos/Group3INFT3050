using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using BeerStore.DAL;

namespace BeerStore.BL
{

    public class UserAcountBL
    {
        public void registerAccount(string email, string userPassword, string firstName, string lastName, int phoneNumber, string userAddress)
        {
            UsersDAL DAL = new UsersDAL();
            DAL.registerAccount(email, userPassword, firstName, lastName, phoneNumber, userAddress);
        }
        public int confirmLogin(string email, string password)
        {
            UsersDAL DAL = new UsersDAL();
            return DAL.confirmLogin(email, password);
        }
        public DataTable displayUserDetails(int userID)
        {
            UsersDAL DAL = new UsersDAL();
            return DAL.displayUserDetails(userID);
        }
        public int getUserID(string email)
        {
            UsersDAL DAL = new UsersDAL();
            return DAL.getUserID(email);
        }
        public void updatePassword(string email, string password)
        {
            UsersDAL DAL = new UsersDAL();
            DAL.updatePassword(email, password);
        }
        public void makeAdmin(string email)
        {
            UsersDAL DAL = new UsersDAL();
            DAL.makeAdmin(email);
        }
        public string getAdminEmail()
        {
            UsersDAL DAL = new UsersDAL();
            return DAL.getAdminEmail();
        }
        public int getAdminStatus(string email)
        {
            UsersDAL DAL = new UsersDAL();
            return DAL.getAdminStatus(email);
        }
    }
}