using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BeerStore.BL;
using System.Data;

namespace BeerStore
{
    public partial class ShoppingCart : System.Web.UI.Page
    {
        ProductsBL BL = new ProductsBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Gridview1.DataSource = Session["AddItems"];

                if (Request.QueryString["id"] != null)
                {
                    DataSet ds = BL.AddToCart(Convert.ToInt32(Request.QueryString["id"]));
                    Gridview1.DataSource = ds;
                    Gridview1.DataBind();
                    Session["AddItems"] = ds;

                }
            }
         
        }
        /*
        protected void grdCategories_PreRender(object sender, EventArgs e)
        {
            if (GridViewShoppingCart.HeaderRow != null)
                GridViewShoppingCart.HeaderRow.TableSection = TableRowSection.TableHeader;
        } */
        protected void btnCheckout_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Payment.aspx");
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            Session.Clear();
        }

    }
}