using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BeerStore
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void grdCategories_PreRender(object sender, EventArgs e)
        {
            if (GridViewPurchaseHistory.HeaderRow != null)
                GridViewPurchaseHistory.HeaderRow.TableSection = TableRowSection.TableHeader;
        }

    }

}