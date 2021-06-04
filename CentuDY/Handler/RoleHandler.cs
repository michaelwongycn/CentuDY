using CentuDY.Model;
using CentuDY.Repository;
using System.Collections.Generic;

namespace CentuDY.Handler {
    public class RoleHandler {
        public static List<Role> GetRoles() {
            return RoleRepository.GetRoles();
        }

        public static void AddRole(Role role) {
            RoleRepository.AddRole(role);
        }

        public static void UpdateRole(int roleId, string newRoleName) {
            RoleRepository.UpdateRole(roleId, newRoleName);
        }

        public static void DeleteRole(int roleId) {
            RoleRepository.DeleteRole(roleId);
        }
    }
}