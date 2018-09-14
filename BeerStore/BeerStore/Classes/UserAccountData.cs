using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace BeerStore.Classes
{
    [DataObject(true)]
    public class UserAccountData
    {

        public UserAccountData()
        {
            u_userAccount.Add(new UserAccount() { userId = 1, email = "wade.carmichael@uon.edu.au", firstName = "Wade", lastName = "Carmichael", phoneNumber = 0449784755, address = "Australia" });
            u_userAccount.Add(new UserAccount() { userId = 2, email = "luke.mckenzie@uon.edu.au", firstName = "Luke", lastName = "Mckenzie", phoneNumber = 0374832991, address = "Australia" });
            u_userAccount.Add(new UserAccount() { userId = 3, email = "nathan.haigh@uon.edu.au", firstName = "Nathan", lastName = "Haigh", phoneNumber = 0457458475, address = "Australia" });

        }

        public List<UserAccount> UserAccounts
        {
            get { return u_userAccount; }
        }


        [DataObjectMethod(DataObjectMethodType.Select)]
        public UserAccount GetUserAccount(int id)
        {
            foreach (UserAccount u in u_userAccount)
            {
                if (u.userId == id)
                    return u;
            }
            return null;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<UserAccount> GetUserAccounts()
        {
            return u_userAccount;
        }


        private List<UserAccount> u_userAccount = new List<UserAccount>();

    }
}