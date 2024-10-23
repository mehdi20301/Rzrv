using System.Collections.Generic;
using RZRV.Authorization.Delegation;
using RZRV.Authorization.Users.Delegation.Dto;

namespace RZRV.Web.Areas.App.Models.Layout
{
    public class ActiveUserDelegationsComboboxViewModel
    {
        public IUserDelegationConfiguration UserDelegationConfiguration { get; set; }

        public List<UserDelegationDto> UserDelegations { get; set; }

        public string CssClass { get; set; }
    }
}
