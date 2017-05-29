using Abp.AutoMapper;
using TG.UBP.Authorization.Roles.Dto;
using TG.UBP.Web.Areas.Mpa.Models.Common;

namespace TG.UBP.Web.Areas.Mpa.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class CreateOrEditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool IsEditMode
        {
            get { return Role.Id.HasValue; }
        }

        public CreateOrEditRoleModalViewModel(GetRoleForEditOutput output)
        {
            output.MapTo(this);
        }
    }
}