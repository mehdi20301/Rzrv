using Abp.AutoMapper;
using RZRV.Authorization.Users;
using RZRV.Authorization.Users.Dto;
using RZRV.Web.Areas.App.Models.Common;

namespace RZRV.Web.Areas.App.Models.Users
{
    [AutoMapFrom(typeof(GetUserPermissionsForEditOutput))]
    public class UserPermissionsEditViewModel : GetUserPermissionsForEditOutput, IPermissionsEditViewModel
    {
        public User User { get; set; }
    }
}