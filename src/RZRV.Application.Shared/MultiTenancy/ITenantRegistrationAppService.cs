using System.Threading.Tasks;
using Abp.Application.Services;
using RZRV.Editions.Dto;
using RZRV.MultiTenancy.Dto;

namespace RZRV.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}