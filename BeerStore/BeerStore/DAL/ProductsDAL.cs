using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BeerStore.DAL
{
    public class ProductsDAL
    {
        string conString = (ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        SqlConnection con = new SqlConnection();
        Product objP = null;
        List<Product> List = new List<Product>();

        public List<Product> Read()
        {
            con.ConnectionString = conString;
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Product", con);

            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                objP = new Product();
                objP.ID = rd.GetValue(0).ToString();
                List.Add(objP);
            }
            return List;
        }
    }
}