using Abp.Authorization;
using RZRV.Authorization.Roles;
using RZRV.Authorization.Users;

namespace RZRV.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
