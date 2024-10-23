using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using RZRV.Configure;
using RZRV.Startup;
using RZRV.Test.Base;

namespace RZRV.GraphQL.Tests
{
    [DependsOn(
        typeof(RZRVGraphQLModule),
        typeof(RZRVTestBaseModule))]
    public class RZRVGraphQLTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            IServiceCollection services = new ServiceCollection();
            
            services.AddAndConfigureGraphQL();

            WindsorRegistrationHelper.CreateServiceProvider(IocManager.IocContainer, services);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(RZRVGraphQLTestModule).GetAssembly());
        }
    }
}