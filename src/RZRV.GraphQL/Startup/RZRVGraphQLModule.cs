using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace RZRV.Startup
{
    [DependsOn(typeof(RZRVCoreModule))]
    public class RZRVGraphQLModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(RZRVGraphQLModule).GetAssembly());
        }

        public override void PreInitialize()
        {
            base.PreInitialize();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }
    }
}