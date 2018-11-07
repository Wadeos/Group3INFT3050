using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.SessionState;
using BeerStore.BL;

namespace BeerStore
{
    public partial class Login : System.Web.UI.Page
    {
        UserAcountBL BL = new UserAcountBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                int check = BL.confirmLogin(emailtxt.Text, passwordtxt.Text);
                if (check == 1)
                {
                    Session["Email"] = emailtxt.Text;
                    Session["UserID"] = BL.getUserID(emailtxt.Text);
                    Response.Redirect("Default.aspx");
                }
                else
                {
                    errorlbl.Text = "Please Enter Valid User Name And/Or Password";
                }
            }
            catch (Exception ex)
            {
                errorlbl.Text = "Could not login" + ex.Message;
            }
            
        }

        protected void adminPage_Click(object sender, EventArgs e)
        {
                Server.Transfer("AdminLogin.aspx");
        }
    }
}