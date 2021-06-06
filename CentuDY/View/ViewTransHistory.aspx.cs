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
        List<HeaderTransaction> headers;
        List<DetailTransaction> details;

        int Userid;
        protected void Page_Load(object sender, EventArgs e)
        {
            Userid = int.Parse(Request.QueryString["Id"]);
            Load_Grid(Userid);
        }

        protected void Load_Grid(int id)
        {
            //headers = HeaderTransactionController.GetHeaderTransactionsByUser(Userid);
            //details = DetailTransactionController.GetDetailTransactionsByTransaction(headers.);
            //Grid_View_Transaction_History.DataSource = transactions;
            //Grid_View_Transaction_History.DataBind();
        }
    }
}