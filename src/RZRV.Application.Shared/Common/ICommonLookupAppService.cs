using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using RZRV.Common.Dto;
using RZRV.Editions.Dto;

namespace RZRV.Common
{
    public interface ICommonLookupAppService : IApplicationService
    {
        Task<ListResultDto<SubscribableEditionComboboxItemDto>> GetEditionsForCombobox(bool onlyFreeItems = false);

        Task<PagedResultDto<NameValueDto>> FindUsers(FindUsersInput input);

        GetDefaultEditionNameOutput GetDefaultEditionName();
    }
}