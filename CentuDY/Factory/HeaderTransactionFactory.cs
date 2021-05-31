using CentuDY.Model;
using System;

namespace CentuDY.Factory {
    public class HeaderTransactionFactory {
        public static HeaderTransaction createHeaderTransaction(int userId, DateTime transactionDate) {
            HeaderTransaction headerTransaction = new HeaderTransaction();

            headerTransaction.UserId = userId;
            headerTransaction.TransactionDate = transactionDate;

            return headerTransaction;
        }
    }
}