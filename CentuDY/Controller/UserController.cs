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
        public static string updateUser(int userID,string newName, string newGender, string newPhoneNumber, string newAddress)
        {
            if (newName == "")
            {
                return "Name must be filled";
            }
            if (newGender == "Select gender")
            {
                return "Gender must be chosen";
            }
            if (newPhoneNumber == "")
            {
                return "Phone number must be filled";
            }
            long temp = 0;
            if (!long.TryParse(newPhoneNumber, out temp))
            {
                return "Phone number must be numeric";
            }
            if (newAddress == "")
            {
                return "Address must be filled";
            }
            if (!newAddress.Contains("Street"))
            {
                return "Address must contain the word 'Street'";
            }

            if(!UserHandler.UpdateUserProfile(userID, newName, newGender, newPhoneNumber, newAddress))
            {
                return "User not found";
            }
            return "Update Success";
        }

        public static string changePassword(string username, string oldPassword, string newPassword, string confirmPassword)
        {
            if (oldPassword == "")
            {
                return "Old password must be filled";
            }
            if (newPassword == "")
            {
                return "New password must be filled";
            }
            if (confirmPassword == "")
            {
                return "Confirmation Password must be filled";
            }
            if (newPassword != confirmPassword)
            {
                return "Password must be the same";
            }
            User u = UserHandler.GetUserByUsername(username);
            if(oldPassword != u.Password)
            {
                return "Password incorrect";
            }
            if (!UserHandler.UpdateUserPassword(u.UserId, newPassword))
            {
                return "User not found";
            }
            return "Change Password Success";
        }
    }
}