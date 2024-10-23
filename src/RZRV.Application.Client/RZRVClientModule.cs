using Abp.Modules;
using Abp.Reflection.Extensions;

namespace RZRV
{
    public class RZRVClientModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(RZRVClientModule).GetAssembly());
        }
    }
}
