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
    public class ProductsBL
    {
        //Passes data between UL and Data access layers
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
        public void addToCart(int ProductID, DataTable dt)
        {
            ProductsDAL Dal = new ProductsDAL();
            Dal.addToCart(ProductID, dt);
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
        public void createInvoiceID()
        {
            ProductsDAL Dal = new ProductsDAL();
            Dal.createInvoiceID();
        }
        public void createInvoice(int userID, string address, string cardType, long cardNo, DateTime ExpireDate, int CVV)
        {
            ProductsDAL Dal = new ProductsDAL();
            Dal.createInvoice(userID, address, cardType, cardNo, ExpireDate, CVV);
        }
        public DataTable displayInvoice(int userID)
        {
            ProductsDAL Dal = new ProductsDAL();
            return Dal.displayInvoice(userID);
        }
        public DataTable viewPurchaseHistory(int userID)
        {
            ProductsDAL Dal = new ProductsDAL();
            return Dal.viewPurchaseHistory(userID);
        }
    }
}