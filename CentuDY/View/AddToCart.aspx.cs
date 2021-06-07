using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CentuDY.Model;
using CentuDY.Controller;

namespace CentuDY.View
{
    public partial class AddToCart : System.Web.UI.Page
    {
        int MedicineId;
        int UserId;
        protected void Page_Load(object sender, EventArgs e)
        {
            checkUser();
            LoadMedicineData();
            UserId = ((Model.User)Session["user"]).UserId;
        }

        protected void LoadMedicineData()
        {
            txtMedicineName.Text = GetMedicineByID().Name;
            txtMedicineDescription.Text = GetMedicineByID().Description;
            txtMedicineStock.Text = GetMedicineByID().Stock.ToString();
            txtMedicinePrice.Text = GetMedicineByID().Price.ToString();
        }

        protected Medicine GetMedicineByID()
        {
            MedicineId = int.Parse(Request.QueryString["Id"]);
            Medicine data = MedicineController.GetMedicineById(MedicineId);
            return data;
        }

        protected String GetQuantity()
        {
            return inputQuantity.Text;
        }

        private void checkUser()
        {
            if (Session["user"] == null)
            {
                if (Request.Cookies["username"] == null)
                {
                    Response.Redirect("~/View/LoginPage.aspx");
                }
            }
            else
            {
                roleIsMember();
            }
        }

        private void roleIsMember()
        {
            int roleId = ((Model.User)Session["user"]).RoleId;

            if (roleId == 1)
            {
                Response.Redirect("~/View/HomePage.aspx");
            }
        }

        protected void btnAddToCart_Click(object sender, EventArgs e)
        {
            string result =  CartController.AddCart(UserId, MedicineId, GetQuantity());
            txtAlert.Text = result;
            if (result == "Add to cart success")
            {
                btnAddToCart.Visible = false;
                BtnViewCart.Visible = true;
            }
        }

        protected void BtnViewCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ViewCart.aspx");
        }
    }
}