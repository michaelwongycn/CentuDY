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
    public partial class ViewTransactionsHistory : System.Web.UI.Page
    {
        protected int grandTotal = 0;
        protected List<HeaderTransaction> headers;
        protected List<DetailTransaction> details;
        protected List<DetailTransaction> dataTransaction = new List<DetailTransaction>();


        protected void Page_Load(object sender, EventArgs e)
        {
            checkUser();
            Load_Grid();
        }

        protected void Load_Grid()
        {
            int userId = ((Model.User)Session["user"]).UserId;
            headers = HeaderTransactionController.GetHeaderTransactionsByUser(userId);

            foreach (HeaderTransaction ht in headers)
            {
                details = DetailTransactionController.GetDetailTransactionsByTransaction(ht.TransactionId);
                foreach (DetailTransaction dt in details)
                {
                    dataTransaction.Add(dt);
                }
            }

            Grid_View_Transaction_History.DataSource = dataTransaction;
            Grid_View_Transaction_History.DataBind();
            setGrandTotal();
        }

        private void checkUser()
        {
            if (Session["user"] == null)
            {
                Response.Redirect("~/View/Login.aspx");
            }
            else
            {
                roleIsMember();
            }
        }

        private void roleIsMember()
        {
            int roleId = ((Model.User)Session["user"]).RoleId;

            if (roleId == 1)
            {
                Response.Redirect("~/View/Home.aspx");
            }
        }

        protected void setGrandTotal()
        {
            txtGrandTotal.Text = "Rp" + grandTotal.ToString();
        }

        protected void Grid_View_Transaction_History_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Label SubTotal = (Label)e.Row.FindControl("txtSubTotal");

                grandTotal = grandTotal + int.Parse(SubTotal.Text);
            }
        }
    }
}