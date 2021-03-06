﻿using System.Collections.Generic;
using Abp.Application.Services.Dto;
using TG.UBP.Configuration.Tenants.Dto;

namespace TG.UBP.Web.Areas.Mpa.Models.Settings
{
    public class SettingsViewModel
    {
        public TenantSettingsEditDto Settings { get; set; }
        
        public List<ComboboxItemDto> TimezoneItems { get; set; }
    }
}