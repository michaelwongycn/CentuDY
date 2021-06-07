using CentuDY.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CentuDY.View
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            checkUser();
            if (!IsPostBack)
            {
                if (Request.Cookies["username"] != null && Request.Cookies["password"] != null)
                {
                    inputEmail.Text = Request.Cookies["username"].Value;
                    inputPassword.Attributes.Add("value", Request.Cookies["password"].Value);

                }
            }
        }

        private void checkUser()
        {
            if (Session["user"] != null)
            {
                Response.Redirect("~/View/Home.aspx");
            }
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string email = inputEmail.Text;
            string password = inputPassword.Text;

            var user = AuthController.Login(email, password);

            if (user.GetType().Equals(typeof(string)))
            {
                lblMessage.Text = user;
                lblMessage.Visible = true;
            }
            else
            {
                Session["user"] = user;
                if (chckRememberMe.Checked)
                {
                    HttpCookie cookie = new HttpCookie("user");
                    cookie.Secure = true;
                    cookie["username"] = inputEmail.Text;
                    cookie["password"] = inputPassword.Text;

                    if (inputEmail.Text != "" && inputPassword.Text != "")
                    {
                        cookie.Expires = DateTime.Now.AddDays(1);
                        Response.Cookies.Add(cookie);
                    }
                }
                Response.Redirect("~/View/Home.aspx");
            }
        }
    }
}