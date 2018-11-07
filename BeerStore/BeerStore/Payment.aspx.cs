using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BeerStore.Classes;
using BeerStore.PaymentSystem;
using BeerStore.BL;

namespace BeerStore
{
    public partial class Payment : System.Web.UI.Page
    {
        ProductsBL BL = new ProductsBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Request.IsSecureConnection)
            {
                string url =
                    ConfigurationManager.AppSettings["SecurePath"] +
                    "Payment.aspx";
                Response.Redirect(url);
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            BL.createInvoice(Convert.ToInt32(Session["UserID"]), txtAddress1.Text, rblPaymentMethod.SelectedItem.Value.ToString(), 
                Convert.ToInt64(txtCardNumber.Text), txtExpiry.Text, Convert.ToInt16(txtCVV.Text));

             Response.Redirect(ConfigurationManager.AppSettings["SecurePath"] + "Confirmation.aspx");
        }
    }
}