using CentuDY.Controller;
using CentuDY.Model;
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
        List<Medicine> medicine;
        protected void Page_Load(object sender, EventArgs e)
        {
            checkUser();
            checkRole();
            Load_Grid();
        }

        protected void Load_Grid()
        {
            string medicines = TxtSearchMedicines.Text;

            if (medicines == "")
            {
                medicine = MedicineController.GetMedicines();
                Grid_View_Medicine.DataSource = medicine;
                Grid_View_Medicine.DataBind();
            }    
            else if (medicines != "")
            {
                medicine = MedicineController.GetMedicineByKeyword(medicines);
                Grid_View_Medicine.DataSource = medicine;
                Grid_View_Medicine.DataBind();  
            }

        }
        protected void BtnInsertMedicine_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/MedicinePage/InsertMedicine.aspx");
        }

        private void checkRole()
        {
            int roleId = ((Model.User)Session["user"]).RoleId;

            if (roleId == 1)
            {
                BtnInsertMedicine.Visible = true;
                Grid_View_Medicine.Columns[5].Visible = true;
                Grid_View_Medicine.Columns[6].Visible = false;
            }
        }

        protected void Grid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow gvRow = Grid_View_Medicine.Rows[index];
            int id = int.Parse(gvRow.Cells[0].Text);
            
            if (e.CommandName == "AddToCart")
            {
                Response.Redirect("~/View/AddToCart.aspx?Id=" + id);
            }
        }

        private void checkUser()
        {
            if (Session["user"] == null)
            {
                 Response.Redirect("~/View/LoginPage.aspx");
            } 
        }
        protected void Grid_View_Medicine_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Medicine medicines = medicine[e.RowIndex];
            MedicineController.DeleteMedicine(medicines.MedicineId);
            Load_Grid();
        }

        protected void Grid_View_Medicine_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Medicine medicines = medicine[e.NewEditIndex];
            Response.Redirect("~/View/MedicinePage/UpdateMedicine.aspx?id="+medicines.MedicineId);
        }

        protected void SearchBtn_Click(object sender, EventArgs e)
        {   
            Load_Grid();
        }
    }
}