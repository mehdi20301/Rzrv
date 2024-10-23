using System.Threading.Tasks;
using RZRV.Sessions.Dto;

namespace RZRV.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
