using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using BeerStore.DAL;
using System.Web.SessionState;
using System.ComponentModel;

namespace BeerStore.BL
{
    [DataObject(true)]
    public class UserAccountBL
    {
        public DataSet getData()
        {
            ProductsDAL Dal = new ProductsDAL();
            return Dal.getData();
        }
        public DataSet getProductDetails(int ProductID)
        {
            ProductsDAL Dal = new ProductsDAL();
            return Dal.getProductDetails(ProductID);
        }
        public List<Classes.Product> getProducts()
        {
            ProductsDAL Dal = new ProductsDAL();
            return Dal.getProducts();
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Classes.Product> getAllProducts()
        {
            ProductsDAL Dal = new ProductsDAL();
            return Dal.getAllProductsDetails();
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public void updateProduct(int productID, string Name, string Brand, string imagefile, decimal price, string shortDescription, string longDescription)
        {
            ProductsDAL Dal = new ProductsDAL();
            Dal.productUpdate(productID, Name, Brand, imagefile, price, shortDescription, longDescription);
        }
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void deleteProduct(int productID)
        {
            ProductsDAL Dal = new ProductsDAL();
           Dal.productDelete(productID);
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void insertProduct(string Name, string Brand, string imagefile, decimal price, string shortDescription, string longDescription)
        {
            ProductsDAL Dal = new ProductsDAL();
            Dal.productInsert(Name,Brand,imagefile,price,shortDescription,longDescription);
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
        public void addToCart(int InvoiceID, int ProductID, DataTable dt)
        {
            ProductsDAL Dal = new ProductsDAL();
            Dal.addToCart(InvoiceID, ProductID, dt);
        }
        public int getQuantity(int ProductID)
        {
            ProductsDAL Dal = new ProductsDAL();
            return Dal.getQuantity(ProductID);
        }
        public string getSum()
        {
            ProductsDAL Dal = new ProductsDAL();
            return Dal.getSum();
        }
        public string getQuantityCount()
        {
            ProductsDAL Dal = new ProductsDAL();
            return Dal.getQuantityCount();
        }
        public void removeCart()
        {
            ProductsDAL Dal = new ProductsDAL();
            Dal.removeCart();
        }
        public void removeCartID(int ProductID)
        {
            ProductsDAL Dal = new ProductsDAL();
            Dal.removeCartID(ProductID);
        }
    }
}