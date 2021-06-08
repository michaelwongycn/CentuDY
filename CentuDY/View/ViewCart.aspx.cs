using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using CentuDY.Model;
using CentuDY.Controller;

namespace CentuDY.View {
    public partial class ViewCart : System.Web.UI.Page
    {
        List<Cart> carts;
        int grandTotal = 0;
        int userId;
        protected void Page_Load(object sender, EventArgs e)
        {
            txtGrandTotal.Visible = true;
            checkUser();
            Load_Grid(); 
        }

        protected void Load_Grid()
        {
            userId = ((User)Session["user"]).UserId;
            carts = CartController.GetCartByUser(userId);
            System.Diagnostics.Debug.WriteLine(carts);
            Grid_View_Cart.DataSource = carts;
            Grid_View_Cart.DataBind();
            setGrandTotal();
        }

        protected void Grid_View_Cart_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Cart cr = carts[e.RowIndex];
            CartController.DeleteCart(cr.UserId, cr.MedicineId);
            Page.Response.Redirect(Page.Request.Url.ToString(), true);
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

        protected void setGrandTotal()
        {
            txtGrandTotal.Text = "Rp" + grandTotal.ToString();
        }

        protected void Grid_View_Cart_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Label SubTotal = (Label)e.Row.FindControl("txtSubTotal");

                grandTotal = grandTotal + int.Parse(SubTotal.Text);
            }
        }

        protected bool cartIsEmpty()
        {
            if (CartController.GetCartByUser(userId).Count == 0) return true;

            return false;
        }

        protected void btnCheckout_Click(object sender, EventArgs e)
        {
            if (cartIsEmpty())
            {
                errMsg.Text = "Cart is Empty";
            }
            else
            {
                CartController.Checkout(carts.First().UserId);
                Load_Grid();
                grandTotal = 0;
                setGrandTotal();
            }
        }
    }
}