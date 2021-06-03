using CentuDY.Model;

namespace CentuDY.Factory {
    public class RoleFactory {
        public static Role CreateRole(string roleName) {
            Role role = new Role();

            role.RoleName = roleName;

            return role;
        }
    }
}