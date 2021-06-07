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
    public partial class ViewTransHistory : System.Web.UI.Page
    {
        protected int grandTotal = 0;
        protected List<HeaderTransaction> headers;
        protected List<DetailTransaction> details;
        protected List<DetailTransaction> dataTransaction = new List<DetailTransaction>();

        int Userid;
        protected void Page_Load(object sender, EventArgs e)
        {
            Userid = int.Parse(Request.QueryString["Id"]);
            Load_Grid(Userid);
        }

        protected void Load_Grid(int id)
        {
            headers = HeaderTransactionController.GetHeaderTransactionsByUser(Userid);

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
        }

        protected void Grid_View_Transaction_History_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Label SubTotal = (Label)e.Row.FindControl("txtSubTotal");

                grandTotal = grandTotal + int.Parse(SubTotal.Text);

                Label GrandTotal = (Label)e.Row.FindControl("txtGrandTotal");
                GrandTotal.Text = grandTotal.ToString();
            }
        }
    }
}