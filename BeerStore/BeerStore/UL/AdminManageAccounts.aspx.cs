using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BeerStore.UL
{
    public partial class AdminManageAccounts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Request.IsSecureConnection)
            {
                string url =
                    ConfigurationManager.AppSettings["SecurePath"] +
                    "UL/AdminManageAccounts.aspx";
                Response.Redirect(url);
            }
        }

        protected void GridView1_PreRender(object sender,
        EventArgs e)
        {
            if (GridView1.HeaderRow != null)
                GridView1.HeaderRow.TableSection =
                    TableRowSection.TableHeader;
        }

    }
}