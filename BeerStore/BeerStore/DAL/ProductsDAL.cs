using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using BeerStore.Classes;
using System.Web.SessionState;

namespace BeerStore.DAL
{
    public class Product
    {
        //creates values to be inserted into the product data
        public int productID { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string imagefile { get; set; }
        public double price { get; set; }
        public string shortDescription { get; set; }
        public string longDescription { get; set; }
    }

    public class ProductsDAL
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        List<Product> List = new List<Product>();
        List<CartList> cartItems = new List<CartList>();
        DataSet ds = new DataSet();
        DataView dv = new DataView();

        public DataSet getData()
        {

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM Product", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            con.Close();
            return ds;
        }

        public List<Product> getProducts()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Name FROM Product", con);
            SqlDataReader reader = cmd.ExecuteReader() ;
            Product p = new Product();
            while (reader.Read())
            {
                p.Name = (string)reader["Name"];
                List.Add(p);
            }
            con.Close();
            return List;

        }
        public string getProductName(int ID)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Name FROM Product WHERE productID = " + ID + "", con);
            SqlDataReader reader = cmd.ExecuteReader();
            Product p = new Product();
            while (reader.Read())
            {
                p.Name = (string)reader["Name"];
                List.Add(p);
            }
            return p.Name;
        }
        public DataSet AddToCart(int ProductID)
        {
                DataSet ds = new DataSet();
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT p.Brand, p.Name, p.Price, s.ItemQuantity FROM Product p, ShoppingCart s" +
                    " WHERE p.productID = " + ProductID + " AND p.productID = s.productID", con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                con.Close();
                return ds;
        }

        public DataSet search(String search)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Product WHERE (Name like '%' + @Name + '%' or Brand like '%' + @Brand + '%')", con);
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = search;
            cmd.Parameters.Add("@Brand", SqlDbType.NVarChar).Value = search;

            cmd.ExecuteNonQuery();

            DataSet searchData = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;
            da.Fill(searchData, "Name");
            da.Fill(searchData, "Brand");
            con.Close();
            return searchData;
        }
    }
}