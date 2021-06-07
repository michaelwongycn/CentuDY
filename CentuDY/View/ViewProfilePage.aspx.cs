using CentuDY.Controller;
using CentuDY.Model;
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
        static User user;
        protected void Page_Load(object sender, EventArgs e)
        {
            checkUser();

            int id = ((Model.User)Session["user"]).UserId;
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
                Response.Redirect("~/View/LoginPage.aspx");
            }
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