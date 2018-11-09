﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using BeerStore.Classes;
using System.Web.SessionState;
using System.ComponentModel;
using System.Web.UI;
namespace BeerStore.DAL
{
    [DataObject(true)]
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

        public DataSet getProductDetails(int ProductID)
        {

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM Product WHERE productID = " + ProductID + "", con);
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

        public List<Classes.Product> getAllProductsDetails()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Product", con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Classes.Product p = new Classes.Product();
                p.productID = (int)reader["ProductID"];
                p.Name = (string)reader["Name"];
                p.Brand = (string)reader["Brand"];
                p.imagefile = (string)reader["ImageFile"];
                p.price = Convert.ToDouble(reader["Price"]);
                p.longDescription = (string)reader["LongDescription"];
                List.Add(p);
            }
            con.Close();
            return List;

        }
        [DataObjectMethod(DataObjectMethodType.Update)]
        public void productUpdate(int productID, string Name, string Brand, string imagefile, decimal price, string shortDescription, string longDescription)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                string sql = "UPDATE Product SET Name = @Name, "
                    + "Brand = @Brand, "
                    + "ImageFile = @imagefile, "
                    + "Price = @price, "
                    + "LongDescription = @longDescription "
                    + "WHERE ProductID = @productID";
                
                SqlCommand cmd = new SqlCommand(sql, con);
                try
                {
                    SqlParameter paramID = new SqlParameter("@productID", productID);
                    cmd.Parameters.Add(paramID);
                }
                catch(Exception)
                {
                    
                }
                    SqlParameter paramName = new SqlParameter("@Name", Name);
                    cmd.Parameters.Add(paramName);
                    SqlParameter paramBrand = new SqlParameter("@Brand", Brand);
                    cmd.Parameters.Add(paramBrand);
                    SqlParameter paramImage = new SqlParameter("@imagefile", imagefile);
                    cmd.Parameters.Add(paramImage);
                    SqlParameter paramPrice = new SqlParameter("@price", price);
                    cmd.Parameters.Add(paramPrice);
                    SqlParameter paramLong = new SqlParameter("@longDescription", longDescription);
                    cmd.Parameters.Add(paramLong);
                

                
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void productDelete(int productID)
        {
            /*
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                string sql = "DELETE FROM Product WHERE ProductID = @productID";

                SqlCommand cmd = new SqlCommand(sql, con);
                SqlParameter paramID = new SqlParameter("@productID", productID);
                
                cmd.Parameters.Add(paramID);
                con.Open();
                cmd.ExecuteNonQuery();
            }*/

            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Product WHERE ProductID = " + productID + "", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void productInsert(string Name, string Brand, string imagefile, decimal price, string shortDescription, string longDescription)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Product (Name, Brand, ImageFile, Price, LongDescription) VALUES ( @Name, @Brand, @ImageFile, @Price, @LongDescription)", con);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Brand", Brand);
            cmd.Parameters.AddWithValue("@ImageFile", imagefile);
            cmd.Parameters.AddWithValue("@Price", price);
            cmd.Parameters.AddWithValue("@LongDescription", longDescription);
            cmd.ExecuteNonQuery();
            con.Close();
        }
       
        public DataTable displayCart()
        {
            DataTable dt = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT p.productID, p.Brand, p.Name, p.Price, s.ItemQuantity, s.SubTotal FROM Product p, ShoppingCart s" +
                        " WHERE p.productID = s.productID", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public void addToCart(int ProductID, DataTable dt)
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
                    + (getProductPrice(ProductID) * getQuantity(ProductID)) + " WHERE productID = " + ProductID + "", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else {
                SqlCommand cmd = new SqlCommand("INSERT INTO ShoppingCart VALUES (1 ," + ProductID + "," + getProductPrice(ProductID) + ",1)", con);
                cmd.ExecuteNonQuery();
                SqlCommand cmdTotal = new SqlCommand("UPDATE ShoppingCart SET SubTotal =" + (getProductPrice(ProductID) * getQuantity(ProductID)) + "WHERE productID = " + ProductID + "", con);
                con.Open();
                cmdTotal.ExecuteNonQuery();
                con.Close();
            }
        }
        public void createInvoiceID()
        {
            con.Open();
            int id = 0;
            SqlCommand cmdCount = new SqlCommand("SELECT MAX(InvoiceID) FROM Invoice", con);
            if (cmdCount.ExecuteScalar() is DBNull)
            {
                id = 1;
            }
            else
            {
                id = Convert.ToInt32(cmdCount.ExecuteScalar()) + 1;
            }

            SqlCommand cmd = new SqlCommand("INSERT INTO Invoice (InvoiceID) VALUES (" + id + ")", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public int getInvoiceID()
        {
            SqlCommand cmd = new SqlCommand("SELECT MAX(InvoiceID) FROM Invoice", con);
            int ID = Convert.ToInt32(cmd.ExecuteScalar());
            return ID;
        }

        public void createInvoice(int userID, string address, string cardType, long cardNo, DateTime ExpireDate, int CVV)
        {
            con.Open();
            DateTime date = DateTime.Now;
            SqlCommand cmd = new SqlCommand("UPDATE Invoice SET userID = "+userID+", OrderDate = "+ DateTime.Now.ToString("dd/MM/yyyy") +",ShippingAddress = @address, " +
                "CreditCardType = @cardType, CardNumber = "+cardNo+", ExpirationDate = "+ExpireDate.ToString("MM/yyyy")+", CVV = "+CVV+" WHERE InvoiceID = " +getInvoiceID()+ "", con);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@cardType", cardType);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable displayInvoice(int userID)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT p.Brand, p.Name, s.ItemQuantity, s.SubTotal, i.ShippingAddress, i.OrderDate" +
                " FROM Invoice i, ShoppingCart s, Product p, UserAccount u WHERE s.InvoiceID = i.InvoiceID AND u.userID = " + userID + " AND p.ProductID = s.ProductID", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
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
                    //If Database value doesn't exist return 0
                    if (cmd.ExecuteScalar() is DBNull)
                    {
                        sum = 0;
                    }
                    else {
                        sum = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            return " $" + sum.ToString();
        }

        public string getQuantityCount()
        {
            int sum = 0;
            con.Open();
            using (var cmd = new SqlCommand("SELECT SUM(ItemQuantity) FROM ShoppingCart", con))
            {
                if (cmd.ExecuteScalar() is DBNull)
                {
                    sum = 0;
                }
                else
                {
                    sum = Convert.ToInt32(cmd.ExecuteScalar());
                }
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
        public void removeCart()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM ShoppingCart", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void removeCartID(int ProductID)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM ShoppingCart WHERE productID = "+ProductID+"", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable viewPurchaseHistory(int userID)
        {
            //If Invoice has been created from current user, display history
            //Otherwise If count is null return empty table
            con.Open();
            DataTable dt = new DataTable();
            SqlCommand cmdCount = new SqlCommand("SELECT COUNT(i.userId) FROM UserAccount u, Invoice i WHERE u.userId ="+userID+"", con);
            if (cmdCount.ExecuteScalar() is DBNull)
            {
                con.Close();
                return dt;
            }
            else
            {
                SqlCommand cmd = new SqlCommand("SELECT p.Brand, p.Name, s.ItemQuantity, s.SubTotal, i.OrderDate " +
                    "FROM ShoppingCart s, Invoice i, Product p, UserAccount u " +
                    "WHERE i.userID = u.userID AND p.productID = s.productID AND i.userID = " + userID + "", con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(dt);
                con.Close();
                return dt;
            }
        }
    }
}