using System.Threading.Tasks;
using Abp.Application.Services;
using RZRV.MultiTenancy.Payments.Dto;
using RZRV.MultiTenancy.Payments.Stripe.Dto;

namespace RZRV.MultiTenancy.Payments.Stripe
{
    public interface IStripePaymentAppService : IApplicationService
    {
        Task ConfirmPayment(StripeConfirmPaymentInput input);

        StripeConfigurationDto GetConfiguration();

        Task<SubscriptionPaymentDto> GetPaymentAsync(StripeGetPaymentInput input);

        Task<string> CreatePaymentSession(StripeCreatePaymentSessionInput input);
    }
}