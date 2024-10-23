using Abp.AutoMapper;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.Reflection.Extensions;
using RZRV.ApiClient;
using RZRV.Mobile.MAUI.Core.ApiClient;

namespace RZRV
{
    [DependsOn(typeof(RZRVClientModule), typeof(AbpAutoMapperModule))]

    public class RZRVMobileMAUIModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Localization.IsEnabled = false;
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;

            Configuration.ReplaceService<IApplicationContext, MAUIApplicationContext>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(RZRVMobileMAUIModule).GetAssembly());
        }
    }
}