using Abp.MultiTenancy;
using RenCaiEX.Users;

namespace RenCaiEX.MultiTenancy
{
    public class Tenant : AbpTenant<Tenant, User>
    {

    }
}