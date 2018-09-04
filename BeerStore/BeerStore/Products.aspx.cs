using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BeerStore
{
    public partial class Products1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Products p1 = new Products();
            p1.productID = 1;
            p1.Name = "Old Dark Ale";
            p1.Brand = "Tooheys";
            p1.categoryID = 1;
            p1.Price = 10.50;
            p1.QuantityAvaliable = 10;
            p1.shortDescription = "Light Beverage";
            p1.imageFile = "~/Images/64871-1.png";

            ProductCategory c1 = new ProductCategory();
            c1.categoryID = 1;
            c1.productType = "beer";

            ProductCategory c2 = new ProductCategory();
            c2.categoryID = 2;
            c2.productType = "wine";

            beerName.Text = p1.Name;
            categoryType.Text= c1.productType;
            beerDescription.Text = p1.Brand;
        }
    }
}