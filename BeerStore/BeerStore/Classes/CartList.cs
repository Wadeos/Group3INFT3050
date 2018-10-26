using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerStore.Classes
{
    public class CartList
    {
        private List<Cart> cartList;
        //create new cart list from cart class
        public CartList()
        {
            cartList = new List<Cart>();
        }

        public int Count
        {
            get { return cartList.Count; }
        }

        public static CartList getCart()
        {
            CartList cart = (CartList)HttpContext.Current.Session["Cart"];
            if (cart == null)
                HttpContext.Current.Session["Cart"] = new CartList();
            return (CartList)HttpContext.Current.Session["Cart"];

        }
        public void AddItem(Product Product, int Quantity)
        {
            Cart c = new Cart(Product, Quantity);
            cartList.Add(c);
        }
        public void RemoveAt(int Index)
        {
            cartList.RemoveAt(Index);
        }
        public void clearCart()
        {
            cartList.Clear();
        }
    }
}