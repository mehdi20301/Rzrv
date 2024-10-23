using System.Threading.Tasks;
using Abp.Application.Services;
using RZRV.MultiTenancy.Payments.PayPal.Dto;

namespace RZRV.MultiTenancy.Payments.PayPal
{
    public interface IPayPalPaymentAppService : IApplicationService
    {
        Task ConfirmPayment(long paymentId, string paypalOrderId);

        PayPalConfigurationDto GetConfiguration();
    }
}
