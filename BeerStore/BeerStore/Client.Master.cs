using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.SessionState;
using System.Data;

namespace BeerStore
{
    public partial class Client : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds;
            ds = (DataSet)Session["AddItems"];
            if (ds == null)
            {
                cartCount.Text = 0.ToString();
            }
            else{
                cartCount.Text = ds.Tables[0].Rows.Count.ToString();
            }

            if (Session["Email"] == null)
            {
                //Displays please login message
                emailtxt.Text = "Please Login";
                //links hidden and visible depending on user login status
                logoutbtn.Visible = false;
                HyperLink6.Visible = false;
                HyperLink7.Visible = false;
                HyperLink8.Visible = false;

                if (Session["AdminEmail"] == null)
                {
                    emailtxt.Text = "Please Login";
                    logoutbtn.Visible = false;
                    HyperLink6.Visible = false;
                    HyperLink7.Visible = false;
                    HyperLink8.Visible = false;
                }
                //If user enters valid email displays welcome
                else
                {
                    emailtxt.Text = Session["AdminEmail"].ToString();
                    logoutbtn.Visible = true;
                    HyperLink6.Visible = true;
                    RegisterLink.Visible = false;
                    loginLink.Visible = false;
                    HyperLink7.Visible = true;
                    HyperLink8.Visible = true;
                }

            }
            else
            {
                emailtxt.Text = Session["Email"].ToString();
                logoutbtn.Visible = true;
                HyperLink6.Visible = false;
                RegisterLink.Visible = false;
                loginLink.Visible = false;
                HyperLink7.Visible = false;
                HyperLink8.Visible = true;
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