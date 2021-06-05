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
        static User user;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                setGenderDropDown();
            }
        }
        public void setGenderDropDown()
        {
            genderDropDown.Items.Add("Select gender");
            genderDropDown.Items.Add("Male");
            genderDropDown.Items.Add("Female");
        }
        protected void BtnUpdateProfile_Click(object sender, EventArgs e)
        {
            int userId = ((Model.User)Session["user"]).UserId;
            string name = NameTxt.Text;
            string gender = genderDropDown.Text;
            string phoneNumber = PhoneTxt.Text;
            string address = AddressTxt.Text;
            
            if(name == "" || gender ==  "" || phoneNumber == "" || address == "")
            {
                lblMessage.Text = UserController.UpdateUserProfile(userId, name, gender, phoneNumber, address);
                lblMessage.Visible = true;
            }
            else
            {

                lblMessage.Text = UserController.UpdateUserProfile(userId, name, gender, phoneNumber, address);
                lblMessage.Visible = true;
                BtnUpdateProfile.Visible = false;
                BtnBackHome.Visible = true;
                
            }
            
        }

        protected void BtnBackHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/viewProfilePage.aspx");
        }
    }
}