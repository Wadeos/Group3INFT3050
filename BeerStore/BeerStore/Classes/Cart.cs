﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerStore.Classes
{
    public class Cart
    {
        public Cart() { }
        //creates a product inside cart list
        //then gets and sets values
        public Cart (Product Product, int quantity)
        {
            this.Products = Product;
            this.Quantity = quantity;
        }
        public Product Products { get; set; }
        public int Quantity { get; set; }

        //Add quantity when item is added to cart
        public void AddQuantity (int quantity)
        {
            this.Quantity += quantity;
        }
    }
}