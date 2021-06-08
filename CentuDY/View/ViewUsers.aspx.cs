using CentuDY.Controller;
using CentuDY.Model;
using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace CentuDY.View {
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

        protected void Grid_View_Users_RowCommand(object sender, GridViewCommandEventArgs e) {

            int index = Convert.ToInt32(e.CommandArgument);
            int id = (int)Grid_View_Users.DataKeys[index].Value;

            if (e.CommandName == "Delete") {
                UserController.DeleteUser(id);
            }
        }

        protected void Grid_View_Users_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            Load_Grid();
        }
    }
}