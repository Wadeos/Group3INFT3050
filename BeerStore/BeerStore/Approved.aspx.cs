using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BeerStore.BL;

namespace BeerStore
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        UserAcountBL BL = new UserAcountBL();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect(ConfigurationManager.AppSettings["UnSecurePath"] + "Default.aspx");
        }
        protected void displayInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                //Display invoice of the current user signed in
                GridView1.DataSource = BL.displayInvoice(Convert.ToInt32(Session["UserID"]));
                GridView1.DataBind();
                GridView1.Visible = true;
            }
            catch (Exception ex)
            {
                errorlbl.Text = "Invoice Cannot be displayed Error : " + ex.Message;
            }
        }
    }
}