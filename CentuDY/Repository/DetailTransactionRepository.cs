using CentuDY.Model;
using System.Collections.Generic;
using System.Linq;

namespace CentuDY.Repository {
    public class DetailTransactionRepository {
        public static List<DetailTransaction> GetDetailTransactionsByTransaction(int transactionId) {
            CentuDYDBEntities db = new CentuDYDBEntities();
            return (from detailTransaction
                    in db.DetailTransaction
                    where detailTransaction.TransactionId.Equals(transactionId)
                    select detailTransaction).ToList();
        }

        public static List<DetailTransaction> GetDetailTransactionsByMedicine(int medicineId) {
            CentuDYDBEntities db = new CentuDYDBEntities();
            return (from detailTransaction
                    in db.DetailTransaction
                    where detailTransaction.MedicineId.Equals(medicineId)
                    select detailTransaction).ToList();
        }

        public static void AddDetailTransaction(DetailTransaction detailTransaction) {
            CentuDYDBEntities db = new CentuDYDBEntities();
            db.DetailTransaction.Add(detailTransaction);
            db.SaveChanges();
        }

        public static void UpdateDetailTransaction(int transactionId, int medicineId, int newQuantity) {
            CentuDYDBEntities db = new CentuDYDBEntities();
            DetailTransaction updatedTransactionHeader =
                    (from detailTransaction
                     in db.DetailTransaction
                     where detailTransaction.TransactionId.Equals(transactionId) &&
                     detailTransaction.MedicineId.Equals(medicineId)
                     select detailTransaction).FirstOrDefault();

            updatedTransactionHeader.Quantity = newQuantity;
            db.SaveChanges();
        }

        public static void DeleteDetailTransaction(int transactionId, int medicineId) {
            CentuDYDBEntities db = new CentuDYDBEntities();
            DetailTransaction deletedDetailTransaction =
                    (from detailTransaction
                     in db.DetailTransaction
                     where detailTransaction.TransactionId.Equals(transactionId) &&
                     detailTransaction.MedicineId.Equals(medicineId)
                     select detailTransaction).FirstOrDefault();

            db.DetailTransaction.Remove(deletedDetailTransaction);
            db.SaveChanges();
        }
    }
}