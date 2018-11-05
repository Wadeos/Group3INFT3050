using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BeerStore.BL;

namespace BeerStore
{
    public partial class AdminRegister : System.Web.UI.Page
    {
        UserAcountBL BL = new UserAcountBL();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegisterButton_Click(object sender, EventArgs e)
        {
           // BL.registerAccount(1, emailtxt.Text, passwordtxt.Text, fNametxt.Text, lNametxt.Text, Convert.ToInt32(phonetxt.Text), addresstxt.Text);
            Response.Redirect("AdminLogin.aspx");
        }
    }
}