using System.Collections.Generic;
using Abp.Application.Services.Dto;
using TG.UBP.Configuration.Host.Dto;

namespace TG.UBP.Web.Areas.Mpa.Models.HostSettings
{
    public class HostSettingsViewModel
    {
        public HostSettingsEditDto Settings { get; set; }

        public List<ComboboxItemDto> EditionItems { get; set; }

        public List<ComboboxItemDto> TimezoneItems { get; set; }
    }
}