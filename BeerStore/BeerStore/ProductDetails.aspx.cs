using System;
using BeerStore.Classes;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace BeerStore
{
    public partial class ProductDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                //insert session states retrived from products if productID == int;
                if (Convert.ToInt32(Session["ID"]) == 1)
                {
                    Label1.Text = Session["Name"].ToString();
                    Label2.Text = Session["Description"].ToString();
                    Label3.Text = Session["ShortDescription"].ToString();
                    image.ImageUrl = Session["ImageFIle"].ToString();
                }
                if (Convert.ToInt32(Session["ID"]) == 2)
                {
                    Label1.Text = Session["Name"].ToString();
                    Label2.Text = Session["Description"].ToString();
                    Label3.Text = Session["ShortDescription"].ToString();
                    image.ImageUrl = Session["ImageFile"].ToString();
                }
                if (Convert.ToInt32(Session["ID"]) == 3)
                {
                    Label1.Text = Session["Name"].ToString();
                    Label2.Text = Session["Description"].ToString();
                    image.ImageUrl = Session["ImageFile"].ToString();
                    Label3.Text = Session["ShortDescription"].ToString();
            }
           
            
        }

        protected void returnProducts(object sender, EventArgs e)
        {
            Response.Redirect("Products.aspx");
        }
    }
}