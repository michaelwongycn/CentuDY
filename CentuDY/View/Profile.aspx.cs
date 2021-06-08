using CentuDY.Controller;
using CentuDY.Model;
using System;

namespace CentuDY.View
{
    public partial class Profile : System.Web.UI.Page
    {
        static User user;
        protected void Page_Load(object sender, EventArgs e)
        {
            checkUser();

            int id = ((User)Session["user"]).UserId;
            user = UserController.GetUserById(id);

            UserNameTxt.Text = user.Username;
            NameTxt.Text = user.Name;
            GenderTxt.Text = user.Gender;
            PhoneTxt.Text = user.PhoneNumber;
            AddressTxt.Text = user.Address;
        }
        private void checkUser()
        {
            if (Session["user"] == null)
            {
                Response.Redirect("~/View/Login.aspx");
            }
        }
        protected void BtnUpdateProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/UpdateProfile.aspx");
        }

        protected void BtnChangePassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ChangePassword.aspx");
        }

    }
}