using Abp.Application.Services;
using Abp.Application.Services.Dto;
using RZRV.Authorization.Permissions.Dto;

namespace RZRV.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
