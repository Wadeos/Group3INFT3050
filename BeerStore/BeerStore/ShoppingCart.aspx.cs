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
                DataTable dt = new DataTable();
                DataRow dr;
                if (Request.QueryString["id"] != null)
                {
                    if (Session["AddItems"] == null)
                    {
                        BL.addToCart(1, Convert.ToInt32(Request.QueryString["id"]), 
                            BL.getProductPrice(Convert.ToInt32(Request.QueryString["id"])) * 1, 1, dt);
                        BL.displayCart();
                        Gridview1.DataSource = BL.displayCart();
                        Gridview1.DataBind();
                        Session["AddItems"] = BL.displayCart();
                    }
                    else {
                        dt = (DataTable)Session["AddItems"];
                        BL.addToCart(1, Convert.ToInt32(Request.QueryString["id"]), 
                            BL.getProductPrice(Convert.ToInt32(Request.QueryString["id"])) * 1, 1, dt);
                        BL.displayCart();
                        Gridview1.DataSource = BL.displayCart();
                        Gridview1.DataBind();
                        Session["AddItems"] = BL.displayCart();
                    }
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