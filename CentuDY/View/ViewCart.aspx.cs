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
    public partial class ViewCart : System.Web.UI.Page
    {
        List<Cart> carts;
        int grandTotal = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            Load_Grid();
        }

        protected void Load_Grid()
        {
            int id = int.Parse(Request.QueryString["Id"]);
            carts = CartController.GetCartByUser(id);
            System.Diagnostics.Debug.WriteLine(carts);
            Grid_View_Cart.DataSource = carts;
            Grid_View_Cart.DataBind();
        }

        protected void Grid_View_Cart_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Cart cr = carts[e.RowIndex];
            CartController.DeleteCart(cr.UserId, cr.MedicineId);
            Load_Grid();
        }

        protected void Grid_View_Cart_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Label SubTotal = (Label)e.Row.FindControl("txtSubTotal");

                grandTotal = grandTotal + int.Parse(SubTotal.Text);

                Label GrandTotal = (Label)e.Row.FindControl("txtGrandTotal");
                GrandTotal.Text = grandTotal.ToString();
            }
        }

        protected void btnCheckout_Click(object sender, EventArgs e)
        {
            CartController.Checkout(carts.First().UserId);
        }
    }
}