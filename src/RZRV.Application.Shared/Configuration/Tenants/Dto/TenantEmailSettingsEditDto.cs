using Abp.Auditing;
using RZRV.Configuration.Dto;

namespace RZRV.Configuration.Tenants.Dto
{
    public class TenantEmailSettingsEditDto : EmailSettingsEditDto
    {
        public bool UseHostDefaultEmailSettings { get; set; }
    }
}