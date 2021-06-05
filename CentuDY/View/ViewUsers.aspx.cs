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
            Load_Grid();
        }
        protected void Load_Grid()
        {
            user = UserHandler.GetUsers();
           
            Grid_View_Medicine.DataSource = user;
            Grid_View_Medicine.DataBind();
        }

        protected void Grid_View_Medicine_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            User users = user[e.RowIndex];
            UserController.DeleteUser(users.UserId);
            Load_Grid();
        }
    }
}