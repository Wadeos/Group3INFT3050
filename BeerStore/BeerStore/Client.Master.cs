using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.SessionState;
using BeerStore.BL;
using System.Data;
using System.Configuration;

namespace BeerStore
{
    public partial class Client : System.Web.UI.MasterPage
    {
        UserAccountBL BL = new UserAccountBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            string unsecured = ConfigurationManager.AppSettings["UnsecurePath"];
            string secured = ConfigurationManager.AppSettings["securePath"];

            //unsecures/secures all links from navagation menu
            defaultLink.NavigateUrl = unsecured + "Default.aspx";
            aboutLink.NavigateUrl = unsecured + "About.aspx";
            contactLink.NavigateUrl = unsecured + "Contact.aspx";
            productsLink.NavigateUrl = unsecured + "Products.aspx";
            manageLink.NavigateUrl = secured + "AdminManageItems.aspx";
            manageAccountLink.NavigateUrl = secured + "AdminManageAccounts.aspx";
            HyperLink8.NavigateUrl = secured + "PurchaseHistory.aspx";
           HyperLink4.NavigateUrl = secured + "ShoppingCart.aspx";

            DataTable dt;
            dt = (DataTable)Session["AddItems"];
            if (dt == null)
            {
                cartCount.Text = 0.ToString();
            }
            else{
                cartCount.Text = BL.getQuantityCount();
            }

            if (Session["Email"] == null)
            {
                //Displays please login message
                emailtxt.Text = "Please Login";
                //links hidden and visible depending on user login status
                logoutbtn.Visible = false;
                manageLink.Visible = false;
                manageAccountLink.Visible = false;
                HyperLink8.Visible = false;

                if (Session["AdminEmail"] == null)
                {
                    emailtxt.Text = "Please Login";
                    logoutbtn.Visible = false;
                    manageLink.Visible = false;
                    manageAccountLink.Visible = false;
                    HyperLink8.Visible = false;
                }
                //If user enters valid email displays welcome
                else
                {
                    emailtxt.Text = Session["AdminEmail"].ToString();
                    logoutbtn.Visible = true;
                    manageLink.Visible = true;
                    RegisterLink.Visible = false;
                    loginLink.Visible = false;
                    manageAccountLink.Visible = true;
                    HyperLink8.Visible = true;
                }

            }
            else
            {
                emailtxt.Text = Session["Email"].ToString();
                logoutbtn.Visible = true;
                manageLink.Visible = false;
                RegisterLink.Visible = false;
                loginLink.Visible = false;
                manageAccountLink.Visible = false;
                HyperLink8.Visible = true;
            }


        }
        //Ends session when user logs out
        protected void logoutbtn_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            string url = ConfigurationManager.AppSettings["UnsecurePath"]
                + "Default.aspx";
            Response.Redirect(url);
        }
    }
}