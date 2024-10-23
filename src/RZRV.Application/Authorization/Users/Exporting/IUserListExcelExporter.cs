using System.Collections.Generic;
using RZRV.Authorization.Users.Dto;
using RZRV.Dto;

namespace RZRV.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}