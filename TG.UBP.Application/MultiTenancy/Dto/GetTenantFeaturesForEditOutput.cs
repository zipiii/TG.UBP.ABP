using System.Collections.Generic;
using Abp.Application.Services.Dto;
using TG.UBP.Editions.Dto;

namespace TG.UBP.MultiTenancy.Dto
{
    public class GetTenantFeaturesForEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}