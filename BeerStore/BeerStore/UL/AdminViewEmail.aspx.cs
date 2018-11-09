using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BeerStore.UL
{
    public partial class AdminViewEmail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void return_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminLogin.aspx");
        }

    }
}