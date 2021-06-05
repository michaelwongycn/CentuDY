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
            UserNameTxt.Text = ((Model.User)Session["user"]).Username;
            NameTxt.Text = ((Model.User)Session["user"]).Name;
            GenderTxt.Text = ((Model.User)Session["user"]).Gender;
            PhoneTxt.Text = ((Model.User)Session["user"]).PhoneNumber;
            AddressTxt.Text = ((Model.User)Session["user"]).Address;
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