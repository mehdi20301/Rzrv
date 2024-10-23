using Abp.AutoMapper;
using RZRV.Authorization.Users.Dto;

namespace RZRV.Mobile.MAUI.Models.User
{
    [AutoMapFrom(typeof(UserListDto))]
    public class UserListModel : UserListDto
    {
        public string Photo { get; set; }

        public string FullName => Name + " " + Surname;
    }
}
