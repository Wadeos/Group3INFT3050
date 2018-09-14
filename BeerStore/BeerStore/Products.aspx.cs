using BeerStore.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BeerStore
{
    public partial class Product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                ProductData p = new ProductData();
                var p1 = p.GetProduct(1);
                var p2 = p.GetProduct(2);
                var p3 = p.GetProduct(3);
                //Inserting data into the table
                //Product 1
                nametxt.Text = p1.Name;
                brandtxt.Text = p1.Brand;
                price.Text = "$"+ p1.price.ToString();
                image.ImageUrl = p1.imagefile;
                //Product 2
                nametxt1.Text = p2.Name;
                brandtxt1.Text = p2.Brand;
                price1.Text = "$" + p2.price.ToString();
                image1.ImageUrl = p2.imagefile;
                //Product 3
                nametxt2.Text = p3.Name;
                brandtxt2.Text = p3.Brand;
                price2.Text = "$" + p3.price.ToString();
                image2.ImageUrl = p3.imagefile;

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Add to Cart
        }

        protected void searchbutton_Click(object sender, EventArgs e)
        {
            //Search for products
        }

        protected void displayMore(object sender, EventArgs e)
        {
            if(image.UniqueID != null)
            {
                Session["Name"] = nametxt.Text;
            }

        }
    }
}