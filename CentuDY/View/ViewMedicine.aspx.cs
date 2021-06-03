using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CentuDY.View
{
    public partial class ViewMedicine : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnInsertMedicine_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/MedicinePage/InsertMedicine.aspx");
        }

        protected void BtnUpdateMedicine_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/MedicinePage/UpdateMedicine.aspx");
        }

        protected void BtnDeleteMedicine_Click(object sender, EventArgs e)
        {

        }

        protected void BtnAddCart_Click(object sender, EventArgs e)
        {

        }
    }
}