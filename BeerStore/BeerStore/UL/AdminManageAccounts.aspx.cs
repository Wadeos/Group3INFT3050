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
    public partial class AdminManageAccounts : System.Web.UI.Page
    {
        
        UserAcountBL BL = new UserAcountBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Request.IsSecureConnection)
            {
                string url =
                    ConfigurationManager.AppSettings["SecurePath"] +
                    "UL/AdminManageAccounts.aspx";
                Response.Redirect(url);
            }
        }

        protected void GridView1_PreRender(object sender,
        EventArgs e)
        {
            try
            {
                if (GridView1.HeaderRow != null)
                    GridView1.HeaderRow.TableSection =
                        TableRowSection.TableHeader;
            }
            catch (Exception ex)
            {
                errorlbl2.Text = "Could not display user accounts : " + ex.Message;
            }
        }


        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName.Equals("Delete"))
                {
                    int index = Convert.ToInt32(e.CommandArgument);
                    GridViewRow selectedRow = GridView1.Rows[index];
                    string id = selectedRow.Cells[2].Text;
                    BL.deleteUserAccount(Convert.ToInt32(id));
                    Response.Redirect(ConfigurationManager.AppSettings["securePath"] + "UL/AdminManageAccounts.aspx");
                }
            }
            catch (Exception ex)
            {
                errorlbl2.Text = "Could not delete : " + ex.Message;
            }

        }

        protected void InsertButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(UserID.Text);
                string email = Email.Text;
                string password = Password.Text;
                string first = FirstName.Text;
                string last = LastName.Text;
                int phone = Convert.ToInt32(PhoneNumber.Text);
                string address = Address.Text;
                BL.insertUserAccount(id, email, password, first, last, phone, address);
                Response.Redirect(ConfigurationManager.AppSettings["securePath"] + "UL/AdminManageAccounts.aspx");
            }
            catch (Exception ex)
            {
                errorlbl.Text = "Error Inserting Please check for correct data types : " + ex.Message;
            }
        }
    }
}