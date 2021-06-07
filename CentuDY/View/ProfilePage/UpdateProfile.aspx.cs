using CentuDY.Controller;
using CentuDY.Handler;
using CentuDY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CentuDY.View.ProfilePage
{
    public partial class UpdateProfile : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            checkUser();
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
            int userId = ((Model.User)Session["user"]).UserId;
            string name = NameTxt.Text;
            string gender = genderDropDown.SelectedItem.ToString();
            string phoneNumber = PhoneTxt.Text;
            string address = AddressTxt.Text;
            
            string result = UserController.UpdateUserProfile(userId, name, gender, phoneNumber, address);
            lblMessage.Text = result;
            lblMessage.Visible = true;
            if (result == "Update Success")
            {    
                BtnUpdateProfile.Visible = false;
            }
        }

        protected void BtnBackHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Profile.aspx");
        }
    }
}