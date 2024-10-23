using System.Collections.Generic;
using RZRV.Authorization.Users.Importing.Dto;
using Abp.Dependency;

namespace RZRV.Authorization.Users.Importing
{
    public interface IUserListExcelDataReader: ITransientDependency
    {
        List<ImportUserDto> GetUsersFromExcel(byte[] fileBytes);
    }
}
