using System.Collections.Generic;
using Abp.Application.Services.Dto;
using TG.UBP.Authorization.Permissions.Dto;

namespace TG.UBP.Authorization.Roles.Dto
{
    public class GetRoleForEditOutput
    {
        public RoleEditDto Role { get; set; }

        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}