﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerStore.Classes
{
    public class Product
    {
        public int productID { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string image { get; set; }
        public double price { get; set; }
    }
}