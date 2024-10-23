using Microsoft.Extensions.Configuration;

namespace RZRV.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
