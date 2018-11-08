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
        ProductsBL BL = new ProductsBL();
        UserAcountBL UserBL = new UserAcountBL();

        protected void Page_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
=======
            if (!Request.IsSecureConnection)
            {
                string url =
                    ConfigurationManager.AppSettings["SecurePath"] +
                    "Approved.aspx";
                Response.Redirect(url);
            }
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect(ConfigurationManager.AppSettings["UnSecurePath"] + "Default.aspx");
        }
        protected void displayInvoice_Click(object sender, EventArgs e)
        {
>>>>>>> f62f3456171f0da2530b62cf6e06c451aae3723d
            try
            {
                //Display invoice of the current user signed in
                GridView1.DataSource = BL.displayInvoice(Convert.ToInt32(Session["UserID"]));
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                errorlbl.Text = "Invoice Cannot be displayed Error : " + ex.Message;
            }
            //Display current user details
            Repeater1.DataSource = UserBL.displayUserDetails(Convert.ToInt32(Session["UserID"]));
            Repeater1.DataBind();
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect(ConfigurationManager.AppSettings["UnSecurePath"] + "Default.aspx");
        }
        protected void displayInvoice_Click(object sender, EventArgs e)
        {
        }
    }
}