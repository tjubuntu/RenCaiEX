using Abp.Authorization.Roles;
using RenCaiEX.MultiTenancy;
using RenCaiEX.Users;

namespace RenCaiEX.Authorization.Roles
{
    public class Role : AbpRole<Tenant, User>
    {

    }
}