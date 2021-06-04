using CentuDY.Handler;
using CentuDY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Controller {
    public class DetailTransactionController {
        public static List<DetailTransaction> GetDetailTransactionsByTransaction(int transactionId) {
            return DetailTransactionHandler.GetDetailTransactionsByTransaction(transactionId);
        }
    }
}