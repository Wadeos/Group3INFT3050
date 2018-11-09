using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BeerStore.BL;

namespace BeerStore
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        UserAcountBL BL = new UserAcountBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            int check = BL.confirmLogin(emailtxt.Text, passwordtxt.Text);
            int status = BL.getAdminStatus(emailtxt.Text);
            if (check == 1 && status == 1)
            {
                Session["AdminEmail"] = emailtxt.Text;
                Response.Redirect("Default.aspx");
            }
            else
            {
                errorlbl.Text = "Please Enter Valid User Name And/Or Password";
            }
        }
    }
}