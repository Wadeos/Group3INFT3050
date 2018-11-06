using BeerStore.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.SessionState;
using System.Data;
using BeerStore.BL;
using System.Configuration;

namespace BeerStore
{
    public partial class Product : System.Web.UI.Page
    {
        ProductsBL BL = new ProductsBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    DataSet ds = BL.getData();

                    Repeater1.DataSource = BL.getData();
                    Repeater1.DataBind();
                }
                catch (Exception ex)
                {
                    errorlbl.Text = "Error : " + ex.Message;
                }
            }
        }

        protected void searchbutton_Click(object sender, EventArgs e)
        {
            try {
                Repeater1.DataSource = BL.search(searchBar.Text);
                Repeater1.DataBind();
            }
            catch (Exception ex)
            {
                errorlbl.Text = "Error : " + ex.Message;
            }
        }

        protected void btn_showAll(object sender, EventArgs e)
        {
            try
            {
                Repeater1.DataSource = BL.getData();
                Repeater1.DataBind();
            }
            catch (Exception ex)
            {
                errorlbl.Text = "Error : " + ex.Message;
            }
        }
        //redirects when certain button or image is clicked
        //either will add to cart or show product details
        protected void Repeater1_ItemCommand1(object source, RepeaterCommandEventArgs e)
        {
            try
            {
                if (!Request.IsSecureConnection)
                {
                    if (e.CommandName == "Add")
                    {
                        Response.Redirect(ConfigurationManager.AppSettings["SecurePath"] + "ShoppingCart.aspx?id=" + e.CommandArgument.ToString());
                    }
                    else
                    {
                        Response.Redirect("ProductDetails.aspx?id=" + e.CommandArgument.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                errorlbl.Text = "Error : " + ex.Message;
            }
            

        }
      
    }
}