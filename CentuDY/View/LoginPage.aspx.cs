﻿using CentuDY.Controller;
using CentuDY.Handler;
using CentuDY.Model;
using CentuDY.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CentuDY.View
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           if(!IsPostBack)
            {   
                if (Request.Cookies["username"] != null && Request.Cookies["password"] != null )
                {
                    inputEmail.Text = Request.Cookies["username"].Value;
                    inputPassword.Attributes.Add("value", Request.Cookies["password"].Value);
                }
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string email = inputEmail.Text;
            string password = inputPassword.Text;
            
            User user = UserHandler.GetUserByUsernameAndPassword(email, password);

            if (user != null)
            {
                Session["user"] = user;

                if (chckRememberMe.Checked)
                {
                    HttpCookie cookie = new HttpCookie("username");
                    cookie.Value = user.Username;
                    cookie.Value = user.Password;

                    Response.Cookies["username"].Value = inputEmail.Text;
                    Response.Cookies["password"].Value = inputPassword.Text;

                    cookie.Expires = DateTime.Now.AddDays(1);

                    Response.Cookies.Add(cookie);
                }

                Response.Redirect("~/View/HomePage/ViewHomePage.aspx");
            }

            lblMessage.Text = AuthController.Login(email, password);
            lblMessage.Visible = true;
        }

    }
}