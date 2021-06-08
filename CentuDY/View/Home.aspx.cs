using CentuDY.Model;
using CentuDY.Controller;
using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace CentuDY.View {
    public partial class Home : System.Web.UI.Page
    {
        List<Medicine> medicine;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Load_Grid();
            }
            checkUser();
            checkRole();
        }

        protected void ViewMedicines_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ViewMedicines.aspx");
        }

        protected void Load_Grid()
        {
            medicine = MedicineController.GetRandomMedicines();
            Grid_View_Medicine.DataSource = medicine;
            Grid_View_Medicine.DataBind();
        }

        protected void BtnViewProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Profile.aspx");
        }

        protected void BtnLogOut_Click(object sender, EventArgs e)
        {
            Session.Remove("user");
            Session.Abandon();
            Session.Clear();

            Response.Cookies["user"].Expires = DateTime.Now.AddDays(-1);

            Response.Redirect("~/View/Login.aspx");
        }

        protected void BtnViewCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ViewCart.aspx");
        }

        protected void BtnViewTransHistory_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ViewTransactionsHistory.aspx");
        }

        protected void BtnInsertMedicine_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/MedicinePage/InsertMedicine.aspx");
        }

        protected void BtnViewUsers_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ViewUsers.aspx");
        }

        protected void BtnViewTransReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ViewTransactionsReport.aspx");
        }

        private void checkUser()
        {
            if (Session["user"] == null)
            {
                if (Request.Cookies["username"] == null)
                {
                    Response.Redirect("~/View/Login.aspx");
                }
                else
                {
                    string username = Request.Cookies["username"].Value;
                    UserNameTxt.Text = username;
                }
            }
            else
            {
                User user = (User)Session["user"];
                UserNameTxt.Text = user.Username;
            }
        }
        private void checkRole()
        {
            int roleId = ((User)Session["user"]).RoleId;

            if (roleId == 1)
            {
                BtnInsertMedicine.Visible = true;
                BtnViewUsers.Visible = true;
                BtnViewTransReport.Visible = true;
            }
            else if (roleId == 2)
            {
                BtnViewCart.Visible = true;
                BtnViewTransHistory.Visible = true;
                Grid_View_Medicine.Visible = true;
            }

        }

        protected void Grid_View_Medicine_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            int id = (int)Grid_View_Medicine.DataKeys[index].Value;

            if (e.CommandName == "AddToCart")
            {
                Response.Redirect("~/View/AddToCart.aspx?Id=" + id);
            }
        }
    }
}