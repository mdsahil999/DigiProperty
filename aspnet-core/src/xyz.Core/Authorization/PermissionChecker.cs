using Abp.Authorization;
using xyz.Authorization.Roles;
using xyz.Authorization.Users;

namespace xyz.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
