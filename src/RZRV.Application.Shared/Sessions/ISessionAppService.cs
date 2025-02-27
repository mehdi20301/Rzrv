﻿using System.Threading.Tasks;
using Abp.Application.Services;
using RZRV.Sessions.Dto;

namespace RZRV.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
