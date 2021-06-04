using CentuDY.Factory;
using CentuDY.Handler;
using CentuDY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Controller
{
    public class UserController
    {
        public static string UpdateUserProfile(int userID,string newName, string newGender, string newPhoneNumber, string newAddress)
        {
            if (newName == "") { return "Name must be filled"; }
            if (newGender == "Select gender") { return "Gender must be chosen"; }
            if (newPhoneNumber == "") {  return "Phone number must be filled"; }
            
            long temp = 0;

            if (!long.TryParse(newPhoneNumber, out temp)) { return "Phone number must be numeric"; }
            if (newAddress == "") { return "Address must be filled"; }
            if (!newAddress.Contains("Street")) { return "Address must contain the word 'Street'"; }

            Boolean result = UserHandler.UpdateUserProfile(userID, newName, newGender, newPhoneNumber, newAddress);

            if (result) { return "Update Success"; }

            else { return "User not found"; }
        }
        public static string UpdateUserPassword(string username, string oldPassword, string newPassword, string confirmPassword)
        {
            if (oldPassword == "") { return "Old password must be filled"; }
            if (newPassword == "") { return "New password must be filled"; }
            if (confirmPassword == "") { return "Confirmation Password must be filled"; }
            if (newPassword != confirmPassword) { return "Password must be the same"; }
            
            User user = UserHandler.GetUserByUsername(username);
            if(oldPassword != user.Password) { return "Password incorrect"; }

            Boolean result = UserHandler.UpdateUserPassword(user.UserId, newPassword);

            if (result) { return "Change Password Success"; }

            else { return "User not found"; }
        }
        public static List<User> GetUsers() {
            return UserHandler.GetUsers();
        }
        public static Boolean DeleteUser(int userId) {
            return UserHandler.DeleteUser(userId);
        }
        public static User GetUserById(int userId) {
            return UserHandler.GetUserById(userId);
        }
    }
}