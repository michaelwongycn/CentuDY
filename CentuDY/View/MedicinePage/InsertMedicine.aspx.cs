using CentuDY.Controller;
using CentuDY.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CentuDY.View.MedicinePage
{
    public partial class InsertMedicine : System.Web.UI.Page
    {
        static string name;
        protected void Page_Load(object sender, EventArgs e)
        {
            checkUser();
        }

        private void checkUser()
        {
            if (Session["user"] == null)
            {       
                Response.Redirect("~/View/LoginPage.aspx");
            }
            else
            {
                int roleId = ((Model.User)Session["user"]).RoleId;
                if(roleId == 2)
                {
                    Response.Redirect("~/View/ViewHomePage.aspx");
                }
            }
        }
        protected void BtnInsert_Click(object sender, EventArgs e)
        {
            name = NameTxt.Text;
            string description = DescTxt.Text;
            string strStock = StockTxt.Text;
            string strPrice = PriceTxt.Text;

            var result = MedicineController.AddMedicine(name, description, strStock, strPrice);
            if (result == "Insert Success")
            {
                LblMessage.Text = result;
                LblMessage.Visible = true;
            }
            if (result.GetType().Equals(typeof(string)))
            {
                LblMessage.Text = result;
                LblMessage.Visible = true;
            }
            
        }
    }
}