using CentuDY.Model;
using System.Collections.Generic;
using System.Linq;

namespace CentuDY.Repository {
    public class RoleRepository {
        public static List<Role> GetRoles() {
            CentuDYDBEntities db = new CentuDYDBEntities();
            return db.Role.ToList();
        }

        public static void AddRole(Role role) {
            CentuDYDBEntities db = new CentuDYDBEntities();
            db.Role.Add(role);
            db.SaveChanges();
        }

        public static void UpdateRole(int roleId, string newRoleName) {
            CentuDYDBEntities db = new CentuDYDBEntities();
            Role updatedRole = (from role
                                in db.Role
                                where role.RoleId.Equals(roleId)
                                select role).FirstOrDefault();

            updatedRole.RoleName = newRoleName;
            db.SaveChanges();
        }

        public static void DeleteRole(int roleId) {
            CentuDYDBEntities db = new CentuDYDBEntities();
            Role deletedRole = (from role
                                in db.Role
                                where role.RoleId.Equals(roleId)
                                select role).FirstOrDefault();

            db.Role.Remove(deletedRole);
            db.SaveChanges();
        }
    }
}