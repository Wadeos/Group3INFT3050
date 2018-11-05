using System;
using System.Collections.Generic;
using System.Configuration;
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
            if (!Request.IsSecureConnection)
            {
                string url =
                    ConfigurationManager.AppSettings["SecurePath"] +
                    "Confirmation.aspx";
                Response.Redirect(url);
            }
        }

        protected void BackButton_Click(object sender, EventArgs e)
        {
            Session.Remove("Payment");
            String url =
                ConfigurationManager.AppSettings["SecurePath"] +
                "Payment.aspx";
            Response.Redirect(url);
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                string url = ConfigurationManager.AppSettings["UnsecurePath"]
                + "Approved.aspx";
                Response.Redirect(url);
            }
        }
    }
}