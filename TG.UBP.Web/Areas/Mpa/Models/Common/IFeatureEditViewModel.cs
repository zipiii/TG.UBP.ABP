using System.Collections.Generic;
using Abp.Application.Services.Dto;
using TG.UBP.Editions.Dto;

namespace TG.UBP.Web.Areas.Mpa.Models.Common
{
    public interface IFeatureEditViewModel
    {
        List<NameValueDto> FeatureValues { get; set; }

        List<FlatFeatureDto> Features { get; set; }
    }
}