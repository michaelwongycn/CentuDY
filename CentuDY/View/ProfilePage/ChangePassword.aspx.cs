﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CentuDY.View.ProfilePage
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnChangePassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ViewProfilePage.aspx");
        }
    }
}