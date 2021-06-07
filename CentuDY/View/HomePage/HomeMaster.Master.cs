using CentuDY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CentuDY.View.HomePage
{
    public partial class HomeMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            checkUser();
        }

        protected void ViewMedicines_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ViewMedicine.aspx");
        }

        protected void BtnViewProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ViewProfilePage.aspx");
        }

        protected void BtnLogOut_Click(object sender, EventArgs e)
        {
            Session.Remove("user");
            Session.Abandon();
            Session.Clear();

            if(Request.Cookies["username"] != null && Request.Cookies["password"] != null)
            {
                Response.Cookies["username"].Expires = DateTime.Now.AddDays(-1);
                Response.Cookies["password"].Expires = DateTime.Now.AddDays(-1);
            }
            Response.Redirect("~/View/LoginPage.aspx");
        }

        private void checkUser()
        {
            if(Session["user"] == null)
            {
                if(Request.Cookies["username"] == null)
                {
                    Response.Redirect("~/View/LoginPage.aspx");
                }
                else 
                {
                    string username = Request.Cookies["username"].Value;
                    User user = new User();
                    user.Username = username;
                    Session["user"] = username;
                    UserNameTxt.Text = username;
                }  
            }
            else
            {
                User user = (User)Session["user"];
                UserNameTxt.Text = user.Username;
            }
        }
    }
}