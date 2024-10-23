using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using RZRV.Authorization;

namespace RZRV
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(
        typeof(RZRVApplicationSharedModule),
        typeof(RZRVCoreModule)
        )]
    public class RZRVApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Adding authorization providers
            Configuration.Authorization.Providers.Add<AppAuthorizationProvider>();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(RZRVApplicationModule).GetAssembly());
        }
    }
}