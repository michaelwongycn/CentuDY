using CentuDY.Handler;
using CentuDY.Model;
using System;
using System.Collections.Generic;

namespace CentuDY.Controller
{
    public class CartController
    {
        public static List<Cart> GetCartByUser(int userId)
        {
            return CartHandler.GetCartByUser(userId);
        }
        public static Boolean DeleteCart(int userId, int medicineId)
        {
            return CartHandler.DeleteCart(userId, medicineId);
        }
        public static Boolean Checkout(int userId)
        {
            return CartHandler.Checkout(userId);
        }
        public static string AddCart(int userId, int medicineId, string quantity)
        {

            if (quantity == "") { return "Quantity must be filled "; }
            
            int temp = 0;
            int qty = int.Parse(quantity);
            if (!int.TryParse(quantity, out temp)) { return "Quantity must be numeric ";}
            if (qty <= 0) { return "Quantity must be more than 0 "; }
            
            Medicine medicine = MedicineHandler.GetMedicineById(medicineId);
            
            if (qty >= medicine.Stock) { return "Quantity cannot be more than available stock "; }
            
            List<Cart> listCart = CartHandler.GetCartByMedicine(medicineId);

            int totalQty = 0;
            foreach (Cart cart in listCart) { totalQty += cart.Quantity; }
            
            totalQty += qty;
            if (totalQty > medicine.Stock) {
                return "Quantity exceeding available stock";
            }
                
            Boolean result = CartHandler.AddCart(userId, medicineId, qty);

            if (result) { return "Add to cart success"; }

            else { return "Success updating cart quantity"; }
        }
    }
}