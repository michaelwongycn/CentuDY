using CentuDY.Model;
using System.Collections.Generic;
using System.Linq;

namespace CentuDY.Repository {
    public class CartRepository {
        public static List<Cart> GetCartByUser(int userId) {
            CentuDYDBEntities db = new CentuDYDBEntities();
            return (from cart
                    in db.Cart
                    where cart.UserId.Equals(userId)
                    select cart).ToList();
        }

        public static List<Cart> GetCartByMedicine(int medicineId) {
            CentuDYDBEntities db = new CentuDYDBEntities();
            return (from cart
                    in db.Cart
                    where cart.MedicineId.Equals(medicineId)
                    select cart).ToList();
        }

        public static Cart GetCartByUserAndMedicine(int userId, int medicineId) {
            CentuDYDBEntities db = new CentuDYDBEntities();
            return (from cart
                    in db.Cart
                    where cart.UserId.Equals(userId) && cart.MedicineId.Equals(medicineId)
                    select cart).FirstOrDefault();
        }

        public static void AddCart(Cart cart) {
            CentuDYDBEntities db = new CentuDYDBEntities();
            db.Cart.Add(cart);
            db.SaveChanges();
        }

        public static void UpdateCartQuantity(int userId, int medicineId, int quantity) {
            CentuDYDBEntities db = new CentuDYDBEntities();
            Cart changedCart = (from cart
                                in db.Cart
                                where cart.UserId.Equals(userId) && cart.MedicineId.Equals(medicineId)
                                select cart).FirstOrDefault();

            changedCart.Quantity = changedCart.Quantity + quantity;
            db.SaveChanges();
        }

        public static void DeleteCart(int userId, int medicineId) {
            CentuDYDBEntities db = new CentuDYDBEntities();
            Cart deletedCart = (from cart
                                in db.Cart
                                where cart.UserId.Equals(userId) && cart.MedicineId.Equals(medicineId)
                                select cart).FirstOrDefault();

            db.Cart.Remove(deletedCart);
            db.SaveChanges();
        }

        public static void EmptyUserCart(int userId) {
            CentuDYDBEntities db = new CentuDYDBEntities();
            List<Cart> userCarts = (from cart
                                    in db.Cart
                                    where cart.UserId.Equals(userId)
                                    select cart).ToList();

            foreach (Cart cart in userCarts) {
                db.Cart.Remove(cart);
            }
            db.SaveChanges();
        }
    }
}