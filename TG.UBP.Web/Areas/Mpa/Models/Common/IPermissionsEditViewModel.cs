using System.Collections.Generic;
using TG.UBP.Authorization.Permissions.Dto;

namespace TG.UBP.Web.Areas.Mpa.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }

        List<string> GrantedPermissionNames { get; set; }
    }
}