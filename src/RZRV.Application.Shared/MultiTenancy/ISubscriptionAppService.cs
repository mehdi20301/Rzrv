using System.Threading.Tasks;
using Abp.Application.Services;

namespace RZRV.MultiTenancy
{
    public interface ISubscriptionAppService : IApplicationService
    {
        Task DisableRecurringPayments();

        Task EnableRecurringPayments();
    }
}
