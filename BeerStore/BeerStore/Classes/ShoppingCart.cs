using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerStore.Classes
{
    public class ShoppingCart
    {   //declare variables to use in shopping cart data
        public string Product { get; set; }
        public string Price { get; set; }
        public int Quantity { get; set; }
        public string Total { get; set; }
    }
}