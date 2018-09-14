using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.SessionState;

namespace BeerStore
{
    public partial class Client : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Displays please login message, buttons that are not required made hidden
            if (Session["Email"] == null)
            {
                emailtxt.Text = "Please Login";
                logoutbtn.Visible = false;
                HyperLink6.Visible = false;

                if (Session["AdminEmail"] == null)
                {
                    emailtxt.Text = "Please Login";
                    logoutbtn.Visible = false;
                    HyperLink6.Visible = false;
                }
                //If user enters valid email displays welcome
                else
                {
                    emailtxt.Text = Session["AdminEmail"].ToString();
                    logoutbtn.Visible = true;
                    HyperLink6.Visible = true;
                    RegisterLink.Visible = false;
                    loginLink.Visible = false;
                }

            }
            else
            {
                emailtxt.Text = Session["Email"].ToString();
                logoutbtn.Visible = true;
                HyperLink6.Visible = false;
                RegisterLink.Visible = false;
                loginLink.Visible = false;
            }


        }
        //Ends session when user logs out
        protected void logoutbtn_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Default.aspx");
        }
    }
}