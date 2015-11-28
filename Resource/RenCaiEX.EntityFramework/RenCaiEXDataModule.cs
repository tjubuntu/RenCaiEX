using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using RenCaiEX.EntityFramework;

namespace RenCaiEX
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(RenCaiEXCoreModule))]
    public class RenCaiEXDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
