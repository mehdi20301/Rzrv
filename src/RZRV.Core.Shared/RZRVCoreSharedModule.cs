using Abp.Modules;
using Abp.Reflection.Extensions;

namespace RZRV
{
    public class RZRVCoreSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(RZRVCoreSharedModule).GetAssembly());
        }
    }
}