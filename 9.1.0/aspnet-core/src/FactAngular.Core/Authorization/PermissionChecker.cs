using Abp.Authorization;
using FactAngular.Authorization.Roles;
using FactAngular.Authorization.Users;

namespace FactAngular.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
