﻿using RZRV.Editions;
using RZRV.MultiTenancy.Payments;

namespace RZRV.Web.Models.Payment
{
    public class CreatePaymentModel
    {
        public int EditionId { get; set; }

        public PaymentPeriodType? PaymentPeriodType { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }

        public bool? RecurringPaymentEnabled { get; set; }

        public SubscriptionPaymentGatewayType Gateway { get; set; }
    }
}
