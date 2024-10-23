using Abp.AutoMapper;
using RZRV.Authorization.Roles.Dto;
using RZRV.Web.Areas.App.Models.Common;

namespace RZRV.Web.Areas.App.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class CreateOrEditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool IsEditMode => Role.Id.HasValue;
    }
}