using CentuDY.Model;
using CentuDY.Repository;
using System.Collections.Generic;

namespace CentuDY.Handler {
    public class DetailTransactionHandler {
        public static List<DetailTransaction> GetDetailTransactionsByTransaction(int transactionId) {
            return DetailTransactionRepository.GetDetailTransactionsByTransaction(transactionId);
        }

        public static List<DetailTransaction> GetDetailTransactionsByMedicine(int medicineId) {
            return DetailTransactionRepository.GetDetailTransactionsByMedicine(medicineId);
        }

        public static void AddDetailTransaction(DetailTransaction detailTransaction) {
            DetailTransactionRepository.AddDetailTransaction(detailTransaction);
        }

        public static void UpdateDetailTransaction(int transactionId, int medicineId, int newQuantity) {
            DetailTransactionRepository.UpdateDetailTransaction(transactionId, medicineId, newQuantity);
        }

        public static void DeleteDetailTransaction(int transactionId, int medicineId) {
            DetailTransactionRepository.DeleteDetailTransaction(transactionId, medicineId);
        }
    }
}