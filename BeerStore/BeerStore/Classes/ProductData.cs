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
            p_product.Add(new Product() { productID = 1, Name = "New", Brand = "Tooheys", imagefile="Images/old.PNG",price = 16.00, longDescription = "4.5%, Tooheys Old is a robustly flavoured Ale made with top fermentation Ale yeast. The beer is lightly hopped, and gets its darker colour from black malt." });
            p_product.Add(new Product() { productID = 2, Name = "Old Dark Ale", Brand = "Tooheys", imagefile = "Images/new.PNG", price = 18.00 });
            p_product.Add(new Product() { productID = 3, Name = "Dry", Brand = "Carlton", imagefile = "Images/dry.png", price = 45.00 });
            p_product.Add(new Product() { productID = 4, Name = "Ligera", Brand = "Corona", imagefile = "", price = 45.00 });
            p_product.Add(new Product() { productID = 5, Name = "Original", Brand = "Great Northern Brewing Company", imagefile = "", price = 43.00 });
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
        public List<Product> GetProducts()
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
