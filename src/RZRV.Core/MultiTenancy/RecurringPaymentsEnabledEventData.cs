﻿using Abp.Events.Bus;

namespace RZRV.MultiTenancy
{
    public class RecurringPaymentsEnabledEventData : EventData
    {
        public int TenantId { get; set; }
    }
}