using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CentuDY.Controller;
using CentuDY.Model;
using CentuDY.CrystalReports;

namespace CentuDY.View
{
    public partial class ViewTransReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            checkUser();
            List<HeaderTransaction> dataSource = HeaderTransactionController.GetHeaderTransactions();
            TransactionCrystalReport cr = new TransactionCrystalReport();
            cr.SetDataSource(GetDataSet(dataSource));
            TransactionCrystalReportViewer.ReportSource = cr;
        }

        private void checkUser()
        {
            if (Session["user"] == null)
            {
                if (Request.Cookies["username"] == null)
                {
                    Response.Redirect("~/View/LoginPage.aspx");
                }
            }
            else
            {
                roleIsAdmin();
            }
        }

        private void roleIsAdmin()
        {
            int roleId = ((Model.User)Session["user"]).RoleId;

            if (roleId == 2)
            {
                Response.Redirect("~/View/HomePage.aspx");
            }
        }

        protected TransactionDataSet GetDataSet(List<HeaderTransaction> transactions)
        {
            TransactionDataSet ds = new TransactionDataSet();

            var header = ds.HeaderTransaction;
            var detail = ds.DetailTransaction;
            foreach (HeaderTransaction ht in transactions)
            {
                var newHeader = header.NewRow();
                newHeader["TransactionId"] = ht.TransactionId;
                newHeader["UserName"] = ht.User.Name;
                newHeader["TransactionDate"] = ht.TransactionDate.ToString();
                header.Rows.Add(newHeader);

                foreach (DetailTransaction dt in ht.DetailTransaction)
                {
                    var newDetail = detail.NewRow();
                    newDetail["TransactionId"] = dt.TransactionId;
                    newDetail["MedicineName"] = dt.Medicine.Name;
                    newDetail["MedicinePrice"] = dt.Medicine.Price;
                    newDetail["Quantity"] = dt.Quantity;
                    detail.Rows.Add(newDetail);
                }
            }
            return ds;
        }
    }
}