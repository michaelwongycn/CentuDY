using CentuDY.Handler;
using CentuDY.Model;
using System;

namespace CentuDY.Controller
{
    public class AuthController
    {
        public static dynamic Login(string username, string password)
        {
            if(username == "") { return "Username must be filled"; }
            if(password == "") { return "Password must be filled"; }

            User user = UserHandler.GetUserByUsernameAndPassword(username, password);

            if (user == null) { return "Wrong username and password"; }
            else { return user; }
        }

        public static string Register(string username, string password, string confirmPassword, string name, string gender, string phoneNumber, string address)
        {
            if (username == "") { return "Username must be filled"; }
            if (username.Length < 3) { return "Username must have at least 3 characters"; }
            if (password == "") { return "Password must be filled"; }
            if (password.Length < 8) { return "Password must have at least 8 characters"; }
            if (confirmPassword == "") { return "Confirmation Password must be filled"; }
            if (password != confirmPassword) { return "Password must be the same"; }
            if (name == "") { return "Name must be filled"; }
            if (gender == "Select gender") { return "Gender must be chosen"; }
            if (phoneNumber == "") { return "Phone number must be filled"; }
            
            long temp = 0;
            
            if (!long.TryParse(phoneNumber, out temp)){ return "Phone number must be numeric"; }
            if (address == "") { return "Address must be filled"; }
            if (!address.Contains("Street")){ return "Address must contain the word 'Street'"; }

            Boolean result = UserHandler.AddUser(username, password, name, gender, phoneNumber, address);

            if (result) { return "Register Success"; }

            else { return "Username already exists"; }
        }
    }
}