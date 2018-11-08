using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;
using BeerStore.PaymentSystem;
using BeerStore.BL;

namespace BeerStore
{
    public partial class Confirmation : System.Web.UI.Page
    {
        IPaymentSystem paymentSystem = INFT3050PaymentFactory.Create();
        ProductsBL BL = new ProductsBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Button2.Visible = false;
            }
        }
        protected void showTransactionResult(PaymentResult payment)
        {
            resultlbl.Text = payment.TransactionResult.ToString();
            Thread.Sleep(5000);
        }
        protected void confirm()
        {
            try
            {
                PaymentRequest payment = new PaymentRequest();
                payment.CardName = "Arthur Anderson";
                payment.CardNumber = "4444333322221111";
                payment.CVC = 123;
                payment.Expiry = new DateTime(2020, 11, 1);
                payment.Amount = 200;
                payment.Description = "test";

                var task = paymentSystem.MakePayment(payment);
                task.Wait();
                //https://blog.hubilo.com/loading/
                if (task.IsCompleted)
                {
                    showTransactionResult(task.Result);

                }
            }
            catch (Exception ex)
            {
                resultlbl.Text = "Cannot make payment Error : " + ex.Message;
            }
            
        }
        protected void transfer_Click(object sender, EventArgs e)
        {
            Response.Redirect(ConfigurationManager.AppSettings["SecurePath"] + "Approved.aspx");
            Session.Contents.Remove("AddItems");
            BL.removeCart();
        }
    }
}