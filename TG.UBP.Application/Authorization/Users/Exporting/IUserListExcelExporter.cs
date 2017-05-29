using System.Collections.Generic;
using TG.UBP.Authorization.Users.Dto;
using TG.UBP.Dto;

namespace TG.UBP.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}