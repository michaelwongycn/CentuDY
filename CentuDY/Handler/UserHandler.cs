using CentuDY.Factory;
using CentuDY.Model;
using CentuDY.Repository;
using System;
using System.Collections.Generic;

namespace CentuDY.Handler {
    public class UserHandler {

        public static List<User> GetUsers() {
            return UserRepository.GetUsers();
        }

        public static User GetUserById(int userId) {
            return UserRepository.GetUserById(userId);
        }

        public static User GetUserByUsername(string username) {
            return UserRepository.GetUserByUsername(username);
        }

        public static User GetUserByUsernameAndPassword(string username, string password) {
            return UserRepository.GetUserByUsernameAndPassword(username, password);
        }

        public static Boolean AddUser(string username, string password, string name, string gender, string phoneNumber, string address) {
            
            User tempUser = UserRepository.GetUserByUsername(username);

            if (tempUser != null) {
                return false;
            }
            else {
                User user = UserFactory.CreateUser(2, username, password, name, gender, phoneNumber, address);
                UserRepository.AddUser(user);
                return true;
            }
        }

        public static Boolean UpdateUserProfile(int userId, string newName, string newGender,
                                             string newPhoneNumber, string newAddress) {
            User tempUser = UserRepository.GetUserById(userId);

            if (tempUser == null) {
                return false;
            }
            else {
                UserRepository.UpdateUserProfile(userId, newName, newGender, newPhoneNumber, newAddress);
                return true;
            }
        }

        public static Boolean UpdateUserPassword(int userId, string newPassword) {
            User tempUser = UserRepository.GetUserById(userId);

            if (tempUser == null) {
                return false;
            }
            else {
                UserRepository.UpdateUserPassword(userId, newPassword);
                return true;
            }
        }

        public static Boolean DeleteUser(int userId) {
            List<Cart> cartList = CartRepository.GetCartByUser(userId);
            List<HeaderTransaction> headerTransactionList = HeaderTransactionRepository.GetHeaderTransactionsByUser(userId);
        
            if(cartList == null || headerTransactionList == null) {
                return false;
            }
            if(cartList.Count != 0 || headerTransactionList.Count != 0){
                return false;
            }
            else {
                UserRepository.DeleteUser(userId);
                return true;
            }
        }
    }
}