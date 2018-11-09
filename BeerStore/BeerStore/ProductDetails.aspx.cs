using System;
using BeerStore.Classes;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BeerStore.BL;
using System.Data;


namespace BeerStore
{
    public partial class ProductDetails : System.Web.UI.Page
    {
        ProductsBL BL = new ProductsBL();
        protected void Page_Load(object sender, EventArgs e)
        {
              if(!IsPostBack)
            {
                productDetails.DataSource = BL.getProductDetails(Convert.ToInt16(Request.QueryString["id"]));
                productDetails.DataBind();
                
            }
        }

        protected void returnProducts(object sender, EventArgs e)
        {
            Response.Redirect("Products.aspx");
        }
    }
}