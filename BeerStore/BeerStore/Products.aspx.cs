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
                ProductData pdata1 = new ProductData();
                var p1 = pdata1.GetProduct(1);

                Session["Name"] = p1.Name;
                nametxt.Text = Session["Name"].ToString();
                image.ImageUrl = p1.image;
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
    }
}