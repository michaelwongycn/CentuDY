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
            checkRole();
            Load_Grid();
            Load_Grid();
        }

        protected void Load_Grid()
        {
            medicine = MedicineController.GetMedicines();
            Grid_View_Medicine.DataSource = medicine;
            Grid_View_Medicine.DataBind();
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
                Grid_View_Medicine.Columns[4].Visible = true;
                Grid_View_Medicine.Columns[5].Visible = false;
            }
        }

        protected void Grid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow gvRow = Grid_View_Medicine.Rows[index];
            if (e.CommandName == "AddToCart")
            {
                Response.Redirect("~/View/AddToCart.aspx?id="+gvRow.RowIndex);
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

        protected void Grid_View_Medicine_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            
        }
    }
}