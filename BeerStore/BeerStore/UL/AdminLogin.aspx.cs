using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using BeerStore.BL;

namespace BeerStore.UL
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        UserAcountBL BL = new UserAcountBL();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Checking to see whether the account exists
                int check = BL.confirmLogin(emailtxt.Text, passwordtxt.Text);
                //If the user is an admin or not
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
            catch (Exception ex)
            {
                errorlbl.Text = "could not long in : " + ex.Message;
            }
        }
        protected void change_click(object sender, EventArgs e)
        {
            try
            {
                //using localhost to send
                SmtpClient smtpClient = new SmtpClient("localhost");

                smtpClient.UseDefaultCredentials = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                //creating message
                MailMessage mail = new MailMessage();
                mail.IsBodyHtml = true;
                mail.From = new MailAddress("test@gmail.com", "BeerStore");
                mail.To.Add(new MailAddress("test@gmail.com"));
                //using Body Html to create link
                mail.Body = "Click this link to change password <a href=\"http://localhost:9621/UL/AdminPassChange.aspx\">Change</a>";
                mail.Subject = "Change Password";

                smtpClient.Send(mail);
            }
            catch (Exception ex)
            {
                errorlbl.Text = "cannot send message : " + ex.Message;
            }
            errorlbl.Text = "A message has been sent to your account";
        }
    }
}