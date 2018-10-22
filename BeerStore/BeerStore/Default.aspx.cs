using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BeerStore.DAL;
using BeerStore.BL;

namespace BeerStore
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductsBL p = new ProductsBL();
            this.GridView1.DataSource = p.GetProducts();
        }

        protected void searchbutton_Click(object sender, EventArgs e)
        {
     
        }
    }
}