using BeerStore.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.SessionState;

namespace BeerStore
{
    public partial class Product : System.Web.UI.Page
    {
        ProductData p = new ProductData();

        protected void Page_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD

            if (!IsPostBack)
            {
=======
            
            if (!IsPostBack)
            {
                
>>>>>>> e663dd3292033d653d654295359b1de16215e53c
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

        protected void AddtoCart_Click(object sender, EventArgs e)
        {
            Session["Cart"] = "";
            Response.Redirect("ShoppingCart.aspx");
        }

        protected void searchbutton_Click(object sender, EventArgs e)
        {
            //Search for products
        }

        //create sessions states when product image is selected
        protected void btn1_click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            var p1 = p.GetProduct(1);
            Session["ID"] = p1.productID;
            Session["Name"] = p1.Brand + " "+ p1.Name;
            Session["Description"] = p1.longDescription;
            Session["ShortDescription"] = p1.shortDescription;
            Session["ImageFile"] = p1.imagefile;
            Response.Redirect("ProductDetails.aspx");
=======
>>>>>>> e663dd3292033d653d654295359b1de16215e53c
        }
        protected void btn2_click(object sender, EventArgs e)
        {
            var p2 = p.GetProduct(2);
            Session["ID"] = p2.productID;
            Session["Name"] = p2.Brand + " " + p2.Name;
            Session["Description"] = p2.longDescription;
            Session["ShortDescription"] = p2.shortDescription;
            Session["ImageFile"] = p2.imagefile;
            Response.Redirect("ProductDetails.aspx");
        }
        protected void btn3_click(object sender, EventArgs e)
        {
            var p3 = p.GetProduct(3);
            Session["ID"] = p3.productID;
            Session["Name"] = p3.Brand + " " + p3.Name;
            Session["Description"] = p3.longDescription;
            Session["ShortDescription"] = p3.shortDescription;
            Session["ImageFile"] = p3.imagefile;
            Response.Redirect("ProductDetails.aspx");
        }

    }
}