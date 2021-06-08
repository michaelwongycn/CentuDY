using System;
using CentuDY.Model;
using CentuDY.Controller;

namespace CentuDY.View {
    public partial class AddToCart : System.Web.UI.Page
    {
        int MedicineId;
        int UserId;
        protected void Page_Load(object sender, EventArgs e)
        {
            checkUser();
            LoadMedicineData();
            UserId = ((User)Session["user"]).UserId;
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
                    Response.Redirect("~/View/Login.aspx");
                }
            }
            else
            {
                roleIsMember();
            }
        }

        private void roleIsMember()
        {
            int roleId = ((User)Session["user"]).RoleId;

            if (roleId == 1)
            {
                Response.Redirect("~/View/Home.aspx");
            }
        }

        protected void btnAddToCart_Click(object sender, EventArgs e)
        {
            string result =  CartController.AddCart(UserId, MedicineId, GetQuantity());
            txtAlert.Text = result;

            if (result == "Add to cart success")
            {
                Response.Redirect("~/View/ViewCart.aspx");
            }

            if (result == "Success updating cart quantity")
            {
                Response.Redirect("~/View/ViewCart.aspx");
            }
        }
    }
}