using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerStore.Classes
{
    public class PurchaseHistory
    {
        public int OrderID { get; set; }
        public DateTime Date { get; set; }
        public string Product { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }
        public double Total { get; set; }
    }
}