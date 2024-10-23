using Abp.AutoMapper;
using RZRV.MultiTenancy.Dto;

namespace RZRV.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(EditionsSelectOutput))]
    public class EditionsSelectViewModel : EditionsSelectOutput
    {
    }
}
