using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using BeerStore.DAL;

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
        public string getProductName()
        {
            ProductsDAL Dal = new ProductsDAL();
            return Dal.getProductName(1);
        }
        public DataSet search(string search)
        {
            ProductsDAL Dal = new ProductsDAL();
            return Dal.search(search);
        }
        public DataTable getProductRow(int ProductID)
        {
            ProductsDAL Dal = new ProductsDAL();
            return Dal.AddToCart(ProductID);
        }
    }
}