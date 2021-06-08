using CentuDY.Controller;
using System;

namespace CentuDY.View {
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            checkUser();
        }

        private void checkUser()
        {
            if (Session["user"] != null)
            {
                Response.Redirect("~/View/Home.aspx");
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string username = inputUsername.Text;
            string password = inputPassword.Text;
            string confrimPassword = inputConfPassword.Text;
            string name = inputName.Text;
            string gender = genderDropDown.SelectedItem.ToString();
            string phone = inputPhoneNumber.Text;
            string address = inputAddress.Text;

            string result = AuthController.Register(username, password, confrimPassword, name, gender, phone, address);
            lblmessage.Text = result;
            lblmessage.Visible = true;

            if (result == "Register Success")
            {
                btnRegister.Visible = false;
            }

        }

        protected void btnBackLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Login.aspx");
        }
    }
}