using CentuDY.Model;

namespace CentuDY.Factory {
    public class MedicineFactory {
        public static Medicine CreateMedicine(string name, string description, int stock, int price) {
            Medicine medicine = new Medicine();

            medicine.Name = name;
            medicine.Description = description;
            medicine.Stock = stock;
            medicine.Price = price;

            return medicine;
        }
    }
}