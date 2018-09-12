using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerStore.Classes
{
    public class Product
    {
        public int productID { get; set; }
        public string Name;
        public string Brand { get; set; }
        public string shortDescription { get; set; }
        public string longDescription { get; set; }
        public int categoryID { get; set; }
        public string imageFile { get; set; }
        public double Price { get; set; }
        public int QuantityAvaliable { get; set; }
        public string productManager { get; set; }

        public Product()
        {
            setName("Tooheys");
        }
            
        public void setName(string newName)
        {
            HttpContext.Current.Session["Name"] = newName;
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