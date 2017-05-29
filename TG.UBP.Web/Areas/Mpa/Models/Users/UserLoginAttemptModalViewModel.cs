using System.Collections.Generic;
using TG.UBP.Authorization.Users.Dto;

namespace TG.UBP.Web.Areas.Mpa.Models.Users
{
    public class UserLoginAttemptModalViewModel
    {
        public List<UserLoginAttemptDto> LoginAttempts { get; set; }
    }
}