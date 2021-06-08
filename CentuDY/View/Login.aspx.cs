using CentuDY.Controller;
using System;
using System.Web;

namespace CentuDY.View {
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            checkUser();
            if (!IsPostBack)
            {
                if (Request.Cookies["User"] != null)
                {
                    HttpCookie cookie = Request.Cookies["User"];

                    inputUsername.Text = cookie["username"];
                    inputPassword.Attributes.Add("value", cookie["password"]);
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
            string email = inputUsername.Text;
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
                    cookie["username"] = inputUsername.Text;
                    cookie["password"] = inputPassword.Text;

                    if (inputUsername.Text != "" && inputPassword.Text != "")
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