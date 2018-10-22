using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace BeerStore.DAL
{
    public class ProductsDAL
    {
        public string connection = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
    }
}