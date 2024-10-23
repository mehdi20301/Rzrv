using System.Threading.Tasks;
using Abp.Webhooks;

namespace RZRV.WebHooks
{
    public interface IWebhookEventAppService
    {
        Task<WebhookEvent> Get(string id);
    }
}
