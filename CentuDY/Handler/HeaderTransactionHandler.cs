using CentuDY.Model;
using CentuDY.Repository;
using System;
using System.Collections.Generic;

namespace CentuDY.Handler {
    public class HeaderTransactionHandler {
        public static List<HeaderTransaction> GetHeaderTransactions() {
            return HeaderTransactionRepository.GetHeaderTransactions();
        }

        public static HeaderTransaction GetHeaderTransactionsById(int transactionId) {
            return HeaderTransactionRepository.GetHeaderTransactionsById(transactionId);
        }

        public static List<HeaderTransaction> GetHeaderTransactionsByUser(int userId) {
            return HeaderTransactionRepository.GetHeaderTransactionsByUser(userId);
        }

        public static void AddHeaderTransaction(HeaderTransaction headerTransaction) {
            HeaderTransactionRepository.AddHeaderTransaction(headerTransaction);
        }

        public static void UpdateHeaderTransaction(int transactionId, DateTime newTransactionDate) {
            HeaderTransactionRepository.UpdateHeaderTransaction(transactionId, newTransactionDate);
        }

        public static void DeleteHeaderTransaction(int transactionId) {
            HeaderTransactionRepository.DeleteHeaderTransaction(transactionId);
        }
    }
}