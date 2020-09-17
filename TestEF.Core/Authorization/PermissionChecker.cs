using Abp.Authorization;
using TestEF.Authorization.Roles;
using TestEF.Authorization.Users;

namespace TestEF.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
