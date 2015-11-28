using Abp.Application.Features;
using RenCaiEX.Authorization.Roles;
using RenCaiEX.MultiTenancy;
using RenCaiEX.Users;

namespace RenCaiEX.Features
{
    public class FeatureValueStore : AbpFeatureValueStore<Tenant, Role, User>
    {
        public FeatureValueStore(TenantManager tenantManager)
            : base(tenantManager)
        {
        }
    }
}