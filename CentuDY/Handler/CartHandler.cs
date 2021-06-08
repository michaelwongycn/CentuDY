using CentuDY.Factory;
using CentuDY.Model;
using CentuDY.Repository;
using System;
using System.Collections.Generic;

namespace CentuDY.Handler {
    public class CartHandler {
        public static List<Cart> GetCartByUser(int userId) {
            return CartRepository.GetCartByUser(userId);
        }

        public static List<Cart> GetCartByMedicine(int medicineId) {
            return CartRepository.GetCartByMedicine(medicineId);
        }

        public static Cart GetCartByUserAndMedicine(int userId, int medicineId) {
            return CartRepository.GetCartByUserAndMedicine(userId, medicineId);
        }

        public static Boolean AddCart(int userId, int medicineId, int quantity) {
            Cart tempCart = CartRepository.GetCartByUserAndMedicine(userId, medicineId);

            if (tempCart == null) {
                Cart cart = CartFactory.CreateCart(userId, medicineId, quantity);
                CartRepository.AddCart(cart);
                return true;
            }
            else {
                CartRepository.UpdateCartQuantity(userId, medicineId, quantity);
                return false;
            }
        }

        public static Boolean DeleteCart(int userId, int medicineId) {
            Cart tempCart = CartRepository.GetCartByUserAndMedicine(userId, medicineId);

            if (tempCart == null) {
                return false;
            }
            else {
                CartRepository.DeleteCart(userId, medicineId);
                return true;
            }
        }

        public static Boolean Checkout(int userId) {
            List<Cart> cartList = CartRepository.GetCartByUser(userId);
            
            if(cartList.Count < 1) {
                return false;
            }
            else {
                DateTime time = DateTime.Now;

                HeaderTransaction headerTransaction = HeaderTransactionFactory.CreateHeaderTransaction(userId, time);
                HeaderTransactionRepository.AddHeaderTransaction(headerTransaction);

                HeaderTransaction lastInsertedHt = HeaderTransactionRepository.GetLastInsertedTransaction();

                int id = lastInsertedHt.TransactionId;

                foreach (Cart cart in cartList) {
                    Medicine medicine = MedicineRepository.GetMedicineById(cart.MedicineId);
                    int newQuantity = medicine.Stock - cart.Quantity;

                    MedicineRepository.UpdateMedicine(medicine.MedicineId, medicine.Name, medicine.Description, newQuantity, medicine.Price);

                    DetailTransaction detailTransaction =
                        DetailTransactionFactory.CreateDetailTransaction(id, cart.MedicineId, cart.Quantity);

                    DetailTransactionRepository.AddDetailTransaction(detailTransaction);
                }

                CartRepository.EmptyUserCart(userId);
                return true;
            }
        }
    }
}