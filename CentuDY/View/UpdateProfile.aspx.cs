using CentuDY.Controller;
using CentuDY.Model;
using System;

namespace CentuDY.View {
    public partial class UpdateProfile : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            checkUser();
            if (!IsPostBack) {
                loadUserData();
            }
        }
        private void checkUser()
        {
            if (Session["user"] == null)
            {
               Response.Redirect("~/View/Login.aspx");           
            }
        }

        private void loadUserData()
        {
            int userId = ((User)Session["user"]).UserId;
            User user = UserController.GetUserById(userId);

            NameTxt.Text = user.Name;

            int index = 0;
            if (user.Gender == "Male") {
                index = 1;
            }
            else {
                index = 2;
            }
            genderDropDown.Items.FindByValue(index.ToString()).Selected = true;
            PhoneTxt.Text = user.PhoneNumber;
            AddressTxt.Text = user.Address;
        }
        protected void BtnUpdateProfile_Click(object sender, EventArgs e)
        {
            int userId = ((User)Session["user"]).UserId;
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