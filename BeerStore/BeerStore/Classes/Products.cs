using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerStore
{
    public class Products
    {
        public int productID { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string shortDescription { get; set; }
        public string longDescription { get; set; }
        public int categoryID { get; set; }
        public string imageFile { get; set; }
        public double Price { get; set; }
        public int QuantityAvaliable { get; set; }
        public string productManager { get; set; }
    }
}