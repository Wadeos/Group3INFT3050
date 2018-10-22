using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerStore.Classes
{
    public class CartList
    {
        private List<Cart> cart;
        //create new cart list from cart class
        public CartList()
        {
            cart = new List<Cart>();
        }

        public int Count
        {
            get { return cart.Count; }
        }
    }
}