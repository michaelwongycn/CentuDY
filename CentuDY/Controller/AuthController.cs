using CentuDY.Factory;
using CentuDY.Handler;
using CentuDY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Controller
{
    public class AuthController
    {
        public static dynamic login(string username, string password)
        {
            if(username == "")
            {
                return "Username must be filled";
            }
            if(password == "")
            {
                return "Password must be filled";
            }
            User u = UserHandler.GetUserByUsernameAndPassword(username, password);
            if(u == null)
            {
                return "Wrong username and password";
            }
            return u;
        }

        public static string register(string username, string password, string confirmPassword, string name, string gender, string phoneNumber, string address)
        {
            if(username == "")
            {
                return "Username must be filled";
            }
            if (password == "")
            {
                return "Password must be filled";
            }
            if (confirmPassword == "")
            {
                return "Confirmation Password must be filled";
            }
            if (password != confirmPassword)
            {
                return "Password must be the same";
            }
            if (name == "")
            {
                return "Name must be filled";
            }
            if (gender == "Select gender")
            {
                return "Gender must be chosen";
            }
            if (phoneNumber == "")
            {
                return "Phone number must be filled";
            }
            long temp = 0;
            if (!long.TryParse(phoneNumber, out temp))
            {
                return "Phone number must be numeric";
            }
            if (address == "")
            {
                return "Address must be filled";
            }
            if (!address.Contains("Street"))
            {
                return "Address must contain the word 'Street'";
            }

            User u = UserFactory.createUser(2, username, password, name, gender, phoneNumber, address);
            if (!UserHandler.AddUser(u))
            {
                return "Username already exists";
            }
            return "Register Success";
        }
    }
}