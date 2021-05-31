using CentuDY.Factory;
using CentuDY.Model;
using CentuDY.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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

        public static Boolean AddCart(Cart cart) {
            Cart tempCart = CartRepository.GetCartByUserAndMedicine(cart.UserId, cart.MedicineId);

            if (tempCart != null) {
                CartRepository.UpdateCartQuantity(cart.UserId, cart.MedicineId, cart.Quantity);
                return false;
            }
            else {
                CartRepository.AddCart(cart);
                return true;
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

                HeaderTransaction headerTransaction =
                    HeaderTransactionFactory.createHeaderTransaction(userId, time);
                HeaderTransactionRepository.AddHeaderTransaction(headerTransaction);
                //int id = >>>;

                foreach(Cart cart in cartList) {
                    DetailTransaction detailTransaction =
                        DetailTransactionFactory.createDetailTransaction(0, cart.MedicineId, cart.Quantity);

                    DetailTransactionRepository.AddDetailTransaction(detailTransaction);
                }

                CartRepository.EmptyUserCart(userId);
                return true;
            }
        }
    }
}