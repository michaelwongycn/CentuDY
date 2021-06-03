using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CentuDY.View
{
    public partial class ViewProfilePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnUpdateProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ProfilePage/UpdateProfile.aspx");
        }

        protected void BtnChangePassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ProfilePage/ChangePassword.aspx");
        }
    }
}