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
        protected void Page_Load(object sender, EventArgs e)
        {
            Load_Grid();
        }

        protected void Load_Grid()
        {
            carts = CartController.GetCartByUser(int.Parse(Request.QueryString["Id"]));
            Grid_View_Cart.DataSource = carts;
            Grid_View_Cart.DataBind();
        }

        protected void Grid_View_Cart_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
    }
}