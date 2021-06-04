using CentuDY.Handler;
using CentuDY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Controller
{
    public class HeaderTransactionController
    {
        public static List<HeaderTransaction> GetHeaderTransactions() {
            return HeaderTransactionHandler.GetHeaderTransactions();
        }
        public static List<HeaderTransaction> GetHeaderTransactionsByUser(int userId)
        {
            return HeaderTransactionHandler.GetHeaderTransactionsByUser(userId);
        }
    }
}