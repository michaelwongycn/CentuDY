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

namespace CentuDY.View
{
    public partial class ViewUsers : System.Web.UI.Page
    {
        List<User> user;
        protected void Page_Load(object sender, EventArgs e)
        {
            checkUser();
            Load_Grid();
        }
        private void checkUser()
        {
            if (Session["user"] == null)
            {
                Response.Redirect("~/View/Login.aspx");
            }
            else
            {
                int roleId = ((Model.User)Session["user"]).RoleId;
                if (roleId == 2)
                {
                    Response.Redirect("~/View/Home.aspx");
                }
            }
        }

        protected void Load_Grid()
        {
            user = UserController.GetUsers();

            Grid_View_Users.DataSource = user;
            Grid_View_Users.DataBind();
        }

        protected void Grid_View_Users_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            User users = user[e.RowIndex];
            UserController.DeleteUser(users.UserId);
            Load_Grid();
        }
    }
}