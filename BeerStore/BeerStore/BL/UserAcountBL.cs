using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using BeerStore.DAL;
using System.ComponentModel;

namespace BeerStore.BL
{
    [DataObject(true)]
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
        public DataTable displayInvoice(int UserID)
        {
            UsersDAL DAL = new UsersDAL();
            return DAL.DisplayInvoice(UserID);
        }
        public int getUserID(string email)
        {
            UsersDAL DAL = new UsersDAL();
            return DAL.getUserID(email);
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Classes.UserAccount> getUserDetails()
        {
            UsersDAL DAL = new UsersDAL();
            return DAL.getAllUsersDetails();
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public void updateUserAccount(int userId, string Email, string userPassword, string FirstName, string LastName, int PhoneNumber, string userAddress)
        {
            UsersDAL Dal = new UsersDAL();
            Dal.userAccountUpdate(userId,Email,userPassword,FirstName,LastName,PhoneNumber,userAddress);
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void deleteUserAccount(int userId)
        {
            UsersDAL Dal = new UsersDAL();
            Dal.userAccountDelete(userId);
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void insertUserAccount(string Email, string userPassword, string FirstName, string LastName, int PhoneNumber, string userAddress)
        {
            UsersDAL Dal = new UsersDAL();
            Dal.userAccountInsert(Email,userPassword,FirstName,LastName,PhoneNumber,userAddress);
        }
    }
}