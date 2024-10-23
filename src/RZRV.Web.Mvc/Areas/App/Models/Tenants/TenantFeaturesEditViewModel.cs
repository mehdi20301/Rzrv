using Abp.AutoMapper;
using RZRV.MultiTenancy;
using RZRV.MultiTenancy.Dto;
using RZRV.Web.Areas.App.Models.Common;

namespace RZRV.Web.Areas.App.Models.Tenants
{
    [AutoMapFrom(typeof (GetTenantFeaturesEditOutput))]
    public class TenantFeaturesEditViewModel : GetTenantFeaturesEditOutput, IFeatureEditViewModel
    {
        public Tenant Tenant { get; set; }
    }
}