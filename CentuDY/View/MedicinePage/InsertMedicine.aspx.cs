using CentuDY.Controller;
using System;

namespace CentuDY.View.MedicinePage {
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
                Response.Redirect("~/View/Login.aspx");
            }
            else
            {
                int roleId = ((Model.User)Session["user"]).RoleId;
                if(roleId == 2)
                {
                    Response.Redirect("~/View/Home.aspx");
                }
            }
        }
        protected void BtnInsert_Click(object sender, EventArgs e)
        {
            name = NameTxt.Text;
            string description = DescTxt.Text;
            string strStock = StockTxt.Text;
            string strPrice = PriceTxt.Text;

            string result = MedicineController.AddMedicine(name, description, strStock, strPrice);
            LblMessage.Text = result;
            LblMessage.Visible = true;
        }
    }
}