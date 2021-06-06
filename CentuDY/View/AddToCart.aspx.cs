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
        int UserId ;
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadMedicineData();

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
            UserId = int.Parse(Request.QueryString["Id"]) + 1;
            Medicine data = MedicineController.GetMedicineById(UserId);
            return data;
        }

        protected int GetQuantity()
        {
            int quantity;
            return quantity = int.Parse(inputQuantity.Text);
        }

        protected void btnAddToCart_Click(object sender, EventArgs e)
        {
            //TODO Add to cart database
            //TODO Validasi Quantity
            Response.Redirect("~/View/ViewCart.aspx?id=" + UserId);
        }
    }
}