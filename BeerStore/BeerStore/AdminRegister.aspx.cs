using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BeerStore.BL;
using System.Net.Mail;

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
            try
            {
                //register non-admin account
                BL.registerAccount(emailtxt.Text, passwordtxt.Text, fNametxt.Text, lNametxt.Text, Convert.ToInt32(phonetxt.Text), addresstxt.Text);

                SmtpClient smtpClient = new SmtpClient("localhost");

                smtpClient.UseDefaultCredentials = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;

                MailMessage mail = new MailMessage();
                mail.IsBodyHtml = true;
                mail.From = new MailAddress("test@gmail.com", "BeerStore");
                mail.To.Add(new MailAddress(emailtxt.Text));
                mail.Body = "Click this link to active account <a href=\"http://localhost:9621/AdminConfirm.aspx\">Activate</a>";
                mail.Subject = "Confirm Account";

                smtpClient.Send(mail);

                Response.Redirect("~/AdminViewEmail.aspx");
            }
            catch (Exception ex)
            {
                lblError.Text = "Could not send message : " + ex.Message;
            }
        }
    }
}