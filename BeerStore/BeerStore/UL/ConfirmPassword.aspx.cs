using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BeerStore.BL;

namespace BeerStore.UL
{
    public partial class ConfirmPassword : System.Web.UI.Page
    {
        UserAcountBL BL = new UserAcountBL();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void confirmPassword_Click(object sender, EventArgs e)
        {
            try
            {
                //Checks if user exists then updates password
                BL.updatePassword(emailtxt.Text, confirmtxt.Text);
                Response.Redirect("Login.aspx");
            }
            catch (Exception ex)
            {
                errorlbl.Text = "Could not update password : " + ex.Message;
            }
        }

    }
}