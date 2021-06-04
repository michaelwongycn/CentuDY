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
        public static Boolean AddCart(int userId, int medicineId, int quantity)
        {
            return CartHandler.AddCart(userId, medicineId, quantity);
        }
    }
}