using System.Threading.Tasks;
using RZRV.Authorization.Users;

namespace RZRV.WebHooks
{
    public interface IAppWebhookPublisher
    {
        Task PublishTestWebhook();
    }
}
