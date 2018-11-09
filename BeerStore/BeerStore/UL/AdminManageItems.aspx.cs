using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BeerStore.BL;

namespace BeerStore.UL
{
    public partial class AdminManageItems: System.Web.UI.Page
    {
        ProductsBL BL = new ProductsBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Request.IsSecureConnection)
            {
                string url =
                    ConfigurationManager.AppSettings["SecurePath"] +
                    "UL/AdminManageItems.aspx";
                Response.Redirect(url);
            }
            
            
            
        }

        public override void VerifyRenderingInServerForm(Control control)
        {
            //
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //finds row from index of the button
            //uses location of cell to find ID
            /*if (e.CommandName.Equals("Insert"))
            {
                GridViewRow footerRow = GridView1.FooterRow;
                string name = footerRow.Cells[3].Text;
                string brand = footerRow.Cells[4].Text;
                string image = footerRow.Cells[5].Text;
                decimal price = Convert.ToDecimal(footerRow.Cells[6].Text);
                string shortDes = footerRow.Cells[7].Text;
                string longDes = footerRow.Cells[8].Text;
                BL.insertProduct(name,brand,image,price,shortDes,longDes);
                //Response.Redirect(ConfigurationManager.AppSettings["securePath"] + "AdminManageItems.aspx");
            }*/
            if (e.CommandName.Equals("Delete"))
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow selectedRow = GridView1.Rows[index];
                string id = selectedRow.Cells[2].Text;
                BL.deleteProduct(Convert.ToInt32(id));
                Response.Redirect(ConfigurationManager.AppSettings["securePath"] + "UL/AdminManageItems.aspx");
            }
            
        }


        protected void InsertButton_Click(object sender, EventArgs e)
        {
            int productID = Convert.ToInt32(ProductID.Text);
            string name = Name.Text;
            string brand = Brand.Text;
            string imageString = image.Text;
            decimal price = Convert.ToDecimal(Price.Text);
            string shortDes = ShortDescription.Text;
            string longDes = LongDescription.Text;
            BL.insertProduct(productID, name, brand, imageString, price, shortDes, longDes);
            Response.Redirect(ConfigurationManager.AppSettings["securePath"] + "UL/AdminManageItems.aspx");
        }




    }
}