using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BeerStore.BL;

namespace BeerStore.UL
{
    public partial class PurchaseHistory : System.Web.UI.Page
    {
        ProductsBL BL = new ProductsBL();

        protected void Page_Load(object sender, EventArgs e)
        {

                //returns purchase history for current user
                GridView1.DataSource = BL.viewPurchaseHistory(Convert.ToInt32(Session["UserID"]));
                GridView1.DataBind();
        }
    }

}