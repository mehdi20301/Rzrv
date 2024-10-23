using Abp;

namespace RZRV
{
    /// <summary>
    /// This class can be used as a base class for services in this application.
    /// It has some useful objects property-injected and has some basic methods most of services may need to.
    /// It's suitable for non domain nor application service classes.
    /// For domain services inherit <see cref="RZRVDomainServiceBase"/>.
    /// For application services inherit RZRVAppServiceBase.
    /// </summary>
    public abstract class RZRVServiceBase : AbpServiceBase
    {
        protected RZRVServiceBase()
        {
            LocalizationSourceName = RZRVConsts.LocalizationSourceName;
        }
    }
}