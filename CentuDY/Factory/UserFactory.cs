using CentuDY.Model;

namespace CentuDY.Factory {
    public class UserFactory {
        public static User CreateUser(int roleId, string username, string password, string name, 
                                      string gender, string phoneNumber, string address) {
            User user = new User();

            user.RoleId = roleId;
            user.Username = username;
            user.Password = password;
            user.Name = name;
            user.Gender = gender;
            user.PhoneNumber = phoneNumber;
            user.Address = address;

            return user;
        }
    }
}