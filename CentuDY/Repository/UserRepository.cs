using CentuDY.Model;
using System.Collections.Generic;
using System.Linq;

namespace CentuDY.Repository {
    public class UserRepository {
        public static List<User> GetUsers() {
            CentuDYDBEntities db = new CentuDYDBEntities();
            return db.User.ToList();
        }

        public static User GetUserById(int userId) {
            CentuDYDBEntities db = new CentuDYDBEntities();
            return (from user
                    in db.User
                    where user.UserId.Equals(userId)
                    select user).FirstOrDefault();
        }
   
        public static User GetUserByUsername(string username) {
            CentuDYDBEntities db = new CentuDYDBEntities();
            return (from user
                    in db.User
                    where user.Username.Equals(username)
                    select user).FirstOrDefault();
        }

        public static User GetUserByUsernameAndPassword(string username, string password) {
            CentuDYDBEntities db = new CentuDYDBEntities();
            return (from user
                    in db.User
                    where user.Username.Equals(username) && user.Password.Equals(password)
                    select user).FirstOrDefault();
        }

        public static void AddUser(User user) {
            CentuDYDBEntities db = new CentuDYDBEntities();
            db.User.Add(user);
            db.SaveChanges();
        }

        public static void UpdateUserProfile(int userId, string newName, string newGender,
                                             string newPhoneNumber, string newAddress) {
            CentuDYDBEntities db = new CentuDYDBEntities();
            User changedUser = (from user
                         in db.User
                         where user.UserId.Equals(userId)
                         select user).FirstOrDefault();

            changedUser.Name = newName;
            changedUser.Gender = newGender;
            changedUser.PhoneNumber = newPhoneNumber;
            changedUser.Address = newAddress;
            db.SaveChanges();
        }

        public static void UpdateUserPassword(int userId, string newPassword) {
            CentuDYDBEntities db = new CentuDYDBEntities();
            User changedUser = (from user
                                in db.User
                                where user.UserId.Equals(userId)
                                select user).FirstOrDefault();

            changedUser.Password = newPassword;
            db.SaveChanges();
        }

        public static void DeleteUser(int userId) {
            CentuDYDBEntities db = new CentuDYDBEntities();
            User deletedUser = (from user
                                in db.User
                                where user.UserId.Equals(userId)
                                select user).FirstOrDefault();

            db.User.Remove(deletedUser);
            db.SaveChanges();
        }
    }
}