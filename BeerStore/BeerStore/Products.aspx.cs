﻿using BeerStore.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.SessionState;
using System.Data;
using BeerStore.BL;

namespace BeerStore
{
    public partial class Product : System.Web.UI.Page
    {
        ProductsBL BL = new ProductsBL();
        DataRow dr;

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                DataSet ds = BL.getData();

                Repeater1.DataSource = BL.getData();
                Repeater1.DataBind();
            }
        }

        protected void searchbutton_Click(object sender, EventArgs e)
        {
                Repeater1.DataSource = BL.search(searchBar.Text);
                Repeater1.DataBind();
        }

        protected void btn_showAll(object sender, EventArgs e)
        {
            Repeater1.DataSource = BL.getData();
            Repeater1.DataBind();
        }
        //redirects when certain button or image is clicked
        //either will add to cart or show product details
        protected void Repeater1_ItemCommand1(object source, RepeaterCommandEventArgs e)
        {
            if(e.CommandName == "Add")
            {
                Response.Redirect("ProductDetails.aspx?id=" + e.CommandArgument.ToString());
            }
            else{
                Response.Redirect("ShoppingCart.aspx?id=" + e.CommandArgument.ToString());
            }
        }
    }
}