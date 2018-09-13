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
    public class ProductData
    {
         //public System.Web.SessionState.HttpSessionState Session { get; }
         /*
        public string shortDescription { get; set; }
        public string longDescription { get; set; }
        public int categoryID { get; set; }
        public string imageFile { get; set; }
        public double Price { get; set; }
        public int QuantityAvaliable { get; set; }
        public string productManager { get; set; }*/




        public ProductData()
        {
            p_product.Add(new Product() { productID = 1, Name = "Tooheys", Brand = "Tooheys" });
            p_product.Add(new Product() { productID = 2, Name = "Tooheys", Brand = "Tooheys" });
            p_product.Add(new Product() { productID = 3, Name = "Tooheys", Brand = "Tooheys" });
            p_product.Add(new Product() { productID = 4, Name = "Tooheys", Brand = "Tooheys" });
            p_product.Add(new Product() { productID = 5, Name = "Tooheys", Brand = "Tooheys" });
        }

        public List<Product> Products
        {
            get { return p_product; }
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public Product GetProduct(int id)
        {
            foreach(Product p in p_product)
            {
                if (p.productID == id)
                    return p;
            }
            return null;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Product> GetProduct()
        {
            return p_product;
        }

        private List<Product> p_product = new List<Product>();

        /*public Product()
        {
            setName("Tooheys");
        }
            
        public void setName(string newName)
        {
            Session["Name"] = newName;
        }

        /* public List<Product> GetItems()
         {
             List<Product> p = new List<Product>();
             p.Add(new Product("Tooheys", "New"));
             p.Add(new Product("Carlton", "Dry"));
             return p;

         }*/



        
    }


}
