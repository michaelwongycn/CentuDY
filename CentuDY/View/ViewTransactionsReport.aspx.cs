using CentuDY.Controller;
using CentuDY.CrystalReports;
using CentuDY.Model;
using System;
using System.Collections.Generic;

namespace CentuDY.View {
    public partial class ViewTransactionsReport : System.Web.UI.Page
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
                 Response.Redirect("~/View/Login.aspx");
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
                Response.Redirect("~/View/Home.aspx");
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