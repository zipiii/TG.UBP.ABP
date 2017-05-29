using Abp.Authorization;
using TG.UBP.Authorization.Roles;
using TG.UBP.Authorization.Users;
using TG.UBP.MultiTenancy;

namespace TG.UBP.Authorization
{
    /// <summary>
    /// Implements <see cref="PermissionChecker"/>.
    /// </summary>
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
