﻿using CentuDY.Controller;
using CentuDY.Handler;
using CentuDY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CentuDY.View
{
    public partial class ViewHomePage : System.Web.UI.Page
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
            Response.Redirect("~/View/ViewMedicine.aspx");
        }

        protected void Load_Grid()
        {
            Grid_View_Medicine.Columns[5].Visible = true;
            medicine = MedicineController.GetRandomMedicines();
            Grid_View_Medicine.DataSource = medicine;
            Grid_View_Medicine.DataBind();
        }

        protected void BtnViewProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ViewProfilePage.aspx");
        }

        protected void BtnLogOut_Click(object sender, EventArgs e)
        {
            Session.Remove("user");
            Session.Abandon();
            Session.Clear();

            Response.Cookies["user"].Expires = DateTime.Now.AddDays(-1);

            Response.Redirect("~/View/LoginPage.aspx");
        }

        protected void BtnViewCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ViewCart.aspx" );
        }

        protected void BtnViewTransHistory_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ViewTransHistory.aspx?id=" + ((Model.User)Session["user"]).UserId);
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
            Response.Redirect("~/View/ViewTransReport.aspx");
        }

        private void checkUser()
        {
            if (Session["user"] == null)
            {
                if (Request.Cookies["username"] == null)
                {
                    Response.Redirect("~/View/LoginPage.aspx");
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
            int roleId = ((Model.User)Session["user"]).RoleId;

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
            GridViewRow gvRow = Grid_View_Medicine.Rows[index];
            int id = int.Parse(gvRow.Cells[0].Text);

            if (e.CommandName == "AddToCart")
            {
                Response.Redirect("~/View/AddToCart.aspx?Id=" + id);
            }
        }
    }
}