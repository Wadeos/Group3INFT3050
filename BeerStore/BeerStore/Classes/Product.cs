using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerStore.Classes
{
    public class Product
    {
        public int productID;
        public string Name;
        public string Brand;
        public string shortDescription { get; set; }
        public string longDescription { get; set; }
        public int categoryID { get; set; }
        public string imageFile { get; set; }
        public double Price { get; set; }
        public int QuantityAvaliable { get; set; }
        public string productManager { get; set; }

        public void setName(string newName)
        {
            HttpContext.Current.Session["Name"] = newName;
        }
        
        public void DisplayProducts()
        {
            setName("Tooheys");
        }
    }
}