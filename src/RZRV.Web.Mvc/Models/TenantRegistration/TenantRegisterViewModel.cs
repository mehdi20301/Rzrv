using RZRV.Editions;
using RZRV.Editions.Dto;
using RZRV.MultiTenancy.Payments;
using RZRV.Security;
using RZRV.MultiTenancy.Payments.Dto;

namespace RZRV.Web.Models.TenantRegistration
{
    public class TenantRegisterViewModel
    {
        public PasswordComplexitySetting PasswordComplexitySetting { get; set; }

        public int? EditionId { get; set; }

        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }
    }
}
