﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BeerStore.DAL;
using System.Data;
using BeerStore.BL;

namespace BeerStore.UL
{
    public partial class _default : System.Web.UI.Page
    {
        ProductsBL p = new ProductsBL();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void searchbutton_Click(object sender, EventArgs e)
        {
     
        }
    }
}