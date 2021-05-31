using CentuDY.Model;

namespace CentuDY.Factory {
    public class DetailTransactionFactory {
        public static DetailTransaction createDetailTransaction(int transactionId, int medicineId,
                                                                int quantity) {
            DetailTransaction detailTransaction = new DetailTransaction();

            detailTransaction.TransactionId = transactionId;
            detailTransaction.MedicineId = medicineId;
            detailTransaction.Quantity = quantity;

            return detailTransaction;
        }
    }
}