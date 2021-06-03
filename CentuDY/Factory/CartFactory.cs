using CentuDY.Model;

namespace CentuDY.Factory {
    public class CartFactory {
        public static Cart CreateCart(int userId, int medicineId, int quantity) {
            Cart cart = new Cart();

            cart.UserId = userId;
            cart.MedicineId = medicineId;
            cart.Quantity = quantity;

            return cart;
        }
    }
}