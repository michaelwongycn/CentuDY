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

        }

        protected void BtnChangePassword_Click(object sender, EventArgs e)
        {
            string username = ((Model.User)Session["user"]).Username;
            string oldPassword = OldPasswordTxt.Text;
            string newPassword = NewPasswordTxt.Text;
            string confrimPassword = ConfirmPasswordTxt.Text;

            if(oldPassword == "" || newPassword == "" || confrimPassword == "")
            {
                lblMessage.Text = UserController.UpdateUserPassword(username, oldPassword, newPassword, confrimPassword);
                lblMessage.Visible = true;
            }
            else
            {
                lblMessage.Text = UserController.UpdateUserPassword(username, oldPassword, newPassword, confrimPassword);
                lblMessage.Visible = true;
                BtnChangePassword.Visible = false;
                BtnBackHome.Visible = true;
            }
            
        }

        protected void BtnBackHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ViewProfilePage.aspx");
        }
    }
}