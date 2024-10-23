using System.Collections.Generic;
using RZRV.Editions;
using RZRV.Editions.Dto;
using RZRV.MultiTenancy.Payments;
using RZRV.MultiTenancy.Payments.Dto;

namespace RZRV.Web.Models.Payment
{
    public class BuyEditionViewModel
    {
        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public decimal? AdditionalPrice { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}
