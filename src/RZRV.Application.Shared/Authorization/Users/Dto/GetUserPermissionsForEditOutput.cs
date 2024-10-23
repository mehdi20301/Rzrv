using System.Collections.Generic;
using RZRV.Authorization.Permissions.Dto;

namespace RZRV.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}