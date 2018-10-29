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

    public class ProductsDAL
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        List<Classes.Product> List = new List<Classes.Product>();
        List<CartList> cartItems = new List<CartList>();
        DataSet ds = new DataSet();

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

        public List<Classes.Product> getProducts()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Name FROM Product", con);
            SqlDataReader reader = cmd.ExecuteReader();
            Classes.Product p = new Classes.Product();
            while (reader.Read())
            {
                p.Name = (string)reader["Name"];
                List.Add(p);
            }
            con.Close();
            return List;

        }
        public double getProductPrice(int ID)
        {
            SqlCommand cmd = new SqlCommand("SELECT Price FROM Product WHERE productID = " + ID + "", con);
            SqlDataReader reader = cmd.ExecuteReader();
            Classes.Product p = new Classes.Product();
            while (reader.Read())
            {
                p.price = Convert.ToDouble(reader["Price"]);
                List.Add(p);
            }
            reader.Close();
            return p.price;
        }
        public DataTable displayCart()
        {
            DataTable dt = new DataTable();
                 con.Open();
                SqlCommand cmd = new SqlCommand("SELECT p.Brand, p.Name, p.Price, s.ItemQuantity, s.SubTotal FROM Product p, ShoppingCart s" +
                            " WHERE p.productID = s.productID", con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(dt);
                con.Close();
            return dt;
        }

        public void addToCart(int InvoiceID, int ProductID, DataTable dt)
        {
            con.Open();
            SqlCommand cmdExists = new SqlCommand("SELECT COUNT(s.productID) FROM ShoppingCart s, Product p WHERE p.productID = @productID AND p.productID = s.productID", con);
            cmdExists.Parameters.AddWithValue("@productID", ProductID);
            int Exists = (int)cmdExists.ExecuteScalar();
            if (Exists > 0)
            {
                int quantity = getQuantity(ProductID) + 1;
                setQuantity(ProductID, quantity);
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE ShoppingCart SET ItemQuantity = " + quantity + ", SubTotal = " 
                    + (getProductPrice(ProductID) * getQuantity(ProductID)) +" WHERE productID = " + ProductID + "", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else {
                SqlCommand cmd = new SqlCommand("INSERT INTO ShoppingCart VALUES (" + InvoiceID + "," + ProductID + "," + getProductPrice(ProductID) + ",1)", con);
                cmd.ExecuteNonQuery();
                SqlCommand cmdTotal = new SqlCommand("UPDATE ShoppingCart SET SubTotal =" + (getProductPrice(ProductID) * getQuantity(ProductID))+ "WHERE productID = "+ProductID+"", con);
                con.Open();
                cmdTotal.ExecuteNonQuery();
                con.Close();   
            }
        }

        public int getQuantity(int ProductID)
        {
            SqlCommand cmd = new SqlCommand("SELECT ItemQuantity FROM ShoppingCart WHERE productID = "+ProductID+"", con);
            int quantity = (int)cmd.ExecuteScalar();
            con.Close();
            return quantity;
        }
        public int setQuantity(int ProductID, int Quantity)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE ShoppingCart SET ItemQuantity ="+ Quantity +" WHERE productID = " + ProductID + "", con);
            cmd.ExecuteNonQuery();
            con.Close();
            return Quantity;
        }
        public string getSum()
        {
            int sum = 0;
                con.Open();
                using (var cmd = new SqlCommand("SELECT SUM(SubTotal) FROM ShoppingCart", con))
                {
                    sum = Convert.ToInt32(cmd.ExecuteScalar());
                }
            return " $" + sum.ToString();
        }

        public string getQuantityCount()
        {
            int sum = 0;
            con.Open();
            using (var cmd = new SqlCommand("SELECT SUM(ItemQuantity) FROM ShoppingCart", con))
            {
                sum = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return sum.ToString();
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