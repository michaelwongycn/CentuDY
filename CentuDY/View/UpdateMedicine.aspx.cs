using CentuDY.Controller;
using CentuDY.Model;
using System;
using System.Web.UI;

namespace CentuDY.View {

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
                    Response.Redirect("~/View/ViewMedicines.aspx");
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
                  Response.Redirect("~/View/Login.aspx");
            }
            else
            {
                int roleId = ((Model.User)Session["user"]).RoleId;
                if (roleId == 2)
                {
                    Response.Redirect("~/View/Home.aspx");
                }
            }
        }
        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            string name = NameTxt.Text;
            string description = DescTxt.Text;
            string strStock = StockTxt.Text;
            string strPrice = PriceTxt.Text;

            string result = MedicineController.UpdateMedicine(medicine.MedicineId, name, description, strStock, strPrice);
            LblMessage.Text = result;
            LblMessage.Visible = true;
         }
    }
}