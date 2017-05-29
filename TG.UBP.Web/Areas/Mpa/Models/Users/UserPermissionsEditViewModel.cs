using Abp.AutoMapper;
using TG.UBP.Authorization.Users;
using TG.UBP.Authorization.Users.Dto;
using TG.UBP.Web.Areas.Mpa.Models.Common;

namespace TG.UBP.Web.Areas.Mpa.Models.Users
{
    [AutoMapFrom(typeof(GetUserPermissionsForEditOutput))]
    public class UserPermissionsEditViewModel : GetUserPermissionsForEditOutput, IPermissionsEditViewModel
    {
        public User User { get; private set; }

        public UserPermissionsEditViewModel(GetUserPermissionsForEditOutput output, User user)
        {
            User = user;
            output.MapTo(this);
        }
    }
}