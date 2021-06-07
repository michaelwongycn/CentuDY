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
            MedicineId = int.Parse(Request.QueryString["Id"]);
            Medicine data = MedicineController.GetMedicineById(MedicineId);
            return data;
        }

        protected String GetQuantity()
        {
            return inputQuantity.Text;
        }

        protected void btnAddToCart_Click(object sender, EventArgs e)
        {
            var result =  CartController.AddCart(UserId, MedicineId, GetQuantity());
            if (result == "Add to cart success")
            {
                Response.Redirect("~/View/ViewCart.aspx?id=" + UserId);
            }
            if (result.GetType().Equals(typeof(string)))
            {
                txtAlert.Text = result;
            }
        }
    }
}