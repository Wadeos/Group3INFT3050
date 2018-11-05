using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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


    }
}