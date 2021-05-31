using CentuDY.Model;
using CentuDY.Repository;
using System;
using System.Collections.Generic;

namespace CentuDY.Handler {
    public class MedicineHandler {
        public static List<Medicine> GetMedicines() {
            return MedicineRepository.GetMedicines();
        }

        public static List<Medicine> GetRandomMedicines() {
            Random random = new Random();
            List<Medicine> medicineList =  MedicineRepository.GetMedicines();
            List<Medicine> randomizedMedicineList = new List<Medicine>();
            
            for(int i = 0; i < 5; i++) {
                int baseNum = medicineList.Count;
                int randNum = random.Next() % baseNum;

                randomizedMedicineList.Add(medicineList[randNum]);
                medicineList.RemoveAt(randNum);

                if(baseNum == 1) {
                    break;
                }
            }

            return randomizedMedicineList;
        }

        public static Medicine GetMedicineById(int medicineId) {
            return MedicineRepository.GetMedicineById(medicineId);
        }

        public static List<Medicine> GetMedicineByKeyword(string keyword) {
            return MedicineRepository.GetMedicineByKeyword(keyword);
        }

        public static void AddMedicine(Medicine medicine) {
            MedicineRepository.AddMedicine(medicine);
        }

        public static Boolean UpdateMedicine(int medicineId, string newName, string newDescription,
                                          int newStock, int newPrice) {
            Medicine tempMedicine = MedicineRepository.GetMedicineById(medicineId);

            if (tempMedicine == null) {
                return false;
            }
            else {
                MedicineRepository.UpdateMedicine(medicineId, newName, newDescription, newStock, newPrice);
                return true;
            }
        }

        public static Boolean DeleteMedicine(int medicineId) {
            List<Cart> cartList = CartRepository.GetCartByMedicine(medicineId);
            List<DetailTransaction> detailTransactionList = DetailTransactionRepository.GetDetailTransactionsByMedicine(medicineId);
            
            if (cartList == null || detailTransactionList == null) {
                return false;
            }
            if (cartList.Count != 0 || detailTransactionList.Count != 0){
                return false;
            }
            else {
                MedicineRepository.DeleteMedicine(medicineId);
                return true;
            }
        }
    }
}