using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BeerStore
{
    public partial class Confirmation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BackButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Payment.aspx");
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            Response.Redirect("Approved.aspx");
        }
    }
}