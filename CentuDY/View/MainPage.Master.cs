using System;

namespace CentuDY.View {
    public partial class MainPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnHomePage_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Home.aspx");
        }
    }
}