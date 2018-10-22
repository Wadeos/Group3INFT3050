using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerStore.Classes
{
    public class UserAccount
    {   //declare user account data to be used in list
        public int userId { get; set; }
        public string email { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int phoneNumber { get; set; }
        public string address { get; set; }
    }
}