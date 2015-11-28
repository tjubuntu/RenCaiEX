using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace RenCaiEX
{
    [DependsOn(typeof(RenCaiEXCoreModule), typeof(AbpAutoMapperModule))]
    public class RenCaiEXApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
