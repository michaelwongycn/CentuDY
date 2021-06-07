using CentuDY.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CentuDY.View.ProfilePage
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            checkUser();
        }

        private void checkUser()
        {
            if (Session["user"] == null)
            {
                Response.Redirect("~/View/LoginPage.aspx");
            }
        }
        protected void BtnChangePassword_Click(object sender, EventArgs e)
        {
            string username = ((Model.User)Session["user"]).Username;
            string oldPassword = OldPasswordTxt.Text;
            string newPassword = NewPasswordTxt.Text;
            string confrimPassword = ConfirmPasswordTxt.Text;

            string result = UserController.UpdateUserPassword(username, oldPassword, newPassword, confrimPassword);
            lblMessage.Text = result;
            lblMessage.Visible = true;
            if (result == "Change Password Success")
            {
                BtnChangePassword.Visible = false;
            }
        }

        protected void BtnBackHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ViewProfilePage.aspx");
        }
    }
}