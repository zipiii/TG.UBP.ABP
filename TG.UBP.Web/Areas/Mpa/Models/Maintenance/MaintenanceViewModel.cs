using System.Collections.Generic;
using TG.UBP.Caching.Dto;

namespace TG.UBP.Web.Areas.Mpa.Models.Maintenance
{
    public class MaintenanceViewModel
    {
        public IReadOnlyList<CacheDto> Caches { get; set; }
    }
}