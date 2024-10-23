using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RZRV.MultiTenancy.HostDashboard.Dto;

namespace RZRV.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}