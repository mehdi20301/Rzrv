using System.Collections.Generic;
using Abp.Application.Services.Dto;
using RZRV.Authorization.Permissions.Dto;
using RZRV.Web.Areas.App.Models.Common;

namespace RZRV.Web.Areas.App.Models.Roles
{
    public class RoleListViewModel : IPermissionsEditViewModel
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}