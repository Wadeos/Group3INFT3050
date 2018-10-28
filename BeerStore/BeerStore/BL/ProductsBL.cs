using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using BeerStore.DAL;
using System.Web.SessionState;

namespace BeerStore.BL
{

    public class ProductsBL
    {
        public DataSet getData()
        {
            ProductsDAL Dal = new ProductsDAL();
            return Dal.getData();
        }
        public List<DAL.Product> getProducts()
        {
            ProductsDAL Dal = new ProductsDAL();
            return Dal.getProducts();
        }
        public double getProductPrice(int ProductID)
        {
            ProductsDAL Dal = new ProductsDAL();
            return Dal.getProductPrice(ProductID);
        }
        public DataSet search(string search)
        {
            ProductsDAL Dal = new ProductsDAL();
            return Dal.search(search);
        }
        public DataTable displayCart()
        {
            ProductsDAL Dal = new ProductsDAL();
            return Dal.displayCart();
        }
        public void addToCart(int InvoiceID, int ProductID, double price, int quantity, DataTable dt)
        {
            ProductsDAL Dal = new ProductsDAL();
            Dal.addToCart(InvoiceID, ProductID, price, quantity, dt);
        }
    }
}