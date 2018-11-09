using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BeerStore.BL;
using System.Data;

namespace BeerStore
{
    public partial class ShoppingCart : System.Web.UI.Page
    {
        UserAccountBL BL = new UserAccountBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {

                DataTable dt = new DataTable();
                int ProductID = Convert.ToInt16(Request.QueryString["id"]);

                
                if (Request.QueryString["id"] != null)
                {
                    if (Session["AddItems"] == null)
                    {
                        try
                        {
                            BL.createInvoiceID();
                            BL.addToCart(ProductID, dt);
                            BL.displayCart();
                            Gridview1.DataSource = BL.displayCart();
                            Gridview1.DataBind();
                            Session["AddItems"] = BL.displayCart();
                            dt = (DataTable)Session["AddItems"];
                            Label2.Text = BL.getSum();
                        }
                        catch (Exception ex)
                        {
                            Label1.Text = "Could Not add to cart" + ex.Message;
                        }
                    }
                    else {
                        try
                        {
                            dt = (DataTable)Session["AddItems"];
                            BL.addToCart(ProductID, dt);
                            BL.displayCart();
                            Gridview1.DataSource = BL.displayCart();
                            Gridview1.DataBind();
                            Session["AddItems"] = BL.displayCart();
                            dt = (DataTable)Session["AddItems"];
                            Label2.Text = BL.getSum();
                        }
                        catch (Exception ex)
                        {
                            Label1.Text = "Could not add item to cart" + ex.Message;
                        }
                    }
                }
                else {
                    try
                    {
                        dt = (DataTable)Session["AddItems"];
                        Gridview1.DataSource = BL.displayCart();
                        Gridview1.DataBind();
                        Label2.Text = BL.getSum();
                    }
                    catch (Exception ex)
                    {
                        Label1.Text = "Could not display cart" + ex.Message;
                    }
                }

            }

        }

        protected void btnCheckout_Click1(object sender, EventArgs e)
        {
            string url = ConfigurationManager.AppSettings["SecurePath"]
                + "Payment.aspx";
            Response.Redirect(url);
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                BL.removeCart();
                Session.Contents.Remove("AddItems");
                Response.Redirect(ConfigurationManager.AppSettings["securePath"] + "ShoppingCart.aspx");
            }
            catch (Exception ex)
            {
                Label1.Text = "Could not remove Items from cart" + ex.Message;
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            string url = ConfigurationManager.AppSettings["UnsecurePath"]
                + "Products.aspx";
            Response.Redirect(url);
        }

        protected void Gridview1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //finds row from index of the button
            //uses location of cell to find ID
            try
            {
                if (e.CommandName.Equals("remove"))
                {
                    int index = Convert.ToInt32(e.CommandArgument);
                    GridViewRow selectedRow = Gridview1.Rows[index];
                    string id = selectedRow.Cells[1].Text;
                    BL.removeCartID(Convert.ToInt32(id));
                }
                Response.Redirect(ConfigurationManager.AppSettings["securePath"] + "ShoppingCart.aspx");
            }
            catch (Exception ex)
            {
                Label1.Text = "Could not remove Item" + ex.Message;
            }
        }
    }
}