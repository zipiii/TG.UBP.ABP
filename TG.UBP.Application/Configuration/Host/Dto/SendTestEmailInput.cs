using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using TG.UBP.Authorization.Users;

namespace TG.UBP.Configuration.Host.Dto
{
    public class SendTestEmailInput
    {
        [Required]
        [MaxLength(User.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }
    }
}