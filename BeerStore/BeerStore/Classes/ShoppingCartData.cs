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
    public class ShoppingCartData
    {
        //create shopping cart list
        private List<ShoppingCart> p_cart = new List<ShoppingCart>();

        public ShoppingCartData()
        {
            p_cart.Add(new ShoppingCart() { Product = "Corona, Extra Beer Bottles 355mL", Price = "$25 per pack of 6", Quantity = 7, Total = "$175" });
        }
        //get Shopping cart
        public List<ShoppingCart> ShoppingCart
        {
            get { return p_cart; }
        }
        //return shopping cart
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<ShoppingCart> GetShoppingCart()
        {
            return p_cart;
        }
    }
}