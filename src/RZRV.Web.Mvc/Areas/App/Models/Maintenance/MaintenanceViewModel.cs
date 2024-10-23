using System.Collections.Generic;
using RZRV.Caching.Dto;

namespace RZRV.Web.Areas.App.Models.Maintenance
{
    public class MaintenanceViewModel
    {
        public IReadOnlyList<CacheDto> Caches { get; set; }
        
        public bool CanClearAllCaches { get; set; }
    }
}