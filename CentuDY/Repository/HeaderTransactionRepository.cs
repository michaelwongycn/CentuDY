using CentuDY.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CentuDY.Repository {
    public class HeaderTransactionRepository {
        public static List<HeaderTransaction> GetHeaderTransactions() {
            CentuDYDBEntities db = new CentuDYDBEntities();
            return db.HeaderTransaction.ToList();
        }

        public static HeaderTransaction GetHeaderTransactionsById(int transactionId) {
            CentuDYDBEntities db = new CentuDYDBEntities();
            return (from headerTransaction
                    in db.HeaderTransaction
                    where headerTransaction.TransactionId.Equals(transactionId)
                    select headerTransaction).FirstOrDefault();
        }

        public static List<HeaderTransaction> GetHeaderTransactionsByUser(int userId) {
            CentuDYDBEntities db = new CentuDYDBEntities();
            return (from headerTransaction
                    in db.HeaderTransaction
                    where headerTransaction.UserId.Equals(userId)
                    select headerTransaction).ToList();
        }

        public static HeaderTransaction GetLastInsertedTransaction() {
            CentuDYDBEntities db = new CentuDYDBEntities();
            return (from headerTransaction
                    in db.HeaderTransaction
                    orderby headerTransaction.TransactionId descending
                    select headerTransaction).FirstOrDefault();
        }

        public static void AddHeaderTransaction(HeaderTransaction headerTransaction) {
            CentuDYDBEntities db = new CentuDYDBEntities();
            db.HeaderTransaction.Add(headerTransaction);
            db.SaveChanges();
        }

        public static void UpdateHeaderTransaction(int transactionId, DateTime newTransactionDate) {
            CentuDYDBEntities db = new CentuDYDBEntities();
            HeaderTransaction updatedHeaderTransaction =
                    (from headerTransaction
                     in db.HeaderTransaction
                     where headerTransaction.TransactionId.Equals(transactionId)
                     select headerTransaction).FirstOrDefault();

            updatedHeaderTransaction.TransactionDate = newTransactionDate;
            db.SaveChanges();
        }

        public static void DeleteHeaderTransaction(int transactionId) {
            CentuDYDBEntities db = new CentuDYDBEntities();
            HeaderTransaction deletedHeaderTransaction =
                    (from headerTransaction
                     in db.HeaderTransaction
                     where headerTransaction.TransactionId.Equals(transactionId)
                     select headerTransaction).FirstOrDefault();

            db.HeaderTransaction.Remove(deletedHeaderTransaction);
            db.SaveChanges();
        }
    }
}