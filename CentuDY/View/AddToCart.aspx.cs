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
            MedicineId = int.Parse(Request.QueryString["index"]);
            Medicine data = MedicineController.GetMedicineById(MedicineId);
            return data;
        }

        protected String GetQuantity()
        {
            return inputQuantity.Text;
        }

        protected void btnAddToCart_Click(object sender, EventArgs e)
        {
            txtAlert.Text =  CartController.AddCart(UserId, MedicineId, GetQuantity());
            string validate = txtAlert.Text;
            if (validate.Equals("Quantity must be filled ")
                || txtAlert.Text.Equals("Quantity must be numeric ")
                || txtAlert.Text.Equals("Quantity must be more than 0 ")
                || txtAlert.Text.Equals("Quantity cannot be more than available stock ")
                || txtAlert.Text.Equals("Quantity exceeding available stock")
                || txtAlert.Text.Equals("Quantity exceeding available stock")
                )
            {

            }
            else
            {
                Response.Redirect("~/View/ViewCart.aspx?id=" + UserId);
            }
        }
    }
}