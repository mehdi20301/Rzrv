﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RZRV.Tenants.Dashboard.Dto
{
    public class GetTopStatsOutput
    {
        public int TotalProfit { get; set; }

        public int NewFeedbacks { get; set; }

        public int NewOrders { get; set; }

        public int NewUsers { get; set; }
    }
}
