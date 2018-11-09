using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BeerStore.BL;

namespace BeerStore
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        
        UserAcountBL BL = new UserAcountBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Request.IsSecureConnection)
            {
                string url =
                    ConfigurationManager.AppSettings["SecurePath"] +
                    "AdminManageAccounts.aspx";
                Response.Redirect(url);
            }
        }

        protected void GridView1_PreRender(object sender,
        EventArgs e)
        {
            if (GridView1.HeaderRow != null)
                GridView1.HeaderRow.TableSection =
                    TableRowSection.TableHeader;
        }


        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            if (e.CommandName.Equals("Delete"))
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow selectedRow = GridView1.Rows[index];
                string id = selectedRow.Cells[2].Text;
                BL.deleteUserAccount(Convert.ToInt32(id));
                Response.Redirect(ConfigurationManager.AppSettings["securePath"] + "AdminManageAccounts.aspx");
            }

        }

        protected void InsertButton_Click(object sender, EventArgs e)
        {

            string email = Email.Text;
            string password = Password.Text;
            string first = FirstName.Text;
            string last = LastName.Text;
            int phone = Convert.ToInt32(PhoneNumber.Text);
            string address = Address.Text;
            BL.insertUserAccount(email, password, first, last, phone, address);
            Response.Redirect(ConfigurationManager.AppSettings["securePath"] + "AdminManageAccounts.aspx");
        }
    }
}