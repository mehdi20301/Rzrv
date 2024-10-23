using Abp.Domain.Services;

namespace RZRV
{
    public abstract class RZRVDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected RZRVDomainServiceBase()
        {
            LocalizationSourceName = RZRVConsts.LocalizationSourceName;
        }
    }
}
