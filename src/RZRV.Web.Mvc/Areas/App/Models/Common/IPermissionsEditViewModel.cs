using System.Collections.Generic;
using RZRV.Authorization.Permissions.Dto;

namespace RZRV.Web.Areas.App.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }

        List<string> GrantedPermissionNames { get; set; }
    }
}