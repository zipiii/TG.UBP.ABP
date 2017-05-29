using Abp.AutoMapper;
using TG.UBP.MultiTenancy;
using TG.UBP.MultiTenancy.Dto;
using TG.UBP.Web.Areas.Mpa.Models.Common;

namespace TG.UBP.Web.Areas.Mpa.Models.Tenants
{
    [AutoMapFrom(typeof (GetTenantFeaturesForEditOutput))]
    public class TenantFeaturesEditViewModel : GetTenantFeaturesForEditOutput, IFeatureEditViewModel
    {
        public Tenant Tenant { get; set; }

        public TenantFeaturesEditViewModel(Tenant tenant, GetTenantFeaturesForEditOutput output)
        {
            Tenant = tenant;
            output.MapTo(this);
        }
    }
}