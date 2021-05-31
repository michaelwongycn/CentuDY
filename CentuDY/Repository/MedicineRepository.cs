using CentuDY.Model;
using System.Collections.Generic;
using System.Linq;

namespace CentuDY.Repository {
    public class MedicineRepository {
        public static List<Medicine> GetMedicines() {
            CentuDYDBEntities db = new CentuDYDBEntities();
            return db.Medicine.ToList();
        }

        public static Medicine GetMedicineById(int medicineId) {
            CentuDYDBEntities db = new CentuDYDBEntities();
            return (from medicine
                    in db.Medicine
                    where medicine.MedicineId.Equals(medicineId)
                    select medicine).FirstOrDefault();
        }

        public static List<Medicine> GetMedicineByKeyword(string keyword) {
            CentuDYDBEntities db = new CentuDYDBEntities();
            return (from medicine
                    in db.Medicine
                    where medicine.Name.Contains(keyword)
                    select medicine).ToList();
        }

        public static void AddMedicine(Medicine medicine) {
            CentuDYDBEntities db = new CentuDYDBEntities();
            db.Medicine.Add(medicine);
            db.SaveChanges();
        }

        public static void UpdateMedicine(int medicineId, string newName, string newDescription,
                                          int newStock, int newPrice) {
            CentuDYDBEntities db = new CentuDYDBEntities();
            Medicine changedMedicine = (from medicine
                                        in db.Medicine
                                        where medicine.MedicineId.Equals(medicineId)
                                        select medicine).FirstOrDefault();

            changedMedicine.Name = newName;
            changedMedicine.Description = newDescription;
            changedMedicine.Stock = newStock;
            changedMedicine.Price = newPrice;
            db.SaveChanges();
        }

        public static void DeleteMedicine(int medicineId) {
            CentuDYDBEntities db = new CentuDYDBEntities();
            Medicine deletedMedicine = (from medicine
                                        in db.Medicine
                                        where medicine.MedicineId.Equals(medicineId)
                                        select medicine).FirstOrDefault();

            db.Medicine.Remove(deletedMedicine);
            db.SaveChanges();
        }
    }
}