using CentuDY.Controller;
using CentuDY.Handler;
using CentuDY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CentuDY.View.MedicinePage
{

    public partial class UpdateMedicine : System.Web.UI.Page
    {
        static Medicine medicine;
        protected void Page_Load(object sender, EventArgs e)
        {
            checkUser();
            if (!Page.IsPostBack)
            {
                int id = int.Parse(Request.QueryString["id"]);
                medicine = MedicineController.GetMedicineById(id);
                if(medicine == null)
                {
                    Response.Redirect("~/View/ViewMedicine.aspx");
                }
                else
                {
                    NameTxt.Text = medicine.Name;
                    DescTxt.Text = medicine.Description;
                    StockTxt.Text = medicine.Stock.ToString();
                    PriceTxt.Text = medicine.Price.ToString();        
                }
            }
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
                int roleId = ((Model.User)Session["user"]).RoleId;
                if (roleId == 2)
                {
                    Response.Redirect("~/View/ViewHomePage.aspx");
                }
            }
        }
        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            string name = NameTxt.Text;
            string description = DescTxt.Text;
            string strStock = StockTxt.Text;
            string strPrice = PriceTxt.Text;

            if (name == "" || description == "" || strStock == "" || strPrice == "")
            {
                LblMessage.Text = MedicineController.UpdateMedicine(medicine.MedicineId, name, description, strStock, strPrice);
                LblMessage.Visible = true;
            }
            else
            {
                LblMessage.Text = MedicineController.UpdateMedicine(medicine.MedicineId, name, description, strStock, strPrice);
                LblMessage.Visible = true;
            }
        }
    
    }
}