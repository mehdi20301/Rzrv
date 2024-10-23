using System.Collections.Generic;
using RZRV.Editions.Dto;
using RZRV.MultiTenancy.Payments;

namespace RZRV.Web.Models.Payment
{
    public class ExtendEditionViewModel
    {
        public EditionSelectDto Edition { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}