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
    public class ProductData
    {
     
        //creates a list, adds products to new list
        public ProductData()
        {
            p_product.Add(new Product() { productID = 1, Name = "Old Dark Ale", Brand = "Tooheys", imagefile="Images/old.PNG",price = 16.00, shortDescription = "4.3%, 350mL", longDescription = "Tooheys Old is a robustly flavoured Ale made with top fermentation Ale yeast. The beer is lightly hopped, and gets its darker colour from black malt." });
            p_product.Add(new Product() { productID = 2, Name = "New", Brand = "Tooheys", imagefile = "Images/new.PNG", price = 18.00, shortDescription = "4.6%, 350mL", longDescription = "Back in the 1860s, brothers John and James Toohey, started their legendary brewery. Through hard work and determination their name and their recipes live on. Toohey's New is now an iconic Australian BBQ beer. No artificial additives or preservatives. Serve ice cold." });
            p_product.Add(new Product() { productID = 3, Name = "Dry", Brand = "Carlton", imagefile = "Images/dry.png", price = 45.00, shortDescription = "4.5%, 350mL", longDescription = "Carlton Dry''s extended brewing process removes excess sugars creating a smooth, crisp finish with lower carbohydrates than a full strength beer. A clean, crisp and incredibly refreshing lager that is perfect drinking in the summer sunshine or equally at home." });
            p_product.Add(new Product() { productID = 4, Name = "Ligera", Brand = "Corona", imagefile = "", price = 45.00, longDescription = "" });
            p_product.Add(new Product() { productID = 5, Name = "Original", Brand = "Great Northern Brewing Company", imagefile = "", price = 43.00, longDescription = "" });
        }
        //gets product data list
        public List<Product> Products
        {
            get { return p_product; }
        }
        //returns product row based on prodcut ID
        [DataObjectMethod(DataObjectMethodType.Select)]
        public Product GetProduct(int id)
        {
            foreach(Product p in p_product)
            {
                if (p.productID == id)
                    return p;
                    
            }
            return null;
        }
        //returns all products
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Product> GetProducts()
        {
            return p_product;
        }

        private List<Product> p_product = new List<Product>();

        
    }


}
