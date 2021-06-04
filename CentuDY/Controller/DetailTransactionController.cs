using CentuDY.Handler;
using CentuDY.Model;
using System.Collections.Generic;

namespace CentuDY.Controller {
    public class DetailTransactionController {
        public static List<DetailTransaction> GetDetailTransactionsByTransaction(int transactionId) {
            return DetailTransactionHandler.GetDetailTransactionsByTransaction(transactionId);
        }
    }
}