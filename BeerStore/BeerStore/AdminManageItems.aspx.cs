using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BeerStore
{
    public partial class AdminManageItems: System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Request.IsSecureConnection)
            {
                string url =
                    ConfigurationManager.AppSettings["SecurePath"] +
                    "AdminManageItems.aspx";
                Response.Redirect(url);
            }
        }

        public override void VerifyRenderingInServerForm(Control control)
        {
            //
        }


    }
}