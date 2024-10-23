using System.Collections.Generic;
using RZRV.Authorization.Users.Importing.Dto;
using RZRV.Dto;

namespace RZRV.Authorization.Users.Importing
{
    public interface IInvalidUserExporter
    {
        FileDto ExportToFile(List<ImportUserDto> userListDtos);
    }
}
