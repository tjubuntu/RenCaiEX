using Abp.Authorization;
using RenCaiEX.Authorization.Roles;
using RenCaiEX.MultiTenancy;
using RenCaiEX.Users;

namespace RenCaiEX.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
