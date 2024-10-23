using System.Threading.Tasks;
using Abp.Application.Services;
using RZRV.Configuration.Tenants.Dto;

namespace RZRV.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearDarkLogo();
        
        Task ClearLightLogo();

        Task ClearCustomCss();
    }
}
