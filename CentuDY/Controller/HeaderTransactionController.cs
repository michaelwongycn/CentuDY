using CentuDY.Handler;
using CentuDY.Model;
using System.Collections.Generic;

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