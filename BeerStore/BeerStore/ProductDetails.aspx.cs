using System;
using BeerStore.Classes;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace BeerStore
{
    public partial class ProductDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                
        }

        protected void returnProducts(object sender, EventArgs e)
        {
            Response.Redirect("Products.aspx");
        }
    }
}