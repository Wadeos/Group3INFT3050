using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.SessionState;
using BeerStore.BL;

namespace BeerStore.UL
{
    public partial class AdminConfirm : System.Web.UI.Page
    {
        UserAcountBL BL = new UserAcountBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //makes admin via email
                BL.makeAdmin(BL.getAdminEmail());
            }
            catch (Exception ex)
            {
                errorlbl.Text = "Could not activate admin : " + ex.Message;
            }
        }
    }
}