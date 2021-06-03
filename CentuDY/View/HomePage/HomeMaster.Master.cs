using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CentuDY.View.HomePage
{
    public partial class HomeMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ViewMedicines_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ViewMedicine.aspx");
        }

        protected void BtnViewProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ViewProfilePage.aspx");
        }

        protected void BtnLogOut_Click(object sender, EventArgs e)
        {

        }
    }
}