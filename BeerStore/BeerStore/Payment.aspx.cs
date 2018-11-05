using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BeerStore
{
    public partial class Payment : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Request.IsSecureConnection)
            {
                string url =
                    ConfigurationManager.AppSettings["SecurePath"] +
                    "Payment.aspx";
                Response.Redirect(url);
            }
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                string url = ConfigurationManager.AppSettings["SecurePath"]
                + "Confirmation.aspx";
                Response.Redirect(url);
            }
        }
    }
}