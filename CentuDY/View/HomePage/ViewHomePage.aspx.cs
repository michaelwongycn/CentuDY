using CentuDY.Controller;
using CentuDY.Handler;
using CentuDY.Model;
using CentuDY.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CentuDY.View.HomePage
{
    public partial class ViewHomePage : System.Web.UI.Page
    {
        protected static List<Role> roles = new List<Role>();
        int UserID;
        protected void Page_Load(object sender, EventArgs e)
        {      
            checkRole();
        }

        protected void BtnViewCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ViewCart.aspx");
        }

        protected void BtnViewTransHistory_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ViewTransHistory.aspx");
        }

        protected void BtnInsertMedicine_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/MedicinePage/InsertMedicine.aspx");
        }

        protected void BtnViewUsers_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ViewUsers.aspx");
        }

        protected void BtnViewTransReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ViewTransReport.aspx");
        }

        private void checkRole()
        {
           int roleId = ((Model.User)Session["user"]).RoleId;
   
           if(roleId==1)
            {
                BtnInsertMedicine.Visible = true;
                BtnViewUsers.Visible = true;
                BtnViewTransReport.Visible = true;
            }
           else if(roleId==2)
            {
                BtnViewCart.Visible = true;
                BtnViewTransHistory.Visible = true;
            }
        }
    }
}