using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using RZRV.EntityFrameworkCore;

namespace RZRV.HealthChecks
{
    public class RZRVDbContextHealthCheck : IHealthCheck
    {
        private readonly DatabaseCheckHelper _checkHelper;

        public RZRVDbContextHealthCheck(DatabaseCheckHelper checkHelper)
        {
            _checkHelper = checkHelper;
        }

        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
        {
            if (_checkHelper.Exist("db"))
            {
                return Task.FromResult(HealthCheckResult.Healthy("RZRVDbContext connected to database."));
            }

            return Task.FromResult(HealthCheckResult.Unhealthy("RZRVDbContext could not connect to database"));
        }
    }
}
