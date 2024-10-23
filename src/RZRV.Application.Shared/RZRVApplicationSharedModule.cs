using Abp.Modules;
using Abp.Reflection.Extensions;

namespace RZRV
{
    [DependsOn(typeof(RZRVCoreSharedModule))]
    public class RZRVApplicationSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(RZRVApplicationSharedModule).GetAssembly());
        }
    }
}