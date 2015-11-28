using Abp.MultiTenancy;
using RenCaiEX.Authorization.Roles;
using RenCaiEX.Editions;
using RenCaiEX.Users;

namespace RenCaiEX.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, Role, User>
    {
        public TenantManager(EditionManager editionManager)
            : base(editionManager)
        {

        }
    }
}