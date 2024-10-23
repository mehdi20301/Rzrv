using Abp.AutoMapper;
using RZRV.Authorization.Users.Dto;

namespace RZRV.Mobile.MAUI.Models.User
{
    [AutoMapFrom(typeof(CreateOrUpdateUserInput))]
    public class UserCreateOrUpdateModel : CreateOrUpdateUserInput
    {

    }
}
