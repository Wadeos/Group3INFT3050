using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerStore.Classes
{
    public class Cart
    {
        public Cart() { }
        public Cart (Products Product, int quantity)
        {
            this.Products = Product;
            this.Quantity = quantity;
        }
        public Products Products { get; set; }
        public int Quantity { get; set; }

        public void AddQuantity (int quantity)
        {
            this.Quantity += quantity;
        }
    }
}